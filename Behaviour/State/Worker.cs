using System;

namespace State
{
	public class Worker : IState
	{
		public Worker()
		{
			Console.WriteLine("Teper ti rabotyaga");
		}

		public IState Downgrade(IState downGrade)
		{
			Console.WriteLine("Stal umnij poshel v sharagu");
			return new Student();
		}

		public IState Upgrade(IState oldState)
		{
			Console.WriteLine("Dropnul zavod i poehal v ormeu");
			return new Soldier();
		}
	}
}