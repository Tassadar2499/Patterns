namespace AbstractFactory.Entities
{
	public abstract class Tank
	{
		public abstract int Damage { get; set; }
		public abstract int Armor { get; set; }

		public abstract void Shoot();

		protected Tank(int damage, int armor)
		{
			Damage = damage;
			Armor = armor;
		}
	}
}