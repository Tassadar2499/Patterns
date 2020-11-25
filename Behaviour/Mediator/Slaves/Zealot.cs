using System;

namespace Mediator.Slaves
{
	public class Zealot : Protoss
	{
		private readonly string _name;

		private Zealot(IGlobalNet globalNet) : base(globalNet)
		{
		}

		public Zealot(IGlobalNet globalNet, string name) : this(globalNet)
			=> _name = name;

		public override void Notify(string message)
		{
			Console.WriteLine($"Zealot {_name} notified");
		}
	}
}