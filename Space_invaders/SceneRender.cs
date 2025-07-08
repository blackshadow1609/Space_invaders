﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_invaders
{
	class SceneRender
	{
		int _screenWidth;
		int _screenHeight;

		char[,] _screenMatrix;

		public SceneRender(GameSettings gameSettings)
		{
			_screenWidth = gameSettings.ConsoleWidth + 1;
			_screenHeight = gameSettings.ConsoleHeight + 1;
			_screenMatrix = new char[gameSettings.ConsoleHeight, gameSettings.ConsoleWidth];

			Console.WindowHeight = gameSettings.ConsoleHeight;
			Console.BufferWidth = gameSettings.ConsoleWidth;

			Console.CursorVisible = false;
			Console.SetCursorPosition(0, 0);
		}

		public void Render(Scene scene)
		{
			Console.SetCursorPosition(0, 0);

			AddListForRendering(scene.swarm);
			AddListForRendering(scene.ground);
			AddListForRendering(scene.playerShipMissile);

			AddGameObjectForRendering(scene.playerShip);

			StringBuilder stringBuilder = new StringBuilder();

			for (int y = 0; y < _screenHeight; y++)
			{ 
				for (int x =  0; x < _screenWidth; x++)
				{
					stringBuilder.Append(_screenMatrix[y, x]);
				}
				stringBuilder.Append(Environment.NewLine);
			}
			Console.WriteLine(stringBuilder.ToString());
			Console.SetCursorPosition(0, 0);
		}
		public void AddGameObjectForRendering (GameObject gameObject)
		{
			if(gameObject.GameObjectPlace.Ycoordinate < _screenMatrix.GetLength(0) && 
				gameObject.GameObjectPlace.Xcoordinate < _screenMatrix.GetLength(1))
			{
				_screenMatrix[gameObject.GameObjectPlace.Ycoordinate, 
					gameObject.GameObjectPlace.Xcoordinate] = gameObject.Figure;
			}
			else
			{
				_screenMatrix[gameObject.GameObjectPlace.Ycoordinate,
					gameObject.GameObjectPlace.Xcoordinate] = ' ';
			}

		}

		public void AddListForRendering(List<GameObject> gameObjects)
		{
			foreach (GameObject gameObject in gameObjects)
			{
				AddListForRendering(gameObjects);
			}
		}
	}
}
