

using System;

class ClothShowRoom
{
    static void Main()
    {
        Console.WriteLine("Enter the purchase amount:");
        double purchaseAmount = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the type of cloth (Mill/Handloom):");
        string clothType = Console.ReadLine();

        double discount = 0.0;

        switch (clothType)
        {
            case "mill":
                if (purchaseAmount >= 0 && purchaseAmount <= 100)
                {
                    discount = 0.0;
                }
                else if (purchaseAmount >= 101 && purchaseAmount <= 200)
                {
                    discount = 5.0;
                }
                else if (purchaseAmount >= 201 && purchaseAmount <= 300)
                {
                    discount = 7.5;
                }
                else if (purchaseAmount > 300)
                {
                    discount = 10.0;
                }
                break;

            case "handloom":
                if (purchaseAmount >= 0 && purchaseAmount <= 100)
                {
                    discount = 5.0;
                }
                else if (purchaseAmount >= 101 && purchaseAmount <= 200)
                {
                    discount = 7.5;
                }
                else if (purchaseAmount >= 201 && purchaseAmount <= 300)
                {
                    discount = 10.0;
                }
                else if (purchaseAmount > 300)
                {
                    discount = 15.0;
                }
                break;

            default:
                Console.WriteLine("Invalid cloth type entered.");
                return;
        }

        double discountAmount = (discount / 100) * purchaseAmount;
        double netAmount = purchaseAmount - discountAmount;

        Console.WriteLine("Net amount to be paid: {0}", netAmount);
    }
}



