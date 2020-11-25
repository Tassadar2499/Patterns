namespace Prototype
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			var archery = new Archery("Лучник1", 10);
			var archery2 = archery.Clone() as Archery;
			archery2.Name = "Лучник2";
			archery2.ArrowsCount = 15;

			var archery3 = archery2.DeepCopy() as Archery;
			archery3.Name = "Лучник3";
			archery3.ArrowsCount = 20;
		}
	}
}