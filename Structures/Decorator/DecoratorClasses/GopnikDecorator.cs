namespace Decorator.DecoratorClasses
{
	public abstract class GopnikDecorator : AbstractDecorator<IBydlo>
	{
		protected GopnikDecorator(IBydlo mainObject) : base(mainObject)
		{
		}

		public int SemkasCount
		{
			get => GetValue<int>("SemkasCount");
			set => SetValue("SemkasCount", value);
		}

		public void DropBottle()
			=>_mainObject.DropBottle();

		public void Shout()
			=> _mainObject.Shout();

		public void GriztSemkas()
			=> InvokeVoidMethod("GriztSemkas");
	}
}