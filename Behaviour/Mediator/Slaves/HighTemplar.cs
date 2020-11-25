using System;

namespace Mediator.Slaves
{
	public class HighTemplar : Protoss
	{
		public HighTemplar(IGlobalNet globalNet) : base(globalNet)
		{
		}

		public override void Notify(string message)
		{
			Console.WriteLine("High templar notified");
		}
	}
}