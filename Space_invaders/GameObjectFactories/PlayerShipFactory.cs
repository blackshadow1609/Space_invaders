using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_invaders
{
	class PlayerShipFactory : GameObjectFactory
	{
		public PlayerShipFactory(GameSettings gameSettings)
			: base(gameSettings)
		{

		}

		public override GameObject GetGameObject(GameObjectPlace objectPlace)
		{

			GameObject gameObject = new PlayerShip()
			{
				Figure = GameSettings.PlayerShip,
				GameObjectPlace = objectPlace,
				GameObjectType = GameObjectType.PlayerShip
			};

			return gameObject;
		}

		public GameObject GetGameObject()
		{
			GameObjectPlace place = new GameObjectPlace()
			{
				Xcoordinate = GameSettings.PlayerShipStartXCoordinate,
				Ycoordinate = GameSettings.GroundStartYCoordinate
			};

			GameObject gameObject = GetGameObject(place);

			return gameObject;
		}
	}
}
