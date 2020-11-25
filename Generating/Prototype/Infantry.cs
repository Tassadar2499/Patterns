using System;

namespace Prototype
{
	[Serializable]
	public class Infantry : Warrior
	{
		public Infantry(string name) : base(name)
		{
		}

		public override void ShowInfo()
			=> Console.WriteLine("Пехотинец");
	}
}