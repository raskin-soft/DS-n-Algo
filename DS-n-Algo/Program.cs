using DS_n_Algo.All_DS;
using DS_n_Algo.All_Programs;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_n_Algo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            allDS();

            allPrograms();

        }

        public static void allDS()
        {
            all_DS all_ds = new all_DS();

            //all_DS.Stack();
            //all_DS.Queue(); 
        }

        public static void allPrograms()
        {
            all_Programs all_prg = new all_Programs();

            //all_prg.RemoveDuplicateChars("tree");

            //all_prg.IsPalindrome("civic");

            //all_prg.IsUnique("asadfg");

            //all_prg.Replace("aaa bbb nn mmm ");

            //all_prg.SubstringAll("rstu");

            //all_prg.WordCount("abb uytr  uyg fdd jig rewerty ");

            // all_prg.reverseArray();

            //all_prg.rotateLeft();

            //all_prg.MinMax();

            //all_prg.MergeSortedArray();

            //all_prg.GetMajorityElement();

            //all_prg.getWeired();

            //all_prg.GCD();

            //all_prg.countTriplet();

            //all_prg.anagram();



            //all_prg.AddNode(new all_Programs.Node(85));
            //all_prg.AddNode(new all_Programs.Node(15));
            //all_prg.AddNode(new all_Programs.Node(4));
            //all_prg.AddNode(new all_Programs.Node(20));

            //// List before reversal 
            //Console.WriteLine("Given linked list:");
            //all_prg.PrintList();

            //// Reverse the list 
            //all_prg.ReverseList();

            //// List after reversal      
            //Console.WriteLine("Reversed linked list:");
            //all_prg.PrintList();



            //all_prg.ParenthesisChecker();

            //all_prg.BinarySearchIterative();

            // all_prg.sortArray();

            Console.WriteLine(all_prg.EqualFrequency("abc"));
            Console.WriteLine(all_prg.EqualFrequency("abbbbcccc"));
            Console.WriteLine(all_prg.EqualFrequency("aaabbbcccc"));
            Console.WriteLine(all_prg.EqualFrequency("aabbcc"));
            Console.WriteLine(all_prg.EqualFrequency("aaaabc"));
            Console.WriteLine(all_prg.EqualFrequency("aaaabbbbcc"));
            Console.ReadLine();
        }
    }
}
