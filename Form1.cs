using FF6KefkaRush.Randomize;
using FF6KefkaRush.Inventory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Compression;
using System.Security.Cryptography;

namespace FF6KefkaRush
{
	public partial class FF4FabulGauntlet : Form
	{
		bool loading = true;
		Random r1;
		DateTime lastGameAssets;
		const string defaultFlags = "0440000";

		public FF4FabulGauntlet()
		{
			InitializeComponent();
		}

		public void DetermineFlags(object sender, EventArgs e)
		{
			if (loading) return;

			string flags = "";
			flags += convertIntToChar(checkboxesToNumber(new CheckBox[] { dupCharactersAllowed }));
			//// Combo boxes time...
			flags += convertIntToChar(xpMultiplier.SelectedIndex + (numHeroes.SelectedIndex * 4));
			flags += convertIntToChar(magicPointMulti.SelectedIndex);
			flags += convertIntToChar(checkboxesToNumber(new CheckBox[] { exTerra, exLocke, exCyan, exShadow, exEdgar, exSabin }));
			flags += convertIntToChar(checkboxesToNumber(new CheckBox[] { exCeles, exStrago, exRelm, exSetzer, exMog, exGau }));
			flags += convertIntToChar(checkboxesToNumber(new CheckBox[] { exGogo, exUmaro, exBanon, exLeo, exWedge, exBiggs }));
			flags += convertIntToChar(firstHero.SelectedIndex);
			RandoFlags.Text = flags;

			//flags = "";
			//flags += convertIntToChar(checkboxesToNumber(new CheckBox[] { CuteHats }));
			//VisualFlags.Text = flags;
		}

		private void determineChecks(object sender, EventArgs e)
		{
			if (loading && RandoFlags.Text.Length != defaultFlags.Length)
				RandoFlags.Text = defaultFlags; // Default flags here
			else if (RandoFlags.Text.Length != defaultFlags.Length)
				return;

			loading = true;

			string flags = RandoFlags.Text;
			numberToCheckboxes(convertChartoInt(Convert.ToChar(flags.Substring(0, 1))), new CheckBox[] { dupCharactersAllowed });
			xpMultiplier.SelectedIndex = convertChartoInt(Convert.ToChar(flags.Substring(1, 1))) % 16;
			numHeroes.SelectedIndex = convertChartoInt(Convert.ToChar(flags.Substring(1, 1))) / 16;
			magicPointMulti.SelectedIndex = convertChartoInt(Convert.ToChar(flags.Substring(2, 1)));
			numberToCheckboxes(convertChartoInt(Convert.ToChar(flags.Substring(3, 1))), new CheckBox[] { exTerra, exLocke, exCyan, exShadow, exEdgar, exSabin });
			numberToCheckboxes(convertChartoInt(Convert.ToChar(flags.Substring(4, 1))), new CheckBox[] { exCeles, exStrago, exRelm, exSetzer, exMog, exGau  });
			numberToCheckboxes(convertChartoInt(Convert.ToChar(flags.Substring(5, 1))), new CheckBox[] { exGogo, exUmaro, exBanon, exLeo, exWedge, exBiggs });
			firstHero.SelectedIndex = convertChartoInt(Convert.ToChar(flags.Substring(6, 1))) % 32;

			loading = false;
		}

		private int checkboxesToNumber(CheckBox[] boxes)
		{
			int number = 0;
			for (int lnI = 0; lnI < Math.Min(boxes.Length, 6); lnI++)
				number += boxes[lnI].Checked ? (int)Math.Pow(2, lnI) : 0;

			return number;
		}

		private int numberToCheckboxes(int number, CheckBox[] boxes)
		{
			for (int lnI = 0; lnI < Math.Min(boxes.Length, 6); lnI++)
				boxes[lnI].Checked = number % ((int)Math.Pow(2, lnI + 1)) >= (int)Math.Pow(2, lnI);

			return number;
		}

		private string convertIntToChar(int number)
		{
			if (number >= 0 && number <= 9)
				return number.ToString();
			if (number >= 10 && number <= 35)
				return Convert.ToChar(55 + number).ToString();
			if (number >= 36 && number <= 61)
				return Convert.ToChar(61 + number).ToString();
			if (number == 62) return "!";
			if (number == 63) return "@";
			return "";
		}

		private int convertChartoInt(char character)
		{
			if (character >= Convert.ToChar("0") && character <= Convert.ToChar("9"))
				return character - 48;
			if (character >= Convert.ToChar("A") && character <= Convert.ToChar("Z"))
				return character - 55;
			if (character >= Convert.ToChar("a") && character <= Convert.ToChar("z"))
				return character - 61;
			if (character == Convert.ToChar("!")) return 62;
			if (character == Convert.ToChar("@")) return 63;
			return 0;
		}

