using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using FF6KefkaRush.Common;
using FF6KefkaRush.Inventory;
using Newtonsoft.Json;

namespace FF6KefkaRush.Randomize
{
	public class Party
	{
		private class character : ICloneable
		{
			public int id { get; set; }
			public int gender { get; set; }
			public int dominant_arm { get; set; }
			public int lv { get; set; }
			public int exp { get; set; }
			public int growth_curve_group_id { get; set; }
			public int job_id { get; set; }
			public string mes_id_name { get; set; }
			public int in_type_id { get; set; }
			public int hp { get; set; }
			public int mp { get; set; }
			public int magical_times1 { get; set; }
			public int magical_times2 { get; set; }
			public int magical_times3 { get; set; }
			public int magical_times4 { get; set; }
			public int magical_times5 { get; set; }
			public int magical_times6 { get; set; }
			public int magical_times7 { get; set; }
			public int magical_times8 { get; set; }
			public int strength { get; set; }
			public int vitality { get; set; }
			public int agility { get; set; }
			public int intelligence { get; set; }
			public int spirit { get; set; }
			public int magic { get; set; }
			public int luck { get; set; }
			public int attack { get; set; }
			public int defense { get; set; }
			public int accuracy_rate { get; set; }
			public int dodge_times { get; set; }
			public int evasion_rate { get; set; }
			public int ability_defense { get; set; }
			public int magic_evasion_rate { get; set; }
			public int corps { get; set; }
			public int command_id1 { get; set; } // Fight
			public int command_id2 { get; set; }
			public int command_id3 { get; set; }
			public int command_id4 { get; set; }
			public int command_id5 { get; set; }
			public int command_id6 { get; set; }
			public int content_id1 { get; set; }
			public int content_id2 { get; set; }
			public int content_id3 { get; set; }
			public int content_id4 { get; set; }
			public int content_id5 { get; set; }
			public int content_id6 { get; set; }
			public int ability_random_group_id { get; set; }
			public int initial_condition_group { get; set; }
			public int character_asset_id { get; set; }

			public object Clone()
			{
				return this.MemberwiseClone();
			}
		}

		private class init
        {
			public int id { get; set; }
			public string key_name { get; set; }
			public int value1 { get; set; }
			public int value2 { get; set; }
        }

		const int terra = 1;
		const int locke = 2;
		const int cyan = 3;
		const int shadow = 4;
		const int edgar = 5;
		const int sabin = 6;
		const int celes = 7;
		const int strago = 8;
		const int relm = 9;
		const int setzer = 10;
		const int mog = 11;
		const int gau = 12;
		const int gogo = 13;
		const int umaro = 14;
		const int banon = 15;
		const int leo = 16;
		const int wedge = 31;
		const int biggs = 32;

		private List<int> characters = new List<int>();

		public Party(Random r1, string directory, bool duplicates, int numHeroes, bool[] exclude)
		{
			List<character> records;

			using (StreamReader reader = new StreamReader(Path.Combine("csv", "character_status.csv")))
			using (CsvReader csv = new CsvReader(reader, System.Globalization.CultureInfo.InvariantCulture))
				records = csv.GetRecords<character>().ToList();

			List<init> newInits = new List<init>();

			using (StreamReader reader = new StreamReader(Path.Combine("csv", "initialize_data.csv")))
			using (CsvReader csv = new CsvReader(reader, System.Globalization.CultureInfo.InvariantCulture))
				newInits = csv.GetRecords<init>().ToList();

			if (duplicates)
			{
				for (int i = 0; i < 18; i++)
				{
					int charID = r1.Next() % 18 + 1;
					charID = charID == 17 ? 31 : charID == 18 ? 32 : charID;
					if ((charID == terra && !exclude[0]) ||
						(charID == locke && !exclude[1]) ||
						(charID == cyan && !exclude[2]) ||
						(charID == shadow && !exclude[3]) ||
						(charID == edgar && !exclude[4]) ||
						(charID == sabin && !exclude[5]) ||
						(charID == celes && !exclude[6]) ||
						(charID == strago && !exclude[7]) ||
						(charID == relm && !exclude[8]) ||
						(charID == setzer && !exclude[9]) ||
						(charID == mog && !exclude[10]) ||
						(charID == gau && !exclude[11]) ||
						(charID == gogo && !exclude[12]) ||
						(charID == umaro && !exclude[13]) ||
						(charID == banon && !exclude[14]) ||
						(charID == leo && !exclude[15]) ||
						(charID == wedge && !exclude[16]) ||
						(charID == biggs && !exclude[17]))
						characters.Add(charID);
					else
						i--;  // redraw if a character is checked as excluded
				}
			}
			else
			{
				characters = new List<int> { terra, locke, cyan, shadow, edgar, sabin, celes, strago, relm, setzer, mog, gau, gogo, umaro, banon, leo, wedge, biggs };
				if (exclude[0]) characters.Remove(terra);
				if (exclude[1]) characters.Remove(locke);
				if (exclude[2]) characters.Remove(cyan);
				if (exclude[3]) characters.Remove(shadow);
				if (exclude[4]) characters.Remove(edgar);
				if (exclude[5]) characters.Remove(sabin);
				if (exclude[6]) characters.Remove(celes);
				if (exclude[7]) characters.Remove(strago);
				if (exclude[8]) characters.Remove(relm);
				if (exclude[9]) characters.Remove(setzer);
				if (exclude[10]) characters.Remove(mog);
				if (exclude[11]) characters.Remove(gau);
				if (exclude[12]) characters.Remove(gogo);
				if (exclude[13]) characters.Remove(umaro);
				if (exclude[14]) characters.Remove(banon);
				if (exclude[15]) characters.Remove(leo);
				if (exclude[16]) characters.Remove(wedge);
				if (exclude[17]) characters.Remove(biggs);
				characters.Shuffle(r1);
			}
			for (int i = 1; i <= 34; i++)
			{
				if (!characters.Contains(i))
					characters.Add(i);
			}

			int id = 1;
			List<character> newRecords = new List<character>();
			List<int> newCharIDs = new List<int>();
			List<int> availableIDs = new List<int> { 2, 3, 4, 5, 6, 8, 9, 10 };
			List<int> allCharIDs = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34 };
			List<int> charsToReassign = new List<int> { 15, 16, 31, 32 };
			for (int i = 0; i < 4; i++)
			{
				if (availableIDs.Contains(characters[i]) || charsToReassign.Contains(characters[i]))
					availableIDs.Remove(characters[i]);
			}

