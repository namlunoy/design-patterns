using System;

namespace Creational_Singleton
{
	class C1 { }
	class C2 { }
	class MainClass
	{
		public static void Main(string[] args)
		{
			var a = MySingleton<C1>.Instance;
			var b = MySingleton<C1>.Instance;


		}
	}
}
