using Decorator.DecoratorClasses;
using Decorator.StandartClasses;
using System;

namespace Decorator
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			var gopnikStandart1 = new Gopnik
			{
				SemkasCount = 4
			};

			var sportsmen = new SportsmenGopnik(gopnikStandart1);

			var gopnikStandart2 = new Gopnik
			{
				SemkasCount = 4
			};
			var pizhonGopnik = new PizhonGopnik(gopnikStandart2);

			sportsmen.SemkasCount = 5;
			pizhonGopnik.GriztSemkas();
			Console.WriteLine($"Количество семок спортсмена - {sportsmen.SemkasCount}");
			Console.WriteLine($"Количество семок пижона - {pizhonGopnik.SemkasCount}");

			sportsmen.DropBottle();
			pizhonGopnik.Shout();

			sportsmen.PropisatDvoechku();
			pizhonGopnik.Naehat();
		}
	}
}