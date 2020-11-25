namespace GeneratingPatterns
{
	public class ArcheryFactory : WarriorFactory
	{
		public override Warrior Create()
			=> new Archery(10);
	}
}