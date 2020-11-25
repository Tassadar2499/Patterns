namespace Flyweight
{
	public interface IStarShip
	{
		public string Engine { get; }
		public string Weapon { get; }

		public void Initiate(string name, int number);
	}
}