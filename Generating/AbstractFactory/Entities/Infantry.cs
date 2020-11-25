namespace AbstractFactory.Entities
{
	public abstract class Infantry
	{
		public abstract int Damage { get; set; }

		public abstract void Shoot();

		protected Infantry(int damage)
		{
			Damage = damage;
		}
	}
}