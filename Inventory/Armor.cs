using CsvHelper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using static FF6KefkaRush.Common.Common;

namespace FF6KefkaRush.Inventory
{
	class Armor
	{
		private class singleArmor
		{
			public int id { get; set; }
			public int sort_id { get; set; }
			public int type_id { get; set; }
			public int equip_job_group_id { get; set; }
			public int parts_group_id { get; set; }
			public int defense { get; set; }
			public int ability_defense { get; set; }
			public int weight { get; set; }
			public int evasion_rate { get; set; }
			public int ability_evasion_rate { get; set; }
			public int ability_disturbed_rate { get; set; }
			public int destroy_rate { get; set; }
			public int magnetic_force { get; set; }
			public int invalid_reflection { get; set; }
			public int trigger_ability_id { get; set; }
			public int wear_function_group_id { get; set; }
			public int wear_condition_group_id { get; set; }
			public int resistance_attribute { get; set; }
			public int resistance_condition { get; set; }
			public int resistance_species { get; set; }
			public int strength { get; set; }
			public int vitality { get; set; }
			public int agility { get; set; }
			public int intelligence { get; set; }
			public int spirit { get; set; }
			public int magic { get; set; }
			public int max_hp_up { get; set; }
			public int max_mp_up { get; set; }
			public int battle_effect_asset_id { get; set; }
			public int guard_icon { get; set; }
			public int se_asset_id { get; set; }
			public int buy { get; set; }
			public int sell { get; set; }
			public int sales_not_possible { get; set; }
			public string process_prog { get; set; }
		}

		public class armor
		{
			public int id { get; set; }
			public int job_equip_id { get; set; }
			public int tier { get; set; }
		}

		private List<armor> allArmor = new List<armor>() {
			new armor() { id = 201, job_equip_id = 22, tier = 1 }, // t1
			new armor() { id = 202, job_equip_id = 23, tier = 2 }, // t2
			new armor() { id = 203, job_equip_id = 22, tier = 2 }, // t2
			new armor() { id = 204, job_equip_id = 24, tier = 3 }, // t3
			new armor() { id = 205, job_equip_id = 22, tier = 5 }, // t5
			new armor() { id = 206, job_equip_id = 25, tier = 4 }, // t4
			new armor() { id = 207, job_equip_id = 22, tier = 6 }, // t6
			new armor() { id = 208, job_equip_id = 22, tier = 6 }, // t6
			new armor() { id = 209, job_equip_id = 22, tier = 6 }, // t6
			new armor() { id = 210, job_equip_id = 25, tier = 5 }, // t5
			new armor() { id = 211, job_equip_id = 22, tier = 7 }, // t7
			new armor() { id = 212, job_equip_id = 22, tier = 7 }, // t7
			new armor() { id = 213, job_equip_id = 22, tier = 1 }, // t1
			new armor() { id = 214, job_equip_id = 22, tier = 9 }, // t9
			new armor() { id = 215, job_equip_id = 22, tier = 8 }, // t8
			new armor() { id = 216, job_equip_id = 26, tier = 1 }, // t1
			new armor() { id = 217, job_equip_id = 27, tier = 2 }, // t2
			new armor() { id = 218, job_equip_id = 26, tier = 1 }, // t1
			new armor() { id = 219, job_equip_id = 28, tier = 5 }, // t5
			new armor() { id = 220, job_equip_id = 29, tier = 5 }, // t5 
			new armor() { id = 221, job_equip_id = 30, tier = 3 }, // t3
			new armor() { id = 222, job_equip_id = 31, tier = 3 }, // t3
			new armor() { id = 223, job_equip_id = 28, tier = 6 }, // t6
			new armor() { id = 224, job_equip_id = 26, tier = 5 }, // t5
			new armor() { id = 225, job_equip_id = 26, tier = 5 }, // t5
			new armor() { id = 226, job_equip_id = 32, tier = 4 }, // t4
			new armor() { id = 227, job_equip_id = 33, tier = 3 }, // t3
			new armor() { id = 228, job_equip_id = 27, tier = 5 }, // t5
			new armor() { id = 229, job_equip_id = 34, tier = 4 }, // t4
			new armor() { id = 230, job_equip_id = 35, tier = 6 }, // t6
			new armor() { id = 231, job_equip_id = 26, tier = 6 }, // t6
			new armor() { id = 232, job_equip_id = 27, tier = 6 }, // t6
			new armor() { id = 233, job_equip_id = 26, tier = 6 }, // t6
			new armor() { id = 234, job_equip_id = 36, tier = 7 }, // t7
			new armor() { id = 235, job_equip_id = 37, tier = 5 }, // t5
			new armor() { id = 236, job_equip_id = 38, tier = 6 }, // t6
			new armor() { id = 237, job_equip_id = 39, tier = 6 }, // t6
			new armor() { id = 238, job_equip_id = 27, tier = 7 }, // t7
			new armor() { id = 239, job_equip_id = 28, tier = 8 }, // t8
			new armor() { id = 240, job_equip_id = 26, tier = 8 }, // t8
			new armor() { id = 241, job_equip_id = 26, tier = 7 }, // t7
			new armor() { id = 242, job_equip_id = 26, tier = 7 }, // t7
			new armor() { id = 244, job_equip_id = 69, tier = 1 }, // t1
			new armor() { id = 245, job_equip_id = 41, tier = 1 }, // t1
			new armor() { id = 246, job_equip_id = 42, tier = 1 }, // t1
			new armor() { id = 247, job_equip_id = 43, tier = 2 }, // t2
			new armor() { id = 248, job_equip_id = 44, tier = 2 }, // t2
			new armor() { id = 249, job_equip_id = 40, tier = 2 }, // t2
			new armor() { id = 250, job_equip_id = 45, tier = 3 }, // t3
			new armor() { id = 251, job_equip_id = 46, tier = 4 }, // t4
			new armor() { id = 252, job_equip_id = 43, tier = 3 }, // t3
			new armor() { id = 253, job_equip_id = 47, tier = 5 }, // t5
			new armor() { id = 254, job_equip_id = 40, tier = 5 }, // t5
			new armor() { id = 255, job_equip_id = 48, tier = 4 }, // t4
			new armor() { id = 256, job_equip_id = 49, tier = 4 }, // t4
			new armor() { id = 257, job_equip_id = 50, tier = 5 }, // t5
			new armor() { id = 258, job_equip_id = 51, tier = 5 }, // t5
			new armor() { id = 259, job_equip_id = 52, tier = 7 }, // t7
			new armor() { id = 260, job_equip_id = 43, tier = 6 }, // t6
			new armor() { id = 261, job_equip_id = 53, tier = 5 }, // t5
			new armor() { id = 262, job_equip_id = 45, tier = 7 }, // t7
			new armor() { id = 263, job_equip_id = 50, tier = 7 }, // t7
			new armor() { id = 264, job_equip_id = 43, tier = 7 }, // t7
			new armor() { id = 265, job_equip_id = 54, tier = 7 }, // t7
			new armor() { id = 266, job_equip_id = 55, tier = 8 }, // t8
			new armor() { id = 267, job_equip_id = 40, tier = 7 }, // t7
			new armor() { id = 268, job_equip_id = 56, tier = 8 }, // t8
			new armor() { id = 269, job_equip_id = 57, tier = 3 }, // t3
			new armor() { id = 270, job_equip_id = 57, tier = 5 }, // t5
			new armor() { id = 271, job_equip_id = 57, tier = 5 }, // t5
			new armor() { id = 272, job_equip_id = 57, tier = 7 }, // t7
			new armor() { id = 273, job_equip_id = 57, tier = 8 }, // t8
			new armor() { id = 274, job_equip_id = 58, tier = 8 } // t8
		};

