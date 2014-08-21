namespace VariablesAndValues
{
	public class Program
	{
		public static void Main(string[] args)
		{
			// Declaring a Variable with a Primitive Type.

			int myInteger;				    	// Declare myInteger as an Integer.
			double myDouble;			    	// Declare myDouble as a Double.
			string myString;			    	// Declare myString as a String.
			bool myBoolean;				    	// Declare myBoolean as an Boolean.

			// Using the Assignment Operator to Assign a Literal Value to a Variable.

			myInteger = 10;				    	// Assign myInteger the Literal Integer Value 10.
			myDouble = 5.5;				    	// Assign myDouble the Literal Double Value 5.5.
			myString = "Hello World";	    	// Assign myString the Literal String Value "Hello World".
			myBoolean = true;				    // Assign myBoolean the Literal Boolean Value true.

			// Compound Statement combining the Variable Declaration and Value Assignment.

			int anotherInteger = 20;			// Declare anotherInteger as an Integer with a value of 20.
			double anotherDouble = 9.75;		// Declare anotherDouble as a Double with a value of 9.75.
			string anotherString = "Goodbye";	// Declare anotherString as a String with a value of "Goodbye".
			bool anotherBoolean = false;		// Declare anotherBoolean as a Boolean with a value of false.

			// Assigning a different value to a Variable will wipe out the old value.

			anotherInteger = 22;				// Assign anotherInteger the Literal Integer Value 22.
			anotherDouble = 10.44;			    // Assign anotherDouble the Literal Double Value 10.44.
			anotherString = "Hello Again";		// Assign anotherString the Literal String Value "Hello Again".
			anotherBoolean = true;		    	// Assign anotherBoolean the Literal Boolean Value true.

			// Using the Assignment Operator to Assign a Variable Value to a Variable.

			myInteger = anotherInteger;		    // Assign myInteger the Variable Value of anotherInteger.
			myDouble = anotherDouble;			// Assign myDouble the Variable Value of anotherDouble.
			myString = anotherString;			// Assign myString the Variable Value of anotherString.
			myBoolean = anotherBoolean;	        // Assign myBoolean the Variable Value of anotherBoolean.

			// Using Basic Arithmetic Operators to compute a Value.

			myInteger = 10 + 15;				// Assign myInteger the sum of 10 and 15.
			myDouble = 2.2 + 3.3;				// Assign myDouble the sum of 2.2 and 3.3.
			myString = "One" + "Two";			// Assign myString the concatenation of "One" and "Two".

			// Combining Literal Values and Variable Values in an Expression.

			myInteger = anotherInteger + 10;	// Assign myInteger the sum of anotherInteger and 10.
			myDouble = anotherDouble + 1.5;		// Assign myDouble the sum of anotherDouble and 1.5.
			myString = anotherString + "Three";	// Assign myString the concatenation of anotherString and "Three".
		}
	}
}