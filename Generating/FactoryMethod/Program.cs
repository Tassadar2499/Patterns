namespace GeneratingPatterns
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			string typeName = "Archery";

			WarriorFactory factory = null;
			switch (typeName)
			{
				case "Archery":
					factory = new ArcheryFactory();
					break;

				case "Infantry":
					factory = new InfantryFactory();
					break;

				case "HorseMan":
					factory = new HorseManFactory();
					break;
			}

			Warrior warrior = factory?.Create();
			warrior?.ShowInfo();
		}
	}
}