using CsvHelper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using static FF6KefkaRush.Common.Common;

namespace FF6KefkaRush.Inventory
{
	class Weapons
	{
		private class singleWeapon
		{
			public int id { get; set; }
			public string sort_id { get; set; }
			public int type_id { get; set; }
			public int category_type { get; set; }
			public int attribute_id { get; set; }
			public int attribute_group_id { get; set; }
			public int equip_job_group_id { get; set; }
			public int parts_group_id { get; set; }
			public int attack { get; set; }
			public int weight { get; set; }
			public int accuracy_rate { get; set; }
			public int evasion_rate { get; set; }
			public int ability_disturbed_rate { get; set; }
			public int destroy_rate { get; set; }
			public int magnetic_force { get; set; }
			public int throw_flag { get; set; }
			public int back_flag { get; set; }
			public int two_handed_flag { get; set; }
			public int invalid_reflection { get; set; }
			public int trigger_ability_id { get; set; }
			public int wear_function_group_id { get; set; }
			public int wear_condition_group_id { get; set; }
			public int weak_attribute { get; set; }
			public int effective_species { get; set; }
			public int additional_condition_group_id { get; set; }
			public int strength { get; set; }
			public int vitality  { get; set; }
			public int agility { get; set; }
			public int intelligence { get; set; }
			public int spirit { get; set; }
			public int magic { get; set; }
			public int critical_rate { get; set; }
			public int max_hp_up { get; set; }
			public int max_mp_up { get; set; }
			public int battle_equipment_asset_id { get; set; }
			public int battle_effect_asset_id { get; set; }
			public int guard_icon { get; set; }
			public int buy { get; set; }
			public int sell { get; set; }
			public int sales_not_possible { get; set; }
			public string process_prog { get; set; }
		}

		private class weapon
		{
			public int id { get; set; }
			public int job_equip_id { get; set; }
			public int tier { get; set; }
		}