		private void FF4FabulGauntlet_Load(object sender, EventArgs e)
		{
			RandoSeed.Text = (DateTime.Now.Ticks % 2147483647).ToString();

			try
			{
				using (TextReader reader = File.OpenText("lastFF4FG.txt"))
				{
					FF6PRFolder.Text = reader.ReadLine();
					RandoSeed.Text = reader.ReadLine();
					RandoFlags.Text = reader.ReadLine();
					lastGameAssets = Convert.ToDateTime(reader.ReadLine());
					//VisualFlags.Text = reader.ReadLine();
					determineChecks(null, null);

					loading = false;
				}
			}
			catch
			{
				// Default flags here
				RandoFlags.Text = defaultFlags;
				//VisualFlags.Text = "0";
				// ignore error
				loading = false;
				determineChecks(null, null);
				lastGameAssets = DateTime.MinValue;
			}
		}

		private void NewSeed_Click(object sender, EventArgs e)
		{
			RandoSeed.Text = (DateTime.Now.Ticks % 2147483647).ToString();
		}

		private void Randomize_Click(object sender, EventArgs e)
		{
			int included = (exTerra.Checked ? 0 : 1) +
				(exLocke.Checked ? 0 : 1) +
				(exCyan.Checked ? 0 : 1) +
				(exShadow.Checked ? 0 : 1) +
				(exEdgar.Checked ? 0 : 1) +
				(exSabin.Checked ? 0 : 1) +
				(exCeles.Checked ? 0 : 1) +
				(exStrago.Checked ? 0 : 1) +
				(exRelm.Checked ? 0 : 1) +
				(exSetzer.Checked ? 0 : 1) +
				(exMog.Checked ? 0 : 1) +
				(exGau.Checked ? 0 : 1) + 
				(exGogo.Checked ? 0 : 1) + 
				(exUmaro.Checked ? 0 : 1) + 
				(exBanon.Checked ? 0 : 1) + 
				(exLeo.Checked ? 0 : 1) + 
				(exWedge.Checked ? 0 : 1) +
				(exBiggs.Checked ? 0 : 1);

			if (included < Convert.ToInt32(numHeroes.SelectedItem) && !dupCharactersAllowed.Checked)
            {
				MessageBox.Show("Included heroes exceed number of heroes and duplicate heroes is not checked.  Please try again.");
				return;
			}

			r1 = new Random(Convert.ToInt32(RandoSeed.Text));
			NewChecksum.Text = "Updating FF6:  Kefka Rush JSON files..."; NewChecksum.Refresh();
			update();
			NewChecksum.Text = "Randomizing party..."; NewChecksum.Refresh();
			List<int> party = randomizeParty();
			Learning.GauStragoLearn(r1, Path.Combine(FF6PRFolder.Text, "FINAL FANTASY VI_Data", "StreamingAssets", "Assets", "GameAssets", "Serial", "Data", "Master"));
			NewChecksum.Text = "Retrieving equipment restrictions..."; NewChecksum.Refresh();
			List<int> equippable = JobGroup.GetEquipJobGroupID(party);
			NewChecksum.Text = "Randomizing rewards..."; NewChecksum.Refresh();
			randomizeTreasures(equippable);
			NewChecksum.Text = "Randomizing monsters..."; NewChecksum.Refresh();
			randomizeMonstersWithBoost(equippable);
			//new Inventory.Map(r1, Path.Combine(FF4PRFolder.Text, "FINAL FANTASY VI_Data", "StreamingAssets", "Assets", "GameAssets", "Serial", "Data", "Master"),
			//		encounterRate.SelectedIndex == 1 || encounterRate.SelectedIndex == 4 ? 2 :
			//		encounterRate.SelectedIndex == 3 || encounterRate.SelectedIndex == 5 ? 4 :
			//		encounterRate.SelectedIndex == 6 ? 8 : 1,
			//		encounterRate.SelectedIndex == 0 ? 2 :
			//		encounterRate.SelectedIndex == 1 || encounterRate.SelectedIndex == 3 ? 3 : 1,
			//	encounterRate.SelectedIndex == 7);

			try
			{
				using (var sha1Crypto = SHA1.Create())
				{
					using (var stream = File.OpenRead(Path.Combine(FF6PRFolder.Text, "FINAL FANTASY VI_Data", "StreamingAssets", "Assets", "GameAssets", "Serial", "Data", "Master", "monster_party.csv")))
					{
						string checkSum = BitConverter.ToString(sha1Crypto.ComputeHash(stream)).ToLower().Replace("-", "").Substring(0, 16);
						Clipboard.SetText(checkSum);
						NewChecksum.Text = "COMPLETE - checksum " + checkSum + " (copied to clipboard)";
					}
				}
			}
			catch // (Exception ex)
			{
				NewChecksum.Text = "COMPLETE - checksum ????????????????";
			}
		}

		private void update()
		{
			new Inventory.Updater(Path.Combine(FF6PRFolder.Text), ref lastGameAssets);  // , "GameAssets", "Serial"
		}

