using System;

namespace Interpreter
{
	public class AddExpression : NonTerminalExpression
	{
		public AddExpression(IExpression left, IExpression right, Func<int, int, int> function) : base(left, right, function)
		{
		}

		public AddExpression(IExpression left, IExpression right) : this(left, right, (int a, int b) => a + b)
		{
		}
	}
}