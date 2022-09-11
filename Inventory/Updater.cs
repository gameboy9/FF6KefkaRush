using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF6KefkaRush.Inventory
{
	public class Updater
	{
		public Updater(string directory, ref DateTime lastGameAssets)
		{
			DateTime currentGameAssets = File.GetLastWriteTime("GameAssets.zip");
			if (currentGameAssets > lastGameAssets)
			{
				ZipFile.ExtractToDirectory("GameAssets.zip", directory);
				lastGameAssets = currentGameAssets;
			}
		}
	}
}
