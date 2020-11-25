namespace Builder
{
	public class CorvetBuilder : StarShipBuilder
	{
		protected override void SetArmor()
		{
			_starShip.Armor = "Биоброня";
		}

		protected override void SetEngine()
		{
			_starShip.Engine = "Варп";
		}

		protected override void SetWeapon()
		{
			_starShip.Weapon = "Лазер";
		}
	}
}