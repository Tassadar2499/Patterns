namespace Memento
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			var game = new GameEnvironment() { CowsCount = 10, MoneysCount = 100 };
			var gameHistory = new GameHistory();

			game.WriteToConsole();

			gameHistory.Push(game.SaveState());

			game.BuyCow();
			game.WriteToConsole();

			game.RestoreState(gameHistory.Pop());
			game.WriteToConsole();
		}
	}
}