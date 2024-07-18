using System;

namespace BankingApp
{
    class BankingSystem
    {
        int amt;
        const int pass1 = 1234;
        const int acc = 1234;

        public void Withdrawal()
        {
            Console.WriteLine("Enter The Amount To Withdraw: ");
            int with = System.Int32.Parse(System.Console.ReadLine());
            
            if (with <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a valid amount to withdraw.");
                return;
            }

            if (with < 100)
            {
                Console.WriteLine("Withdrawal amount must be 100 rupees or more.");
            }
            else if (with > amt)
            {
                Console.WriteLine("Insufficient balance. Please enter a valid amount to withdraw.");
            }
            else
            {
                amt -= with;
                
            }
        }

        public void Credit()
        {
            Console.WriteLine("Enter The Amount To Credit: ");
            int cre = System.Int32.Parse(System.Console.ReadLine());
            
            if (cre <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a valid amount to credit.");
                return;
            }

            if (cre < 100)
            {
                Console.WriteLine("Credit amount must be 100 rupees or more.");
            }
            else
            {
                amt += cre;
                Console.WriteLine("Credited Amount: " + cre);
                
            }
        }

        public void Show_Balance()
        {
            Console.WriteLine("Balance Amount: " + amt);
        }

         public static void Main(string[] args)
        {
            Console.Write("Enter The Account number: ");
            int accno = System.Int32.Parse(System.Console.ReadLine());
            while (accno != acc)
            {
                Console.WriteLine("Invalid account number. Please enter a valid account number.");
                accno = System.Int32.Parse(System.Console.ReadLine());
            }

            Console.Write("Enter The password number: ");
            int pass = System.Int32.Parse(System.Console.ReadLine());
            while (pass != pass1)
            {
                Console.WriteLine("Invalid password. Please enter a valid password.");
                pass = System.Int32.Parse(System.Console.ReadLine());
            }

            Console.WriteLine("Welcome!");

            BankingSystem obj = new BankingSystem();

            Console.Write("Enter The Initial Amount To Be Credited: ");
            obj.amt = System.Int32.Parse(System.Console.ReadLine());
            while (obj.amt < 0)
            {
                Console.WriteLine("Invalid input. Please enter a valid initial amount.");
                obj.amt = System.Int32.Parse(System.Console.ReadLine());
            }

            while (true)
            {
                Console.WriteLine("\n1. For Withdrawal\n2. For Credit\n3. Current Amount\n4. Exit");
                int ch = System.Int32.Parse(System.Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        obj.Withdrawal();
                        break;

                    case 2:
                        obj.Credit();
                        break;

                    case 3:
                        obj.Show_Balance();
                        break;

                    case 4:
                        Console.WriteLine("Exiting...");
                        return;

                    default:
                        Console.WriteLine("Invalid input.");
                        break;
                }
            }
        }
    }
}