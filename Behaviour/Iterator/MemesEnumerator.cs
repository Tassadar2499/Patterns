using System;
using System.Collections;

namespace Iterator
{
	public class MemesEnumerator : IEnumerator
	{
		private readonly string[] _memes;
		private int _currentIndex;

		public MemesEnumerator(string[] memes)
		{
			_memes = memes;
			_currentIndex = -1;
		}

		public object Current
		{
			get
			{
				if (_currentIndex == -1 || _currentIndex >= _memes.Length)
					throw new InvalidOperationException();

				return _memes[_currentIndex];
			}
		}

		public bool MoveNext()
		{
			if (_currentIndex >= _memes.Length - 1)
				return false;

			_currentIndex++;

			return true;
		}

		public void Reset()
		{
			_currentIndex = -1;
		}
	}
}