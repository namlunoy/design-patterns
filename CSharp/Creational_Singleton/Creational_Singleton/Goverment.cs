using System;
namespace Creational_Singleton
{
	public class Goverment
	{
		// Our instance, create only once
		private static readonly Goverment _instance = new Goverment();

		// Make constructor private
		private Goverment()
		{
			Console.WriteLine("Constructor!");
		}

		// Method to get the instance
		public static Goverment Instance
		{
			get { return _instance; }
		}
	}
}
