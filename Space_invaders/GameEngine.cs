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

		private SceneRender _sceneRender;

		private Scene _scene;

		public GameEngine()
		{

		}

		public static GameEngine GetGameEngine(GameSettings gameSettings)
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
			_sceneRender = new SceneRender(gameSettings);
		}

		public void Run()
		{
			do
			{
				_sceneRender.Render(_scene);
			}
			while (_isNotOwer);
		}
	}
}
