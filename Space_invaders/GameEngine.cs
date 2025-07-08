using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_invaders
{
	class GameEngine
	{
		private bool _isNotOwer;

		private static GameEngine _gameEngine;

		private Scene _scene;

		public GameEngine()
		{
			
		}

		public static GameEngine GetGameEngine()
		{
			if (_gameEngine == null)
			{
				_gameEngine = new GameEngine(gameSettings);
			}
			return _gameEngine;	
		}

		private GameEngine(GameSettings gameSettings)
		{
			_isNotOwer = true;
			_scene = Scene.GetScene(gameSettings);
		}

		public void Run()
		{
			do
			{

			}
			while (_isNotOwer);
		}
	}
}
