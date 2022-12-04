using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FF6KefkaRush.Inventory.Monster;

namespace FF6KefkaRush.Common
{
	public static class Scenarios
	{
		public class scenario
		{
			public int id { get; set; }
			public string winScript { get; set; }
			public string startScript { get; set; }
			public int characterID { get; set; }
			public int initialPartyID { get; set; }
			public List<int> ordinaryMonsterList { get; set; }
			public List<int> bossList { get; set; }
			public int initialXPLimit { get; set; }
			public int initialXPBossLimit { get; set; }
			public int initialDifficulty { get; set; }	
			public int battleBackground { get; set; }
			public int bossBattleBackground { get; set; }
			public int bgm { get; set; }
			public int bossbgm { get; set; }
			public bool noEscape { get; set; }
			public List<singleGroup> monsterParties { get; set; }
		}

		public static List<scenario> getScripts()
		{
			return new List<scenario>()
			{
				// Single fight scenario
				new scenario {
					id = -1,
					characterID = 51,
					startScript = "",
					winScript = "",
					initialPartyID = 4900,
					ordinaryMonsterList = new List<int> { 1, 26, 20, 71, 78, 41, 24 },
					bossList = new List<int> { },
					initialXPLimit = 60,
					initialXPBossLimit = 275,
					initialDifficulty = 1,
					battleBackground = 1,
					bossBattleBackground = 1,
					bgm = 6,
					bossbgm = 6,
					noEscape = true
				},
				new scenario { // Narshe Mines
					id = 0,
					characterID = 142,
					startScript = "narshemines.json",
					winScript = "Map_30011\\Map_30011_2\\sc_e_0018_2.json",
					initialPartyID = 5000,
					ordinaryMonsterList = new List<int> { 1, 28, 26, 20, 71, 78 },
					bossList = new List<int> { 101 },
					initialXPLimit = 90,
					initialXPBossLimit = 275,
					initialDifficulty = 1,
					battleBackground = 11,
					bossBattleBackground = 11,
					bgm = 0,
					bossbgm = 25,
					noEscape = true
				},
				new scenario { // Kefka @ Narshe
					id = 3,
					characterID = 142, // Empire Soldier, not Kefka, already used.
					startScript = "kefkaatnarshe.json",
					winScript = "Map_20030\\Map_20030\\sc_e_0259_1.json",
					initialPartyID = 5300,
					ordinaryMonsterList = new List<int> { 102, 29, 160, 122, 64 },
					bossList = new List<int> { 331 },
					initialXPLimit = 250,
					initialXPBossLimit = 1500,
					initialDifficulty = 1,
					battleBackground = 19,
					bossBattleBackground = 19,
					bgm = 0,
					bossbgm = 25,
					noEscape = true
				},
				new scenario { // Lethe River
					id = 5,
					characterID = 49,
					startScript = "letheriver.json",
					winScript = "Map_30390\\Map_30390\\sc_e_0065_1.json",
					initialPartyID = 5500,
					ordinaryMonsterList = new List<int> { 35, 57, 58 },
					bossList = new List<int> { 301 },
					initialXPLimit = 400,
					initialXPBossLimit = 1000,
					initialDifficulty = 1,
					battleBackground = 14,
					bossBattleBackground = 14,
					bgm = 6,
					bossbgm = 25,
					noEscape = true
				},
				new scenario { // Phantom Train
					id = 7,
					characterID = 139,
					startScript = "phantomtrain.json",
					winScript = "Map_30440\\Map_30440\\sc_e_0214_1.json",
					initialPartyID = 5700,
					ordinaryMonsterList = new List<int> { 80, 9, 15, 91, 163, 187, 16 },
					bossList = new List<int> { 263 },
					initialXPLimit = 80,
					initialXPBossLimit = 800,
					initialDifficulty = 1,
					battleBackground = 16,
					bossBattleBackground = 34,
					bgm = 6,
					bossbgm = 25,
					noEscape = false
				},
				new scenario { // Baren Falls
					id = 8,
					characterID = 71,
					startScript = "barenfalls.json",
					winScript = "Map_30480\\Map_30480\\sc_e_0218_2.json",
					initialPartyID = 5800,
					ordinaryMonsterList = new List<int> { 42, 119, 48, 25, 341 },
					bossList = new List<int> { 342 },
					initialXPLimit = 80,
					initialXPBossLimit = 500,
					initialDifficulty = 1,
					battleBackground = 32,
					bossBattleBackground = 32,
					bgm = 6,
					bossbgm = 6,
					noEscape = true
				},
				new scenario { // Serpent Trench
					id = 9,
					characterID = 99,
					startScript = "serpenttrench.json",
					winScript = "Map_20121\\Map_20121_4\\sc_e_1502_3.json",
					initialPartyID = 5900,
					ordinaryMonsterList = new List<int> { 35, 57, 58 },
					bossList = new List<int> {  },
					initialXPLimit = 400,
					initialXPBossLimit = 2400,
					initialDifficulty = 1,
					battleBackground = 36,
					bossBattleBackground = 36,
					bgm = 0,
					bossbgm = 0,
					noEscape = true
				},
				new scenario { // Opera House
					id = 11,
					characterID = 47,
					startScript = "operahouse.json",
					winScript = "Map_20161\\Map_20161_6\\sc_e_0344_2.json",
					initialPartyID = 6100,
					ordinaryMonsterList = new List<int> { 116, 210 },
					bossList = new List<int> { 302 },
					initialXPLimit = 350,
					initialXPBossLimit = 1000,
					initialDifficulty = 1,
					battleBackground = 25,
					bossBattleBackground = 24,
					bgm = 0,
					bossbgm = 0,
					noEscape = true
				},
				new scenario { // Imperial Air Force
					id = 17,
					characterID = 50,
					startScript = "imperialairforce.json",
					winScript = "Map_30600\\Map_30600\\sc_e_0565_3.json",
					initialPartyID = 6700,
					ordinaryMonsterList = new List<int> { 68, 228 },
					bossList = new List<int> { 276, 361 },
					initialXPLimit = 900,
					initialXPBossLimit = 5000,
					initialDifficulty = 2,
					battleBackground = 38,
					bossBattleBackground = 8,
					bgm = 0,
					bossbgm = 25,
					noEscape = true
				},
				new scenario { // Cultist's Tower
					id = 31,
					characterID = 203,
					startScript = "cultiststower.json",
					winScript = "Map_30750\\Map_30750\\sc_e_0881_1.json",
					initialPartyID = 8100,
					ordinaryMonsterList = new List<int> { 307, 305, 294, 300, 308, 314, 324, 356, 357 },
					bossList = new List<int> { 37, 359 },
					initialXPLimit = 3000,
					initialXPBossLimit = 11000,
					initialDifficulty = 3,
					battleBackground = 46,
					bossBattleBackground = 46,
					bgm = 0,
					bossbgm = 25,
					noEscape = true
				},
				//new scenario { // Solitary Island Monster Rush
				//	id = 47,
				//	characterID = 51,
				//	startScript = "solitaryisland.json",
				//	winScript = "Map_20291\\Map_20291_1\\sc_e_0625.json",
				//	initialPartyID = 9700,
				//	ordinaryMonsterList = new List<int> { 115, 179, 214 },
				//	bossList = new List<int> {  },
				//	initialXPLimit = 600,
				//	initialXPBossLimit = 2500,
				//	initialDifficulty = 1,
				//	battleBackground = 1,
				//	bossBattleBackground = 1,
				//	bgm = 6,
				//	bossbgm = 25,
				//	noEscape = true
				//},
				new scenario { // Falcon Monster Rush
					id = 49,
					characterID = 44,
					startScript = "falcon.json",
					winScript = "Map_Script\\Resident\\sc_secede_gau.json",
					initialPartyID = 9900,
					ordinaryMonsterList = new List<int> { 214, 54, 212, 89, 39, 77, 125, 92, 168, 49, 286, 179, 154, 153, 50, 139, 138, 44, 63, 186, 61, 203, 115, 96, 136, 53, 40, 152, 211, 34, 220, 196, 231, 213, 60, 177 },
					bossList = new List<int> {  },
					initialXPLimit = 500,
					initialXPBossLimit = 2000,
					initialDifficulty = 1,
					battleBackground = 42,
					bossBattleBackground = 6,
					bgm = 6,
					bossbgm = 25,
					noEscape = true
				},
				new scenario { // All scenarios cleared
					id = 50,
					characterID = 51,
					startScript = "",
					winScript = "Map_40012\\Map_40012\\sc_e_1053.json",
					initialPartyID = -1,
					ordinaryMonsterList = new List<int> {  },
					bossList = new List<int> {  },
					initialXPLimit = -1,
					initialXPBossLimit = -1,
					initialDifficulty = -1,
					battleBackground = -1,
					bossBattleBackground = -1,
					bgm = -1,
					bossbgm = -1,
					noEscape = true
				},
			};
		}
	}
}
