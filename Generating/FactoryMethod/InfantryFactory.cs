namespace GeneratingPatterns
{
	public class InfantryFactory : WarriorFactory
	{
		public override Warrior Create()
			=> new Infantry();
	}
}