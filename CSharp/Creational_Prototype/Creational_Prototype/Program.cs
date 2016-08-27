using System;

namespace Creational_Prototype
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			BaseCar a = new BaseCar();
			a.data.value = -1;
			// BaseCar b = (BaseCar)a.Clone();
			BaseCar b = (BaseCar)a.DeepCopy();
			Console.WriteLine("b.data = " + b.data.value);

			a.data.value = -10;
			Console.WriteLine("b.data = " + b.data.value);
		}
	}
}