		public void adjustPrices(string directory, int multiplier, int divisor)
		{
			List<singleArmor> records;

			using (StreamReader reader = new StreamReader(Path.Combine("csv", "armor.csv")))
			using (CsvReader csv = new CsvReader(reader, System.Globalization.CultureInfo.InvariantCulture))
				records = csv.GetRecords<singleArmor>().ToList();

			foreach (singleArmor item in records)
			{
				item.buy *= multiplier;
				item.buy /= divisor;
				item.sell *= Math.Min(multiplier, 4);
				item.sell /= divisor;

				item.buy = item.buy > 99999 ? 99999 : item.buy < 1 ? 1 : item.buy;
				item.sell = item.sell > 99999 ? 99999 : item.sell < 1 ? 1 : item.sell;
			}

			using (StreamWriter writer = new StreamWriter(Path.Combine(directory, "armor.csv")))
			using (CsvWriter csv = new CsvWriter(writer, System.Globalization.CultureInfo.InvariantCulture))
			{
				csv.WriteRecords(records);
			}
		}

		public int selectItem(Random r1, int minTier, int maxTier, bool highTierReduction, List<int> equippable)
		{
			List<int> selection = getList(minTier, maxTier, highTierReduction, equippable);
			return selection[r1.Next() % selection.Count];
		}

		public List<int> getList(int minTier, int maxTier, bool highTierReduction, List<int> equippable)
		{
			List<int> selection = new List<int>();
			for (int i = minTier - 1; i <= maxTier - 1; i++)
			{
				int repetition = highTierReduction ? maxTier - i : 1;
				for (int j = 0; j < repetition; j++)
					selection.AddRange(allArmor.Where(c => c.tier == i && equippable.Contains(c.job_equip_id)).Select(c => c.id));
			}

			return selection;
		}
	}
}
