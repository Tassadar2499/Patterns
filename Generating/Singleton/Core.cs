using System;

namespace Singleton
{
	public class Core
	{
		private static readonly Core _instance = new Core();

		public string Name { get; }

		private Core() => Name = "Kek";

		public static Core GetInstance() 
			=> _instance;
	}
}
