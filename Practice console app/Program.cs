using System.Diagnostics.CodeAnalysis;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Practice_console_app
{
    internal class Program
    {
        public static async Task Main(string[] args)
        {


            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8,24,25,26 };
            //int target = 10;
            ////PrintTwoSumResult(nums, target);
            //newbook b = new newbook();
            //b.Display();
            ////PrintName();
            //decimal balance = 0;
            //bool exits = false;
            ////PrintBooks();
            //while (exits)
            //int y =sumnumber();
            //Console.WriteLine(y);
            int x = addnumers(1,2,3,4,5,6,6,2,3,4,5);
            //Console.WriteLine(x);

            //int[] result = RemoveDuplicates(1, 2, 3, 4, 5, 6, 8, 2, 3, 4);
            //Console.WriteLine(string.Join(", ", result));
            //string result2 =await checnkthevalue(nums);
            //Console.WriteLine(result2);
            StarPattern();

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
            public int[] twosum(int[] nums,int target)
            {
                int n = nums.Length;
                for( int i = 0; i < n; i++ )
                {
                    for(int j = 0; j < n; j++)
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

        public static void PrintName()
        {
            book b = new book(1);
            b.Title = "harry potter";
            Console.Write(b.Title);
        }

        class newname
        {
            public int num { get; set; }
            public string name { get; set; }
            public newname()
            {

            }

        }
        public static void main()
        {
            newname n = new newname();
            n.num = 1;
            n.name = "new name";
            Console.WriteLine(n.name);

        }

        class books
        {
            public string Title { get; set; }
            public string Author { get; set; }
            public int bookid { get; set; }

            public books(string title, string author, int bookid)
            {
                Title = title;
                Author = author;
                this.bookid = bookid;
            }
        }

        public static void PrintBooks()
        {
            books b1 = new books("harry potter", "J.K. Rowling", 1);
            books b2 = new books("The Hobbit", "J.R.R. Tolkien", 2);
            books b3 = new books("1984", "George Orwell", 3);
            List<books> bookList = new List<books> { b1, b2, b3 };
            foreach (var book in bookList)
            {
                Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Book ID: {book.bookid}");
            }
        }

        class newbook
        {
            public  void Display()
            {
                object obj;
                obj = new int[] {1,2, 3, 4, 5};
                Console.WriteLine(string.Join(", ", (int[])obj)); 
                Console.WriteLine(obj);
                Console.WriteLine(obj.GetType());
            }
        }

        public static int sumnumber()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            int total = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                total += numbers[i];
            }
         
            int n = 0;
            foreach (var item in numbers)
            {
                n += item;
            }
            int result = n;
            numbers.Add(n); 
            int sum =  numbers.Sum();
            //Console.WriteLine(sum);
            return sum;

        }

        public static int addnumers(params int[] numbers)
        {
            HashSet<int> uniqueNumbers = new HashSet<int>(numbers);
            int total= 0;
            foreach (var item in uniqueNumbers)
            {
                total += item;

            }
            for (int i = 1; i < uniqueNumbers.Count; i++)
            {
                total *= uniqueNumbers.ElementAt(i);
                
            }
            return total;

        }


        public static int[] RemoveDuplicates(params int[] nums)
        {
            if (nums.Length == 0)
            {
                return new int[0];
            }

            Array.Sort(nums); 

            int i = 0;
            for (int j = 1; j < nums.Length; j++)
            {
                if (nums[i] != nums[j])
                {
                    i++;
                    nums[i] = nums[j];
                }
            }
            int[] unique = new int[i + 1];
            Array.Copy(nums, unique, i + 1);
            return unique;
        }

        public static async Task<string> checnkthevalue(int[] nums)
        {
            try
            {
                foreach (var item in nums)
                {
                    if (item != null)
                    {
                        switch (item)
                        {
                            case 24:
                                Console.WriteLine("24 is present in the array.");
                                break;
                            case 25:
                                Console.WriteLine("25 is present in the array.");
                                break;
                            case 26:
                                Console.WriteLine("26 is present in the array.");
                                break;

                            default:
                                Console.WriteLine($"{item} is not present in the array.");
                                break;
                        }
                    }
                }
                return "Check completed successfully.";
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return "An error occurred during the check.";
            }
        }
      
        private static void StarPattern()
        {
            for (int row = 1; row <= 8; ++row)
            {
                for (int col = 1; col <= row; ++col)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
            Console.ReadLine();
        }


    }



}