		private List<int> randomizeParty()
		{
			Randomize.Party party = new Randomize.Party(r1, Path.Combine(FF6PRFolder.Text, "FINAL FANTASY VI_Data", "StreamingAssets", "Assets", "GameAssets", "Serial", "Res", "Map"), dupCharactersAllowed.Checked, Convert.ToInt32(numHeroes.SelectedItem),
				new bool[] { exTerra.Checked, exLocke.Checked, exCyan.Checked, exShadow.Checked, exEdgar.Checked, exSabin.Checked, 
					exCeles.Checked, exStrago.Checked, exRelm.Checked, exSetzer.Checked, exMog.Checked, exGau.Checked, 
					exGogo.Checked, exUmaro.Checked, exBanon.Checked, exLeo.Checked, exWedge.Checked, exBiggs.Checked });
			return party.getParty(Convert.ToInt32(numHeroes.SelectedItem)).ToList();
		}

		private void randomizeTreasures(List<int> equippable)
		{
			Treasure.createTreasure(r1, Path.Combine(FF6PRFolder.Text, "FINAL FANTASY VI_Data", "StreamingAssets", "Assets", "GameAssets", "Serial", "Res", "Map"),
				Path.Combine(FF6PRFolder.Text, "FINAL FANTASY VI_Data", "StreamingAssets", "Assets", "GameAssets", "Serial", "Data", "Message"), equippable);
		}

		private void randomizeMonstersWithBoost(List<int> equippable)
		{
			double xpMulti = xpMultiplier.SelectedIndex == 0 ? 1.0 :
				xpMultiplier.SelectedIndex == 1 ? 2.0 :
				xpMultiplier.SelectedIndex == 2 ? 3.0 :
				xpMultiplier.SelectedIndex == 3 ? 5.0 :
				xpMultiplier.SelectedIndex == 4 ? 10.0 :
				xpMultiplier.SelectedIndex == 5 ? 20.0 :
				xpMultiplier.SelectedIndex == 6 ? 50.0 : 100.0;
			double mpMulti = magicPointMulti.SelectedIndex == 0 ? 1.0 :
				magicPointMulti.SelectedIndex == 1 ? 1.5 :
				magicPointMulti.SelectedIndex == 2 ? 2.0 :
				magicPointMulti.SelectedIndex == 3 ? 2.5 :
				magicPointMulti.SelectedIndex == 4 ? 3.0 :
				magicPointMulti.SelectedIndex == 5 ? 4.0 :
				magicPointMulti.SelectedIndex == 6 ? 5.0 : 10.0;
			new Monster(r1, Path.Combine(FF6PRFolder.Text, "FINAL FANTASY VI_Data", "StreamingAssets", "Assets", "GameAssets", "Serial", "Data", "Master"), xpMulti, mpMulti, equippable);
		}

		private void FF4FabulGauntlet_FormClosing(object sender, FormClosingEventArgs e)
		{
			using (StreamWriter writer = File.CreateText("lastFF4FG.txt"))
			{
				writer.WriteLine(FF6PRFolder.Text);
				writer.WriteLine(RandoSeed.Text);
				writer.WriteLine(RandoFlags.Text);
				writer.WriteLine(lastGameAssets.ToString());
				//writer.WriteLine(VisualFlags.Text);
			}
		}

		private void btnBrowse_Click(object sender, EventArgs e)
		{
			using (var fbd = new FolderBrowserDialog())
			{
				DialogResult result = fbd.ShowDialog();

				if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
					FF6PRFolder.Text = fbd.SelectedPath;
			}
		}

		private void revertToDefault_click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Are you sure you want to revert Final Fantasy VI back to vanilla?", "Final Fantasy IV: Fabul Gauntlet", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				try
				{
					NewChecksum.Text = "Reverting...";
					if (File.Exists(Path.Combine(FF6PRFolder.Text, "BepInEx", "plugins", "Memoria.FF4.dll")))
						File.Delete(Path.Combine(FF6PRFolder.Text, "BepInEx", "plugins", "Memoria.FF4.dll"));
					if (File.Exists(Path.Combine(FF6PRFolder.Text, "BepInEx", "plugins", "Memoria.FF4.pdb")))
						File.Delete(Path.Combine(FF6PRFolder.Text, "BepInEx", "plugins", "Memoria.FF4.pdb"));
					if (File.Exists(Path.Combine(FF6PRFolder.Text, "BepInEx", "config", "Memoria.ffpr.cfg")))
						File.Delete(Path.Combine(FF6PRFolder.Text, "BepInEx", "config", "Memoria.ffpr.cfg"));
					if (Directory.Exists(Path.Combine(FF6PRFolder.Text, "BepInEx")))
						Directory.Delete(Path.Combine(FF6PRFolder.Text, "BepInEx"), true);
					if (Directory.Exists(Path.Combine(FF6PRFolder.Text, "FINAL FANTASY VI_Data", "StreamingAssets", "Assets")))
						Directory.Delete(Path.Combine(FF6PRFolder.Text, "FINAL FANTASY VI_Data", "StreamingAssets", "Assets"), true);
					NewChecksum.Text = "Revert complete!";
				}
				catch (Exception ex)
				{
					MessageBox.Show("Unable to revert - " + ex.Message);
					NewChecksum.Text = "Revert failed...";
				}
			}
		}
    }
}
