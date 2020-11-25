namespace Observer
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			var observers = new IObserver[] { new Voenkomat(), new Parent() };
			var student = new Student(observers);

			for (int i = 0; i < 10; i++)
				student.DropLessons();
		}
	}
}