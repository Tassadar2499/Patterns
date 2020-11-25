namespace Interpreter
{
	public class NumberExpression : TerminalExpression
	{
		public NumberExpression(string variableName) : base(variableName)
		{
		}

		public override int Interpret(Context context)
			=> context.GetVariable(_name);
	}
}