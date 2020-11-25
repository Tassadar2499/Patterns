using System;
using System.Threading;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
	public class KekHandler : IHandler
	{
		public async Task ExecuteAsync(Request request)
		{
			await Task.Run(() => Execute(request)).ConfigureAwait(false);
		}

		private void Execute(Request request)
		{
			Thread.Sleep(3000);
			Console.WriteLine("Kek " + request.Name);
		}
	}
}