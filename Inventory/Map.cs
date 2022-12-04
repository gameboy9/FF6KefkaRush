using CsvHelper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF6KefkaRush.Inventory
{
    public static class Map
    {
        private class singleMap
        {
            public int id { get; set; }
            public string map_name { get; set; }
            public string asset_name { get; set; }
            public string map_title { get; set; }
            public int script_id { get; set; }
            public int bgm_id { get; set; }
            public int reverb_flag { get; set; }
            public int environmental_se_id { get; set; }
            public int required_steps_min { get; set; }
            public int required_steps_max { get; set; }
            public int subtract_steps { get; set; }
            public int monster_set_id { get; set; }
            public int encount_area_grid_id { get; set; }
            public int encount_effect_id { get; set; }
            public int area_id { get; set; }
            public int loop_type { get; set; }
            public int moving_availability { get; set; }
            public int sleeping_availability { get; set; }
            public int save_availability { get; set; }
            public int floor { get; set; }
        }

        private class scripts
        {
            public int originalID { get; set; }
			public string originalName { get; set; }
			public int newID { get; set; }
			public string newName { get; set; }
		}

        private class map
        {
			public int originalID { get; set; }
			public string originalName { get; set; }
			public int newID { get; set; }
			public string newName { get; set; }
		}

        private class Assets
        {
            List<string> keys { get; set; }
            List<string> values { get; set; }
        }

		public static void addDifficulties(string directory, string mapKey)
        {
            // TODO:  Add key for each difficulty.  The key will be called [mapKey]-[1-5], depending on difficulty. (AssetsPath.json)
            // Copy key and value involved for the map
            // Paste into new key, adding "-[1-5]", depending on difficulty
            // Copy package.json
            // Paste into new folder, adding "-[1-5]" to ends of each filename (do not do the same for textures)
            // Note script IDs by going through each entity_default.json, ev_e_*.json, and sc_e_*.json.  Acquire name for each and place into class
            // Get lowest script ID from scripts.csv.  Record into variable, then record new IDs into class
            // Add new IDs to scripts.csv.
            // Repeat process for maps (map.csv)
            // Then go through each entity_default.json and ev_e_*.json and adjust the script numbers and map numbers

            // I don't think this is possible right now, not until we at least can export textures.
        }

        public static void encounterAdjustment(string directory, int encNumerator, int encDenominator, bool noEncounters)
        {
            List<singleMap> allMaps;

            using (StreamReader reader = new(Path.Combine("csv", "map.csv")))
            using (CsvReader csv = new(reader, System.Globalization.CultureInfo.InvariantCulture))
                allMaps = csv.GetRecords<singleMap>().ToList();

            foreach (singleMap map in allMaps)
            {
                if (noEncounters)
                {
                    map.required_steps_max = 9999;
                    map.required_steps_min = 9999;
                    map.subtract_steps = 1;
                } else
                {
                    map.required_steps_min *= encNumerator;
                    if (map.required_steps_min != 0)
                        map.required_steps_min /= encDenominator;

                    map.required_steps_max *= encNumerator;
                    if (map.required_steps_max != 0)
                        map.required_steps_max /= encDenominator;
                }
            }

            using (StreamWriter writer = new(Path.Combine(directory, "map.csv")))
            using (CsvWriter csv = new(writer, System.Globalization.CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(allMaps);
            }
        }
    }
}
