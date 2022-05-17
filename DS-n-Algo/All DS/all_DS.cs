using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_n_Algo.All_DS
{
    public class all_DS
    {
        public void Stack()
        {
            Stack<string> num = new Stack<string>();

            num.Push("one");
            num.Push("two");
            num.Push("three");
            num.Push("four");
            num.Push("five");

            foreach(string n in num)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine("\npopping '{0}'",num.Pop());

            //num.Pop();

            Console.WriteLine("\nPeek at next item to destack: {0}", num.Peek());

            Console.WriteLine("\npopping '{0}'", num.Pop());

            Stack<string> num2 = new Stack<string>(num.ToArray());  

            Console.WriteLine("\nContents of the first copy: ");
            foreach (string n in num2)
            {
                Console.WriteLine(n);
            }

            // Create an array twice the size of the stack and copy the
            // elements of the stack, starting at the middle of the
            // array.

            string[] arr =new string[num2.Count*2];
            num.CopyTo(arr, num2.Count);


            Stack<string> num3 = new Stack<string>(arr);
            Console.WriteLine("\nContents of the second copy, with duplicates and nulls: ");
            foreach (string n in num3)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine("\num2.Contains('four') = {0}", num2.Contains("four"));

            Console.WriteLine("num2.Clear()");

            num2.Clear();

            Console.WriteLine("num2.Count = {0}", num2.Count);

            Console.ReadLine();
        }

        public void Queue()
        {
            Queue<string> num = new Queue<string>();

            num.Enqueue("one");
            num.Enqueue("two");
            num.Enqueue("three");
            num.Enqueue("four");
            num.Enqueue("five");

            foreach (string n in num)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine("\nDequeuing  '{0}'", num.Dequeue());

            //num.Pop();

            Console.WriteLine("\nPeek at next item to nDequeuing : {0}", num.Peek());

            Console.WriteLine("\nDequeuing  '{0}'", num.Dequeue());

            Queue<string> num2 = new Queue<string>(num.ToArray());

            Console.WriteLine("\nContents of the first copy: ");
            foreach (string n in num2)
            {
                Console.WriteLine(n);
            }

            // Create an array twice the size of the stack and copy the
            // elements of the stack, starting at the middle of the
            // array.

            string[] arr = new string[num2.Count * 2];
            num.CopyTo(arr, num2.Count);


            Queue<string> num3 = new Queue<string>(arr);
            Console.WriteLine("\nContents of the second copy, with duplicates and nulls: ");
            foreach (string n in num3)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine("\nnum2.Contains('four') = {0}", num2.Contains("four"));

            Console.WriteLine("num2.Clear()");

            num2.Clear();

            Console.WriteLine("num2.Count = {0}", num2.Count);

            Console.ReadLine();
        }
    }
}
