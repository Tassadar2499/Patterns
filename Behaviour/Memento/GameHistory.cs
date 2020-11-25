using System.Collections.Generic;

namespace Memento
{
	public class GameHistory
	{
		private readonly Stack<GameEnvironmentMemento> _history;

		public GameHistory()
		{
			_history = new Stack<GameEnvironmentMemento>();
		}

		public void Push(GameEnvironmentMemento memento)
			=> _history.Push(memento);

		public GameEnvironmentMemento Pop()
			=> _history.Pop();
	}
}