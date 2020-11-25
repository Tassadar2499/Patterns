using System.Threading.Tasks;

namespace ChainOfResponsibility
{
	public class Client
	{
		private readonly IHandler[] _handlers;

		public Client(IHandler[] handlers)
		{
			_handlers = handlers;
		}

		public async void HandleRequestAsync(Request request)
		{
			await Task.Run(() => HandleRequest(request)).ConfigureAwait(false);
		}

		private void HandleRequest(Request request)
		{
			foreach (var handler in _handlers)
				handler.ExecuteAsync(request).Wait();
		}
	}
}