namespace Practice_console_app
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal balance = 0;
            bool exits=false;

            while (!exits)
            {
                Console.Clear();
                Console.WriteLine("==== Welcome to Console Bank ====");
                Console.WriteLine("1. Check Balance");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Withdraw");
                Console.WriteLine("4. Exit");
                Console.Write("Choose an option (1-4): ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine($"your current balance is : {balance}");
                        Pause();
                        
                        break;
                    case "2":
                        Console.WriteLine("enter the amount deposit :$");
                        if (decimal.TryParse(Console.ReadLine(), out decimal deposit) && deposit > 0)
                        {
                            balance += deposit;
                            Console.WriteLine($"deposites: ${deposit}");
                        }
                        else
                        {
                            Console.WriteLine("invalid amount");
                        }
                        Pause();
                        break;
                    case "3":
                        Console.WriteLine("enter the amount to widrow:");
                        if (decimal.TryParse(Console.ReadLine(), out decimal withdraw) && withdraw > 0)
                        {
                           if(withdraw <= balance)
                            {
                                balance -= withdraw;
                                Console.WriteLine($"withdraw : ${withdraw}");
                           }
                           else
                           {
                                Console.WriteLine("insufficiant funds");
                           }
                        }
                        else
                        {
                            Console.WriteLine("Invalid amoount");
                        }
                        Pause();
                        break;

                    case "4":
                        exits = true;
                        Console.WriteLine("Thank you for using Console Bank!");
                       
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please select 1-4.");
                        Pause();
                        break;

                }
            }
        }


        static void Pause()
        {
            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
        }
    }
}
