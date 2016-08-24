using System;

namespace Creational_Singleton
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Singleton t1 = Singleton.UniqueInstance;
			Singleton t2 = Singleton.UniqueInstance;
			if (t1 == t2)
			{
				Console.WriteLine("xxx");
			}
		}
	}
}
