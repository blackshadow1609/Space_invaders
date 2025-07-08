using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_invaders 
{
	class GameSettings
	{
		public int ConsoleWidth { get; set; } = 80;                 //Размер окна консоли
		public int ConsoleHeight { get; set; } = 30;

		//------------------------------------------------------------------------------------------------------------------
		public int NumberOfSwarmRows { get; set; } = 2;             //Количество рядов кораблей
		public int NumberOfSwarmColls { get; set; } = 60;           //Количество кораблей в 1 ряду

		public int SwarmStartXCoordinate { get; set; } = 10;        //Координаты первоначального положения по ширине
		public int SwarmStartYCoordinate { get; set; } = 2;         //Координаты первоначального положения по высоте

		public char AlienShip { get; set; } = 'O';                  //Символ кораблей пришельцев
		public int SwarmSpeed { get; set; } = 20;                   //Скорость перемещения кораблей пришельцев

		//------------------------------------------------------------------------------------------------------------------
		public int PlayerShipStartXCoordinate { get; set; } = 40;   //Координаты первоначального положения по ширине
		public int PlayerShipStartYCoordinate { get; set; } = 19;   //Координаты первоначального положения по высоте

		public char PlayerShip { get; set; } = '^';                 //Символ корабля игрока

		//------------------------------------------------------------------------------------------------------------------
		public int GroundStartXCoordinate { get; set; } = 1;        //Координаты первоначального положения по ширине
		public int GroundStartYCoordinate { get; set; } = 20;       //Координаты первоначального положения по высоте

		public char Ground { get; set; } = 'П';                     //Символ поверхности земли
		public int NumberOfGroundRows { get; set; } = 1;            //Количество рядов поверхности
		public int NumberOfGroundColls { get; set; } = 80;          //Количество символов в ширину поверхности

		//------------------------------------------------------------------------------------------------------------------
		public char PlayerMissile { get; set; } = '|';              //Символ стрелялки
		public int PlayerMissileSpeed { get; set; } = 5;            //Скорость стрелялки

		//------------------------------------------------------------------------------------------------------------------
		public int GameSpeed { get; set; } = 100;                   //Скорость кадров (задержка)

	}
}
