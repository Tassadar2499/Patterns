using System;
using System.Threading.Tasks;

namespace Observer
{
	public class Student
	{
		public event Action UniversityDropped;

		private const int MAX_LESSONS_TO_DROP = 10;
		private int _countOfLessonsDropped;

		private readonly IObserver[] _observers;

		public Student(IObserver[] observers)
		{
			_observers = observers;
			UniversityDropped += Student_UniversityDropped;
		}

		~Student()
		{
			UniversityDropped -= Student_UniversityDropped;
		}

		private void Student_UniversityDropped()
			=> Parallel.ForEach(_observers, (IObserver o) => o.Handle());

		public void Sleep()
			=> Console.WriteLine("Pojral");

		public void DropLessons()
		{
			_countOfLessonsDropped++;
			Console.WriteLine("Dropnul paru");

			if (_countOfLessonsDropped == MAX_LESSONS_TO_DROP)
				DropUniversity();
		}

		private void DropUniversity()
		{
			Console.WriteLine("Chislanulsya s sharagi azazazaz");
			UniversityDropped.Invoke();
		}
	}
}