namespace State
{
	public class Man
	{
		public IState State { get; private set; }

		public Man(IState state)
		{
			State = state;
		}

		public void Upgrade()
		{
			State = State.Upgrade(State);
		}

		public void Downgrade()
		{
			State = State.Downgrade(State);
		}
	}
}