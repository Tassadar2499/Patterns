namespace Mediator
{
	public abstract class Protoss
	{
		protected readonly IGlobalNet _globalNet;

		public Protoss(IGlobalNet globalNet)
			=> _globalNet = globalNet;

		public abstract void Notify(string message);

		public virtual void Send(string message)
			=> _globalNet.Send(message, this);
	}
}