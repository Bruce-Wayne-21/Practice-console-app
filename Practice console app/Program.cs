using System.Diagnostics.CodeAnalysis;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;

namespace Practice_console_app
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8 };
            //int target = 10;
            //PrintTwoSumResult(nums, target);
            //var obj = new Program();    
         
            //string name= obj.GetName(); 

            var addtwosum = new Solution();
            ListNode list = addtwosum.AddTwoNumbers(new ListNode(2, new ListNode(4, new ListNode(3))), new ListNode(5, new ListNode(6, new ListNode(4))));

            decimal balance = 0;
            bool exits = false;

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
                            if (withdraw <= balance)
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


        static void PrintTwoSumResult(int[] nums, int target)
        {
            solution s = new solution();
            int[] result = s.twosum(nums, target);

            if (result != null)
            {
                Console.WriteLine($"{result[0]},{result[1]}");
            }
            else
            {
                Console.WriteLine("No solution found.");
            }
        }

        // two sum . when i nums contains a [1,2,3,4,5] target is 6.
        // this method it through the array and check the sum of target. eg: 4+2 =6. it returns the [1,3] this is the answer
        public class solution
        {
            public int[] twosum(int[] nums, int target)
            {
                int n = nums.Length;
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (nums[i] + nums[j] == target)
                        {
                            return new int[] { i, j };
                        }
                    }
                }
                return null;
            }
        }

        public string GetName()
        {
            return "Practice Console App";
        }
        public static string GetVersion()
        {
            return "1.0.0";

        }
        public static string GetAuthor()
        {
            return "Your Name"; // Replace with your name
        }



        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }


        public class Solution
        {
            public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
            {
                ListNode dummyHead = new ListNode(0);
                ListNode curr = dummyHead;
                int carry = 0;
                while (l1 != null || l2 != null || carry != 0)
                {
                    int x = (l1 != null) ? l1.val : 0;
                    int y = (l2 != null) ? l2.val : 0;
                    int sum = carry + x + y;
                    carry = sum / 10;
                    curr.next = new ListNode(sum % 10);
                    curr = curr.next;
                    if (l1 != null)
                        l1 = l1.next;
                    if (l2 != null)
                        l2 = l2.next;
                }

                return dummyHead.next;
            }
        }

        public class animal
        {
            private string ProtectedMessage { get; set; }
            protected void DisplayMessage()
            {
                ProtectedMessage = "This is a protected message from the base class.";
                Console.WriteLine(ProtectedMessage);
            }
        }

        public class dog : animal
        {
           protected void ShowMessage()
           {
                DisplayMessage(); // This will work because DisplayMessage is protected
                
           }
        }

        public class  nattuDog :dog
        {
           
            public void ShowMessagew()
            {
                ShowMessage(); // This will work because ShowMessage is public
            }
        }   
            





    }
}
