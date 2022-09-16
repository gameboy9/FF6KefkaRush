using CsvHelper;
using FF6KefkaRush.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF6KefkaRush.Inventory
{
	public static class Learning
	{
		private class singleLearn
		{
			// id,type_id,value1,value2,job_id,content_id
			public int id { get; set; }
			public int type_id { get; set; }
			public int value1 { get; set; }
			public int value2 { get; set; }
			public int job_id { get; set; }
			public int content_id { get; set; }
		}

		public static void GauStragoLearn(Random r1, string directory)
		{
			List<singleLearn> records = new();
			using (StreamReader reader = new StreamReader(Path.Combine("csv", "learning.csv")))
			using (CsvReader csv = new CsvReader(reader, System.Globalization.CultureInfo.InvariantCulture))
				records = csv.GetRecords<singleLearn>().ToList();

			int learnID = 232;

			// Add Lores to Strago at levels 10, 15, 20, 25, etc.
			List<int> lores = new List<int>();
			List<int> existingLores = new List<int> { 473, 477, 490 };
			for (int i = 470; i <= 493; i++)
			{
				if (!existingLores.Contains(i))
					lores.Add(i);
			}
			lores.Shuffle(r1);

			int spellPointer = 0;
			for (int lv = 10; lv < 100; lv += 5)
			{
				singleLearn newMagic = new singleLearn();
				newMagic.id = learnID;
				newMagic.type_id = 1;
				newMagic.value1 = lv;
				newMagic.value2 = 0;
				newMagic.job_id = 8;
				newMagic.content_id = lores[spellPointer];
				learnID++;
				spellPointer++;
				records.Add(newMagic);
			}

			List<int> rages = new List<int>();
			List<int> existingRages = new List<int> { 979, 982, 987, 989, 993, 1014, 1022, 1025, 1034 };
			for (int i = 968; i <= 1222; i++)
			{
				if (!existingRages.Contains(i))
					rages.Add(i);
			}
			rages.Shuffle(r1);

			spellPointer = 0;
			for (int lv = 8; lv < 100; lv += 2)
			{
				singleLearn newMagic = new singleLearn();
				newMagic.id = learnID;
				newMagic.type_id = 1;
				newMagic.value1 = lv;
				newMagic.value2 = 0;
				newMagic.job_id = 12;
				newMagic.content_id = rages[spellPointer];
				learnID++;
				spellPointer++;
				records.Add(newMagic);
			}

			using (StreamWriter writer = new StreamWriter(Path.Combine(directory, "learning.csv")))
			using (CsvWriter csv = new CsvWriter(writer, System.Globalization.CultureInfo.InvariantCulture))
			{
				csv.WriteRecords(records);
			}
		}
	}
}
