namespace GeneratingPatterns
{
	public class HorseManFactory : WarriorFactory
	{
		public override Warrior Create()
			=> new HorseMan();
	}
}