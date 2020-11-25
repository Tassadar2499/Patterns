using Mediator.Slaves;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mediator.Gestalts
{
	public class Khala : IGlobalNet
	{
		public HighTemplar HighTemplar { get; set; }
		public List<Zealot> Zealots { get; set; }
		public List<Dragun> Dragunes { get; set; }

		public void Send(string order, Protoss warrior)
		{
			if (warrior == HighTemplar)
			{
				var actions = new Action[]
				{
					() => Parallel.ForEach(Zealots, (Zealot h) => h.Notify(order)),
					() => Parallel.ForEach(Dragunes, (Dragun d) => d.Notify(order))
				};
				Parallel.Invoke(actions);
			}
			else if (Zealots.Contains(warrior) || Dragunes.Contains(warrior))
				HighTemplar.Notify(order);
		}
	}
}