
public class MilesToFeetApp {

	public static void main(String[] args) 
	{
		final double FEET_IN_MILE = 5280;
		double milesToUncles = 7.3;
		double feetToUncles;
		
		feetToUncles = milesToUncles * FEET_IN_MILE;

		System.out.println("The distance to my uncle's house is " + milesToUncles + " miles or " + feetToUncles + " feet"); 
	}

}
