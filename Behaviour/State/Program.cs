namespace State
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			var man = new Man(new Student());
			man.Upgrade();
			man.Upgrade();
			man.Upgrade();
			man.Downgrade();
			man.Downgrade();
			man.Downgrade();
		}
	}
}