using System;
namespace Creational_Singleton
{
	public class MySingleton<T> where T : class, new()
	{
		private MySingleton() { }
		class SingletonCreator
		{
			static SingletonCreator() { }
			internal static readonly T instance = new T();
		}

		public static T Instance
		{
			get { return SingletonCreator.instance;}
		}
	}
}
