
public class Program {
	public static void main(String[] args) {
		
		try {
			
			BaseCar a = new BaseCar();
			// BaseCar b = (BaseCar) a.clone();
			BaseCar b = (BaseCar) a.deepCopy();
			
			if(a.data == b.data){
				System.out.println("It's the same!");
			}else{
				System.out.println("Difference!");
			}
			
		} catch (CloneNotSupportedException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}
}
