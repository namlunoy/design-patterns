
public class BaseCar implements Cloneable {
	public int id;
	public DeepData data = new DeepData(1);
	@Override
	protected Object clone() throws CloneNotSupportedException {
		// TODO Auto-generated method stub
		return super.clone();
	}
	
	public BaseCar deepCopy() throws CloneNotSupportedException{
		BaseCar newCar = (BaseCar) this.clone();
		newCar.data = (DeepData) this.data.clone();
		return newCar;
	}

}
