namespace FluentBuilder
{
	public class Rodnulkin
	{
		public string Name { get; set; }
		public bool IsEatSalo { get; set; }
		public string Factory { get; set; }
		public int MoneysCount { get; set; }

		public static RodnulkinBuilder CreateBuilder()
			=> new RodnulkinBuilder();
	}
}