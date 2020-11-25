namespace Command.Commands
{
	public class PudgeCommand : ICommand
	{
		private readonly Pudge _pudge;

		public PudgeCommand(Pudge pudge)
		{
			_pudge = pudge;
		}

		public void Tashit()
		{
			_pudge.Hukat();
			_pudge.Orkat();
		}

		public void TightGame()
		{
			_pudge.FarmitLes();
			_pudge.MidDerzat();
		}
	}
}