class Question7
{
    public int Value1 ;
    public int Value2 ;

    public Question7(int value1, int value2)
    {
        Value1 = value1;
        Value2 = value2;
    }

    public static void Swap(Question7 obj1, Question7 obj2)
    {
        int temp1 = obj1.Value1;
        int temp2 = obj1.Value2;

        obj1.Value1 = obj2.Value1;
        obj1.Value2 = obj2.Value2;

        obj2.Value1 = temp1;
        obj2.Value2 = temp2;
    }

    public void Display()
    {
        System.Console.WriteLine("Value1 = "+Value1);
        System.Console.WriteLine("Value2 = "+Value2);
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Question7 obj1 = new Question7(10, 20);
        Question7 obj2 = new Question7(30, 40);

        System.Console.WriteLine("Before swapping:");
        System.Console.Write("Object 1: ");
        obj1.Display();
        System.Console.Write("Object 2: ");
        obj2.Display();

        Question7.Swap(obj1, obj2);

        System.Console.WriteLine("After swapping:");
        System.Console.Write("Object 1: ");
        obj1.Display();
        System.Console.Write("Object 2: ");
        obj2.Display();
    }
}
