﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_invaders
{
	abstract class GameObject
	{
		public GameObjectPlace GameObjectPlace {  get; set; }
		public char Figure { get; set; }
		public GameObjectType GameObjectType { get; set; }
	}
}
