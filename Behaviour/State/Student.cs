using System;

namespace State
{
	public class Student : IState
	{
		public Student()
		{
			Console.WriteLine("Stal studentom");
		}

		public IState Downgrade(IState downGrade)
		{
			Console.WriteLine("Dropnul paru");
			return new Soldier();
		}

		public IState Upgrade(IState oldState)
		{
			Console.WriteLine("Zakconchil vuzik");
			return new Worker();
		}
	}
}