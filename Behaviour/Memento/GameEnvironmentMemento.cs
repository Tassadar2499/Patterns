namespace Memento
{
	public class GameEnvironmentMemento
	{
		public readonly int CowsCount;
		public readonly int MoneysCount;

		public GameEnvironmentMemento(int cowsCount, int moneys)
		{
			CowsCount = cowsCount;
			MoneysCount = moneys;
		}
	}

	//public record EnvironmentMemento
	//{
	//	public int CountOfCows { get; init; }
	//	public int Moneys { get; init; }
	//}
}