
public class Goverment {
	private static Goverment _instance = new Goverment();
	private Goverment(){
		System.out.println("Constructor!");
	}
	
	public static Goverment getInstace(){
		return _instance;
	}
}
