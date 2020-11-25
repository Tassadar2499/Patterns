using System.Threading;

namespace ChainOfResponsibility
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			var handlers = new IHandler[] { new LolHandler(), new KekHandler() };
			var client = new Client(handlers);

			client.HandleRequestAsync(new Request() { Name = "Roflan" });
			client.HandleRequestAsync(new Request() { Name = "Kekam" });

			Thread.Sleep(10000);
		}
	}
}