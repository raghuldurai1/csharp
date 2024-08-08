class question5
{
	private int value;
	question5(int value1)
	{
		value=value1;
		System.Console.WriteLine("object is created and the value is "+value);	
	}
	~question5()
	{
		System.Console.WriteLine("object is destroyed");	
	}

	public static void Main(string[] args)
	{
		question5 obj = new question5(10);
	}
}