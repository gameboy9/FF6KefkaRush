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

namespace FF6KefkaRush.Randomize
{
	public class Treasure
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

		public Treasure(Random r1, string directory, string csvDirectory, List<int> equippable)
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

			// TODO:  Shuffle, then establish starter scripts.
			minigameSelections.Shuffle(r1);

			////////////////////////////////////////////
			// Now we need to cycle through the four super item scripts and place treasures in there.  We also will have to update the text accordingly.
			string[] winScripts = new string[] {
				"Map_30011\\Map_30011_2\\sc_e_0018_2.json", // 0
				"",
				"",
				"Map_20030\\Map_20030\\sc_e_0259_1.json",
				"",
				"Map_30390\\Map_30390\\sc_e_0065_1.json", // 5
				"",
				"Map_30440\\Map_30440\\sc_e_0214_1.json",
				"Map_30480\\Map_30480\\sc_e_0218_2.json",
				"Map_20121\\Map_20121_4\\sc_e_1502_3.json",
				"", // 10
				"Map_20161\\Map_20161_6\\sc_e_0344_2.json",
				"",
				"",
				"",
				"", // 15
				"",
				"Map_30600\\Map_30600\\sc_e_0565_3.json",
				"",
				"",
				"", // 20
				"",
				"",
				"",
				"",
				"", // 25
				"",
				"",
				"",
				"",
				"", // 30
				"Map_30750\\Map_30750\\sc_e_0881_1.json",
				"",
				"",
				"",
				"", // 35
				"",
				"",
				"",
				"",
				"", // 40
				"",
				"",
				"",
				"",
				"", // 45
				"",
				"Map_20291\\Map_20291_1\\sc_e_0625.json",
				"",
				"Map_Script\\Resident\\sc_secede_gau.json" // 49
			};

			// We also need to infuse the scripts at Map_40012.
			// sc_e_0065_2
			// sc_e_0135_1
			// sc_e_0256_1
			// sc_e_0258_1
			// sc_e_0302_1
			// sc_e_0328_1
			// sc_e_0569_1
			// sc_e_0607_9
			// sc_e_0828_1
			// sc_e_0966_3_1
			string[] startScripts = new string[] {
				"narshemines.json", // 0
				"",
				"",
				"kefkaatnarshe.json",
				"",
				"letheriver.json", // 5
				"",
				"phantomtrain.json",
				"barenfalls.json",
				"serpenttrench.json",
				"", // 10
				"operahouse.json",
				"",
				"",
				"",
				"", // 15
				"",
				"imperialairforce.json",
				"",
				"",
				"", // 20
				"",
				"",
				"",
				"",
				"", // 25
				"",
				"",
				"",
				"",
				"", // 30
				"cultiststower.json",
				"",
				"",
				"",
				"", // 35
				"",
				"",
				"",
				"",
				"", // 40
				"",
				"",
				"",
				"",
				"", // 45
				"",
				"solitaryisland.json",
				"",
				"falcon.json" // 49
			};

