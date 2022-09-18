using FF6KefkaRush.Inventory;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using CsvHelper;
using System.Text;
using System.Threading.Tasks;
using CsvHelper.Configuration.Attributes;
using FF6KefkaRush.Common;
using System.Diagnostics;
using System.Threading;

namespace FF6KefkaRush.Randomize
{
	public static class Treasure
	{
		private class message
		{
			[Index(0)]
			public string id { get; set; }
			[Index(1)]
			public string msgString { get; set; }
		}

		private class content
		{
			[Index(0)]
			public int id { get; set; }
			[Index(1)]
			public string mes_id_name { get; set; }
			[Index(2)]
			public string mes_id_battle { get; set; }
			[Index(3)]
			public string mes_id_description { get; set; }
			[Index(4)]
			public int icon_id { get; set; }
			[Index(5)]
			public int type_id { get; set; }
			[Index(6)]
			public int type_value { get; set; }
		}

		private class scenarioScript
		{
			public int id { get; set; }
			public string winScript { get; set; }
			public string startScript { get; set; }
			public int characterID { get; set; }
		}

		private static List<message> itemStrings;
		private static List<content> contentCSV = new List<content>();

		public static void createTreasure(Random r1, string directory, string csvDirectory, List<int> equippable)
		{
			//List<string> treasureDirectories = new()
			//{
			//	Path.Combine(directory, "Map_20020"),
			//	Path.Combine(directory, "Map_20021"),
			//	Path.Combine(directory, "Map_30011"),
			//	Path.Combine(directory, "Map_20071"),
			//	Path.Combine(directory, "Map_20070"),
			//	Path.Combine(directory, "Map_30021"), //
			//	Path.Combine(directory, "Map_30050"),
			//	Path.Combine(directory, "Map_30060"),
			//	Path.Combine(directory, "Map_30080"),
			//	Path.Combine(directory, "Map_30100"),
			//	Path.Combine(directory, "Map_30121"), //
			//	Path.Combine(directory, "Map_20011"),
			//	Path.Combine(directory, "Map_30131"),
			//	Path.Combine(directory, "Map_30141"),
			//	Path.Combine(directory, "Map_20151"),
			//	Path.Combine(directory, "Map_30151"), //
			//	Path.Combine(directory, "Map_30161"),
			//	Path.Combine(directory, "Map_20131"),
			//	Path.Combine(directory, "Map_30171"),
			//	Path.Combine(directory, "Map_30191"),
			//	Path.Combine(directory, "Map_30221"), //
			//	Path.Combine(directory, "Map_30251"),
			//	Path.Combine(directory, "Map_20111")
			//};

			//List<int> stdMaxTier = new()
			//{
			//	2,
			//	3,
			//	3,
			//	4,
			//	3,
			//	4, //
			//	4,
			//	3,
			//	4,
			//	4,
			//	4, //
			//	4,
			//	5,
			//	5,
			//	6,
			//	6, //
			//	6,
			//	6,
			//	7,
			//	7,
			//	7, //
			//	8,
			//	-1
			//};

			//List<int> proMaxTier = new()
			//{
			//	1,
			//	2,
			//	2,
			//	3,
			//	2,
			//	3, //
			//	3,
			//	2,
			//	3,
			//	3,
			//	3, //
			//	3,
			//	4,
			//	4,
			//	5,
			//	5, //
			//	5,
			//	6,
			//	6,
			//	6,
			//	6, //
			//	7,
			//	-1
			//};

			//List<string> Booster1 = new()
			//{
			//	"Map_20071_4",
			//	"Map_30021_2",
			//	"Map_30121_1"
			//};

			//int i = 0;

			//int rttType = 0;
			//int rttTier = RateThatTreasury(r1, ref rttType);

			//foreach (string tDir in treasureDirectories)
			//{
			//	foreach (string fileName in Directory.EnumerateFiles(tDir, "entity_default.json", SearchOption.AllDirectories))
			//	{
			//		string json = File.ReadAllText(fileName);
			//		EntityJSON jEvents = JsonConvert.DeserializeObject<EntityJSON>(json);
			//		foreach (var layer in jEvents.layers)
			//			foreach (var sObject in layer.objects)
			//			{
			//				bool process = sObject.properties.Where(c => c.name == "action_id" && (long)c.value == 6).Any();
			//				bool monster = sObject.properties.Where(c => c.name == "script_id" && (long)c.value != 0).Any();
			//				bool gold = false;
			//				if (fileName.Contains("Map_20021_7"))
			//					gold = sObject.properties.Where(c => c.name == "content_id" && (long)c.value == 1).Any();
			//				if (process)
			//				{
			//					int trMaxTier = (randoLevel == 0 ? stdMaxTier[i] :
			//									randoLevel == 1 ? proMaxTier[i] :
			//									noSuper ? 8 : 9) + (monster ? 2 : 0);
			//					trMaxTier += fileName.Contains(Booster1[0]) ? 1 : 0;
			//					trMaxTier += fileName.Contains(Booster1[1]) ? 1 : 0;
			//					trMaxTier += fileName.Contains(Booster1[2]) ? 1 : 0;

			//					int trMinTier = Math.Max(1, randoLevel == 2 ? 1 : trMaxTier - 2);
			//					trMaxTier = Math.Min(!noSuper ? 9 : 8, trMaxTier);
			//					trMinTier = Math.Min(8, trMinTier);

			//					if (fileName.Contains("Map_30251_17"))
			//					{
			//						trMaxTier = trMinTier = 9;
			//						monster = true;
			//					}

			//					if (fileName.Contains("Map_20111"))
			//                             {
			//						trMaxTier = rttTier;
			//						trMinTier = trMaxTier == 9 ? 8 : rttTier;
			//                             }

			//					int trType = gold ? 0 : r1.Next() % 12;
			//					int finalType = 0;
			//					if (monster) // Only weapons and armor in monster chests
			//						finalType = (r1.Next() % 2) + 2;
			//					else if (fileName.Contains("Map_20111") && rttType != 4)
			//						finalType = rttType;
			//					else
			//						finalType = trType == 0 ? 0 : trType >= 1 && trType <= 5 ? 1 : trType >= 6 && trType <= 8 ? 2 : 3;

			//					if (finalType == 0)
			//					{
			//						foreach (var prop in sObject.properties.Where(c => c.name == "content_id"))
			//							prop.value = 1;
			//						foreach (var prop in sObject.properties.Where(c => c.name == "content_num"))
			//							prop.value = (r1.Next() % (500 * trMaxTier)) + (500 * Math.Max(0, trMaxTier - 4)) + (gold ? 500 : 0);
			//						foreach (var prop in sObject.properties.Where(c => c.name == "message_key"))
			//							prop.value = "S0005_999_a_03";
			//					}
			//					else if (finalType == 1)
			//					{
			//						foreach (var prop in sObject.properties.Where(c => c.name == "content_id"))
			//							prop.value = new Items().selectItem(r1, trMinTier, trMaxTier, false);
			//						foreach (var prop in sObject.properties.Where(c => c.name == "content_num"))
			//							prop.value = 1;
			//						foreach (var prop in sObject.properties.Where(c => c.name == "message_key"))
			//							prop.value = "S0005_999_a_02";
			//					}
			//					else if (finalType == 2)
			//					{
			//						foreach (var prop in sObject.properties.Where(c => c.name == "content_id"))
			//							prop.value = new Weapons().selectItem(r1, trMinTier, trMaxTier, false, includeBonus, includeFGExclusive, party);
			//						foreach (var prop in sObject.properties.Where(c => c.name == "content_num"))
			//							prop.value = 1;
			//						foreach (var prop in sObject.properties.Where(c => c.name == "message_key"))
			//							prop.value = "S0005_999_a_02";
			//					}
			//					else
			//					{
			//						foreach (var prop in sObject.properties.Where(c => c.name == "content_id"))
			//							prop.value = new Armor().selectItem(r1, trMinTier, trMaxTier, false, includeBonus, includeFGExclusive, party);
			//						foreach (var prop in sObject.properties.Where(c => c.name == "content_num"))
			//							prop.value = 1;
			//						foreach (var prop in sObject.properties.Where(c => c.name == "message_key"))
			//							prop.value = "S0005_999_a_02";
			//					}
			//				}
			//			}

			//		JsonSerializer serializer = new();

			//		using StreamWriter sw = new(fileName);
			//		using JsonWriter writer = new JsonTextWriter(sw);
			//		serializer.Serialize(writer, jEvents);
			//	}
			//	i++;
			//}

			List<int> minigameSelections = new List<int> { 0, 3, 5, 7, 8, 9, 11, 17, 31, 49 }; // 47 is also available

			minigameSelections.Shuffle(r1);
			minigameSelections = new List<int> { minigameSelections[0], minigameSelections[1], minigameSelections[2], minigameSelections[3], minigameSelections[4], minigameSelections[5] };
			minigameSelections.Sort();
			minigameSelections.Add(50);

			List<scenarioScript> scScripts = new List<scenarioScript>()
			{
				new scenarioScript { id = 0, characterID = 51, startScript = "narshemines.json", winScript = "Map_30011\\Map_30011_2\\sc_e_0018_2.json"},
				new scenarioScript { id = 3, characterID = 142, startScript = "kefkaatnarshe.json", winScript = "Map_20030\\Map_20030\\sc_e_0259_1.json"}, // Empire Soldier, not Kefka, already used.
				new scenarioScript { id = 5, characterID = 49, startScript = "letheriver.json", winScript = "Map_30390\\Map_30390\\sc_e_0065_1.json"},
				new scenarioScript { id = 7, characterID = 139, startScript = "phantomtrain.json", winScript = "Map_30440\\Map_30440\\sc_e_0214_1.json"},
				new scenarioScript { id = 8, characterID = 71, startScript = "barenfalls.json", winScript = "Map_30480\\Map_30480\\sc_e_0218_2.json"},
				new scenarioScript { id = 9, characterID = 99, startScript = "serpenttrench.json", winScript = "Map_20121\\Map_20121_4\\sc_e_1502_3.json"}, // Helmet
				new scenarioScript { id = 11, characterID = 47, startScript = "operahouse.json", winScript = "Map_20161\\Map_20161_6\\sc_e_0344_2.json"},
				new scenarioScript { id = 17, characterID = 50, startScript = "imperialairforce.json", winScript = "Map_30600\\Map_30600\\sc_e_0565_3.json"},
				new scenarioScript { id = 31, characterID = 203, startScript = "cultiststower.json", winScript = "Map_30750\\Map_30750\\sc_e_0881_1.json"},
				//new scenarioScript { id = 47, characterID = 51, startScript = "solitaryisland.json", winScript = "Map_20291\\Map_20291_1\\sc_e_0625.json"},
				new scenarioScript { id = 49, characterID = 44, startScript = "falcon.json", winScript = "Map_Script\\Resident\\sc_secede_gau.json"},
				new scenarioScript { id = 50, characterID = 51, startScript = "", winScript = "Map_40012\\Map_40012\\sc_e_1053.json"}
			};

			// TODO:  Iterate through mini-games and set asset IDs for entity_default in Map_40012.
			string json3 = File.ReadAllText(Path.Combine(directory, "Map_40012", "Map_40012", "entity_default.json"));
			EntityJSON jEvents3 = JsonConvert.DeserializeObject<EntityJSON>(json3);

			foreach (var layer in jEvents3.layers)
				foreach (var sObject in layer.objects)
				{
					if (sObject.properties.Where(p => p.name == "script_id" && (long)p.value >= 1256 && (long)p.value <= 1261).Any())
					{
						long scriptID1 = (long)(sObject.properties.Where(p => p.name == "script_id" && (long)p.value >= 1256 && (long)p.value <= 1261).First().value);
						EntityJSON.Property1 singleProp = sObject.properties.Where(p => p.name == "asset_id" && (long)p.value > 0).SingleOrDefault();
						if (singleProp != null)
						{
							singleProp.value = scScripts.Where(c => c.id == minigameSelections[(int)scriptID1 - 1256]).Single().characterID;
						}
					}
				}

			JsonSerializer serializer1 = new JsonSerializer();

			using (StreamWriter sw = new StreamWriter(Path.Combine(directory, "Map_40012", "Map_40012", "entity_default.json")))
			using (JsonWriter writer = new JsonTextWriter(sw))
			{
				serializer1.Serialize(writer, jEvents3);
			}

			string[] ff6StartScripts = new string[6] { "sc_e_0065_2.json", "sc_e_0135_1.json", "sc_e_0256_1.json", "sc_e_0258_1.json", "sc_e_0302_1.json", "sc_e_0328_1.json" }; // , "sc_e_0569_1.json", "sc_e_0607_9.json", "sc_e_0828_1.json", "sc_e_0966_3_1.json"
			for (int i = 0; i < ff6StartScripts.Count(); i++)
			{
				File.Copy(Path.Combine("scenario", scScripts.Where(c => c.id == minigameSelections[i]).Single().startScript), Path.Combine(directory, "Map_40012", "Map_40012", ff6StartScripts[i]), true);
				// TODO: Fill in MISSION_01-10 as well.
				string json = File.ReadAllText(Path.Combine(directory, "Map_40012", "Map_40012", ff6StartScripts[i]));
				EventJSON jEvents = JsonConvert.DeserializeObject<EventJSON>(json);

				int mission = i + 1;
				foreach (var singleScript in jEvents.Mnemonics)
				{
					if (singleScript.mnemonic == "Msg" && singleScript.operands.sValues[0].Contains("MISSION_"))
					{
						singleScript.operands.sValues[0] = "MISSION_" + mission.ToString("0#");
						break;
					}
				}

				JsonSerializer serializer = new JsonSerializer();

				using (StreamWriter sw = new StreamWriter(Path.Combine(directory, "Map_40012", "Map_40012", ff6StartScripts[i])))
				using (JsonWriter writer = new JsonTextWriter(sw))
				{
					serializer.Serialize(writer, jEvents);
				}
			}

			// Establish monsters

			string[] CSVs = new string[] { "story_mes_de.txt", "story_mes_en.txt", "story_mes_es.txt", "story_mes_fr.txt", "story_mes_it.txt", "story_mes_ja.txt", "story_mes_ko.txt", "story_mes_pt.txt", "story_mes_ru.txt", "story_mes_th.txt", "story_mes_zhc.txt", "story_mes_zht.txt" };
			int scriptID = 0;

			List<List<int>> finalItems = new List<List<int>>();
			int[,,] finalItemArray = new int[7, 5, 4];
			List<int> magiciteUsed = new List<int>();
			magiciteUsed.Add(64); // Siren is given to you at the beginning of the game.
			int branchFlags = 0;
			int setFlags = 0;

			// TODO:  Establish item gaining first.  Do it in a [7][5] format, starting with the [X][0] first, then [X][1], and so forth.
			for (int level = 0; level < 5; level++)
			{
				for (int j = 0; j < 7; j++)
				{
					bool allScenarios = j == 6;
					for (int k = 0; k < 4; k++)
					{
						int minTier = (allScenarios ? 5 : 3) + level;
						int maxTier = minTier + 2;
						minTier = Math.Min(8, minTier);
						maxTier = Math.Min(9, maxTier);
						int finalItem = -1;
						List<int> itemsAvailable = new List<int>();

						List<int> magicite = new Magicite().getList(magiciteUsed, Math.Min(6, minTier), Math.Min(8, maxTier));

						itemsAvailable.AddRange(magicite);
						if ((level == 0 && r1.Next() % 3 > 0) || (level == 1 && r1.Next() % 2 > 0) || magicite.Count == 0)
						{
							itemsAvailable.AddRange(new Weapons().getList(minTier, maxTier, true, equippable));
							itemsAvailable.AddRange(new Armor().getList(minTier, maxTier, true, equippable));
							itemsAvailable.AddRange(new Accessories().getList(minTier, maxTier, true, equippable));
						}

						if (itemsAvailable.Count > 0)
							finalItem = itemsAvailable[r1.Next() % itemsAvailable.Count];

						if (magicite.Contains(finalItem))
							magiciteUsed.Add(finalItem);

						finalItemArray[j, level, k] = finalItem;
					}
				}
			}

			foreach (int game in minigameSelections)
			{
				bool allScenarios = (game == 50);
				string script = scScripts.Where(c => c.id == game).Single().winScript;
				string json = File.ReadAllText(Path.Combine(directory, script));
				EventJSON jEvents = JsonConvert.DeserializeObject<EventJSON>(json);
				List<int> scriptItems = new List<int>();
				int miniGame = minigameSelections.IndexOf(game) + 1;
				int rewardMsg = 0;
				int getItems = 0;
				foreach (var singleScript in jEvents.Mnemonics)
				{
					if (!allScenarios && singleScript.mnemonic == "Branch" && singleScript.operands.sValues[0] == "ScenarioFlag3" && singleScript.operands.iValues[0] > 100)
					{
						branchFlags++;
						singleScript.operands.iValues[0] = 100 + branchFlags;
					}
					if (!allScenarios && singleScript.mnemonic == "SetFlag" && singleScript.operands.sValues[0] == "ScenarioFlag3" && singleScript.operands.iValues[0] > 100)
					{
						setFlags++;
						singleScript.operands.iValues[0] = 100 + setFlags;
					}
					if (singleScript.mnemonic == "GetItem")
					{
						int level = getItems / 4;

						singleScript.operands.iValues[0] = finalItemArray[miniGame - 1, level, getItems % 4];
						singleScript.operands.iValues[1] = 1;

						getItems++;
					}

					if (singleScript.mnemonic == "Msg" && singleScript.operands.sValues[0].Contains("_REWARD_") && miniGame >= 0)
					{
						rewardMsg++;
						singleScript.operands.sValues[0] = "MISSION_" + miniGame.ToString("0#").Trim() + "_REWARD_0" + rewardMsg.ToString().Trim();
					}
				}

				finalItems.Add(scriptItems);

				JsonSerializer serializer = new JsonSerializer();

				using (StreamWriter sw = new StreamWriter(Path.Combine(directory, script)))
				using (JsonWriter writer = new JsonTextWriter(sw))
				{
					serializer.Serialize(writer, jEvents);
				}
				scriptID++;
			}

			List<Thread> threads = new List<Thread>();
			foreach (string csv in CSVs)
				fillInScript(finalItemArray, minigameSelections, csv, csvDirectory);
		}

