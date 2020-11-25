using System;
using System.Collections.Generic;

namespace Composite
{
	public class Location : Component
	{
		private readonly LinkedList<Component> _components;

		public Location(string name) : base(name)
			=> _components = new LinkedList<Component>();

		public override void Add(Component component)
			=> _components.AddLast(component);

		public override void Remove(Component component)
			=> _components.Remove(component);

		public override void Display()
		{
			Console.WriteLine($"Узел: {Name}");
			Console.WriteLine("Подузлы:");
			foreach (var component in _components)
				component.Display();
		}
	}
}