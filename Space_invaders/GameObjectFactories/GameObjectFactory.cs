﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_invaders                //.GameObjectFactories				//Не забыть убрать если вдруг
{
	abstract class GameObjectFactory
	{
		public GameSettings GameSettings { get; set; }
		public abstract GameObject GetGameObject(GameObjectPlace objectPlace);
		public GameObjectFactory(GameSettings gameSettings)
		{
			GameSettings = gameSettings;
		}
	}
}
