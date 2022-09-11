using CsvHelper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using static FF6KefkaRush.Common.Common;

namespace FF6KefkaRush.Inventory
{
	public class Items
	{
		private class singleItem
		{
			public int id { get; set; }
			public int sort_id { get; set; }
			public int type_id { get; set; }
			public int system_id { get; set; }
			public int item_lv { get; set; }
			public int attribute_id { get; set; }
			public int accuracy_rate { get; set; }
			public int destroy_rate { get; set; }
			public int standard_value { get; set; }
			public int renge_id { get; set; }
			public int menu_renge_id { get; set; }
			public int battle_renge_id { get; set; }
			public int invalid_reflection { get; set; }
			public int period_id { get; set; }
			public int throw_flag { get; set; }
			public int preparation_flag { get; set; }
			public int drink_flag { get; set; }
			public int machine_flag { get; set; }
			public int condition_group_id { get; set; }
			public int battle_effect_asset_id { get; set; }
			public int menu_se_asset_id { get; set; }
			public int menu_function_group_id { get; set; }
			public int battle_function_group_id { get; set; }
			public int buy { get; set; }
			public int sell { get; set; }
			public int sales_not_possible { get; set; }
		}

		public const int potion = 2; // t1
		public const int hiPotion = 3; // t3
		public const int xPotion = 4; // t5
		public const int ether = 5; // t3
		public const int hiEther = 6; // t5
		public const int xEther = 7; // t7
		public const int elixer = 8; // t8
		public const int megalixer = 9; // t9
		public const int phoenixDown = 10; // t2
		public const int holyWater = 11; // t4
		public const int antidote = 12; // t2
		public const int eyeDrops = 13; // t2
		public const int goldNeedle = 14; // t3
		public const int remedy = 15; // t6
		public const int greenCherry = 18; // t2
		public const int magiciteShard = 19; // t6
		public const int superBall = 20; // t5
		public const int echoScreen = 21; // t2
		public const int smokeBomb = 22; // t4
		public const int teleportStone = 23; // t6
		public const int driedMeat = 24; // t2
		public const int flameScroll = 26; // t4
		public const int waterScroll = 27; // t4
		public const int lightningScroll = 28; // t4
		public const int invisibilityScroll = 29; // t5
		public const int shadowScroll = 30; // t5

		public List<List<int>> tiers = new List<List<int>>
			{ new List<int> { potion },
			  new List<int> { phoenixDown, antidote, eyeDrops, greenCherry, echoScreen, driedMeat },
			  new List<int> { hiPotion, ether, goldNeedle },
			  new List<int> { holyWater, smokeBomb, flameScroll, waterScroll, lightningScroll },
			  new List<int> { xPotion, hiEther, superBall, invisibilityScroll, shadowScroll },
			  new List<int> { remedy, magiciteShard, teleportStone },
			  new List<int> { xEther },
			  new List<int> { elixer },
			  new List<int> { megalixer }
		};

		public int selectItem(Random r1, int minTier, int maxTier, bool highTierReduction)
		{
			List<int> selection = getList(minTier, maxTier, highTierReduction);
			return selection[r1.Next() % selection.Count];
		}

		public List<int> getList(int minTier, int maxTier, bool highTierReduction)
		{
			List<int> selection = new List<int>();
			for (int i = minTier - 1; i <= maxTier - 1; i++)
			{
				int repetition = highTierReduction ? maxTier - i : 1;
				for (int j = 0; j < repetition; j++)
					selection.AddRange(tiers[i]);
			}

			return selection;
		}
	}
}
