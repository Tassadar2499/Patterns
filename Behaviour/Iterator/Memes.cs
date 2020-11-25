using System.Collections;

namespace Iterator
{
	public class Memes : IEnumerable
	{
		private readonly string[] _memes;

		public Memes()
		{
			_memes = new string[] { "Gerakl", "Plum", "Rofl" };
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return new MemesEnumerator(_memes);
		}
	}
}