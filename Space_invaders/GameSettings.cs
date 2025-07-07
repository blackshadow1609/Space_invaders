using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_invaders
{
	class GameSettings
	{
		public int ConsoleWidth { get; set; } = 80;
		public int ConsoleHight { get; set; } = 30;

		//-------------------------------------------
		public int NumberOfSwarmRows { get; set; } = 2;
		public int NumberOfSwarmColls { get; set; } = 60;

		public int SwarmStartXCoordinate { get; set; } = 10;
		public int SwarmStartYCoordinate { get; set; } = 2;

		//public int[] SwarmStartMoving { get; set; } = { 1, 1 };
		public char AlienShip { get; set; } = '0';
		public int Swarm { get; set; } = 20;

		//-------------------------------------------
	}
}
