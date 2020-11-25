using Facade.Components.Interfaces;
using System;

namespace Facade.Components
{
	public class PlazmaShield : IShield
	{
		public void TurnShieldOn()
			=> Console.WriteLine("Плазменный щит включен");

		public void TurnShieldOff()
			=> Console.WriteLine("Плазменный щит выключен");
	}
}