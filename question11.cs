class question1 
{
	public static void Main(string[] args)
	{
		System.Console.WriteLine("Enter a Number: ");
		int number = System.Convert.ToInt32(System.Console.ReadLine());

		int reversedNumber = 0;
		
		While (number > 0)
		{
			int remainder = number %10;
			reversedNumber = reversedNumber * 10 + remainder;
			number = nmuber / 10;
		}
		System.Console.WriteLine(" the reverse Number is "+reversedNumber);
	}
}
 