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

           //all_prg.IsUnique("asdfg");

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

           // Console.WriteLine(all_prg.EqualFrequency("abbbc"));

            //all_prg.RunningSum(new int[] { 1,2,3,4 });


            //int[][] a = new int[3][];
            //a[0] = new int[] { 1, 5 };
            //a[1] = new int[] { 7, 3 };
            //a[2] = new int[] { 3, 5 };
            //Console.WriteLine(all_prg.MaximumWealth(a));

            //Console.WriteLine(all_prg.FizzBuzz(5));

            //Console.WriteLine(all_prg.EvenMax_OddMin(new List<int>(){ 0,2,9 }));

            //Console.WriteLine(all_prg.PairCount(new List<int>() { 1,2,3,2,1 } , 5));

            //Console.WriteLine(all_prg.PairCount(new List<int>() { 1,1,1 }, 2));

            //Console.WriteLine(all_prg.PairCount(new List<int>() { 2,4,9,1,9,7,6,4,9 }, 8));

           // Console.WriteLine(all_prg.CommonItem(new List<int>() { 1, 2, 2, 1 } , new List<int>() { 2,3,1,2 }));

            Console.ReadLine();
        }
    }
}
