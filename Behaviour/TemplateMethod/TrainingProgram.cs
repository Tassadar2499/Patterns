namespace TemplateMethod
{
	public abstract class TrainingProgram
	{
		public void Train()
		{
			TrainHands();
			TrainLegs();
			TrainBody();
		}

		public abstract void TrainHands();

		public abstract void TrainLegs();

		public abstract void TrainBody();
	}
}