		private List<weapon> allWeapons = new List<weapon> {
			new weapon { id = 94, job_equip_id = 3, tier = 1 }, // Dagger
			new weapon { id = 95, job_equip_id = 3, tier = 1 }, // t1
			new weapon { id = 96, job_equip_id = 4, tier = 3 }, // t3
			new weapon { id = 97, job_equip_id = 5, tier = 3 }, // t3
			new weapon { id = 98, job_equip_id = 6, tier = 5 }, // t5
			new weapon { id = 99, job_equip_id = 6, tier = 6 }, // t6
			new weapon { id = 100, job_equip_id = 7, tier = 7 }, // t7
			new weapon { id = 101, job_equip_id = 68, tier = 8 }, // t8
			new weapon { id = 102, job_equip_id = 3, tier = 9 }, // t9
			new weapon { id = 103, job_equip_id = 4, tier = 6 }, // t6
			new weapon { id = 104, job_equip_id = 8, tier = 1 }, // t1
			new weapon { id = 105, job_equip_id = 9, tier = 2 }, // t2
			new weapon { id = 106, job_equip_id = 9, tier = 3 }, // t3
			new weapon { id = 107, job_equip_id = 8, tier = 4 }, // t4
			new weapon { id = 108, job_equip_id = 8, tier = 4 }, // t4
			new weapon { id = 109, job_equip_id = 8, tier = 4 }, // t4
			new weapon { id = 110, job_equip_id = 9, tier = 3 }, // t3
			new weapon { id = 111, job_equip_id = 9, tier = 5 }, // t5
			new weapon { id = 112, job_equip_id = 8, tier = 5 }, // t5
			new weapon { id = 113, job_equip_id = 9, tier = 6 }, // t6
			new weapon { id = 114, job_equip_id = 9, tier = 7 }, // t7
			new weapon { id = 115, job_equip_id = 8, tier = 7 }, // t7
			new weapon { id = 116, job_equip_id = 8, tier = 6 }, // t6
			new weapon { id = 117, job_equip_id = 9, tier = 8 }, // t8
			new weapon { id = 118, job_equip_id = 8, tier = 8 }, // t8 
			new weapon { id = 119, job_equip_id = 10, tier = 9 }, // t9
			new weapon { id = 120, job_equip_id = 8, tier = 9 }, // t9
			new weapon { id = 121, job_equip_id = 8, tier = 9 }, // t9
			new weapon { id = 122, job_equip_id = 8, tier = 8 }, // t8
			new weapon { id = 123, job_equip_id = 11, tier = 2 }, // t2
			new weapon { id = 124, job_equip_id = 11, tier = 3 }, // t3
			new weapon { id = 125, job_equip_id = 11, tier = 3 }, // t3
			new weapon { id = 126, job_equip_id = 11, tier = 5 }, // t5
			new weapon { id = 127, job_equip_id = 11, tier = 6 }, // t6
			new weapon { id = 128, job_equip_id = 11, tier = 4 }, // t4
			new weapon { id = 129, job_equip_id = 11, tier = 8 }, // t8
			new weapon { id = 130, job_equip_id = 12, tier = 7 }, // t7
			new weapon { id = 131, job_equip_id = 13, tier = 3 }, // t3
			new weapon { id = 132, job_equip_id = 13, tier = 4 }, // t4
			new weapon { id = 133, job_equip_id = 13, tier = 5 }, // t5
			new weapon { id = 134, job_equip_id = 13, tier = 5 }, // t5
			new weapon { id = 135, job_equip_id = 13, tier = 7 }, // t7
			new weapon { id = 136, job_equip_id = 13, tier = 8 }, // t8
			new weapon { id = 137, job_equip_id = 14, tier = 2 }, // t2
			new weapon { id = 138, job_equip_id = 14, tier = 2 }, // t2
			new weapon { id = 139, job_equip_id = 14, tier = 3 }, // t3
			new weapon { id = 140, job_equip_id = 14, tier = 5 }, // t5
			new weapon { id = 141, job_equip_id = 14, tier = 4 }, // t4
			new weapon { id = 142, job_equip_id = 14, tier = 6 }, // t6
			new weapon { id = 143, job_equip_id = 14, tier = 7 }, // t7
			new weapon { id = 144, job_equip_id = 14, tier = 8 }, // t8
			new weapon { id = 145, job_equip_id = 15, tier = 4 }, // t4
			new weapon { id = 146, job_equip_id = 15, tier = 3 }, // t3 
			new weapon { id = 147, job_equip_id = 15, tier = 4 }, // t4
			new weapon { id = 148, job_equip_id = 15, tier = 4 }, // t4
			new weapon { id = 149, job_equip_id = 15, tier = 4 }, // t4 
			new weapon { id = 150, job_equip_id = 15, tier = 4 }, // t4
			new weapon { id = 151, job_equip_id = 15, tier = 7 }, // t7
			new weapon { id = 152, job_equip_id = 15, tier = 5 }, // t5
			new weapon { id = 153, job_equip_id = 15, tier = 6 }, // t6
			new weapon { id = 154, job_equip_id = 15, tier = 8 }, // t8
			new weapon { id = 155, job_equip_id = 16, tier = 2 }, // t2
			new weapon { id = 156, job_equip_id = 16, tier = 4 }, // t4
			new weapon { id = 157, job_equip_id = 16, tier = 5 }, // t5
			new weapon { id = 158, job_equip_id = 16, tier = 6 }, // t6
			new weapon { id = 159, job_equip_id = 2, tier = 3 }, // t3
			new weapon { id = 160, job_equip_id = 2, tier = 5 }, // t5
			new weapon { id = 161, job_equip_id = 2, tier = 8 }, // t8
			new weapon { id = 162, job_equip_id = 17, tier = 3 }, // t3
			new weapon { id = 163, job_equip_id = 19, tier = 5 }, // t5
			new weapon { id = 164, job_equip_id = 17, tier = 4 }, // t4
			new weapon { id = 165, job_equip_id = 19, tier = 5 }, // t5
			new weapon { id = 166, job_equip_id = 19, tier = 6 }, // t6
			new weapon { id = 167, job_equip_id = 19, tier = 6 }, // t6
			new weapon { id = 168, job_equip_id = 18, tier = 6 }, // t6
			new weapon { id = 169, job_equip_id = 19, tier = 7 }, // t7
			new weapon { id = 170, job_equip_id = 19, tier = 9 }, // t9
			new weapon { id = 171, job_equip_id = 20, tier = 4 }, // t4
			new weapon { id = 172, job_equip_id = 20, tier = 5 }, // t5
			new weapon { id = 173, job_equip_id = 20, tier = 7 }, // t7
			new weapon { id = 174, job_equip_id = 20, tier = 6 }, // t6
			new weapon { id = 175, job_equip_id = 20, tier = 3 }, // t3
			new weapon { id = 176, job_equip_id = 20, tier = 7 }, // t7
			new weapon { id = 177, job_equip_id = 21, tier = 2 }, // t2
			new weapon { id = 178, job_equip_id = 21, tier = 3 }, // t3
			new weapon { id = 179, job_equip_id = 21, tier = 4 }, // t4
			new weapon { id = 180, job_equip_id = 21, tier = 5 }, // t5 
			new weapon { id = 181, job_equip_id = 21, tier = 6 }, // t6
			new weapon { id = 182, job_equip_id = 21, tier = 7 }, // t7
			new weapon { id = 183, job_equip_id = 21, tier = 9 }, // t9
			new weapon { id = 38, job_equip_id = 70, tier = 2 }, // t2
			new weapon { id = 31, job_equip_id = 70, tier = 3 }, // t3
			new weapon { id = 32, job_equip_id = 70, tier = 4 }, // t4
			new weapon { id = 33, job_equip_id = 70, tier = 3 }, // t3
			new weapon { id = 36, job_equip_id = 70, tier = 6 }, // t6
			new weapon { id = 34, job_equip_id = 70, tier = 7 }, // t7
			new weapon { id = 35, job_equip_id = 70, tier = 8 }, // t8
			new weapon { id = 37, job_equip_id = 70, tier = 8 } // t8
		};

