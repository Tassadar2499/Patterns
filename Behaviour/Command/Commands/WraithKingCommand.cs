namespace Command.Commands
{
	public class WraithKingCommand : ICommand
	{
		private readonly WraithKing _wraithKing;

		public WraithKingCommand(WraithKing wraithKing)
		{
			_wraithKing = wraithKing;
		}

		public void Tashit()
		{
			_wraithKing.Tashit();
			_wraithKing.Unizhat();
			_wraithKing.WinGame();
		}

		public void TightGame()
		{
			_wraithKing.Slitsya();
		}
	}
}