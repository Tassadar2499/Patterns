using System;

namespace Interpreter
{
	public class SubtractExpression : NonTerminalExpression
	{
		private SubtractExpression(IExpression left, IExpression right, Func<int, int, int> function) : base(left, right, function)
		{
		}

		public SubtractExpression(IExpression left, IExpression right) : this(left, right, (int a, int b) => a - b)
		{
		}
	}
}