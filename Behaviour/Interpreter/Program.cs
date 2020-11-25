using System;

namespace Interpreter
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			var text = "x + y - z";
			var calcInterpreter = new CalcInterpreter(text);
			var result = calcInterpreter.Interpret(5, 6, 7);

			Console.WriteLine(result);
			Console.ReadKey();
		}
	}
}