using Facade.Components.Interfaces;
using System;

namespace Facade.Components
{
	public class YamatoGun : IGun
	{
		public void WarmingUp()
			=> Console.WriteLine("Разогрев пушки Ямато");

		public void Shoot()
			=> Console.WriteLine("Выстрел из Ямато пушки");
	}
}