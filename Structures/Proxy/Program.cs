using System;

namespace Proxy
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			var proxyRodnulkin = new RodnulkinProxyStore();
			var rodnulkin1 = proxyRodnulkin.GetRodnulkin(1);
			var rodnulkin2 = proxyRodnulkin.GetRodnulkin(2);

			Console.WriteLine(rodnulkin1.Name);
			Console.WriteLine(rodnulkin2.Name);
		}
	}
}