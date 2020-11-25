using Command.Commands;
using System;

namespace Command
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			var pudge = new Pudge();
			var papich = new WraithKing();
			var zeus = new Zeus();

			var commands = new ICommand[]
			{
				new PudgeCommand(pudge),
				new WraithKingCommand(papich),
				new ZeusCommand(zeus)
			};

			var invoker = new Invoker(commands);
			invoker.OrderTightGame();
			invoker.OrderTashitGame();

			Console.ReadKey();
		}
	}
}