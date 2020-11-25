using System;

namespace FluentBuilder
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			var rodnulkin1 = Rodnulkin.CreateBuilder().SetName("Ricardo").SetIsEatSalo(true).SetFactory("Автоваз").SetMoneysCount(10).Build();
			var rodnulkin2 = Rodnulkin.CreateBuilder().SetName("Billy").SetIsEatSalo(false).SetFactory("Белаз").SetMoneysCount(15).Build();

			Console.WriteLine(rodnulkin1.Name);
			Console.WriteLine(rodnulkin2.Name);

			Console.ReadKey();
		}
	}
}