			string[] ff6StartScripts = new string[6] { "sc_e_0065_2.json", "sc_e_0135_1.json", "sc_e_0256_1.json", "sc_e_0258_1.json", "sc_e_0302_1.json", "sc_e_0328_1.json" }; // , "sc_e_0569_1.json", "sc_e_0607_9.json", "sc_e_0828_1.json", "sc_e_0966_3_1.json"
			for (int i = 0; i < ff6StartScripts.Count(); i++)
			{
				File.Copy(Path.Combine("scenario", startScripts[minigameSelections[i]]), Path.Combine(directory, "Map_40012", "Map_40012", ff6StartScripts[i]), true);
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
			List<int> magiciteUsed = new List<int>();
			const int itemsToGrant = 4;
			foreach (string script in winScripts)
			{
				if (script == "" || !minigameSelections.Contains(scriptID))
				{
					finalItems.Add(new List<int>());
					scriptID++;
					continue;
				}
				string json = File.ReadAllText(Path.Combine(directory, script));
				EventJSON jEvents = JsonConvert.DeserializeObject<EventJSON>(json);
				List<int> scriptItems = new List<int>();
				int rewardMsg = 0;
				int getItems = 0;
				foreach (var singleScript in jEvents.Mnemonics)
				{
					if (singleScript.mnemonic == "GetItem")
					{
						int level = getItems / 4;
						getItems++;
						int minTier = 2 + (scriptID / 20) + level;
						int maxTier = minTier + 2;
						maxTier = maxTier > 9 ? 9 : maxTier;
						int finalItem = -1;
						List<int> itemsAvailable = new List<int>();
						
						itemsAvailable.AddRange(new Weapons().getList(minTier, maxTier, true, equippable));
						itemsAvailable.AddRange(new Armor().getList(minTier, maxTier, true, equippable));
						itemsAvailable.AddRange(new Accessories().getList(minTier, maxTier, true, equippable));

						if ((level == 0 && r1.Next() % 5 == 0) || (level >= 1 && r1.Next() % 2 == 0) || level >= 2)
							itemsAvailable.AddRange(new Magicite().getList(magiciteUsed, 3, 4 + level));

						if (itemsAvailable.Count > 0)
							finalItem = itemsAvailable[r1.Next() % itemsAvailable.Count];

						if (new Magicite().getList(magiciteUsed, 3, 4 + level).Contains(finalItem))
							magiciteUsed.Add(finalItem);

						singleScript.operands.iValues[0] = finalItem;
						singleScript.operands.iValues[1] = 1;
						scriptItems.Add(finalItem);
					}

					int miniGame = minigameSelections.IndexOf(scriptID) + 1;
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

			foreach (string CSV in CSVs)
			{
				List<message> records = new List<message>();
				using (StreamReader reader = new StreamReader(Path.Combine("Data", "Message", CSV)))
				{
					CsvHelper.Configuration.CsvConfiguration config = new CsvHelper.Configuration.CsvConfiguration(System.Globalization.CultureInfo.InvariantCulture);
					config.Delimiter = "\t";
					config.HasHeaderRecord = false;
					config.BadDataFound = null;

					using (CsvReader csv = new CsvReader(reader, config))
						records = csv.GetRecords<message>().ToList();
				}

				for (int j = 1; j <= 6; j++)
				{
					for (int k = 1; k <= 5; k++)
					{
						string found = "";
						message record = records.Where(c => c.id == "MISSION_" + j.ToString("0#").Trim() + "_REWARD_0" + k.ToString().Trim()).Single();
						string level = (k == 1 ? "Bronze" : k == 2 ? "Silver" : k == 3 ? "Gold" : k == 4 ? "Diamond" : "Adamant");
						for (int i = 0; i < 4; i++)
						{
							int finalItem = finalItems[minigameSelections[j - 1]].Count < 5 ? -1 : finalItems[minigameSelections[j - 1]][((k - 1) * 4) + i];

							if (finalItem != -1)
								found += "You won " + itemLookup(itemIDLookup(finalItem), CSV.Replace("story_mes_", "").Replace(".txt", "")) + "!\\n";
						}

						record.msgString = "You won at the " + level + " level!<P>\\n" + (found == "" ? "You won nothing!" : found);
					}

					message missionRecord = records.Where(c => c.id == "MISSION_" + j.ToString("0#").Trim()).Single();
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

				// TODO:  Mission texts


				using (StreamWriter writer = new StreamWriter(Path.Combine(csvDirectory, CSV)))
				{
					CsvHelper.Configuration.CsvConfiguration config = new CsvHelper.Configuration.CsvConfiguration(System.Globalization.CultureInfo.InvariantCulture);
					config.Delimiter = "\t";
					config.HasHeaderRecord = false;

					using (CsvWriter csv = new CsvWriter(writer, config))
						csv.WriteRecords(records);
				}
			}
		}

		private int RateThatTreasury(Random r1, ref int type)
        {
			type = r1.Next() % 8;
			if (type >= 4) type = 4;
			int rnd = r1.Next() % 511;
			return (rnd == 0 ? 9 :
					rnd <= 2 ? 8 :
					rnd <= 6 ? 7 :
					rnd <= 14 ? 6 :
					rnd <= 30 ? 5 :
					rnd <= 62 ? 4 :
					rnd <= 126 ? 3 :
					rnd <= 254 ? 2 : 1);
        }

		private string itemIDLookup(int finalItem)
		{
			List<content> contentCSV = new List<content>();
			using (StreamReader reader = new StreamReader(Path.Combine("Data", "Master", "content.csv")))
			{
				CsvHelper.Configuration.CsvConfiguration config = new CsvHelper.Configuration.CsvConfiguration(System.Globalization.CultureInfo.InvariantCulture);
				config.Delimiter = ",";
				config.HasHeaderRecord = true;
				config.BadDataFound = null;

				using (CsvReader csv = new CsvReader(reader, config))
					contentCSV = csv.GetRecords<content>().ToList();
			}
			return contentCSV.Where(c => c.id == finalItem).Single().mes_id_name;
		}

		private string itemLookup(string mesName, string language)
		{
			// Get mes_id_name from content.csv, then get accordingly name from whatever language you're using. (system_xx)
			List<message> records = new List<message>();
			using (StreamReader reader = new StreamReader(Path.Combine("Data", "Message", "system_" + language + ".txt")))
			{
				CsvHelper.Configuration.CsvConfiguration config = new CsvHelper.Configuration.CsvConfiguration(System.Globalization.CultureInfo.InvariantCulture);
				config.Delimiter = "\t";
				config.HasHeaderRecord = false;
				config.BadDataFound = null;

				using (CsvReader csv = new CsvReader(reader, config))
					records = csv.GetRecords<message>().ToList();
			}

			return records.Where(c => c.id == mesName).Single().msgString;
		}
	}
}