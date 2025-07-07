using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Space_invaders
{
	class GroundFactory : GameObjectFactory
	{
		public GroundFactory(GameSettings gameSettings)
			: base(gameSettings)
		{

		}

		public override GameObject GetGameObject(GameObjectPlace objectPlace)
		{
			GameObject groundObject = new GroundObject() { Figure = GameSettings.Ground, GameObjectPlace = objectPlace, GameObjectType = GameObjectType.GroundObject };

			return groundObject;
		}
		public List<GameObject> GetGround()
		{
			List<GameObject> ground = new List<GameObject>();

			int startX = GameSettings.GroundStartXCoordinate;
			int startY = GameSettings.GroundStartYCoordinate;

			for (int y = 0; y < GameSettings.NumberOfGroundRows; y++)
			{
				for (int x = 0; x < GameSettings.NumberOfGroundColls; x++)
				{
					GameObjectPlace objectPlace = new GameObjectPlace() { Xcoordinate = startX + x, Ycoordinate = startY + y };

					GameObject groundObject = GetGameObject(objectPlace);
					ground.Add(groundObject);
				}
			}

			return ground;
		}
	}
}

