class trial1
{
	private int x;
	
	public void set(int y)
	{
		x=y;
		int result=calcsq();
		System.Console.WriteLine(result);
	}
	
	public void calcsq()
	{
		return(x*x);
	}
	
}
class Trial2
{
	public int disp(int z)
	{
		set(z);
	}
}

class TrialClinet
{
	public static void Main(string[] args)
	{	
		Trial2 obj1=new Trial2();
		obj1.disp(4);
	}
}