using System.Linq;

namespace Proxy
{
	/// <summary>
	/// Класс давайте представим, что он аналогичен классу из БД
	/// </summary>
	public class RodnulkinDbStore : IRodnulkinStore
	{
		private readonly Rodnulkin[] _rodnulkins;

		public RodnulkinDbStore()
		{
			_rodnulkins = new Rodnulkin[]
			{
				new Rodnulkin(1, "Rikardo Milos"),
				new Rodnulkin(2, "Billy Herrington")
			};
		}

		public Rodnulkin GetRodnulkin(int id)
			=> _rodnulkins.FirstOrDefault(r => r.Id == id);
	}
}