using System;
using System.Collections;
using System.Collections.Generic;
using Demo02Adv;
using System.Xml.Linq;
using static Demo02Adv.EmployeeCompareName;

namespace C_Advanced02G02
{
    internal class Program
    {
        public static void PrintArrayList(ArrayList arrayList)
        {
            Console.WriteLine();
            foreach (int item in arrayList)
            {
                Console.Write(value: $"{item} ");
            }
            Console.WriteLine();
        }


        public static void SumArrayList(ArrayList list)
        {
            int Sum = 0;
            if (list is not null)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    Sum += (int)list[i]; // unboxing
                }
            }
        }

        public static void PrintList<T>(List<T> values)
        {
            Console.WriteLine();
            foreach (T item in values)
            {
                Console.Write(value: $"[item}");
            }
            Console.WriteLine();

        }

        public static int SumList(List<int> list)
        {
            int Sum = 0;
            if (list is not null)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    Sum += list[i];
                }
                return Sum;
            }

        }
        public static void PrintLinkedList(LinkedList<int> linkedList)
        {
            Console.WriteLine();
            Console.WriteLine(value: "null");
            foreach (int item in linkedList)
            {
            }
            Console.WriteLine(value: $"<- {item} ");
            Console.WriteLine(value: "null");
            Console.WriteLine();
        }

        public static void PrintStack(Stack<int> stack)
        {
            Console.WriteLine();
            foreach (int item in stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
        public static void PrintQueue(Queue<int> queue)
        {
            Console.WriteLine();
            foreach (int item in queue)
            {

                Console.WriteLine(item);
            }
            Console.WriteLine();
        }

            
            static void Main()
            {


                // Revision
                #region Whats Collections ?
                // Collections: Built-in DS in C#
                // Array: Container
                // Collections in C#
                // Lists
                // Hashtables


                // Generic Non-Generic
                // Lists:
                // Non-Generis Lists: ArrayList - Stack Queue
                // Generis Lists : List, LinkedList, Stack Queue


                // Hashtables:
                // Non-Generics HashTables: HashTable
                // Generics HashTables : Dictionary - SortedDictionary

                #endregion

                #region Non Generic Lists - Arraylists
                // Lists
                // Non-Generic Lists: ArrayList

                // ArrayList Like Array
                // Array Based
                // Index

                // Array // Indexed Collection: Fixed Size
                // ArrayList Indexed Collection: Dynamic Size

                // Index: 012345
                // items: 456781
                // Size 6

                // Arr[1] 5


                //int[] Numbers = { 9, 8, 7, 6, 1, 2, 3, 4, 5 };
                ////Console.WriteLine (Numbers[1]);
                ////Numbers[1] = 12;
                ////Console.WriteLine(Numbers[1]);
                //ArrayList list = new ArrayList(capacity: 6);
                //Console.WriteLine(value: $"Count: {list.Count}, Capacity: {list.Capacity}");
                //list.Add(6);
                //list.Add(6);
                //list.Add(6);
                //list.Add(6);
                //list.Add(6);
                //list.Add(6);
                //list.Add(6);
                //list.Add(6);
                //list.Add(6);
                //Console.WriteLine(value: $"Count: {list.Count}, Capacity: {list.Capacity}");


                //ArrayList list = new ArrayList();
                //list.Add(1);
                //Console.WriteLine($"Count: {list.Count}, Capacity: {list.Capacity}");
                //list.Add(2);
                //list.Add(3);
                //list.Add(4);
                //Console.WriteLine($"Count: {list.Count}, Capacity: {list.Capacity}");
                //list.Add(5);
                //list.Add(6);
                //list.Add(7);
                //Console.WriteLine($"Count: {list.Count}, Capacity: {list.Capacity}");


                ////Console.WriteLine(list. IsFixedSize);
                ////Console.WriteLine(list. IsReadOnly);
                //Console.WriteLine(list[1]);
                //List[1] = 12;
                //Console.WriteLine(list[1]);
                //list.AddRange(new[] { 10, 11, 12 });


                //int Index = list. BinarySearch(1,);
                //int Index = list. BinarySearch(2,);
                //Console.WriteLine(Index);
                //Employee E01 = new Employee() { Id = 1, Name = "Ahmed", Salary = 12000, Age = 29 };
                //Employee E02 = new Employee() { Id = 2, Name = "Ali", Salary = 13000, Age = 30 };
                //Employee E03 = new Employee() { Id = 3, Name = "amr", Salary = 11000, Age = 27 };
                //Employee E04 = new Employee() { Id = 4, Name = "aliaa", Salary = 10000, Age = 28 };

                //ArrayList list = new ArrayList();
                //list.AddRange(new Employee[] { E01, E02, Ε03, Ε04 });

                //list.BinarySearch(E01);

                //int Index = list.BinarySearch(E03);
                //Console.WriteLine(value: $"Index: {Index}");


                //Console.WriteLine("================");
                //foreach (Employee item in list)
                //{
                //    Console.WriteLine(item);
                //}

                //list.BinarySearch(0, 2, new Employee() { Name = "Ali" }, null);

                ArrayList list = new ArrayList();
                list.Add(value: 1);
                list.Add(value: 2);
                list.Add(value: 3);
                list.Add(value: 4);
                //Console.WriteLine($"Count: {list.Count), Capacity: {list.Capacity)");
                //list.Clear();
                //Console.WriteLine($"Count: {list.Count), Capacity: {list.Capacity)");
                bool Flag = list.Contains(item: 20);
                Console.WriteLine(Flag);


                //int[] Arr = new int[10];
                //List.CopyTo(2, Arr, 3, 1);
                //foreach (int item in Arr)


                //Console.WriteLine(item);

                //ArrayList arrayList = list.GetRange(0, 2);

                //foreach (int item in arraylist)
                //{
                // Console.WriteLine(item);
                //}
                int i = list.IndexOf(5);
                Console.WriteLine(i);


                //list. Insert(0, 100);
                //PrintArrayList(list);
                //List. InsertRange(0, new int[] { 10, 20, 30, 40 });
                //PrintArrayList(list);
                //int i = list.LastIndexOf(5);
                //Console.WriteLine(i);
                //List.Remove(5);
                //List.RemoveAt(0);
                //List.RemoveRange(6,3);
                //List.SetRange(0, new int[] { 10, 20, 30 });
                list.Sort();
                PrintArrayList(list);



                #endregion

                #region problem with Non Generic Lists - Arraylists
                //ArrayList list = new ArrayList();
                //list.Add(1);
                //list.Add(2);
                //list.Add(3);
                //list.Add(4);
                //list.Add(5);
                //list.Add("Hello World");
                //list.Add(new Employee());
                //list.Add(2.3);
                //int Sum = SumArrayList(list);
                //Console.WriteLine(Sum);

                #endregion

                #region Generic List- lits
                // Generic Lists: List
                // List: Version Generic Of ArrayList
                // List Like ArrayList Like Array Generic Dynamic Size
                //List<int> list = new List<int>(new int[] {1,2,3,4));
                //List<int> list = new list<int>();
                //list.Add(1);
                //list.Add(2);
                //list.Add(3);
                //list.Add(4);
                //List.Add("Hello World"); // Complier
                // PrintList(list);


                //int Sum = SumList(list);
                //Console.WriteLine(Sum);
                //List.AddRange(new List<int>() { 10, 20, 30, 40, 50});
                //List.AsReadOnly();
                //int i = list. BinarySearch(20);
                ////PrintList(i);

                //Console.WriteLine(i);



                //Employee E01 = new Employee() { Id = 1, Name = "Ahmed", Salary = 12000, Age = 29 };
                //Employee E02 = new Employee() { Id = 2, Name = "Ali", Salary = 13000, Age = 30 };
                //Employee E03 = new Employee() { Id = 3, Name = "Omar", Salary = 15000, Age = 35 };
                //Employee E04 = new Employee() { Id = 4, Name = "Mariam", Salary = 14000, Age = 32 };

                //List<Employee> employees = new List<Employee>{ E01, Ε02, Ε03, Ε04 };
                ////int i = employees. BinarySearch(E01, new EmployeeCompareName());
                ////Console.WriteLine(i);


                Console.WriteLine($"Count: {list.Count), Capacity: {list. Capacity}");
                list.EnsureCapacity(10);
                Console.WriteLine($"Count: {list.Count), Capacity: {list.Capacity}");


                //List<int> result = list.GetRange(0, 2);
                //PrintList(result);
                //list.Sort();
                Console.WriteLine($"Count: {list.Count), Capacity: (list.Capacity}");
                //list. TrimExcess();
                Console.WriteLine($"Count: {list.Count), Capacity: (list.Capacity)");
                #endregion

                #region Linkedlist

                // Generic Lists: LinkedList
                //LinkedList<>
                //LinkedList
                LinkedList<int> linkedList = new LinkedList<int>();
                //linkedList.AddFirst(1);
                //LinkedList.AddFirst(2);
                linkedList.AddLast(1);
                linkedList.AddLast(2);

                LinkedListNode<int> node = new LinkedListNode<int>(3);
                linkedList.AddLast(node);

                PrintLinkedList(linkedList);


                LinkedListNode<int> result = linkedList.Find(value: 1);
                linkedList.AddBefore(result, value: 4);
                ////Console.WriteLine(linkedList.First.
                ////Console.WriteLine(linkedList.Last.Value);
                ////LinkedList.Clear()
                //Console.WriteLine(linkedList.First.Next.Value);
                //linkedList.Remove(linkedList.First);
                //LinkedList.Remove(2);
                //LinkedList.RemoveLast();
                linkedList.Remove(linkedList.Last);
                PrintLinkedList(linkedList);
                #endregion

                #region Generic Lists: STACK
                // Generic Lists: STACK
                Stack<int> stack = new Stack<int>();
                stack.Push(item: 1);
                stack.Push(item: 2);
                stack.Push(item: 3);
                stack.Push(item: 4);
                stack.Push(item: 5);
                //int top = stack.Pop();
                //Console.WriteLine(top);
                //int top stack.Peek();
                //Console.WriteLine(top);
                PrintStack(stack);

                //int top = stack.Pop);
                //Console.WriteLine(top);
                //int top stack.Peek();
                //Console.WriteLine(top);
                //stack.Peek();
                //bool flag = stack. TryPeek(out int top);
                //stack.Pop();
                //bool flag = stack. TryPop(out int top);
                //PrintStack(stack);
                //Console.WriteLine(top);

                // undo: ctrl + z 
                #endregion

                #region Generic Lists: Queue
                // Generic Lists: Queue
                Queue<int> queue = new Queue<int>();
                queue.Enqueue(item: 1);
                queue.Enqueue(item: 2);
                queue.Enqueue(item: 3);
                queue.Enqueue(item: 4);
                queue.Dequeue();

                //queue.Peek()
                //queue.
                PrintQueue(queue);

                #endregion


            }
        }
    }
