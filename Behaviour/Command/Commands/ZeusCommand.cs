namespace Command.Commands
{
	public class ZeusCommand : ICommand
	{
		private readonly Zeus _zeus;

		public ZeusCommand(Zeus zeus)
		{
			_zeus = zeus;
		}

		public void Tashit()
		{
			_zeus.ToRoshan();
			_zeus.Ultanut();
		}

		public void TightGame()
		{
			_zeus.FindKura();
			_zeus.DerzatHard();
		}
	}
}