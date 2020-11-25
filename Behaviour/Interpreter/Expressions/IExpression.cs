namespace Interpreter
{
	public interface IExpression
	{
		public int Interpret(Context context);
	}
}