			int dupID = 0;

			foreach (int singleChar in characters)
			{
				if (allCharIDs.Count == 0) break;

				// Next two lines:  Prevents changes done to the single object as well as the list.
				character oldRecord = records.Where(c => c.id == singleChar).ToList()[0];
				character newRecord = (character)oldRecord.Clone();
				if (id <= 4)
				{
					if (newRecords.Any(c => c.id == newRecord.id) || charsToReassign.Contains(characters[id - 1]))
					{
						newRecord.id = availableIDs[dupID];
						dupID++;
					}
					else
					{
						newRecord.id = oldRecord.id;
					}
				} else
				{
					newRecord.id = allCharIDs.Min();
				}
				allCharIDs.Remove(newRecord.id);
				newRecord.job_id = newRecord.job_id == 19 ? 1 : newRecord.job_id;
				newRecords.Add(newRecord);
				id++;
			}

			using (StreamWriter writer = new StreamWriter(Path.Combine(directory, "..", "..", "Data", "Master", "character_status.csv")))
			using (CsvWriter csv = new CsvWriter(writer, System.Globalization.CultureInfo.InvariantCulture))
			{
				csv.WriteRecords(newRecords);
			}

			if (numHeroes < 4) newInits.RemoveAll(c => c.id == 6); else newInits.Where(c => c.id == 6).Single().value1 = newRecords[3].id; // characters[3];
			if (numHeroes < 3) newInits.RemoveAll(c => c.id == 3); else newInits.Where(c => c.id == 3).Single().value1 = newRecords[2].id; // characters[2];
			if (numHeroes < 2) newInits.RemoveAll(c => c.id == 2); else newInits.Where(c => c.id == 2).Single().value1 = newRecords[1].id; // characters[1];
			newInits.Where(c => c.id == 1).Single().value1 = newRecords[0].id; // characters[0];

			int startingGold = 0;
			newInits.Where(c => c.id == 4).Single().value1 = startingGold;

			using (StreamWriter writer = new StreamWriter(Path.Combine(directory, "..", "..", "Data", "Master", "initialize_data.csv")))
			using (CsvWriter csv = new CsvWriter(writer, System.Globalization.CultureInfo.InvariantCulture))
			{
				csv.WriteRecords(newInits);
			}

			using (StreamWriter writer = new StreamWriter(Path.Combine(directory, "..", "..", "Data", "Master", "intermediate_growth_curve.csv")))
			{
				writer.WriteLine("id,character_id,job_id,growth_curve_group_id,exp_table_group_id");
				id = 1;
				foreach (character record in newRecords)
				{
					writer.WriteLine(record.id.ToString().Trim() + "," + record.id.ToString().Trim() + "," + record.job_id.ToString().Trim() + ",1,1");
					id++;
				}
			}
		}

		public int[] getParty(int numHeroes)
        {
			switch (numHeroes)
			{
				case 1:
					return new int[] { characters[0] }; 
				case 2:
					return new int[] { characters[0], characters[1] };
				case 3:
					return new int[] { characters[0], characters[1], characters[2] };
				case 4:
				default:
					return new int[] { characters[0], characters[1], characters[2], characters[3] };
			}
		}
	}
}
