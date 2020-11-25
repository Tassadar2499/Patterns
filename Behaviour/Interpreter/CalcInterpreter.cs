using System;
using System.Collections.Generic;
using System.Linq;

namespace Interpreter
{
	public class CalcInterpreter
	{
		private static readonly Dictionary<char, Func<IExpression, IExpression, IExpression>> _signsToExpressions;

		static CalcInterpreter()
		{
			_signsToExpressions = new Dictionary<char, Func<IExpression, IExpression, IExpression>>()
			{
				['+'] = (IExpression l, IExpression r) => new AddExpression(l, r),
				['-'] = (IExpression l, IExpression r) => new SubtractExpression(l, r)
			};
		}

		private readonly string[] _letters;
		private readonly IExpression _expression;

		public CalcInterpreter(string text)
		{
			var clearText = text.Replace(" ", "");
			var defaultSigns = _signsToExpressions.Keys.ToHashSet();
			_letters = clearText.Split(defaultSigns.ToArray());
			var signs = clearText.Where(s => defaultSigns.Contains(s)).ToArray();

			_expression = GetExpression(_letters, signs);
		}

		public int Interpret(params int[] numbers)
		{
			if (numbers == null)
				return -1;

			if (_letters.Length != numbers.Length)
				throw new ArgumentException($"количество переменных - {_letters.Length} не совпадает с количеством значений {numbers.Length}");

			var context = new Context();
			for (int i = 0; i < numbers.Length; i++)
				context.SetVariable(_letters[i], numbers[i]);

			return _expression.Interpret(context);
		}

		private IExpression GetExpression(string[] letters, char[] signs)
		{
			if (letters.Length - 1 != signs.Length)
				throw new ArgumentException($"Количество букв - {letters.Length} количество знаков - {signs.Length}");

			var numbersExpressionsQueue = new Queue<NumberExpression>();
			foreach (var letter in letters.Select(l => new NumberExpression(l)))
				numbersExpressionsQueue.Enqueue(letter);

			IExpression expression = numbersExpressionsQueue.Dequeue();
			foreach (var sign in signs)
				expression = _signsToExpressions[sign].Invoke(expression, numbersExpressionsQueue.Dequeue());

			return expression;
		}
	}
}