using System;

namespace TemplateMethod
{
	public class SuperTrainingProgram : TrainingProgram
	{
		public override void TrainBody()
		{
			Console.WriteLine("Пресс качат");
		}

		public override void TrainHands()
		{
			Console.WriteLine("Турник");
			Console.WriteLine("Анжуманья");
		}

		public override void TrainLegs()
		{
			Console.WriteLine("Бегит");
		}
	}
}