namespace Builder
{
	public abstract class StarShipBuilder
	{
		protected readonly StarShip _starShip = new StarShip();

		public StarShip CreateStarShip()
		{
			SetArmor();
			SetWeapon();
			SetEngine();

			return _starShip;
		}

		protected abstract void SetWeapon();

		protected abstract void SetArmor();

		protected abstract void SetEngine();
	}
}