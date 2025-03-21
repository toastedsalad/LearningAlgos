using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LearningAlgos
{
    public class DoublyListNode {
        public int value;
        public DoublyListNode next;
        public DoublyListNode prev;
        public DoublyListNode(int val = 0, DoublyListNode next = null!, DoublyListNode prev = null!) {
            this.value = val;
            this.next = next;
            this.prev = prev;
        }
    }

    public class ListNode {
        public int value;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null) {
            this.value = val;
            this.next = next;
        }
    }

    public class TreeNode {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
 
    class Program
    {
        static async Task Main(string[] args)
        {
            var node1 = new DoublyListNode(2);
            var node2 = new DoublyListNode(4);
            var node3 = new DoublyListNode(3);
            node1.next = node2;
            node2.next = node3;


            var nodeA = new DoublyListNode(5);
            var nodeB = new DoublyListNode(6);
            var nodeC = new DoublyListNode(4);
            nodeA.next = nodeB;
            nodeB.next = nodeC;
            
            AddTwoIntsLinkeList.AddTwoNumbers(node1, node2);

            // // Ring buffer concurency experiments.
            // //
            // var ringBuffer = new MyRingBuffer(2);
            // int numTasks = 1000; // Number of concurrent tasks
            // List<Task> tasks = new List<Task>();

            // // Create tasks
            // for (int i = 0; i < numTasks; i++) {
            //     tasks.Add(Task.Run(() => ringBuffer.EnQueue(i)));
            // }

            // // Wait for all tasks to complete
            // await Task.WhenAll(tasks); 

            // Console.WriteLine($"Ring buffer usage {ringBuffer.usageCount}");

            // for (var i = 0; i < 2; i++) {
            //     Console.WriteLine(ringBuffer.circularArray[i]);
            // }

            // byte[] source = { 1, 2, 3, 4, 5 };
            // byte[] destination = new byte[3];

            // Attempting to copy source to destination
            // source.CopyTo(destination, 0); // Throws System.ArgumentException

            // StringMultiplier.Multiply("123", "4");

            // var a = "1010";
            // var b = "1011";
            // BinaryAddition.AddBinary(a, b);

            // var coor = new int[3][];
            // coor[0] = new int[2] {2, 1}; 
            // coor[1] = new int[2] {4, 2}; 
            // coor[2] = new int[2] {6, 3}; 
            // PointsInStraightLine.CheckStraightLine(coor);

            // var fac = KthFactor.GetKthFactor(7, 2);
            // Console.WriteLine(fac);
            // var myposition = ReturnToOrigin.JudgeCircle("UD");
            // string[] operations = {"5","2","C","D","+"};
            // BaseBall.CallPoints(operations); 
            // RomanInt.RomanToInt("MCMXCIV");
            // var myDict = new CustomDicts();
            // myDict.AddKeyValue("AlgoStudent1", "G");
            // myDict.AddKeyValue("AlgoStudent2", "Ansis");

            // myDict.GetValueByKey("AlgoStudent1");
            // myDict.GetValueByKey("AlgoStudent2");
            // var myStack = new CustomStack<int>();
            // myStack.Push(1); 
            // myStack.Push(3); 
            // myStack.Push(4); 
            // myStack.Push(5); 
            // myStack.Push(6); 
            // myStack.Push(7);

            // CustomStackHelpers<int>.PrintLinkedList(myStack._tail);
            // myStack.Pop();
            // Console.WriteLine($"Peeking the stack {myStack.Peek().ToString()}");
            // CustomStackHelpers<int>.PrintLinkedList(myStack._tail);
            // myStack.Pop();
            // Console.WriteLine($"Peeking the stack {myStack.Peek().ToString()}");
            // CustomStackHelpers<int>.PrintLinkedList(myStack._tail);
            // Console.WriteLine(myStack.Size.ToString());
            // myStack.Pop();
            // myStack.Pop();
            // myStack.Pop();
            // Console.WriteLine(myStack.Size.ToString());
            // var myArray = ArrayGenerator.GenerateArray(10);
            // Console.WriteLine(string.Join(", ", myArray));

            // BubbleSort.SortBubbly(myArray);

            // Console.WriteLine(string.Join(", ", myArray));
            
            // bool[] haystack = { false, false, false, false, true };
            // var indexOfNeedle = SqrtSearch.Search(haystack);
            // Console.WriteLine($"The ball will break if thrown form the {indexOfNeedle} floor");

            //int[] haystack = { 1, 2, 3, 4 };
            //LinearSearchAlgo.SearchLinearly(haystack, 10

            //var s = "loveleetcode";
            //var result = FirstUniqueChar.FirstUniqueCharacter(s);
            //Console.WriteLine(result);

            // RunningSum
            //int[] nums = { 1, 2, 3, 4 };
            //var result = program.RunningSum(nums);
            //Console.WriteLine(result);

            // MaxWealth
            //int[] a = { 1, 2, 3 };
            //int[] b = { 3, 2, 1 };
            //int[][] accounts = { a, b };
            //var result = program.GetMaxWealth(accounts);
            //Console.WriteLine(result);

            // FizzBuzz
            //var result = program.FizzBuzzWList(15);
            //Console.WriteLine(string.Join("\n", result));

            // NumberOfSteps
            //var result = program.NumberOfSteps(8);
            //Console.WriteLine(result);

            // NumberOfSteps
            //var result = program.NumberOfStepsBitWise(14);
            //Console.WriteLine(result);

            // Middle of the linked list
            // We can create a linked list by instantiating a bunch of 
            // ListNode objects and then setting their .next attribute
            // to another ListNode object:
            //var node1 = new ListNode(1);
            //var node2 = new ListNode(4);
            //var node3 = new ListNode(7);
            //node1.next = node2;
            //node2.next = node3;
            //var result = program.MiddleNode(node1);
            //Console.WriteLine(result.val);

            // Middle of the linked list with built in new LinkedList<int>()
            //LinkedList<int> linkedList = new LinkedList<int>();
            //linkedList.AddLast(1);
            //linkedList.AddLast(2);
            //linkedList.AddLast(3);

            // Can construct ransom note from the magazine
            //var ransomNote = program.CanConstructRansomNote("gobig", "ofagtwgetweqrebi");
            //Console.WriteLine(ransomNote);

            // Can construct ransom note from the magazine
            //var ransomNote = program.CanCOnstructRansomNoteHashMap("gobig", "ofagtwgetweqrebi");
            //Console.WriteLine(ransomNote);
        }

        public bool CanConstructRansomNote(string ransomNote, string magazine)
        {
            for (int i = 0; i < ransomNote.Length; i++)
            {
                var requiredLetter = ransomNote[i];

                var requiredLetterIndexInMagazine = magazine.IndexOf(requiredLetter);

                if (requiredLetterIndexInMagazine == -1)
                {
                    return false;
                }

                // Why am I doing this?
                // Length is not based of 0, 3 == 3 positions
                magazine = magazine.Substring(0, requiredLetterIndexInMagazine) + magazine.Substring(requiredLetterIndexInMagazine + 1);
            }

            return true;

            // Time complexity O(n*m) as we for each letter in the ransom note we go through a magazine.
            // Space complexity O(n) as we temporarily create a new string to store a copy of the magazine with one less letter.
        }

        public DoublyListNode MiddleNode(DoublyListNode head)
        {
            DoublyListNode middle = head;
            DoublyListNode end = head;

            while (end != null && end.next != null)
            {
                middle = middle.next;
                end = end.next.next;
            }

            return middle;
        }

        public int NumberOfStepsBitWise(int num)
        {
            var steps = 0;

            while (num > 0)
            {   // We apply a bit mask of 00000001 or just 1 to check if the right most bit is 1 or 0
                // 1 & 1 is 1
                // 0 & 1 is 0
                // Because the right most bit allways adds 1 to the total value of bits
                // when we do get 1 it means the number is odd
                // and when we get 0 it means the number was even
                if ((num & 1 ) == 0) 
                {
                    // If the number was even we can halve it by shifting all bits 
                    // to the right by one place.
                    // It works because binary is power of 2 
                    // so the previous place is always half of the curent number.
                    num >>= 1;
                }
                else
                {
                    num--;
                }

                steps++;
            }
            return steps;
        }

        public int NumberOfSteps(int num)
        {
            var steps = 0;

            while(num > 0)
            {   // check if divisible by two
                if (num % 2 == 0)
                {
                    num /= 2;
                }
                else
                {
                    num--;
                }
                steps++;
            }
            return steps;
        }

        public List<string> FizzBuzzWList(int n)
        {
            var currentArray = new List<string>(n);

            for (int i=1; i <= n; i++)
            {
                var currentString = new StringBuilder();

                Boolean divisibleBy3 = i % 3 == 0;
                Boolean divisibleBy5 = i % 5 == 0;

                if (divisibleBy3)
                {
                    currentString.Append("Fizz");
                }
                if (divisibleBy5)
                {
                    currentString.Append("Buzz");
                }
                if (currentString.Length == 0)
                {
                    currentString.Append(i);
                }

                currentArray.Add(currentString.ToString());
            }

            return currentArray;
        }

        public string[] FizzBuzz(int n)
        {
            var currentArray = new string[n];

            for (int i = 1; i <= n; i++)
            {
                var currentString = new StringBuilder();

                Boolean divisibleBy3 = i % 3 == 0;
                Boolean divisibleBy5 = i % 5 == 0;

                if (divisibleBy3)
                {
                    currentString.Append("Fizz");
                }
                if (divisibleBy5)
                {
                    currentString.Append("Buzz");
                }
                if (currentString.Length == 0)
                {
                    currentString.Append(i);
                }

                currentArray[i - 1] = currentString.ToString();
            }

            return currentArray;
        }

        public int GetMaxWealth(int[][] accounts)
        {
            var maxWealthSoFar = 0;

            foreach(int[] customer in accounts)
            {
                var currentCustomerWealth = 0;
                foreach(int bank in customer)
                {
                    currentCustomerWealth += bank;
                }
                maxWealthSoFar = Math.Max(maxWealthSoFar, currentCustomerWealth);
            }

            return maxWealthSoFar;
        }

        public int[] RunningSum(int[] nums)
        {
            var result = new int[nums.Length];
            result[0] = nums[0];

            Console.WriteLine(nums.Length);

            for (int i = 1; i < nums.Length; i++)
            {
                // We need to add the current index to the previous index
                //Console.WriteLine(result[i - 1] + nums[i]);
                var myVar = result[i - 1] + nums[i];
                result[i] = myVar;
            }
            return result;
        }
    }
}
