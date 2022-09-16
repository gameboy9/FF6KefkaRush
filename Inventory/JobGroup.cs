using CsvHelper;
using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF6KefkaRush.Inventory
{
	public static class JobGroup
	{
		private class job_group
		{
			[Index(0)]
			public int id { get; set; }
			[Index(1)]
			public int job1_accept { get; set; }
			[Index(2)]
			public int job2_accept { get; set; }
			[Index(3)]
			public int job3_accept { get; set; }
			[Index(4)]
			public int job4_accept { get; set; }
			[Index(5)]
			public int job5_accept { get; set; }
			[Index(6)]
			public int job6_accept { get; set; }
			[Index(7)]
			public int job7_accept { get; set; }
			[Index(8)]
			public int job8_accept { get; set; }
			[Index(9)]
			public int job9_accept { get; set; }
			[Index(10)]
			public int job10_accept { get; set; }
			[Index(11)]
			public int job11_accept { get; set; }
			[Index(12)]
			public int job12_accept { get; set; }
			[Index(13)]
			public int job13_accept { get; set; }
			[Index(14)]
			public int job14_accept { get; set; }
			[Index(15)]
			public int job15_accept { get; set; }
			[Index(16)]
			public int job16_accept { get; set; }
			[Index(17)]
			public int job17_accept { get; set; }
			[Index(18)]
			public int job18_accept { get; set; }
			[Index(19)]
			public int job19_accept { get; set; }
			[Index(20)]
			public int job20_accept { get; set; }
			[Index(21)]
			public int job21_accept { get; set; }
			[Index(22)]
			public int job22_accept { get; set; }
		}

		public static List<int> GetEquipJobGroupID(List<int> party, bool includeSpecial = false)
		{
			List<int> tempParty = party.ToList();
			List<int> allowedEquip = new List<int>();

			for (int i = 0; i < tempParty.Count; i++)
			{
				if (tempParty[i] == 1) tempParty[i] = 19;
				if (!includeSpecial && tempParty[i] >= 14) tempParty[i] = 22;
				if (includeSpecial && tempParty[i] >= 31) tempParty[i] = 18;
			}
			// TODO: Need to retrieve job_group.csv - a bit cumbersome... job[1-22]_accept -> id - place in new List<int>
			List<job_group> records;

			using (StreamReader reader = new StreamReader(Path.Combine("csv", "job_group.csv")))
			using (CsvReader csv = new CsvReader(reader, System.Globalization.CultureInfo.InvariantCulture))
				records = csv.GetRecords<job_group>().ToList();

			foreach(job_group record in records)
			{
				List<int> accept = new List<int>();
				accept.Add(0); // Want this array to be "1-based", based on party.
				accept.Add(record.job1_accept);
				accept.Add(record.job2_accept);
				accept.Add(record.job3_accept);
				accept.Add(record.job4_accept);
				accept.Add(record.job5_accept);
				accept.Add(record.job6_accept);
				accept.Add(record.job7_accept);
				accept.Add(record.job8_accept);
				accept.Add(record.job9_accept);
				accept.Add(record.job10_accept);
				accept.Add(record.job11_accept);
				accept.Add(record.job12_accept);
				accept.Add(record.job13_accept);
				accept.Add(record.job14_accept);
				accept.Add(record.job15_accept);
				accept.Add(record.job16_accept);
				accept.Add(record.job17_accept);
				accept.Add(record.job18_accept);
				accept.Add(record.job19_accept);
				accept.Add(record.job20_accept);
				accept.Add(record.job21_accept);
				accept.Add(record.job22_accept);

				if (accept[tempParty[0]] == 1 || accept[tempParty[1]] == 1 || accept[tempParty[2]] == 1 || accept[tempParty[3]] == 1)
					allowedEquip.Add(record.id);
			}

			return allowedEquip;
		}
	}
}
