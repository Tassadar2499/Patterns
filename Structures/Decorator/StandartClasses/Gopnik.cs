using System;

namespace Decorator.StandartClasses
{
	public class Gopnik : IBydlo
	{
		public int SemkasCount { get; set; }

		public void DropBottle()
			=> Console.WriteLine("Кинуть бутылку");

		public void Shout()
			=> Console.WriteLine("Э СТОПЭ");

		public void GriztSemkas()
			=> SemkasCount--;
	}
}