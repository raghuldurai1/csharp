class Io
{
	public void Demo()
	{
		int m = 10, n = 20;
		System.Console.WriteLine(" m = " + m);
		System.Console.WriteLine(" n = " + n);
		System.Console.WriteLine(" ++m = " + ++m);
		System.Console.WriteLine(" n++ = " + n++);
		System.Console.WriteLine(" m = " + m);
		System.Console.WriteLine(" n = " + n);
	}
}

class IncrementOperator
{
	public static void Main(string[] args)
	{
		Io obj = new Io();
		obj.Demo();
	}
}