using CsvHelper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using static FF6KefkaRush.Common.Common;

namespace FF6KefkaRush.Inventory
{
	public class Magicite
	{
		public const int ramuh = 62; // t4
		public const int kirin = 63; // t4
		public const int siren = 64; // t3
		public const int caitSith = 65; // t3
		public const int ifrit = 66; // t4
		public const int shiva = 67; // t4
		public const int unicorn = 68; // t5
		public const int maudin = 69; // t5
		public const int catoblepas = 70; // t5
		public const int phantom = 71; // t5
		public const int carbuncle = 72; // t5
		public const int bismarck = 73; // t4
		public const int golem = 74; // t5
		public const int zonaSeeker = 75; // t4
		public const int seraph = 76; // t5
		public const int quetzalli = 77; // t6
		public const int fenrir = 78; // t5
		public const int valigarmanda = 79; // t7
		public const int midgardsormr = 80; // t6
		public const int lakshmi = 81; // t6
		public const int alexander = 82; // t6
		public const int phoenix = 83; // t7
		public const int odin = 84; // t8
		public const int bahamut = 85; // t7
		public const int ragnarok = 86; // t8
		public const int crusader = 87; // t8
		public const int raiden = 88; // t7

		public List<List<int>> tiers = new List<List<int>>
			{ new List<int> { },
			  new List<int> { },
			  new List<int> { siren, caitSith },
			  new List<int> { ramuh, kirin, ifrit, shiva, bismarck, zonaSeeker },
			  new List<int> { unicorn, maudin, catoblepas, phantom, carbuncle, golem, seraph, fenrir },
			  new List<int> { quetzalli, midgardsormr, lakshmi, alexander },
			  new List<int> { valigarmanda, phoenix, bahamut, raiden },
			  new List<int> { odin, ragnarok, crusader }
		};

		public int selectItem(Random r1, List<int> exclude, int minTier, int maxTier)
		{
			List<int> selection = getList(exclude, minTier, maxTier);
			return selection[r1.Next() % selection.Count];
		}

		public List<int> getList(List<int> exclude, int minTier, int maxTier)
		{
			const bool highTierReduction = true;

			List<int> selection = new List<int>();
			for (int i = minTier - 1; i <= maxTier - 1; i++)
			{
				int repetition = highTierReduction ? maxTier - i : 1;
				for (int j = 0; j < repetition; j++)
					selection.AddRange(tiers[i]);
			}
			selection = selection.Except(exclude).ToList();
			return selection;
		}
	}
}
