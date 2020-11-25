using System;

namespace State
{
	public class Soldier : IState
	{
		public Soldier()
		{
			Console.WriteLine("Now you soldat");
		}

		public IState Downgrade(IState downGrade)
		{
			Console.WriteLine("Dembelnulsya i na zavod");
			return new Worker();
		}

		public IState Upgrade(IState oldState)
		{
			Console.WriteLine("Zackonchil i vosstanovilsya v vuzik");
			return new Student();
		}
	}
}