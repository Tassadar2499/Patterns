using System;

namespace Interpreter
{
	public abstract class NonTerminalExpression : IExpression
	{
		private readonly IExpression _leftExpression;
		private readonly IExpression _rightExpression;
		private readonly Func<int, int, int> _function;

		protected NonTerminalExpression(IExpression left, IExpression right, Func<int, int, int> function)
		{
			_leftExpression = left;
			_rightExpression = right;
			_function = function;
		}

		public int Interpret(Context context)
		{
			var left = _leftExpression.Interpret(context);
			var right = _rightExpression.Interpret(context);

			return _function.Invoke(left, right);
		}
	}
}