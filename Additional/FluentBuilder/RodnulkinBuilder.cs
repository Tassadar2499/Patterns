namespace FluentBuilder
{
	public class RodnulkinBuilder
	{
		private readonly Rodnulkin _rodnulkin;

		public RodnulkinBuilder()
			=> _rodnulkin = new Rodnulkin();

		public RodnulkinBuilder SetName(string name)
		{
			_rodnulkin.Name = name;
			return this;
		}

		public RodnulkinBuilder SetIsEatSalo(bool isEatSalo)
		{
			_rodnulkin.IsEatSalo = isEatSalo;
			return this;
		}

		public RodnulkinBuilder SetFactory(string factory)
		{
			_rodnulkin.Factory = factory;
			return this;
		}

		public RodnulkinBuilder SetMoneysCount(int moneysCount)
		{
			_rodnulkin.MoneysCount = moneysCount;
			return this;
		}

		public Rodnulkin Build() => _rodnulkin;
	}
}