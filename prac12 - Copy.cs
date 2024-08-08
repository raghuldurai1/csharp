class prac12
{

public void add(double x,double y)
{
int m=(int)(x+y);
System.Console.WriteLine(m);
}

public static void Main(string[] args)
{
double x=75.86;
double y=43.48;
prac1 obj=new prac1();
obj.add(x,y);
}
}