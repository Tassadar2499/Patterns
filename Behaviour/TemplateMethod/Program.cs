namespace TemplateMethod
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			var superTrainingProgram = new SuperTrainingProgram();
			superTrainingProgram.Train();
			superTrainingProgram.Train();
		}
	}
}