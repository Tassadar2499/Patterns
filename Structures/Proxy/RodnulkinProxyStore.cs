using System;
using System.Collections.Generic;
using System.Linq;

namespace Proxy
{
	public class RodnulkinProxyStore : IRodnulkinStore
	{
		private readonly List<Rodnulkin> _rodnulkins;
		private readonly Lazy<RodnulkinDbStore> _rodnulkinDbStore;

		public RodnulkinProxyStore()
		{
			_rodnulkins = new List<Rodnulkin>();
			_rodnulkinDbStore = new Lazy<RodnulkinDbStore>(() => new RodnulkinDbStore());
		}

		public Rodnulkin GetRodnulkin(int id)
		{
			var rodnulkin = _rodnulkins.FirstOrDefault(r => r.Id == id);
			if (rodnulkin == null)
			{
				rodnulkin = _rodnulkinDbStore.Value.GetRodnulkin(id);
				_rodnulkins.Add(rodnulkin);
			}

			return rodnulkin;
		}
	}
}