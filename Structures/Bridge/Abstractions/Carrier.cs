using System.Threading.Tasks;

namespace Bridge
{
	public abstract class Carrier
	{
		private readonly IInterceptor[] _interceptors;

		protected Carrier(IInterceptor[] interceptors) => _interceptors = interceptors;

		public void Intercept()
			=> Parallel.ForEach(_interceptors, Intercept);

		private void Intercept(IInterceptor interceptor)
		{
			interceptor.Attack();
			interceptor.ReturnToBase();
		}

		public abstract void Shoot();
	}
}