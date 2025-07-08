using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_invaders            //www.youtube.com/watch?v=Zw8DVvmutGc
{
	internal class Program
	{
		static GameEngine gameEngine;

		static GameSettings gameSettings;

		static void Main(string[] args)
		{
			Initialize();
			gameEngine.Run();
		}

		public static void Initialize()
		{
			gameSettings = new GameSettings();
			gameEngine = GameEngine.GetGameEngine(gameSettings);

		}
	}
}
