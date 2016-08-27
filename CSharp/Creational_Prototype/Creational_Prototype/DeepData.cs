using System;
namespace Creational_Prototype
{
	public class DeepData : ICloneable
	{
		public int value = 0;
		public DeepData(int v)
		{
			this.value = v;
		}

		public object Clone()
		{
			return this.MemberwiseClone();
		}
	}
}
