using CsvHelper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using static FF6KefkaRush.Common.Common;

namespace FF6KefkaRush.Inventory
{
	class Accessories
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

		public class accessory
		{
			public int id { get; set; }
			public int job_equip_id { get; set; }
			public int tier { get; set; }
		}

		List<accessory> allAccessories = new List<accessory>
		{
			new accessory() { id = 275, job_equip_id = 1, tier = 1 }, // t1
			new accessory() { id = 276, job_equip_id = 1, tier = 1 }, // t1
			new accessory() { id = 277, job_equip_id = 1, tier = 2 }, // t2
			new accessory() { id = 278, job_equip_id = 1, tier = 2 }, // t2
			new accessory() { id = 279, job_equip_id = 1, tier = 3 }, // t3
			new accessory() { id = 280, job_equip_id = 1, tier = 2 }, // t2
			new accessory() { id = 281, job_equip_id = 1, tier = 2 }, // t2
			new accessory() { id = 282, job_equip_id = 1, tier = 3 }, // t3
			new accessory() { id = 283, job_equip_id = 1, tier = 3 }, // t3
			new accessory() { id = 284, job_equip_id = 1, tier = 3 }, // t3
			new accessory() { id = 285, job_equip_id = 1, tier = 6 }, // t6
			new accessory() { id = 286, job_equip_id = 1, tier = 5 }, // t5
			new accessory() { id = 287, job_equip_id = 1, tier = 3 }, // t3
			new accessory() { id = 288, job_equip_id = 1, tier = 2 }, // t2
			new accessory() { id = 289, job_equip_id = 1, tier = 2 }, // t2
			new accessory() { id = 290, job_equip_id = 59, tier = 3 }, // t3
			new accessory() { id = 291, job_equip_id = 1, tier = 3 }, // t3
			new accessory() { id = 292, job_equip_id = 64, tier = 3 }, // t3
			new accessory() { id = 293, job_equip_id = 1, tier = 4 }, // t4
			new accessory() { id = 294, job_equip_id = 1, tier = 4 }, // t4
			new accessory() { id = 295, job_equip_id = 1, tier = 3 }, // t3
			new accessory() { id = 296, job_equip_id = 63, tier = 7 }, // t7
			new accessory() { id = 297, job_equip_id = 63, tier = 7 }, // t7
			new accessory() { id = 298, job_equip_id = 60, tier = 4 }, // t4
			new accessory() { id = 299, job_equip_id = 1, tier = 3 }, // t3
			new accessory() { id = 300, job_equip_id = 1, tier = 5 }, // t5
			new accessory() { id = 301, job_equip_id = 1, tier = 6 }, // t6
			new accessory() { id = 302, job_equip_id = 1, tier = 4 }, // t4
			new accessory() { id = 303, job_equip_id = 1, tier = 5 }, // t5
			new accessory() { id = 304, job_equip_id = 1, tier = 6 }, // t6
			new accessory() { id = 305, job_equip_id = 59, tier = 9 }, // t9
			new accessory() { id = 306, job_equip_id = 60, tier = 3 }, // t3
			new accessory() { id = 307, job_equip_id = 1, tier = 3 }, // t3
			new accessory() { id = 308, job_equip_id = 59, tier = 6 }, // t6
			new accessory() { id = 309, job_equip_id = 1, tier = 4 }, // t4
			new accessory() { id = 310, job_equip_id = 1, tier = 8 }, // t8
			new accessory() { id = 311, job_equip_id = 1, tier = 6 }, // t6
			new accessory() { id = 312, job_equip_id = 1, tier = 5 }, // t5
			new accessory() { id = 313, job_equip_id = 61, tier = 5 }, // t5
			new accessory() { id = 314, job_equip_id = 62, tier = 4 }, // t4
			new accessory() { id = 315, job_equip_id = 59, tier = 8 }, // t8
			new accessory() { id = 316, job_equip_id = 59, tier = 7 }, // t7
			new accessory() { id = 317, job_equip_id = 67, tier = 7 }, // t7
			new accessory() { id = 318, job_equip_id = 65, tier = 4 }, // t4
			new accessory() { id = 319, job_equip_id = 1, tier = 4 }, // t4
			new accessory() { id = 320, job_equip_id = 1, tier = 4 }, // t4
			new accessory() { id = 321, job_equip_id = 66, tier = 9 }, // t9
			new accessory() { id = 322, job_equip_id = 1, tier = 8 }, // t8
			new accessory() { id = 323, job_equip_id = 1, tier = 8 }, // t8
			new accessory() { id = 324, job_equip_id = 1, tier = 7 }, // t7
			new accessory() { id = 325, job_equip_id = 1, tier = 6 }, // t6
			new accessory() { id = 326, job_equip_id = 1, tier = 6 }, // t6
			new accessory() { id = 327, job_equip_id = 1, tier = 6 }, // t6
			new accessory() { id = 328, job_equip_id = 1, tier = 5 }, // t5
			new accessory() { id = 329, job_equip_id = 1, tier = 3 }, // t3
		};

		public int selectItem(Random r1, int minTier, int maxTier, bool highTierReduction, List<int> equippable)
		{ 
			List<int> selection = getList(minTier, maxTier, highTierReduction, equippable);
			return selection[r1.Next() % selection.Count];
		}

		public List<int> getList(int minTier, int maxTier, bool highTierReduction, List<int> equippable)
		{
			List<int> selection = new List<int>();
			for (int i = minTier; i <= maxTier; i++)
			{
				int repetition = highTierReduction ? maxTier - i + 1 : 1;
				for (int j = 0; j < repetition; j++)
					selection.AddRange(allAccessories.Where(c => c.tier == i && equippable.Contains(c.job_equip_id)).Select(c => c.id));
			}

			return selection;
		}
	}
}
