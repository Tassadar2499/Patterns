using System.Threading.Tasks;

namespace Command
{
	public class Invoker
	{
		private readonly ICommand[] _commands;

		public Invoker(ICommand[] commands)
		{
			_commands = commands;
		}

		public void OrderTashitGame()
			=> Parallel.ForEach(_commands, (ICommand c) => c.Tashit());

		public void OrderTightGame()
			=> Parallel.ForEach(_commands, (ICommand c) => c.TightGame());
	}
}