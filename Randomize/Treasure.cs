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
using System.Configuration;
using static FF6KefkaRush.Common.Scenarios;

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

		private static List<message> itemStrings;
		private static List<content> contentCSV = new List<content>();

		public static void createTreasure(Random r1, string directory, string csvDirectory, List<int> equippable, List<int> minigameSelections)
		{
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

						List<int> magicite = Magicite.getList(magiciteUsed, Math.Min(6, minTier), Math.Min(8, maxTier));

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

			List<scenario> scScripts = getScripts();

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