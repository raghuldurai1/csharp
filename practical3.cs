class practical3
{
	public static void Main(string[] args)
	{
		double p=System.Convert.ToDouble(args[0]);
		double d=System.Convert.ToDouble(args[1]);
		double y=System.Convert.ToDouble(args[2]);
		
		double s=p-(d*y);		

		
		System.Console.WriteLine("{0}",d);
		
		
		
	}
}
/*For a certain electrical Circuit to the inductance N and resistance R the ____ natural frequency given by 
frequency=sqrt((1/lc)-(r^2/4c^2)). The Result to study the variation of frequency with C(capacitors).
Write a C# program to calculate the frequency for the different values of C starting from 0.01 to 0.1 in steps of 0.01*/