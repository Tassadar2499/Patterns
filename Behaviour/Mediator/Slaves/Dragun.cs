using System;

namespace Mediator.Slaves
{
	public class Dragun : Protoss
	{
		private readonly string _name;

		private Dragun(IGlobalNet globalNet) : base(globalNet)
		{
		}

		public Dragun(IGlobalNet globalNet, string name) : this(globalNet)
			=> _name = name;

		public override void Notify(string message)
		{
			Console.WriteLine($"Dragoon {_name} notified");
		}
	}
}