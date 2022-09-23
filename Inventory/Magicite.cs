using CsvHelper;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using static FF6KefkaRush.Common.Common;

namespace FF6KefkaRush.Inventory
{
	public static class Magicite
	{
		public class MagicJSON
		{
			public int Id { get; set; }
			public int AbilityId { get; set; }
			public string ParameterType { get; set; }
			public int ParameterValue { get; set; }
			public string DescriptionKey { get; set; }
		}

		private const int ramuh = 62; // t4
		private const int kirin = 63; // t4
		private const int siren = 64; // t3
		private const int caitSith = 65; // t3
		private const int ifrit = 66; // t4
		private const int shiva = 67; // t4
		private const int unicorn = 68; // t5
		private const int maudin = 69; // t5
		private const int catoblepas = 70; // t5
		private const int phantom = 71; // t5
		private const int carbuncle = 72; // t5
		private const int bismarck = 73; // t4
		private const int golem = 74; // t5
		private const int zonaSeeker = 75; // t4
		private const int seraph = 76; // t5
		private const int quetzalli = 77; // t6
		private const int fenrir = 78; // t5
		private const int valigarmanda = 79; // t7
		private const int midgardsormr = 80; // t6
		private const int lakshmi = 81; // t6
		private const int alexander = 82; // t6
		private const int phoenix = 83; // t7
		private const int odin = 84; // t8
		private const int bahamut = 85; // t7
		private const int ragnarok = 86; // t8
		private const int crusader = 87; // t8
		private const int raiden = 88; // t7

		public static List<List<int>> tiers = new List<List<int>>
			{ new List<int> { },
			  new List<int> { },
			  new List<int> { siren, caitSith },
			  new List<int> { ramuh, kirin, ifrit, shiva, bismarck, zonaSeeker },
			  new List<int> { unicorn, maudin, catoblepas, phantom, carbuncle, golem, seraph, fenrir },
			  new List<int> { quetzalli, midgardsormr, lakshmi, alexander },
			  new List<int> { valigarmanda, phoenix, bahamut, raiden },
			  new List<int> { odin, ragnarok, crusader }
		};

		public static int selectItem(Random r1, List<int> exclude, int minTier, int maxTier)
		{
			List<int> selection = getList(exclude, minTier, maxTier);
			return selection[r1.Next() % selection.Count];
		}

		public static List<int> getList(List<int> exclude, int minTier, int maxTier)
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

		public static void boostMagiciteBonus(string directory, double multiplier, bool roundDown)
		{
			// TODO:  Iterate through mini-games and set asset IDs for entity_default in Map_40012.
			string fileMagic = File.ReadAllText(Path.Combine("csv", "Magicite.json"));
			List<MagicJSON> allMagicite = JsonConvert.DeserializeObject<List<MagicJSON>>(fileMagic);

			foreach (MagicJSON magicite in allMagicite)
			{
				magicite.DescriptionKey = MagiciteBonusLookup(magicite.ParameterType);
				if (!roundDown) 
					magicite.ParameterValue = (int)Math.Round(magicite.ParameterValue * multiplier);
				else
					magicite.ParameterValue = (int)Math.Floor(magicite.ParameterValue * multiplier);
				if (magicite.DescriptionKey != null)
					magicite.DescriptionKey = magicite.DescriptionKey + " -> " + magicite.ParameterValue.ToString();
			}

			JsonSerializer serializer1 = new JsonSerializer();

			using (StreamWriter sw = new StreamWriter(Path.Combine(directory, "Memoria", "Magicite.json")))
			using (JsonWriter writer = new JsonTextWriter(sw))
			{
				serializer1.Serialize(writer, allMagicite);
			}
		}

		private static string MagiciteBonusLookup(string parameter)
		{
			switch (parameter)
			{
				case "HP":
					return "MSG_MAG_INF_151";
				case "MP":
					return "MSG_MAG_INF_154";
				case "Power":
					return "MSG_MAG_INF_159";
				case "Agility":
					return "MSG_MAG_INF_161";
				case "Vitality":
					return "MSG_MAG_INF_162";
				case "Magic":
					return "MSG_MAG_INF_164";
				default:
					return null;
			}
		}
	}
}
