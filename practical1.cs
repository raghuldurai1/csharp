class practical1
{
	public static void Main(string[] args)
	{
		double a=System.Convert.ToDouble(args[0]);
		decimal b=System.Convert.ToDecimal(args[1]);
		
		System.Console.WriteLine("{0} paisa ",a*100 );
		System.Console.WriteLine("{0} rupee ",b/100 );
			
		
	}
}