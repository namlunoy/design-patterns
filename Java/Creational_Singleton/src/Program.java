
public class Program {
	public static void main(String[] args) {
		// Can not create an instance from outside the class
		//Goverment g = new Goverment();
		Goverment g1 = Goverment.getInstace();
		Goverment g2 = Goverment.getInstace();
		
		if(g1 == g2)
		{
			System.out.println("It's the same!");
		}
	}
}
