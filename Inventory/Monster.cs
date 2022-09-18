using CsvHelper;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF6KefkaRush.Inventory
{
	public class Monster
	{
		public class singleMonster
		{
			public int id { get; set; }
			public string mes_id_name { get; set; }
			public int cursor_x_position { get; set; }
			public int cursor_y_position { get; set; }
			public int in_type_id { get; set; }
			public int disappear_type_id { get; set; }
			public int species { get; set; }
			public int resistance_attribute { get; set; }
			public int resistance_condition { get; set; }
			public int initial_condition { get; set; }
			public int lv { get; set; }
			public int hp { get; set; }
			public int mp { get; set; }
			public int exp { get; set; }
			public int gill { get; set; }
			public int attack_count { get; set; }
			public int attack_plus { get; set; }
			public int attack_plus_grop { get; set; }
			public int attack_attribute { get; set; }
			public int strength { get; set; }
			public int vitality { get; set; }
			public int agility { get; set; }
			public int intelligence { get; set; }
			public int spirit { get; set; }
			public int magic { get; set; }
			public int attack { get; set; }
			public int ability_attack { get; set; }
			public int defense { get; set; }
			public int ability_defense { get; set; }
			public int ability_defense_rate { get; set; }
			public int accuracy_rate { get; set; }
			public int dodge_times { get; set; }
			public int evasion_rate { get; set; }
			public int magic_evasion_rate { get; set; }
			public int ability_disturbed_rate { get; set; }
			public int critical_rate { get; set; }
			public int luck { get; set; }
			public int weight { get; set; }
			public int boss { get; set; }
			public int monster_flag_group_id { get; set; }
			public int drop_rate { get; set; }
			public int drop_content_id1 { get; set; }
			public int drop_content_id1_value { get; set; }
			public int drop_content_id2 { get; set; }
			public int drop_content_id2_value { get; set; }
			public int drop_content_id3 { get; set; }
			public int drop_content_id3_value { get; set; }
			public int drop_content_id4 { get; set; }
			public int drop_content_id4_value { get; set; }
			public int drop_content_id5 { get; set; }
			public int drop_content_id5_value { get; set; }
			public int drop_content_id6 { get; set; }
			public int drop_content_id6_value { get; set; }
			public int drop_content_id7 { get; set; }
			public int drop_content_id7_value { get; set; }
			public int drop_content_id8 { get; set; }
			public int drop_content_id8_value { get; set; }
			public int steal_content_id1 { get; set; }
			public int steal_content_id2 { get; set; }
			public int steal_content_id3 { get; set; }
			public int steal_content_id4 { get; set; }
			public int script_id { get; set; }
			public int monster_asset_id { get; set; }
			public int battle_effect_asset_id { get; set; }
			public int p_use_ability_random_group_id { get; set; }
			public int command_group_type { get; set; }
			public int release_ability_random_group_id { get; set; }
			public int rage_ability_random_group_id { get; set; }
		}

		public class singleGroup
		{
			public int id { get; set; }
			public int battle_background_asset_id { get; set; }
			public int battle_bgm_asset_id { get; set; }
			public int appearance_production { get; set; }
			public int script_name { get; set; }
			public int battle_pattern1 { get; set; }
			public int battle_pattern2 { get; set; }
			public int battle_pattern3 { get; set; }
			public int battle_pattern4 { get; set; }
			public int battle_pattern5 { get; set; }
			public int battle_pattern6 { get; set; }
			public int not_escape { get; set; }
			public int battle_flag_group_id { get; set; }
			public int get_value { get; set; }
			public int get_ap { get; set; }
			public int monster1 { get; set; }
			public int monster1_x_position { get; set; }
			public int monster1_y_position { get; set; }
			public int monster1_group { get; set; }
			public int monster2 { get; set; }
			public int monster2_x_position { get; set; }
			public int monster2_y_position { get; set; }
			public int monster2_group { get; set; }
			public int monster3 { get; set; }
			public int monster3_x_position { get; set; }
			public int monster3_y_position { get; set; }
			public int monster3_group { get; set; }
			public int monster4 { get; set; }
			public int monster4_x_position { get; set; }
			public int monster4_y_position { get; set; }
			public int monster4_group { get; set; }
			public int monster5 { get; set; }
			public int monster5_x_position { get; set; }
			public int monster5_y_position { get; set; }
			public int monster5_group { get; set; }
			public int monster6 { get; set; }
			public int monster6_x_position { get; set; }
			public int monster6_y_position { get; set; }
			public int monster6_group { get; set; }
			public int monster7 { get; set; }
			public int monster7_x_position { get; set; }
			public int monster7_y_position { get; set; }
			public int monster7_group { get; set; }
			public int monster8 { get; set; }
			public int monster8_x_position { get; set; }
			public int monster8_y_position { get; set; }
			public int monster8_group { get; set; }
			public int monster9 { get; set; }
			public int monster9_x_position { get; set; }
			public int monster9_y_position { get; set; }
			public int monster9_group { get; set; }
		}

		public readonly List<List<int>> relatedMonsters = new()
		{
			new List<int> { 1, 101, 187 }, // Guard, Guard Leader (boss), Living Dead
			new List<int> { 4, 104, 190 }, // Ninja, Covert, Outsider
			new List<int> { 5, 8, 293  }, // Samurai, Yojimbo, Samurai Soul
			new List<int> { 6, 105, 194 }, // Borghese, Kamui, Demon Knight
			new List<int> { 7, 176, 232, 244 }, // Magna Roaders (four)
			new List<int> { 9, 197, 305, 106 }, // Cloud, Wizard, Level 20 Magic, Warlock
			new List<int> { 10, 191, 356, 107 }, // Misty, Coco, Level 80 Magic, Cherry
			new List<int> { 12, 109, 198 }, // Zaghrem, Iron Fist, Devil Fist
			new List<int> { 13, 110 }, // Apocrypha, Devil
			new List<int> { 15, 97, 193, 111, 343 }, // Angel Whisper, Darkside, Nightwalker, Provoker, Aparition
			new List<int> { 16, 112, 308 }, // Oversoul, Cloudwraith, Level 50 Magic
			new List<int> { 17, 113, 188 }, // Skeletal Horror, Mahadeva, Death Warden
			new List<int> { 20, 245, 116, 210 }, // Wererat, Wild Rat, Stunner, Goetia
			new List<int> { 22, 118, 199 }, // Belmodar, Destroyer, Illuyankas
			new List<int> { 23, 366 }, // Muud Suud, Humbaba (boss)
			new List<int> { 25, 120, 177 }, // Stray Cat, Coeurl Cat, Lycaon
			new List<int> { 26, 121, 203, 249 }, // Silver Lobo, Bloodfang, Luna Wolf, Garm
			new List<int> { 28, 123, 207 }, // Megalodoth, Gorgias, Lukhavi
			new List<int> { 29, 124, 212 }, // Fidor, Don, Bogy
			new List<int> { 30, 125, 215 }, // Briareus, Murussu, Adamankary
			new List<int> { 31, 126 }, // Suriander, Wartpuck
			new List<int> { 32, 229, 127 }, // Chimera, Vector Chimera, Gorgimera 
			new List<int> { 33, 164, 225, 128, 282 }, // Behemoth, Intangir, Great Behemoth, Behemoth King (boss) x2 (reg/undead)
			new List<int> { 34, 129, 330, 415 }, // Fafnir, Vector Lythos, Ice Dragon (boss) x2
			new List<int> { 35, 130, 217, 332 }, // Lesser Lopros, Wyvern, Platinum Dragon, Storm Dragon (boss)
			new List<int> { 36, 214, 131, 338, 411 }, // Fossil Dragon, Black Dragon, Zombie Dragon, Skull Dragon (boss) x2
			new List<int> { 132, 37, 414, 340, 408 }, // Dragon, Holy Dragon (boss) x2, Red Dragon (boss) x2
			new List<int> { 38, 339, 409 }, // Fiend Dragon, Blue Dragon (boss) x2
			new List<int> { 133, 39, 337, 410 }, // Primeval Dragon, Brachiosaur, Gold Dragon (boss) x2
			new List<int> { 134, 227, 40, 333, 413 }, // Weredragon, Chaos Dragon, Tyrannosaur, Earth Dragon (boss) x2
			new List<int> { 41, 135, 205 }, // Darkwind, Cirpius, Caladrius
			new List<int> { 42, 236, 206, 136 }, // Aepyornis, Venobennu, Tzakmaqiel, Sprinter
			new List<int> { 43, 231, 137 }, // Vulture, Rukh, Lenergia
			new List<int> { 138, 44, 237 }, // Marchosias, Vasegiatta, Galypdes
			new List<int> { 45, 139 }, // Zokka, Gloomwind
			new List<int> { 46, 140, 238 }, // Trapper, Dropper, Junk
			new List<int> { 47, 141, 233 }, // Hornet, Rock Wasp, Bug
			new List<int> { 48, 142, 209 }, // Nettlehopper, Grasswyrm, Land Grillon
			new List<int> { 49, 143 }, // Delta Beetle
			new List<int> { 50, 144, 211 }, // Killer Mantis, Twinscythe, Greater Mantis
			new List<int> { 51, 145, 239 }, // Trillium, Paraladia, Mandrake
			new List<int> { 146, 52 }, // Exoray, Rafflesia
			new List<int> { 147, 53 }, // Crusher, Tumbleweed
			new List<int> { 54, 148 }, // Vampire Thorn, Ouroboros
			new List<int> { 56 }, // Siegfried
			new List<int> { 57, 151 }, // Nautiloid, Devourer
			new List<int> { 58, 149, 152 }, // Exocite, Acrophies, Cancer
			new List<int> { 59, 186 }, // Anguiform, Oceanus
			new List<int> { 153, 60 }, // Gigantoad, Leap Frog
			new List<int> { 61, 154 }, // Lizard, Basilisk
			new List<int> { 62, 155 }, // Litwor Chicken, Medusa Chicken
			new List<int> { 63, 156 }, // Slagworm, Landworm
			new List<int> { 64, 216, 157 }, // Hell's Rider, Dante, Test Rider
			new List<int> { 66, 159, 254 }, // Onion Knight, Onion Dasher, Metal Hitman
			new List<int> { 67, 160, 259, 158, 218 }, // Magitek Armor (boss), Heavy Armor, Mega Armor, Pluto Armor, Duel Armor
			new List<int> { 68, 228, 150, 253 }, // Sky Armor, Spitfire, Schmidt, Death Machine
			new List<int> { 69, 161, 247 }, // Satellite, Chaser, InnoSent
			new List<int> { 70, 255, 162 }, // Armored Weapon, Io, Gamma
			new List<int> { 71, 163, 219, 208 }, // Spritzer, Poplium, Psychos, Eukaryote
			new List<int> { 220, 72 }, // Mousse, Flan
			new List<int> { 73, 165, 221 }, // Outcast, Misfit, Shambling Corpse
			new List<int> { 74, 166 }, // Humpty, Creature 
			new List<int> { 75, 189 }, // Brainpan, Face 
			new List<int> { 76, 167 }, // Cruller, Enuo 
			new List<int> { 77 }, // Cactuar
			new List<int> { 78, 169, 240, 224 }, // Bandit (25), Unseelie (53), Valeor (117), Gobbledygook (104)
			new List<int> { 79, 170, 222 }, // Harvester, Neck Hunter, Punisher
			new List<int> { 80, 171, 223 }, // Bomb, Grenade, Balloon
			new List<int> { 81 }, // Still Life
			new List<int> { 82, 173 }, // Lunatys, Pandora 
			new List<int> { 83, 294, 174, 241 }, // Veil Dancer, Level 30 Magic, Blade Dancer, Amduscias
			new List<int> { 84, 243, 175 }, // Hill Gigas, Glasya Labolas, Gigantos
			new List<int> { 85, 256, 313 }, // Tonberry, Tonberries, Master Tonberry
			new List<int> { 87 }, // Mover
			new List<int> { 88, 92 }, // Figaro Lizard, Crawler
			new List<int> { 89, 201 }, // Devoahan, Aspidochelon
			new List<int> { 90, 178 }, // Aspiran, Parasite 
			new List<int> { 91, 183, 230, 307, 242 }, // Ghost, Specter, Lich, Level 10 Magic, Necromancer
			new List<int> { 94, 180, 226 }, // Alacran, Antares, Scorpion
			new List<int> { 95, 181, 234 }, // Actinian, Anemone, Seaflower
			new List<int> { 96, 182 }, // Sandhorse, Moonform
			new List<int> { 98, 184 }, // Malboro, Great Malboro
			new List<int> { 99, 185 }, // Urok, Bonnacon
			new List<int> { 100, 168 }, // Foper, Deepeye
			new List<int> { 108, 11, 300, 192 }, // Al Jabr, Joker, Zeveak, Level 40 Magic
			new List<int> { 114, 122, 204, 27 }, // Vector Hound, Hunting Hound, Belzecue, Doberman
			new List<int> { 115, 19, 202 }, // Peeper, Mu, Knotty
			new List<int> { 119, 24, 196 }, // Leaf Bunny, Chippirabiit, Desert Hare
			new List<int> { 172 }, // Alluring Rider
			new List<int> { 179, 93, 55 }, // Land Ray, Sand Ray, Cartagra
			new List<int> { 358, 235 }, // Proto Armor, Fortis
			new List<int> { 246, 21, 117, 213 }, // Gold Bear, Mugbear, Sorath, Purusa (Ipooh, 334, excluded)
			new List<int> { 250, 285 }, // Daedalus, Dullahan (boss)
			new List<int> { 281, 314, 251 }, // Level 60 Magic, Nelapa, Baalzephon
			new List<int> { 252 }, // Ahriman
			new List<int> { 257, 258 }, // Ymir (boss), Angler Whelk (boss)
			new List<int> { 261, 262 }, // Tunnel Armor (boss), Prometheus
			new List<int> { 284, 317, 318, 319 }, // Tentacles
			new List<int> { 362, 248, 357 }, // Naude, Clymenus, Level 90 Magic
			new List<int> { 301, 302, 303, 361 }, // Four Ultroses
			new List<int> { 324, 14, 291 }, // Level 70 Magic, Dark Force, Wrexsoul (boss)
			new List<int> { 341, 342 }, // Opinicus, Rhizopas (boss)
			new List<int> { 374, 18, 336, 2, 102, 200 }, // Cadet, Commander, Soldier, Imperial Soldier, Corporal, Sergeant
			new List<int> { 375, 3, 335, 103, 195 } // Officer, Templar, Captain, General, Imperial Elite
		};

		readonly List<MonsterTiers> allMonsterTiers = new()
		{
			new MonsterTiers(4900, new List<int> { 1, 26, 20, 71, 78, 41, 24 }, new List<int> {  }, 60, 275, 1, 1, 6, true, 6), // Opening fights
			new MonsterTiers(5000, new List<int> { 1, 28, 26, 20, 71, 78 }, new List<int> { 101 }, 90, 275, 1, 11, 0, true, 25), // Narshe dungeon maze
			new MonsterTiers(5300, new List<int> { 102, 29, 160, 122, 64 }, new List<int> { 331 }, 250, 1500, 1, 19, 0, true, 25), // Kefka @ Narshe
			new MonsterTiers(5500, new List<int> { 35, 57, 58 }, new List<int> { 301 }, 400, 1000, 1, 14, 6, true, 25), // Lethe River
			new MonsterTiers(5700, new List<int> { 80, 9, 15, 91, 163, 187, 16 }, new List<int> { 263 }, 80, 800, 1, 16, 6, false, 25), // Phantom Train
			new MonsterTiers(5800, new List<int> { 42, 119, 48, 25, 341 }, new List<int> { 342 }, 80, 500, 1, 32, 6, true, 6), // Baren Falls
			new MonsterTiers(5900, new List<int> { 35, 57, 58 }, new List<int> { }, 400, 2400, 1, 36, 0, true, 0), // Serpent Trench
			new MonsterTiers(6100, new List<int> { 116, 210 }, new List<int> { 302 }, 350, 1000, 1, 25, 0, true, 0), // Opera House
			new MonsterTiers(6700, new List<int> { 68, 228 }, new List<int> { 276, 361 }, 900, 5000, 2, 38, 0, true, 25), // Approach to Floating Continent
			new MonsterTiers(8100, new List<int> { 307, 305, 294, 300, 308, 314, 324, 356, 357 }, new List<int> { 37, 359 }, 3000, 11000, 3, 46, 6, false, 25), // Cultist's Tower
			new MonsterTiers(9700, new List<int> { 115, 179, 214 }, new List<int> {  }, 600, 2500, 1), // Solitary Island Monster Rush
			new MonsterTiers(9900, new List<int> { 214, 54, 212, 89, 39, 77, 125, 92, 168, 49, 286, 179, 154, 153, 50, 139, 138, 44, 63, 186, 61, 203, 115, 96, 136, 53, 40, 152, 211, 34, 220, 196, 231, 213, 60, 177 }, new List<int> { }, 500, 2000, 1, 42, 6, true, 25) // Falcon Monster Rush
		};

		List<limitedMonsters> restrictedMonsters = new();
		List<singleMonster> allMonsters;

		public class MonsterTiers
		{
			public int initialPartyID;
			List<int> ordinaryList;
			List<int> bossList;
			int initialXPLimit;
			int initialXPBossLimit;
			public int initialDifficulty;
			public List<singleGroup> monsterParties;
			int battleBackground;
			int bgm;
			int bossbgm;
			bool noEscape;

			public MonsterTiers(int id, List<int> list1, List<int> list2, int initXP, int initBossXP, int initDiff, int bg = 1, int music = 6, bool noRun = false, int bossMusic = 25)
			{
				initialPartyID = id;
				ordinaryList = list1;
				bossList = list2;
				initialXPLimit = initXP;
				initialXPBossLimit = initBossXP;
				initialDifficulty = initDiff;
				battleBackground = bg;
				bgm = music;
				bossbgm = bossMusic;
				noEscape = noRun;
				monsterParties = new();

				double temp = initialXPLimit / (initialDifficulty == 1 ? 1 : initialDifficulty == 2 ? 1.75 : initialDifficulty == 3 ? 3 : initialDifficulty == 4 ? 6 : 12);
				initialXPLimit = (int)temp;
				temp = initialXPBossLimit / (initialDifficulty == 1 ? 1 : initialDifficulty == 2 ? 1.75 : initialDifficulty == 3 ? 3 : initialDifficulty == 4 ? 6 : 12);
				initialXPBossLimit = (int)temp;
			}

			// XP Multipliers:
			// -01, +10%
			// -02, +20%
			// -03, +30%
			// -04, +40%
			// -05, +50%
			// -06, +60%
			// -07, +70%
			// -08, +80%
			// -09, +90%
			// -10, +100%
			// -11, +120%
			// -12, +140%
			// -13, +160%
			// -14, +180%
			// -15, +200%
			// -16, +220%
			// -17, +240%
			// -18, +500%
			// -19, Boss
			// Bronze - x1 XP, 4 monster limit
			// Silver - x2 XP, 5 monster limit
			// Gold - x5 XP, 7 monster limit
			// Diamond - x10 XP, 9 monster limit
			// Adamant - x25 XP, 9 monster limit
			// Must meet 1/2 XP limit to qualify as a valid group.  Attempt 20 corrections, removing the lowest XP monster before giving up.
			
			public void createParties(List<singleMonster> allMonsters, List<int> badMonsters, List<limitedMonsters> restrictedMonsters, List<int> allBosses, List<List<int>> relatedMonsters, Random r1, double magicPointBoost)
			{
				int difficulty = 0;
				for (int i = 0; i < 100; i++)
				{
					int minMonsterXP = 0;
					difficulty = (i / 20) + 1;

					singleGroup sg = new singleGroup();
					sg.id = initialPartyID + i;

					sg.battle_background_asset_id = i % 20 == 19 && battleBackground == 16 ? 34 : battleBackground;
					sg.battle_bgm_asset_id = i % 20 == 19 ? bossbgm : bgm;
					sg.appearance_production = 1;
					sg.script_name = initialPartyID == 8100 ? 9024 : 0; // Cultist's Tower - mandatory magic
					sg.battle_pattern1 = 1;
					sg.battle_pattern2 = i % 20 == 19 ? 0 : 1;
					sg.battle_pattern3 = i % 20 == 19 ? 0 : 1;
					sg.battle_pattern4 = i % 20 == 19 ? 0 : 1;
					sg.battle_pattern5 = i % 20 == 19 ? 0 : 1;
					sg.battle_pattern6 = 0;
					sg.not_escape = i % 20 == 19 || noEscape ? 1 : 0;
					sg.battle_flag_group_id = sg.battle_bgm_asset_id == 0 ? 17 : 0; // 11?  Need to watch the deaths!
					sg.get_ap = 0;

					sg.monster1_group = sg.monster2_group = sg.monster3_group = sg.monster4_group = sg.monster5_group = 2;
					sg.monster6_group = sg.monster7_group = sg.monster8_group = sg.monster9_group = 1;
					sg.monster1_x_position = 60;
					sg.monster2_x_position = 55;
					sg.monster3_x_position = 50;
					sg.monster4_x_position = 35;
					sg.monster5_x_position = 30;
					sg.monster6_x_position = 25;
					sg.monster7_x_position = 10;
					sg.monster8_x_position = 5;
					sg.monster9_x_position = 0;
					sg.monster1_y_position = sg.monster2_y_position = sg.monster3_y_position = sg.monster4_y_position = sg.monster5_y_position =
						sg.monster6_y_position = sg.monster7_y_position = sg.monster8_y_position = sg.monster9_y_position = 0;

					// Now we can establish monsters and AP.
					long xpLimit = i % 20 == 19 ? initialXPBossLimit : initialXPLimit;
					double xpTemp = i < 20 ? 1 : i < 40 ? 1.75 : i < 60 ? 3 : i < 80 ? 6 : 12;
					double xpTemp2 = i % 20 <= 17 ? 1 + ((double)i % 20 / 10) : i % 20 == 19 ? 1 : 3; // i % 20 == 18 -> 3x XP limits
					xpLimit = (long)(xpLimit * xpTemp * xpTemp2);
					// Since the maximum XP a monster can give is 16,000, we need to max out the XP limit to 100,000 (the absolute maximum is 144,000, 16,000*9)
					xpLimit = Math.Min(100000, xpLimit);
					int monsterLimit = i < 20 ? 4 : i < 40 ? 5 : i < 60 ? 7 : 9;

					double magicPoints;
					if (i % 20 == 19)
					{
						magicPoints = xpLimit < 5000 ? 3 : xpLimit < 10000 ? 4 : xpLimit < 20000 ? 5 : xpLimit < 30000 ? 6 : xpLimit < 50000 ? 7 : 8;
						double temp = r1.Next() % 50;
						magicPoints += temp / 10;
					}
					else
					{
						magicPoints = xpLimit < 5000 ? 0 : xpLimit < 10000 ? 1 : xpLimit < 20000 ? 2 : xpLimit < 30000 ? 3 : xpLimit < 50000 ? 4 : 5;
						double temp = r1.Next() % 25;
						magicPoints += temp / 10;
					}
					magicPoints = Math.Max(1, magicPoints);
					sg.get_value = (int)(magicPoints * magicPointBoost);

					int origXpLimit = (int)xpLimit;
					int minXPLimit = origXpLimit * 3 / 4;
					int maxPercentHP = 0;
					bool valid = true;
					int lastMonster = -1;
					// Repeat this check 100 times before moving onto the next monster group.
					int loops = 1000;
					int useAllMonsters = 0;
					int monsterLevel = 0;

					// Test code
					//if (initialPartyID == 6700 && i == 19)
					//	monsterLevel = monsterLevel;

					List<int> monster = new List<int>();
					while (valid && monster.Count < monsterLimit && loops > 0)
					{
						loops--;
						if (lastMonster == -1 || r1.Next() % 2 == 0)
						{
							List<singleMonster> iMonsterList;
							//if (true) //  && areaAppropriate
							//{
							List<singleMonster> iMonsterList2;

							if (useAllMonsters <= 20)
							{
								// Combine bosses and monsters if we're in the last battle of a segment.
								if (i % 20 == 19)
									iMonsterList2 = allMonsters.Where(c => ordinaryList.Contains(c.id) || bossList.Contains(c.id)).ToList();
								else
									iMonsterList2 = allMonsters.Where(c => ordinaryList.Contains(c.id)).ToList();

								// Must have a boss to start if a boss exists in that zone
								if (i % 20 == 19 && monster.Count == 0 && bossList.Count > 0)
									iMonsterList = iMonsterList2.Where(c => bossList.Contains(c.id)).ToList();
								else
									iMonsterList = iMonsterList2.Where(c => c.exp <= xpLimit && c.exp >= minMonsterXP).ToList();

								if (difficulty != initialDifficulty || useAllMonsters >= 10)
								{
									// To prevent lazy loading / coupling
									List<singleMonster> iteratedList = iMonsterList.ToList();
									foreach(singleMonster monster1 in iteratedList)
									{
										List<int> related = relatedMonsters.Where(c => c.Contains(monster1.id)).FirstOrDefault();
										if (related != null)
											iMonsterList.AddRange(allMonsters.Where(d => related.Contains(d.id)));
									}

									if (i % 20 != 19 || monster.Count > 0)
										iMonsterList = iMonsterList.Where(c => c.exp <= xpLimit && c.exp >= minMonsterXP).ToList();
								}
							}
							else
							{
								int lowLimit = (int)Math.Pow(origXpLimit, .75);
								lowLimit = Math.Max(lowLimit, minMonsterXP);
								lowLimit = Math.Min(lowLimit, 8000);
								lowLimit = lowLimit < 1 ? 1 : lowLimit;
								if (i % 20 == 19 && monster.Count == 0 && allBosses.Count > 0)
									iMonsterList = allMonsters.Where(c => c.exp <= xpLimit && c.exp >= lowLimit && allBosses.Contains(c.id)).ToList();
								else
									iMonsterList = allMonsters.Where(c => c.exp <= xpLimit && c.exp >= lowLimit).ToList();
							}

							iMonsterList = iMonsterList.Where(c => !badMonsters.Contains(c.id)).ToList();
							iMonsterList = iMonsterList.Distinct().ToList();

							if (iMonsterList.Count >= 1)
							{
								singleMonster chosenMonster;
								chosenMonster = iMonsterList[r1.Next() % iMonsterList.Count];

								// See above comment regarding monsters we don't want chosen for various reasons.
								if (badMonsters.Contains(chosenMonster.id))
								{
									lastMonster = -1;
									continue;
								}

								limitedMonsters limitMonster = restrictedMonsters.Where(c => c.id == chosenMonster.id).FirstOrDefault();
								if (limitMonster != null)
								{
									if (limitMonster.monsterLimit >= 1 && monster.Where(c => c == chosenMonster.id).Count() >= limitMonster.monsterLimit)
									{
										// If there is "no follow-up", just redraw.
										if (limitMonster.followUp == -1)
										{
											lastMonster = -1;
											continue;
										}
										chosenMonster = allMonsters.Where(c => c.id == limitMonster.followUp).Single();
									}

									if (maxPercentHP + limitMonster.hpPercentage > (difficulty <= 2 ? 50 : difficulty == 3 ? 60 : 75))
									{
										lastMonster = -1;
										continue;
									}
									maxPercentHP += limitMonster.hpPercentage;
								}

								lastMonster = chosenMonster.id;
								int lastXP = chosenMonster.exp;
								monster.Add(chosenMonster.id);
								xpLimit = origXpLimit - allMonsters.Where(c => monster.Contains(c.id)).Sum(c => c.exp);

								if (chosenMonster.id == 257 && monster.Count < 9) // If we see a Ymir...
								{
									monster.Add(309); // Add the shell
									lastMonster = -1;
								} 
								else if (chosenMonster.id == 257) // If we see a Ymir and there's no space, remove it.
								{
									lastMonster = -1;
									continue;
								}

								if (chosenMonster.id == 270 && monster.Count < 9) // If we see a Crane...
								{
									monster.Add(271); // Add the other one
									lastMonster = -1;
								} 
								else if (chosenMonster.id == 271 && monster.Count < 9) // And vice versa
								{
									monster.Add(270); // Add the other one
									lastMonster = -1;
								}

								// Curlax, Laragorn, Moebius
								if ((chosenMonster.id == 288 || chosenMonster.id == 289 || chosenMonster.id == 290) && monster.Count < 8)
								{
									if (!monster.Contains(288))
									{
										monster.Add(288);
									}
									if (!monster.Contains(289))
									{
										monster.Add(289);
									}
									if (!monster.Contains(290))
									{
										monster.Add(290);
									}
								}
								else // We want to not allow this unless all three can join.
								{
									lastMonster = -1;
								}

								if (chosenMonster.id == 291 && monster.Count < 9)
								{
									monster.Add(360);
									lastMonster = 360;
								}
								else if (chosenMonster.id == 291)
								{
									lastMonster = -1;
								}

								// Do not add 50/50 chance of duplicating a boss unless addressed above.  This will avoid something like 7 Odins or 7 Evil Walls.
								// ... unless you're in very hard difficulty... in which case you're on your own.  :P
								if (allBosses.Contains(chosenMonster.id) && difficulty < 4)
								{
									lastMonster = -1;
								}

								xpLimit = origXpLimit - allMonsters.Where(c => monster.Contains(c.id)).Sum(c => c.exp);
							}
							else
							{
								// No monsters left... usually because the xpLimit has gone below 0.  Invalidate the loop and move onto the next group.
								valid = false;
							}
						}
						else
						{
							bool normalDup = false;
							// Do not further duplicate monsters in bronze or silver difficulties.
							if (xpLimit < 0 && difficulty < 3)
							{
								valid = false;
								continue;
							}
							// Allow one duplication of a monster in gold difficulty.
							if (xpLimit < 0 && difficulty == 3)
								normalDup = true;

							bool veryHard = true;
							while (veryHard)
							{
								limitedMonsters limitMonster = restrictedMonsters.Where(c => c.id == lastMonster).FirstOrDefault();
								if (limitMonster != null)
								{
									if (limitMonster.monsterLimit == 1)
										lastMonster = limitMonster.followUp;
									if (lastMonster == -1)
										break;

									if (maxPercentHP + limitMonster.hpPercentage > (difficulty <= 2 ? 50 : difficulty == 3 ? 60 : 75))
									{
										lastMonster = -1;
										break;
									}
									maxPercentHP += limitMonster.hpPercentage;
								}

								monster.Add(lastMonster);
								xpLimit -= allMonsters.Where(c => c.id == lastMonster).First().exp;

								// If the XP remaining goes under zero, but you're in very hard difficulty,
								// keep repeating the monster until you reach 9 monsters,
								// unless we had to terminate via HP percentage monsters or had to follow up with a "-1" monster.
								if (xpLimit > 0 || difficulty < 5 || monster.Count >= 9 || lastMonster == -1)
									veryHard = false;
							}

							// In gold difficulty, now complete the group after the single duplication.
							if (normalDup)
								valid = false;
						}

						// Wrexsoul > Number 128
						if (monster.Contains(291) && monster.Contains(268)) { monster.Remove(268); monster.Remove(320); monster.Remove(321); xpLimit += allMonsters.Where(c => c.id == 268).First().exp; }
						// Inferno > Curlax > Cranes
						if (monster.Contains(269) && monster.Contains(270)) { monster.Remove(270); xpLimit += allMonsters.Where(c => c.id == 270).First().exp; }
						if (monster.Contains(269) && monster.Contains(271)) { monster.Remove(271); xpLimit += allMonsters.Where(c => c.id == 271).First().exp; }
						if (monster.Contains(290) && monster.Contains(270)) { monster.Remove(270); xpLimit += allMonsters.Where(c => c.id == 270).First().exp; }
						if (monster.Contains(290) && monster.Contains(271)) { monster.Remove(271); xpLimit += allMonsters.Where(c => c.id == 271).First().exp; }
						if (monster.Contains(269) && monster.Contains(290)) { monster.Remove(290); xpLimit += allMonsters.Where(c => c.id == 290).First().exp; }
						if (monster.Contains(269) && monster.Contains(288)) { monster.Remove(288); xpLimit += allMonsters.Where(c => c.id == 288).First().exp; }
						if (monster.Contains(269) && monster.Contains(289)) { monster.Remove(289); xpLimit += allMonsters.Where(c => c.id == 289).First().exp; }
						// Angler Whelk > Ymir
						if (monster.Contains(258) && monster.Contains(257)) { monster.Remove(257); monster.Remove(309); xpLimit += allMonsters.Where(c => c.id == 257).First().exp; }

						// Remove the lowest XP monster if the XP of the battle is less than half of the maximum XP limit and redraw.
						// Remove the highest XP monster if the XP of the battle is more than twice the maximum XP limit and redraw.
						// Also unlock all monsters.
						if ((!valid || monster.Count >= monsterLimit) && (xpLimit > origXpLimit - minXPLimit || xpLimit < 0 - origXpLimit))
						{
							valid = true;
							useAllMonsters++;
							if (monster.Count > 0)
							{
								singleMonster lowestMonster;
								if (xpLimit > origXpLimit - minXPLimit)
								{
									lowestMonster = allMonsters.Where(c => monster.Contains(c.id)).OrderBy(c => c.exp).First();
									minMonsterXP = Math.Max(minMonsterXP, lowestMonster.exp);
								}
								else
									lowestMonster = allMonsters.Where(c => monster.Contains(c.id)).OrderByDescending(c => c.exp).First();

								monster.Remove(lowestMonster.id);
								xpLimit = origXpLimit - allMonsters.Where(c => monster.Contains(c.id)).Sum(c => c.exp);
							}
							// Revert the minimum monster XP to 0 on loop 10.
							if (useAllMonsters == 10)
								minMonsterXP = 0;
						}
					}

					if (monster.Count == 1) sg.monster5 = monster[0];
					else if (monster.Count == 4)
					{
						if (i % 10 == 0)
							sg.monster5 = monster[0];
						else
							sg.monster1 = monster[0];
						sg.monster9 = monster[1];
						sg.monster7 = monster[2];
						sg.monster3 = monster[3];
					}
					else
					{
						if (i % 10 == 0)
							sg.monster5 = monster[0];
						else
							sg.monster1 = monster[0];
						sg.monster9 = monster.Count >= 2 ? monster[1] : 0;
						if (i % 10 == 0)
							sg.monster1 = monster.Count >= 3 ? monster[2] : 0;
						else
							sg.monster5 = monster.Count >= 3 ? monster[2] : 0;
						sg.monster3 = monster.Count >= 4 ? monster[3] : 0;
						sg.monster7 = monster.Count >= 5 ? monster[4] : 0;
						sg.monster2 = monster.Count >= 6 ? monster[5] : 0;
						sg.monster4 = monster.Count >= 7 ? monster[6] : 0;
						sg.monster6 = monster.Count >= 8 ? monster[7] : 0;
						sg.monster8 = monster.Count >= 9 ? monster[8] : 0;
					}

					// If Ymir/Whelk is in this group, we'll want to swap them into monster 5/2.
					sg = monsterSwap(sg, 257, 5);
					sg = monsterSwap(sg, 309, 2);

					// If Angler Whelk/Presenter is in this group, we'll want to swap them into monster 5/2.
					sg = monsterSwap(sg, 258, 5);
					sg = monsterSwap(sg, 310, 2);

					// If Cranes need to be in monster 9/3.
					sg = monsterSwap(sg, 271, 3);
					sg = monsterSwap(sg, 270, 9);
					
					// Curlax, Laragorn, MoebiusIf need to be in monster 3/4/9.
					sg = monsterSwap(sg, 290, 3);
					sg = monsterSwap(sg, 288, 4);
					sg = monsterSwap(sg, 289, 9);

					// Wrexsoul need to be in monster 8.
					sg = monsterSwap(sg, 291, 8);

					// Number 128, Left Blade, Right Blade
					sg = monsterSwap(sg, 268, 8);
					sg = monsterSwap(sg, 321, 2);
					sg = monsterSwap(sg, 320, 3);

					// Inferno, Other Left Blade, Other Right Blade
					sg = monsterSwap(sg, 269, 9);
					sg = monsterSwap(sg, 323, 2);
					sg = monsterSwap(sg, 322, 5);

					// Ultros IV cannot be in position 5.  His friend (Typhon) appears there.
					if (sg.monster5 == 361)
					{
						sg.monster5 = sg.monster1;
						sg.monster1 = 361;
					}

					// TODO:  May need to worry about Cadets later...

					monsterParties.Add(sg);
				}
			}

			private singleGroup monsterSwap(singleGroup newGroup, int monsterID, int newPosition)
			{
				int temp = 0;
				int oldPosition = 0;

				if (newGroup.monster1 == monsterID) oldPosition = 1;
				else if (newGroup.monster2 == monsterID) oldPosition = 2;
				else if (newGroup.monster3 == monsterID) oldPosition = 3;
				else if (newGroup.monster4 == monsterID) oldPosition = 4;
				else if (newGroup.monster5 == monsterID) oldPosition = 5;
				else if (newGroup.monster6 == monsterID) oldPosition = 6;
				else if (newGroup.monster7 == monsterID) oldPosition = 7;
				else if (newGroup.monster8 == monsterID) oldPosition = 8;
				else if (newGroup.monster9 == monsterID) oldPosition = 9;

				if (oldPosition != 0)
				{
					switch (newPosition)
					{
						case 1: temp = newGroup.monster1; newGroup.monster1 = monsterID; break;
						case 2: temp = newGroup.monster2; newGroup.monster2 = monsterID; break;
						case 3: temp = newGroup.monster3; newGroup.monster3 = monsterID; break;
						case 4: temp = newGroup.monster4; newGroup.monster4 = monsterID; break;
						case 5: temp = newGroup.monster5; newGroup.monster5 = monsterID; break;
						case 6: temp = newGroup.monster6; newGroup.monster6 = monsterID; break;
						case 7: temp = newGroup.monster7; newGroup.monster7 = monsterID; break;
						case 8: temp = newGroup.monster8; newGroup.monster8 = monsterID; break;
						case 9: temp = newGroup.monster9; newGroup.monster9 = monsterID; break;
					}

					switch (oldPosition)
					{
						case 1: newGroup.monster1 = temp; break;
						case 2: newGroup.monster2 = temp; break;
						case 3: newGroup.monster3 = temp; break;
						case 4: newGroup.monster4 = temp; break;
						case 5: newGroup.monster5 = temp; break;
						case 6: newGroup.monster6 = temp; break;
						case 7: newGroup.monster7 = temp; break;
						case 8: newGroup.monster8 = temp; break;
						case 9: newGroup.monster9 = temp; break;
					}
				}

				return newGroup;
			}
		}

        readonly List<int> allBosses = new()
        {
			37, 67, 69, 101, 128, 188, 256, 257, 258, 260, 261, 263, 264, 265, 266, 267, 268, 269, 270, 271, 272, 273, 275, 276, 279, 280, 281, 282, 284, 285, 286, 287, 
			288, 289, 290, 291, 292, 293, 296, 297, 298, 300, 301, 302, 303, 304, 306, 309, 310, 313, 317, 318, 319, 325, 329, 330, 332, 333, 335, 337, 338, 339, 340,
			342, 359, 361, 366, 408, 409, 410, 411, 412, 413, 414, 415
		};

		public class limitedMonsters
		{
			public int id;
			public int hpPercentage = 0;
			public int monsterLimit = 9;
			public int followUp = 0;
		}

		public Monster(Random r1, string directory, double xpMultiplier, double magicPointBoost, List<int> equippable)
		{
			using (StreamReader reader = new(Path.Combine("csv", "monster.csv")))
			using (CsvReader csv = new(reader, System.Globalization.CultureInfo.InvariantCulture))
				allMonsters = csv.GetRecords<singleMonster>().ToList();

			List<singleGroup> groups;
			using (StreamReader reader = new(Path.Combine("csv", "monster_party.csv")))
			using (CsvReader csv = new(reader, System.Globalization.CultureInfo.InvariantCulture))
				groups = csv.GetRecords<singleGroup>().ToList();

			// Zone Eater's no good to us.  (370)
			List<int> badMonsters = new() { 370 };

			MonsterSet ms = new MonsterSet();

			foreach (MonsterTiers mt in allMonsterTiers)
			{
				mt.createParties(allMonsters, badMonsters, restrictedMonsters, allBosses, relatedMonsters, r1, magicPointBoost);
				groups.AddRange(mt.monsterParties);
				ms.setUpMonsterSets(r1, mt.initialPartyID / 10, mt.initialPartyID, mt.initialDifficulty);
			}

			ms.saveMonsterSets(directory);

			restrictedMonsters.Add(new limitedMonsters { id = 257, monsterLimit = 1, followUp = -1 }); // Whelk
			restrictedMonsters.Add(new limitedMonsters { id = 270, monsterLimit = 1, followUp = -1 }); // Crane 1
			restrictedMonsters.Add(new limitedMonsters { id = 271, monsterLimit = 1, followUp = -1 }); // Crane 2

			int lastMonster;
			int maxPercentHP;
			int lastBackgroundID = -1;
			bool valid;

			//if (newGroup.monster5 == 202)
			//            {
			//	newGroup.monster5_x_position = 0;
			//	newGroup.monster5_y_position = -10;
			//            }
			//groups.Add(newGroup);

			using (StreamWriter writer = new(Path.Combine(directory, "monster_party.csv")))
			using (CsvWriter csv = new(writer, System.Globalization.CultureInfo.InvariantCulture))
			{
				csv.WriteRecords(groups);
			}

			foreach (singleMonster iMonster in allMonsters)
			{
				// Award random items based on XP gained and tier.
				iMonster.drop_rate = 100;
				int minTier = iMonster.exp < 100 ? 1 : iMonster.exp < 250 ? 1 : iMonster.exp < 500 ? 2 : iMonster.exp < 1000 ? 3 : iMonster.exp < 2000 ? 4 : 5;
				int maxTier = iMonster.exp < 100 ? 1 : iMonster.exp < 250 ? 2 : iMonster.exp < 500 ? 3 : iMonster.exp < 1000 ? 4 : iMonster.exp < 2000 ? 5 : iMonster.exp < 5000 ? 6 : 7;
				List<int> itemsAvailable = new List<int>();

				// New rules for basic monsters:
				// 45% chance of getting restorative item
				// 15% chance of getting revival item (phoenix down, holy water, gold needle)
				// 10% chance of getting status corrective or other item
				// 5% chance of getting attack item
				// 15% chance of getting weapon or armor
				// 10% chance of getting accessory

				if (allBosses.Contains(iMonster.id))
				{
					minTier += 1;
					maxTier += 2;
					maxTier = maxTier > 9 ? 9 : maxTier;

					itemsAvailable.AddRange(new Weapons().getList(minTier, maxTier, true, equippable));
					itemsAvailable.AddRange(new Armor().getList(minTier, maxTier, true, equippable));
					itemsAvailable.AddRange(new Accessories().getList(minTier, maxTier, true, equippable));
					if (itemsAvailable.Count > 0)
					{
						iMonster.drop_content_id1 = itemsAvailable[r1.Next() % itemsAvailable.Count];
						iMonster.steal_content_id1 = itemsAvailable[r1.Next() % itemsAvailable.Count];
						iMonster.drop_content_id2 = itemsAvailable[r1.Next() % itemsAvailable.Count];
						iMonster.steal_content_id2 = itemsAvailable[r1.Next() % itemsAvailable.Count];
						iMonster.drop_content_id3 = itemsAvailable[r1.Next() % itemsAvailable.Count];
						iMonster.steal_content_id3 = itemsAvailable[r1.Next() % itemsAvailable.Count];
						iMonster.drop_content_id4 = itemsAvailable[r1.Next() % itemsAvailable.Count];
						iMonster.steal_content_id4 = itemsAvailable[r1.Next() % itemsAvailable.Count];
						iMonster.drop_content_id5 = itemsAvailable[r1.Next() % itemsAvailable.Count];
						iMonster.drop_content_id6 = itemsAvailable[r1.Next() % itemsAvailable.Count];
					} 
					else
					{ // Bosses dropping potions... maybe an Ether... AKA a big whammy!
						iMonster.drop_content_id1 = 2;
						iMonster.steal_content_id1 = 2;
						iMonster.drop_content_id2 = 24;
						iMonster.steal_content_id2 = 24;
						iMonster.drop_content_id3 = 3;
						iMonster.steal_content_id3 = 3;
						iMonster.drop_content_id4 = 5;
						iMonster.steal_content_id4 = 5;
						iMonster.drop_content_id5 = 24;
						iMonster.drop_content_id6 = 3;
					}
				}
				else
				{
					iMonster.drop_content_id1 = new Items().getItem(r1, 1, minTier, maxTier);
					iMonster.steal_content_id1 = new Items().getItem(r1, 1, minTier, maxTier);
					iMonster.drop_content_id2 = new Items().getItem(r1, 2, minTier, maxTier);
					iMonster.steal_content_id2 = new Items().getItem(r1, 2, minTier, maxTier);
					iMonster.drop_content_id3 = new Items().getItem(r1, 3, minTier, maxTier);
					iMonster.steal_content_id3 = new Items().getItem(r1, 3, minTier, maxTier);
					iMonster.drop_content_id4 = new Items().getItem(r1, 4, minTier, maxTier);
					iMonster.steal_content_id4 = new Items().getItem(r1, 4, minTier, maxTier);

					itemsAvailable.AddRange(new Weapons().getList(minTier, maxTier, true, equippable));
					itemsAvailable.AddRange(new Armor().getList(minTier, maxTier, true, equippable));
					if (itemsAvailable.Count() > 0)
						iMonster.drop_content_id5 = itemsAvailable[r1.Next() % itemsAvailable.Count];
					else
						iMonster.drop_content_id5 = 2; // Potion... AKA a whammy

					itemsAvailable = new Accessories().getList(minTier, maxTier, true, equippable);
					if (itemsAvailable.Count() > 0)
						iMonster.drop_content_id6 = itemsAvailable[r1.Next() % itemsAvailable.Count];
					else
						iMonster.drop_content_id6 = 2; // Potion... AKA a whammy
				}

				iMonster.drop_content_id1_value = 1;
				iMonster.drop_content_id2_value = 1;
				iMonster.drop_content_id3_value = 1;
				iMonster.drop_content_id4_value = 1;
				iMonster.drop_content_id5_value = 1;
				iMonster.drop_content_id6_value = 1;

				iMonster.exp = (int)(iMonster.exp * xpMultiplier);
			}

			using (StreamWriter writer = new(Path.Combine(directory, "monster.csv")))
			using (CsvWriter csv = new(writer, System.Globalization.CultureInfo.InvariantCulture))
			{
				csv.WriteRecords(allMonsters);
			}
		}
	}
}
