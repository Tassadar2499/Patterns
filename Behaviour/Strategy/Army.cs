namespace Strategy
{
	public class Army
	{
		private readonly ICleaner _toiletCleaner;

		public Army(ICleaner toiletCleaner)
		{
			_toiletCleaner = toiletCleaner;
		}

		public void CleanToilet()
		{
			_toiletCleaner.ClearToilet();
		}
	}
}