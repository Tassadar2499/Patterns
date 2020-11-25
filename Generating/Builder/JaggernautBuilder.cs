namespace Builder
{
	public class JaggernautBuilder : StarShipBuilder
	{
		protected override void SetArmor()
		{
			_starShip.Armor = "Плазменные щиты";
		}

		protected override void SetEngine()
		{
			_starShip.Engine = "Червоточины";
		}

		protected override void SetWeapon()
		{
			_starShip.Weapon = "Ракеты";
		}
	}
}