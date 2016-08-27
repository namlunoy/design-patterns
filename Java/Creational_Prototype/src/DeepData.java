
public class DeepData implements Cloneable{
	public int value = 0;
	public DeepData(int v) {
		this.value = v;
	}
	@Override
	protected Object clone() throws CloneNotSupportedException {
		return super.clone();
	}
}