		public static void fillInScript(int[,,] finalItems, List<int> minigameSelections, string CSV, string csvDirectory)
		{
			string language = CSV.Replace("story_mes_", "").Replace(".txt", "");

			// Initialization
			// Get mes_id_name from content.csv, then get accordingly name from whatever language you're using. (system_xx)
			using (StreamReader reader = new StreamReader(Path.Combine("Data", "Message", "system_" + language + ".txt")))
			{
				CsvHelper.Configuration.CsvConfiguration config = new CsvHelper.Configuration.CsvConfiguration(System.Globalization.CultureInfo.InvariantCulture);
				config.Delimiter = "\t";
				config.HasHeaderRecord = false;
				config.BadDataFound = null;

				using (CsvReader csv = new CsvReader(reader, config))
					itemStrings = csv.GetRecords<message>().ToList();
			}

			using (StreamReader reader = new StreamReader(Path.Combine("Data", "Master", "content.csv")))
			{
				CsvHelper.Configuration.CsvConfiguration config = new CsvHelper.Configuration.CsvConfiguration(System.Globalization.CultureInfo.InvariantCulture);
				config.Delimiter = ",";
				config.HasHeaderRecord = true;
				config.BadDataFound = null;

				using (CsvReader csv = new CsvReader(reader, config))
					contentCSV = csv.GetRecords<content>().ToList();
			}

			List<message> missionRecords = new List<message>();
			using (StreamReader reader = new StreamReader(Path.Combine("Data", "Message", CSV)))
			{
				CsvHelper.Configuration.CsvConfiguration config = new CsvHelper.Configuration.CsvConfiguration(System.Globalization.CultureInfo.InvariantCulture);
				config.Delimiter = "\t";
				config.HasHeaderRecord = false;
				config.BadDataFound = null;

				using (CsvReader csv = new CsvReader(reader, config))
					missionRecords = csv.GetRecords<message>().ToList();
			}

			for (int j = 1; j <= 7; j++)
			{
				for (int k = 1; k <= 5; k++)
				{
					string found = "";
					message record = missionRecords.Where(c => c.id == "MISSION_" + j.ToString("0#").Trim() + "_REWARD_0" + k.ToString().Trim()).Single();
					string level = (k == 1 ? "Bronze" : k == 2 ? "Silver" : k == 3 ? "Gold" : k == 4 ? "Diamond" : "Adamant");
					for (int i = 0; i < 4; i++)
					{
						int finalItem = finalItems[j - 1, k - 1, i];

						if (finalItem != -1)
							found += "You won " + itemLookup(itemIDLookup(finalItem), finalItem >= 62 && finalItem <= 88) + "!\\n";
					}

					if (j < 7)
						record.msgString = "You won at the " + level + " level!<P>\\n" + (found == "" ? "You won nothing!" : found);
					else
						record.msgString = "You completed all scenarios at the " + level + " level!<P>\\n" + (found == "" ? "You won nothing!" : found);
				}

				message missionRecord = missionRecords.Where(c => c.id == "MISSION_" + j.ToString("0#").Trim()).Single();
				switch (minigameSelections[j - 1])
				{
					case 0:
						missionRecord.msgString = "Defend the Narshe Mines!\\nChoose your difficulty."; break;
					case 3:
						missionRecord.msgString = "It's Kefka @ Narshe Time!\\nChoose your difficulty."; break;
					case 5:
						missionRecord.msgString = "Traverse the Lethe River!\\nChoose your difficulty."; break;
					case 7:
						missionRecord.msgString = "All aboard the Phantom Train!\\nChoose your difficulty."; break;
					case 8:
						missionRecord.msgString = "It's a long way down Baren Falls!\\nChoose your difficulty."; break;
					case 9:
						missionRecord.msgString = "Zoom through the Serpent Trench!\\nChoose your difficulty."; break;
					case 11:
						missionRecord.msgString = "Ultros is trying to ruin the Opera!\\nChoose your difficulty."; break;
					case 17:
						missionRecord.msgString = "Here comes the Imperial Air Force! (IAF)\\nChoose your difficulty."; break;
					case 31:
						missionRecord.msgString = "It's magic only at the Fanatics Tower!\\nChoose your difficulty."; break;
					case 47:
						missionRecord.msgString = "Save Cid at Solitary Island!\\nChoose your difficulty."; break;
					case 49:
						missionRecord.msgString = "Monsters have invaded the Falcon!\\nAre you ready?"; break;
					default:
						missionRecord.msgString = "Not implemented!\nChoose your difficulty anyway."; break;
				}
			}

			message practiceMission = missionRecords.Where(c => c.id == "MISSION_10").Single();
			practiceMission.msgString = "Here you can engage a practice fight.  There will be no special reward, but you will get XP if required.\\nChoose your difficulty.";

			using (StreamWriter writer = new StreamWriter(Path.Combine(csvDirectory, CSV)))
			{
				CsvHelper.Configuration.CsvConfiguration config = new CsvHelper.Configuration.CsvConfiguration(System.Globalization.CultureInfo.InvariantCulture);
				config.Delimiter = "\t";
				config.HasHeaderRecord = false;

				using (CsvWriter csv = new CsvWriter(writer, config))
					csv.WriteRecords(missionRecords);
			}
		}

		private static string itemIDLookup(int finalItem)
		{
			return contentCSV.Where(c => c.id == finalItem).Single().mes_id_name;
		}

		private static string itemLookup(string mesName, bool magicite)
		{
			return itemStrings.Where(c => c.id == mesName).Single().msgString + (magicite ? " " + itemStrings.Where(c => c.id == "MSG_SYSTEM_207").Single().msgString : "");
		}
	}
}