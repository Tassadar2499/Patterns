namespace Interpreter
{
	public abstract class TerminalExpression : IExpression
	{
		protected readonly string _name;

		protected TerminalExpression(string variableName)
		{
			_name = variableName;
		}

		public abstract int Interpret(Context context);
	}
}