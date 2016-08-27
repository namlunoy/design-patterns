using System;
namespace Creational_Prototype
{
	public class BaseCar : ICloneable
	{
		public int id = 0;
		public DeepData data = new DeepData(1);
		public BaseCar()
		{
		}

		public object Clone()
		{
			object copiedObject = this.MemberwiseClone();
			return copiedObject;
		}

		public BaseCar DeepCopy()
		{
			BaseCar deepCopiedCar = (BaseCar)this.Clone();
			deepCopiedCar.data = (DeepData)this.data.Clone();
			return deepCopiedCar;
		}
	}
}
