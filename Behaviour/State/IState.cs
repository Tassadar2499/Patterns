namespace State
{
	public interface IState
	{
		public IState Upgrade(IState oldState);

		public IState Downgrade(IState downGrade);
	}
}