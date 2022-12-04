using FF6KefkaRush.Common;
using FF6KefkaRush.Inventory;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FF6KefkaRush.Common.Scenarios;

namespace FF6KefkaRush.Randomize
{
	public static class Minigames
	{
		public static List<int> determineMinigames(Random r1, string directory)
		{
			List<int> minigameSelections = new List<int> { 0, 3, 5, 7, 8, 9, 11, 17, 31, 49 }; // 47 is also available

			minigameSelections.Shuffle(r1);
			minigameSelections = new List<int> { minigameSelections[0], minigameSelections[1], minigameSelections[2], minigameSelections[3], minigameSelections[4], minigameSelections[5] };
			minigameSelections.Sort();
			//minigameSelections[5] = 5; // DEBUG
			minigameSelections.Add(50);

			// TODO:  Iterate through mini-games and set asset IDs for entity_default in Map_40012.
			string json3 = File.ReadAllText(Path.Combine(directory, "Map_40012", "Map_40012", "entity_default.json"));
			EntityJSON jEvents3 = JsonConvert.DeserializeObject<EntityJSON>(json3);

			List<scenario> scScripts = Scenarios.getScripts();

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

			return minigameSelections;
		}
	}
}
