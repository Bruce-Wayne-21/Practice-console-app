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
            string[] array = ["flower", "flow", "flight"];

            //var solution = new LongestCommonPrefix();
            //string str = solution.LongestCommonPrefixe(array);
            //Console.WriteLine(str);
            //Console.ReadLine();


            //var solution= new Solution_4();
            //    string s = "({[]})";
            //bool isValid = solution.IsValid(s);
            //Console.WriteLine($"Is the string \"{s}\" valid? {isValid}");


            //decimal balance = 0;
            //bool exits = false;

            ListNode l1 = new ListNode(1);
            l1.next = new ListNode(2);
            l1.next.next = new ListNode(4);

            // 2. Create the second list: 1 -> 3 -> 4
            ListNode l2 = new ListNode(1);
            l2.next = new ListNode(3);
            l2.next.next = new ListNode(4);

            var solution = new Solution_5();

            ListNode mergedHead = solution.MergeTwoLists(l1, l2);
            Console.WriteLine($"Merged List:{mergedHead}");




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

        public class LongestCommonPrefix
        {
            public string LongestCommonPrefixq(string[] strs)
            {
                try
                {
                    string prefix1 = strs[0];
                    for(int i = 1; i< strs.Length; i++)
                    {
                        while (strs[i].IndexOf(prefix1) != 0)
                        {
                            prefix1 = prefix1.Substring(0, prefix1.Length - 1);
                            if(string.IsNullOrEmpty(prefix1))
                            {
                                return "";
                            }
                        }

                    }
                    return prefix1;
                    
                }
                catch (Exception ex)
                {
                    return "";
                }

            }
        }


        public class Solution_4
        {
            public bool IsValid(string s)
            {
                Stack<char> stack = new Stack<char>();

                foreach (char c in s)
                {
                    // If it's an opening bracket, push to stack
                    if (c == '(' || c == '[' || c == '{')
                    {
                        stack.Push(c);
                    }
                    // If it's a closing bracket
                    else
                    {
                        // Stack is empty, no matching opening bracket
                        if (stack.Count == 0)
                        {
                            return false;
                        }

                        char top = stack.Pop();

                        // Check if the brackets match
                        if (c == ')' && top != '(')
                        {
                            return false;
                        }
                        if (c == ']' && top != '[')
                        {
                            return false;
                        }
                        if (c == '}' && top != '{')
                        {
                            return false;
                        }
                    }
                }

                // Stack should be empty if all brackets are matched
                return stack.Count == 0;
            }
        }


        #region Merge Two Sorted Lists

        public class Solution_5
        {
            public ListNode MergeTwoLists(ListNode list1, ListNode list2)
            {
                // 1. Create a "dummy" node to serve as the start of our merged list
                ListNode dummy = new ListNode(-1);

                // 2. Use a "current" pointer to build the new list
                ListNode current = dummy;

                // 3. Traverse both lists as long as neither is empty
                while (list1 != null && list2 != null)
                {

                    // Compare the values of the two nodes
                    if (list1.val <= list2.val)
                    {
                        current.next = list1;  // Attach list1's node
                        list1 = list1.next;    // Move list1 forward
                    }
                    else
                    {
                        current.next = list2;  // Attach list2's node
                        list2 = list2.next;    // Move list2 forward
                    }

                    // Move our building pointer forward
                    current = current.next;
                }

                // 4. If one list runs out before the other, simply attach the rest of the remaining list
                if (list1 != null)
                {
                    current.next = list1;
                }
                else if (list2 != null)
                {
                    current.next = list2;
                }

                // 5. The actual merged list starts AFTER the dummy node
                return dummy.next;
            }
        }


        #endregion

    }
}
