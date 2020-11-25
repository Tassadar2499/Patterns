namespace Builder
{
	public class BattleCruiserBuilder : StarShipBuilder
	{
		protected override void SetArmor()
		{
			_starShip.Armor = "Дефлекторы";
		}

		protected override void SetEngine()
		{
			_starShip.Engine = "Гипер";
		}

		protected override void SetWeapon()
		{
			_starShip.Weapon = "Кинетическое";
		}
	}
}