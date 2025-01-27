using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Security.Cryptography;
using System;


namespace assignment02adv
{
    class Progrm
    {
        static void Main()
        {
            #region ex01
            // 1.Given an array  consists of  numbers with size N and number of queries, in each query you will be given an integer X,
            // and you should print how many numbers in array that is greater than  X.

            //string[] input = Console.ReadLine().Split(' ');
            //int N = int.Parse(input[0]);
            //int Q = int.Parse(input[1]);

            //List<int> numbers = new List<int>(Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse));

            //for (int i = 0; i < Q; i++)
            //{
            //    int X = int.Parse(Console.ReadLine());
            //    int count = numbers.FindAll(num => num > X).Count; 
            //    Console.WriteLine(count);
            //} 
            #endregion

            #region ex02
            // 2. Given a number N and an array of N numbers. Determine if it's palindrome or not.


            //int N = int.Parse(Console.ReadLine());

            //LinkedList<int> numbers = new LinkedList<int>(Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse));

            //bool isPalindrome = true;
            //LinkedListNode<int> forward = numbers.First;
            //LinkedListNode<int> backward = numbers.Last;
            #endregion

            #region ex03
            // 3.Given a Queue, implement a function to reverse the elements of a queue using a stack.

            //    Queue<int> queue = new Queue<int>();
            //    queue.Enqueue(1);
            //    queue.Enqueue(2);
            //    queue.Enqueue(3);
            //    queue.Enqueue(4);


            //    queue = ReverseQueue(queue);

            //    foreach (int item in queue)
            //    {
            //        Console.Write(item);
            //    }

            //}
            //static Queue<int> ReverseQueue(Queue<int> queue)
            //{
            //    Stack<int> stack = new Stack<int>();

            //    while (queue.Count > 0)
            //    {
            //        stack.Push(queue.Dequeue());
            //    }
            //    return queue;
            #endregion

            #region ex04
            //4. Given a Stack, implement a function to check if a string of parentheses is balanced using a stack.

            #endregion

            #region ex05
            // 5.Given an array, implement a function to remove duplicate elements from an array.


            //int[] numbers = { 1, 2, 2, 3, 4, 4, 5 };

            //HashSet<int> uniqueNumbers = new HashSet<int>(numbers);  // Remove duplicates using a HashSet

            //foreach (int num in uniqueNumbers)
            //{
            //    Console.Write(num);
            //}
            #endregion

            #region ex06
            //  6.Given an array list , implement a function to remove all odd numbers from it.


            //int[] numbers = { 1, 2, 3, 4, 5, 6 };

            //List<int> evenNumbers = new List<int>();


            //foreach (int num in numbers)
            //{
            //    if (num % 2 == 0)
            //    {
            //        evenNumbers.Add(num);
            //    }
            //}

            //foreach (int num in evenNumbers)
            //{
            //    Console.Write(num);
            //}

            #endregion

            #region Ex07
            // 7. Implement a queue that can hold different data types. 
            //            And insert the following data:
            //            queue.Enqueue(1)
            //queue.Enqueue(“Apple”)
            //queue.Enqueue(5.28)

            //Queue queue = new Queue();

            //queue.Enqueue(1);
            //queue.Enqueue("Apple");
            //queue.Enqueue(5.28);

            //foreach (var item in queue)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Ex08   
            // 8.Create a function that pushes a series of integers onto a stack.Then,
            // search for a target integer in the stack.If the target is found,
            // print a message indicating that the target was found how many elements were checked before finding the target
            // (“Target was found successfully and the count = 5”).If the target is not found,
            // print a message indicating that the target was not found(“Target was not found”).

            //Stack<int> stack = new Stack<int>();
            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);
            //stack.Push(4);

            //int target = int.Parse(Console.ReadLine());

            //int count = 0;
            //bool found = false;

            //foreach (int num in stack)
            //{
            //    count++;
            //    if (num == target)
            //    {
            //        found = true;
            //        Console.WriteLine($"Target was found successfully and the count = {count}");
            //        break;
            //    }
            //}

            //if (!found)
            //{
            //    Console.WriteLine("Target was not found");
            //}
            #endregion

            #region ex09

            //9.Given two arrays, find their intersection. Each element in the result should appear as many times as it shows in both arrays.

            //List<int> array1 = new List<int> { 1, 2, 3, 4, 4 };
            //List<int> array2 = new List<int> { 10, 4, 4 };

            //List<int> intersection = new List<int>();

            //foreach (int num in array1)
            //{
            //    if (array2.Contains(num))
            //    {
            //        intersection.Add(num);
            //        array2.Remove(num); 
            //    }
            //}

            #endregion

            #region ex10
            //10.Given an ArrayList of integers and a target sum, find if there is a contiguous sub list that sums up to the target.


            //List<int> numbers = new List<int> { 1, 2, 3, 7, 5 };
            //int target = 12;

            //for (int i = 0; i < numbers.Count; i++)
            //{
            //    int sum = 0;
            //    List<int> sublist = new List<int>();

            //    for (int j = i; j < numbers.Count; j++)
            //    {
            //        sum += numbers[j];
            //        sublist.Add(numbers[j]);

            //        if (sum == target)
            //        {-
            //            Console.WriteLine($"Sublist that sums to {target}");
            //            return;
            //        }
            //    }
            //} 
            #endregion

            #region Ex11
            // 11.Given a queue reverse first K elements of a queue, keeping the remaining elements in the same order


            //Queue<int> queue = new Queue<int>(new[] { 1, 2, 3, 4, 5 });
            //int K = 3;

            //Stack<int> stack = new Stack<int>();

            //for (int i = 0; i < K; i++)
            //{
            //    stack.Push(queue.Dequeue());
            //}
            //while (stack.Count > 0)
            //{
            //    queue.Enqueue(stack.Pop());
            //}
            //for (int i = 0; i < queue.Count - K; i++)
            //{
            //    queue.Enqueue(queue.Dequeue());
            //} 
            #endregion

        }
    }
}