		public void adjustPrices(string directory, int multiplier, int divisor)
		{
			List<singleWeapon> records;

			using (StreamReader reader = new StreamReader(Path.Combine("csv", "weapon.csv")))
			using (CsvReader csv = new CsvReader(reader, System.Globalization.CultureInfo.InvariantCulture))
				records = csv.GetRecords<singleWeapon>().ToList();

			foreach (singleWeapon item in records)
			{
				item.buy *= multiplier;
				item.buy /= divisor;
				item.sell *= Math.Min(multiplier, 4);
				item.sell /= divisor;

				item.buy = item.buy > 99999 ? 99999 : item.buy < 1 ? 1 : item.buy;
				item.sell = item.sell > 99999 ? 99999 : item.sell < 1 ? 1 : item.sell;
			}

			using (StreamWriter writer = new StreamWriter(Path.Combine(directory, "weapon.csv")))
			using (CsvWriter csv = new CsvWriter(writer, System.Globalization.CultureInfo.InvariantCulture))
			{
				csv.WriteRecords(records);
			}
		}

		public int selectItem(Random r1, int minTier, int maxTier, bool highTierReduction, List<int> equippable)
		{
			List<int> selection = getList(minTier, maxTier, highTierReduction, equippable);
			// TODO:  Get equip_job_group_id from weapons.csv, filter by list, THEN retrieve item.  Repeat for armor and accessories.
			return selection[r1.Next() % selection.Count];
		}

		public List<int> getList(int minTier, int maxTier, bool highTierReduction, List<int> equippable)
		{
			List<int> selection = new List<int>();
			for (int i = minTier - 1; i <= maxTier - 1; i++)
			{
				int repetition = highTierReduction ? maxTier - i : 1;
				for (int j = 0; j < repetition; j++)
					selection.AddRange(allWeapons.Where(c => c.tier == i && equippable.Contains(c.job_equip_id)).Select(c => c.id));
			}

			return selection;
		}
	}
}
