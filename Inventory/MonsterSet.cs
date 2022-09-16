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
    public class MonsterSet
    {
        private class singleSet
        {
            public int id { get; set; }
            public int monster_set1 { get; set; }
            public int monster_set1_rate { get; set; }
            public int monster_set2 { get; set; }
            public int monster_set2_rate { get; set; }
            public int monster_set3 { get; set; }
            public int monster_set3_rate { get; set; }
            public int monster_set4 { get; set; }
            public int monster_set4_rate { get; set; }
            public int monster_set5 { get; set; }
            public int monster_set5_rate { get; set; }
            public int monster_set6 { get; set; }
            public int monster_set6_rate { get; set; }
            public int monster_set7 { get; set; }
            public int monster_set7_rate { get; set; }
            public int monster_set8 { get; set; }
            public int monster_set8_rate { get; set; }
            public int monster_set9 { get; set; }
            public int monster_set9_rate { get; set; }
            public int monster_set10 { get; set; }
            public int monster_set10_rate { get; set; }
            public int monster_set11 { get; set; }
            public int monster_set11_rate { get; set; }
            public int monster_set12 { get; set; }
            public int monster_set12_rate { get; set; }
            public int monster_set13 { get; set; }
            public int monster_set13_rate { get; set; }
            public int monster_set14 { get; set; }
            public int monster_set14_rate { get; set; }
            public int monster_set15 { get; set; }
            public int monster_set15_rate { get; set; }
            public int monster_set16 { get; set; }
            public int monster_set16_rate { get; set; }
        }

        private List<singleSet> allSets = new List<singleSet>();

        public MonsterSet()
		{
            using (StreamReader reader = new(Path.Combine("csv", "monster_set.csv")))
            using (CsvReader csv = new(reader, System.Globalization.CultureInfo.InvariantCulture))
                allSets = csv.GetRecords<singleSet>().ToList();
        }

        public void setUpMonsterSets(Random r1, int starter, int firstParty, int difficulty)
		{
            for (int i = starter; i < starter + 10; i++)
			{
                singleSet newSet = new singleSet();
                newSet.id = i;
                List<int> parties = new List<int>();
                // Have a double chance of a monster set appearing except the "super set", set 18.
                for (int j = 0; j < 19; j++) // Do not use 19; that's the boss.
				{
                    parties.Add(firstParty + (20 * (difficulty - 1)) + j);
                    if (j != 18)
                        parties.Add(firstParty + (20 * (difficulty - 1)) + j);
                }
                parties.Shuffle(r1);
                parties.RemoveRange(6, parties.Count - 6);
                parties.Sort();

                newSet.monster_set1 = parties[0];
                newSet.monster_set1_rate = 80;
                newSet.monster_set2 = parties[1];
                newSet.monster_set2_rate = 80;
                newSet.monster_set3 = parties[2];
                newSet.monster_set3_rate = 80;
                newSet.monster_set4 = parties[3];
                newSet.monster_set4_rate = 80;
                newSet.monster_set5 = parties[4];
                newSet.monster_set5_rate = 80;
                newSet.monster_set6 = parties[5];
                newSet.monster_set6_rate = 16;
                newSet.monster_set7 = 0;
                newSet.monster_set7_rate = 0;
                newSet.monster_set8 = 0;
                newSet.monster_set8_rate = 0;
                newSet.monster_set9 = 0;
                newSet.monster_set9_rate = 0;
                newSet.monster_set10 = 0;
                newSet.monster_set10_rate = 0;
                newSet.monster_set11 = 0;
                newSet.monster_set11_rate = 0;
                newSet.monster_set12 = 0;
                newSet.monster_set12_rate = 0;
                newSet.monster_set13 = 0;
                newSet.monster_set13_rate = 0;
                newSet.monster_set14 = 0;
                newSet.monster_set14_rate = 0;
                newSet.monster_set15 = 0;
                newSet.monster_set15_rate = 0;
                newSet.monster_set16 = 0;
                newSet.monster_set16_rate = 0;

                allSets.Add(newSet);
            }
        }

        public void saveMonsterSets(string directory)
		{
            using (StreamWriter writer = new(Path.Combine(directory, "monster_set.csv")))
            using (CsvWriter csv = new(writer, System.Globalization.CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(allSets);
            }
        }
    }
}
