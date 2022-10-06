using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_n_Algo.All_Programs
{
    public class all_Programs
    {

        public virtual object equalFrequency(object word = str)
        {
            var c = Counter(word);
            foreach (var i in word)
            {
                c[i] -= 1;
                var s = new List<object>();
                foreach (var j in c.values())
                {
                    if (j)
                    {
                        s.append(j);
                    }
                }
                if (new HashSet<object>(s).Count == 1)
                {
                    return true;
                }
                c[i] += 1;
            }
            return false;
        }
    }


    public bool EqualFrequency(String word)
        {
            int[] cc = new int[27];
            for (int i = 0; i < word.Length; i++)
            {
                cc[word[i] - 97]++;
            }
            for (int i = 0; i < 26; i++)
            {
                if (cc[i] > 0)
                {

                    cc[i]--;
                    bool eq = true;
                    int eqf = 0;
                    for (int j = 0; j < 26; j++)
                    {
                        if (cc[j] > 0)
                        {
                            if (eqf == 0)
                            {
                                eqf = cc[j];
                            }
                            else if (eqf != cc[j])
                            {
                                eq = false;
                            }
                        }
                    }
                    if (eq)
                    {
                        return true;
                    }
                    cc[i]++;
                }
            }
            return false;
        }



        public void RemoveDuplicateChars(string key)
        {
            string table = "";
            string result = "";

            foreach (char value in key)
            {
                // See if character is in the table.
                if (table.IndexOf(value) == -1) // -1 means this ch is not in the table
                {
                    table += value; // append unique ch
                    result += value; // 
                }
            }
            //return result;

            Console.WriteLine(result);
        }


        public string Reverse(string x)
        {
            string result = "";
            for (int i = x.Length - 1; i >= 0; i--)
                result += x[i];
            return result;
        }

        public void IsPalindrome(string word)
        {
            int min = 0, max = word.Length - 1;
            bool status = false;

            for (int i = min; i < word.Length / 2; i++)
            {
                if (word[min] == word[max])
                {
                    min++;
                    max--;

                    status = true;
                }

                else
                {
                    //return false;
                    Console.WriteLine(false);
                    return;
                }
            }

            //return status;
            Console.WriteLine(status);
        }


        public void IsUnique(string s)
        {
            bool status = false;
            Dictionary<char, int> d = new Dictionary<char, int>();

            foreach (char c in s)
            {
                if (d.ContainsKey(c))
                {
                    Console.WriteLine(false);
                    return;
                }
                else
                {
                    d.Add(c, 1);
                    status = true;
                }
            }
            Console.WriteLine(status);
        }

        public void Replace(string s)
        {
            //s = s.Trim();
            s = s.Replace(" ", "%20");

            Console.WriteLine(s);
        }

        public void SubstringAll(string s)
        {
            for (int length = 1; length < s.Length; length++)
            {
                for (int start = 0; start <= s.Length - length; start++)
                {
                    string substring = s.Substring(start, length);
                    Console.WriteLine(substring);
                }
            }
        }

        public void WordCount(string x)
        {
            int result = 0;

            //Trim whitespace from beginning and end of string
            x = x.Trim();

            //Necessary because foreach will execute once with empty string returning 1
            if (x == "")
                return;

            //Ensure there is only one space between each word in the passed string
            while (x.Contains("  "))
                x = x.Replace("  ", " ");

            //Count the words
            foreach (string y in x.Split(' '))
                result++;

            Console.WriteLine(result);
        }

        public void reverseArray()
        {
            List<int> arr = new List<int>();
            arr.Add(1);
            arr.Add(4);
            arr.Add(3);
            arr.Add(2);

            arr.Reverse();

            Console.WriteLine(arr); ;
        }

        public void rotateLeft()
        {
            List<int> arr = new List<int>();
            arr.Add(1);
            arr.Add(2);
            arr.Add(3);
            arr.Add(4);
            arr.Add(5);

            List<int> rev_arr = new List<int>();

            int start = 2, length = arr.Count, c=0;

            for (int i = start; i < length; i++)
            {
                c++;

                if(i == length-1)
                {
                    rev_arr.Add(arr[i]);

                    length = arr.Count - c;
                    i = -1;
                    
                }
              else
                rev_arr.Add(arr[i]);
            }
            
        }

        public void MinMax()
        {
            int[] arr = { 2,9,5,7,1 };
            int min=0, max = 0;

            for (int i = 1; i < arr.Length; i++)
            {
                if(arr[min]>arr[i])
                    min = i;

                if(arr[max]<arr[i])
                    max = i;
            }

            int temp = 0;

            temp = arr[min];
            arr[min] = arr[max];    
            arr[max] = temp;

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }


        public void MergeSortedArray()
        {
            int[] front = { 1, 2, 3, 4 };
            int[] back = { 5, 6, 7, 8 };

            //int[] combined = new int[front.Length + back.Length];
            //Array.Copy(front, combined, front.Length);
            //Array.Copy(back, 0, combined, front.Length, back.Length);

            var combined = front.Union(back).ToArray();

            for (int i = 0; i < combined.Length; i++)
            {
                Console.WriteLine(combined[i]);
            }
        }
            public void GetMajorityElement()
            {
            int[] x = { 1, 2, 4, 3, 2, 7,4,2,7,8,0,3,2,5,4,6,8,3 };

            Dictionary<int, int> d = new Dictionary<int, int>();
                int majority = x.Length / 2;

            //Stores the number of occcurences of each item in the passed array in a dictionary
            foreach (int i in x)
            {
                if (d.ContainsKey(i))
                {
                    d[i]++;
                    //Checks if element just added is the majority element
                    if (d[i] > majority)
                    {
                        Console.WriteLine(i);
                        return;
                    }
                }
                else
                    d.Add(i, 1);
            }

            var maxValueKey = d.Aggregate((a, b) => a.Value > b.Value ? a : b).Key;

            Console.WriteLine(maxValueKey);

            //Console.WriteLine("No majority element in array");
            }



        public void getWeired()
        {
            int i = 010;
            int j = 07;

            decimal d1 = 010;
            decimal d2 = 07;

            

            Console.WriteLine(i);
            Console.WriteLine(j);

            Console.WriteLine(d1);
            Console.WriteLine(d2);

        }

        public void GCD()
        {
            int a = 30, b = 75;
            int gcd=0;

            //for (int i = 1; i <= a && i<=b; i++)
            //{
            //    if (a % i == 0 && b % i == 0)
            //        gcd = i;
            //}

            gcd = gcd_recursion(a, b);

            Console.WriteLine(gcd);
        }

        int gcd_recursion(int a, int b)
        {
            if (b != 0)
                return gcd_recursion(b, a % b);
            else
                return a;
        }


        // https://practice.geeksforgeeks.org/problems/count-the-triplets4615/1

        public void countTriplet()
        {
            int n=9, c = 0;
            int[] arr = { 2,12,10,5,5,6,7,9,1 };
            List<int> list = new List<int>();

            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    list.Add(arr[i]+arr[j]);
                }
            }

            foreach (int i in arr)
            {
                if (list.Find(x => x.Equals(i)) != 0)
                {
                    c++;

                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("\n\n"+c);
        }


        public void anagram()
        {
            string a = "abqc2d", b="dcabq2";
            int a_len=0, b_len=0;

            foreach (var item in a)
            {
                a_len = a_len + (int)item;
            }

            foreach (var item in b)
            {
                b_len = b_len + (int)item;
            }

            if(a_len==b_len)
                Console.WriteLine("Anagram");
            else
                Console.WriteLine("Not Anagram");

        }

        public void linkedList()
        {

            // Creating a linkedlist
            // Using LinkedList class
            LinkedList<String> my_list = new LinkedList<String>();

            // Adding elements in the LinkedList
            // Using AddLast() method
            my_list.AddLast("Zoya");
            my_list.AddLast("Shilpa");
            my_list.AddLast("Rohit");
            my_list.AddLast("Rohan");
            my_list.AddLast("Juhi");
            my_list.AddLast("Zoya");

            //my_list.Reverse();

            Console.WriteLine("Best students of XYZ university:");

            // Accessing the elements of
            // LinkedList Using foreach loop
            foreach (string str in my_list)
            {
                Console.WriteLine(str);
            }
        }



        // *************************************************************************************
        // https://practice.geeksforgeeks.org/problems/reverse-a-linked-list/1#

        public class Node
        {
            public int data;
            public Node next;

            public Node(int a)
            {
                this.data = a;
                this.next = null;
            }

        }

        Node head;

        public void ReverseList()
        {
            Node prev = null, current = head, next = null;
            while (current != null)
            {
                next = current.next;
                current.next = prev;
                prev = current;
                current = next;
            }
            head = prev;
        }

        public void AddNode(Node node)
        {
            if (head == null)
                head = node;
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
        }

        public void PrintList()
        {
            Node current = head;
            while (current != null)
            {
                Console.Write(current.data + " ");
                current = current.next;
            }
            Console.WriteLine();
        }

        


        //public Node reverseList(Node head)
        //{
    //    Node current = head;
    //    Node next = null;
    //    Node prev = null;

    //        while (current != null)
    //        {
    //            next = current.next;
    //            current.next = prev;
    //            prev = current;
    //            current = next;
    //        }
    //head = prev;
    //        return head;
        //}

        // *************************************************************************************



        public void ParenthesisChecker()
        {
            //string str = "{)(}((]}{](}(}))})(}{{)(]{([({(]([}[(]{)){(}}{})]]]({[]]]))}[(([[{})[{[((){[]][{([]}[}][(]]){]}(}{})({{]))[}{}}({{([([(])({{{{){(((]{](})}){]{{}[{[{(]((({)([)((})]){}{))()({})[{(](]([]))(}({})){(({{(}(}{{){}[]{}{]]]([})}}}{}]){))](()]])][]}}}}{[]((}){}){]{[}](]){)]}{()({}({([[()))}[}}))){()}}[{{)}([})){[)((}([{](}}()((}({([{]({({]{}{)]]}]{[{[{{[(}({{()(]}[([]({))(){{)])]][[([][)][[{[)([}({)]][[){[(]}]}}{][}([}}]()(({})[)[]{)}{(}][[](([{)){)([}){[({])()[({[((]](})}]))]([]]]{]]))(}{))}]{}}}[{]{[]][]}{]))()}}(]}}[([((}]{}}(]}})}}({}[[]{[){](([[])}{([][})]]((([}))}[)[{){)[}){{{}]](]}}[)}{][}][{({[])}{{{{}(}[()(][][}{]{{([})){{]{}{][[{)]))((){}(][}[){)]}{([{}}{[{)}[}{][[])[)(]{]{{{{}[()({]){{)[}{][}{{])))[)))}]{[()])](](]]{{(}[((({][()}(}]]})}[){[{]{[[}[[]}{)[}{})[]{{]({}}([]}({[]}(()][[}([]]}}{}()){)[{{[][}(}{({)}])[](]{](}[]{{{}][[([}{()[}))[]}}}][{([[{}}]](){([])[)[]]])}}(()[][]}]]}}()}{[[[)]([{{(]]][[)(({]{[))](}(}]{[)]{}}}([})}()([])(({})[(((){(]({{})[[{[[[(()}{}({}){)[[([{](([{)}(}}](((}](]({}][)(}))}){]}[})[[)](]])}]}]{}}}()}()([])([}](})]]){{({}[[}){(][){]))(}(]][([{[[)}{[({[)[()][[]([({[]([{)})])((]]({(({][])]][})[])[{{(](}[}{)}][))){)(]{}[)}}))}}{[({[(}]}[[[[[){([){{(())[]]}[(](]}})(]([){][[[}}]]{}[)[([[)})[)](]{]{[((([}]]]}[[)](}{}}[}[(}(}[}]))){]){({])(]{[]](]}{(]{[(}}({}[{]{{)))()({)[]}{[[{]]]}{[)[[({(({}(}{)]}}[}}))(]}}{){[{}()[}{](]]][[]({}}{{]{(]){)[())}(({[{)])]]]({){(]}(}](]})({}((][}]{})[)}([]]]())}}[)[([{[}{(((]}(][(]][((]({{()[)}[([({]]]}){])]{]{([([)}()){)[)]{}]{}[{(]])]}]]][[}})(}})[)}[[)()](](])[}]{{)[[))((](]}})}}({})(](](]{]{({{)()}{[{([(}]}({][])[])}}[([({([}{}[]{)(}{([{[}{}}[}]]{(]({))({]]))]][}{[{}}][])([(}((())([}){{[[{]{(]))[[}{}(}}})[})(([{[{{]}((}{)(}}({{)}{})(}()}])([{(((()([()()])(]}(})]]){{[][[](({}}[{]]()}}[)(]]]]))){){[[{{()][){([{}(]}[[()(])(][}(})[](}}]}({[}([)]])(}{)[}})[{})[]({)[[{[))]][(([}([[[]([(}{)){{)]{{)}{[}[[}{}{([})}(}})}({[[(}[[}[}[(]][(}]{})](}}({((]}])()}[[](}[{(}}{([[{({})[[)][)})[(){[]}{{{){[)(([})}}[)(({()}}(){)[{{][[}][][}[}){)([[}}]]{{)]}])[]})}})]{{)}[(]()()(){][]}{}[}[)([]{[[([)(}{{(}{({}(}(}[{{](}}}}([((]))}{}(}[}}[(}((([][)([)]]}}{][[)[}})])[{{([{{(()(]()[[]{[[{[}[()))}](}]([)[]]))}([[[]))(})})]](][][}][]]][][}][)())[{{(]{{({[}{]{({[[){{([{))[([){[)})](]][{([()]))}[{[}{)}([}{{]]}})}({[(()](]{([[}])[]{([()}]}[(]]{{){({]}{]{][}[]})(]({]({[]{]({[(](}[)]}]}()[][){}{}[)]}[}[(([()((][}]]]}]{(]])[[{)([[(}[[]}(((})(})([(]{))[]])([{]{))[{})(]](])}(])}}({(]]}})([]{(]]{)(())())(()}})]}}{)[)]{(([)(()[[{](][[)([(}))[){}(}]]]}[}]{][}){}]]{{)){}{[}]([({]]]{(][}([(][[}((}[(]{}[]}({}][}[{]{[[}(){()(](([{]{)([)(((([][{}[]{)}[)})(]((]])}](({])([)[[}{]([}}([[[]{{{([({)]{)[[(}{]}}(()))]{])(({[}[{}{({(}[{[])()]](}}]{([{{}}{)}]})[)[}})){}[}}([]}}()[)()[)}[}[)(}][]}[(}[[{[}]})}}[{{{}[{})]](({[)})[([(}}][}(((]{(}(({](){])][({)}]})[[)[{[{({)]]){)}(){[([()]][}]]][]{[(]((({{}[[})]({({)}{[})[}[{({{(({]])}[])[]]{)})(})){}]{)]{}](}}]{]{][[)){[]([)}{(}][)}(()())({[[{}{)][[(]{[)({){{}]]]({}}(])(){([{(]([[(())[)}{{[}])]()]]))][{[}}])}][)[]]{{}])[[}(})}][{)){{){[]]]})](()()]](((]})]}[)}({]}{{]}{[([[{}}})[)}]]})([[]{})]{)]})))({]{({)({{]]){}){){([)]](}[{}{[[]{())({]}])([[[{](}[][]{)([]{{{({]}{]{)[)(){]])[({]}{{{[(){{])[][){]}}))({][((]]((]])([){({)()[({][[){[{}}}}({{{(]]))]{[]]([)]]((}({(([)]]}[[{()({{{({]{(){](]}])(}](]{{}{)[[}[}[(}[}[)()}}}[)){}{][(}](}}][){)(}}}[]{{}]((}}))]([][()}}{([]{}[]{[)[)(({}[}}}}{[{{{)(}](}[{([){}{))]}){](}{([]}[}]))[){]}}(([])[])}[[{{]{}[{{[{})}{}[)){({]][}{{(}{])}){{)([}{()]}((]){])][}(([(}[}}}[(}[)(]){[}([))]}[[{}([){{[)}[()[])([]{][){[(({)[)(])({}}{]{)}}][}[(]{)}[)}][]]]]])][]}{[)(}(}[][[[[[))[{]}]))}(}{}{](][{]}[[}]{{([([)){([}](}}}))({]]{))[){[[(]{])[){({}{)][)[]}((][})}(}([{})]](][)[)}){]((})[[}){}[{{]}[{(]{]}}}}){)[)()[]{{{}[){}{)}{[)}}}]}][{[{[(}}(][({]]((}]}((([[]{{]][((]{)](({)}}())]({)[)}[]((]}]]]]]]){})){([{)[{()(()[)[]{]][{[}}{[])])()[{{()[]{(()(([{][(]{(]({}[){}]]}]{[({(}[]][]{{]{[{))}{{][}{)[{]([{{))[[[)}[){[]]][(}{(){]]}{](]]}){[}](()]][[()})((}}}]){))](][{})}(}({}{}})))({}()}()]{[)}[[))[(})]}[}{([[][)(]{([{)}}[)][)]]](][}[][}[}][}[]}}(((){})][]){})[){{}[({()]{{])]]}{}{]}}([}}}(){{[()()}()())([[][]}({)({)([({{}{{(}{{()})[[{[})([])({[}[}({))[](]){[}}[()}}{[}}){(([{]}[{}(]]([)}{]([{{[}{][}({{(({[}(}}]]]{}})({}[{}}((]{](){([}{)}]((){[{[)[()){{]})])]((}}]([})[()[(]){[}}{((][(]{)[{{[][()))]{{{)]}}[())({][[]{{(])(}(}}}(({((}(){[(}[({)]}{}](][][{[[]{{]({[]()([([)[()(((]}]][}({(}}[]}(]((({}}{(]{))[{(]]))}{][[}}(]{{{]){{}[)]))[(({]}{(((]}([})}{])))(]){))(}][{)])){{[}][)(){){]])(][({]])(]{}[[]]{)[{]({)[{]{}[)[)(([}}}{}{(}](}[})[]}])}(]()][}([(}])}{]{([{[}])([({]](})(}]([}){(}}]]({]){(((({(((}])[)[()}}])}}][({{{}[][}(])}[)})[[]}}}]{}(])[][{[}}()}]}{[}[][[])))[})]{}][()[})[[)([{]{}{)}[(([)(}{[]){)[}({](]}({([]([]{{}([([{]]))]][[}){[{})}]](}(][}])[[[(][{}(]{{{}[}}){})}({])(}{[))][]{{[)())})][}))])[){][{}({)){}{)[)][{[{{{]{[)([{]{(}{([]](}[(}{]{{[[(}}[[])(({}[]{]])))]}}{(]]{}{[){]}[)())))[)()[}}{){(]]{[]{])([})(({)](]))]]]{}{()[{)([[)]}[{]{)([}{{[[}]{}{(]{[]}[((][()]]({{])(({){(})(][(]{[(}{({[])]]][](([([([}[]{{]}[(]{}({(({(}][{}([[})}(])}((]){)[])[){}}])((([]{}))(}[[[{{][}[]}))}{([)}([{](}[[[}}]](])(}})])[])}]))[}[)[]}){)[[}][})]([]((]{[][]{[}}}]()]])[)(}()}{])({[{}[{[{})](])([)]]}{[][[}))[}}}{(){{{)[(}](}(]{[)({)})))((){{{{])){[{[{[([]){])[}){{))((}{)}}{]{)])](([{[{}]({]](]])[}))[[[)}[}()(}}}(]{({[(}(]())})[[]{}(]{{]}]}({)){){[){{{{[){([{}([([]([{)](({{}[{{))(]]{][){{){}){}}]](){){{([]{])]{{][{(){][[(([]{})})){[})[}])]}}[}}(]{]){[(({[(]([{]{]({(][[())){}}](({}}()([{][){}[}))]{)]{(}}[]{]][[]}[{})[(}{(){}({}]{])](]{[)][{)])]}[}){)[()[}})}(]}{{[})])({{{([(()[]({}[}}[)}[}[[([((()][)}}})}{)(}((}[}(())({}[[()[}{]}]{[]([)}()[()([)({[{(][]]}][)[))(]]][}((][]{[{][(){([([]]}]])[)[{}[]}])}[{}[{{(])([(}[)[}{())}[{)(]){))}[)[)(}{)({){([}}{){})){)}])}{][]}](]]}})))}}(}{[}{())[{{})[{)))}[}){(}}){([}}([[({(]]}{}}{[}]}]{][(]{{)}[[{]]{}}}](){}{}}[)}[}{[]}((}[[(()(()})]([{})({]}(]{(]}[((()]{}[]}}}}[[}(}[([[(]({)[]}]}(}[([(({)(]{[}[]})()}([[[]}[)]]){{{]([{)[])({{[)([}}(][[}]{][)[[{]}[{}){(][[][{{{))}{[][({[[((]{{(})[{]])[(]}[[{[())]([]))([{()[)[}(}){[[([})[(]]})}[[}}][[](({[[[{))({{)(}(}[{}))]([{}{}{{){}}({)}}][(}}]{))((]}}{]{[]{([[](}{}(])){])({]{][}[)}{[((})(])]({{]]]})[){{(}[{]]][]]()}[[{({]])((([}]])}({[)){}}({{{(}{{[[)}}[{]}]{][}((}]]}}))){[{)](]([{(}}{[[){))](((){((]}]}}(({[]{])]{[][[{{{}}))}}}[{{]}[])(][)}}({)((}}[{([][}{[[(({{}}()])[)})]]}(()[[)[[)])(({([[)}][([()([(]{}]}}}{[]]])})[{}{}]{}({{{}{(){][}[(}]{[]){{]([({](()])({{[((()[}{}({(}{[)(()[[[]]{}}))}{){)]{{{((]{[(]]([}[[]{[}[[]{(}}}}{)({)({(){)([)(()([]}){[[[[}[]((({])][]{)[)}]({[{{][)()]{{}[[}]}((])[]]))}()]]]]((({((({](([]][(](]({{}[)(]]]{{{)(]}}}][}()][)]{]({[({[}}})()])])[[])({}([)[{}[)}{{])([[](}}](}]({[}]][{{)(}[}))}}[]}[]}](]{}){{({[)})]()}](]}{}{({[{{)))][]((}][{[{{}}][]{}[{}[](]])}(][]()][[[}]()()[}([]]()](]{}}{])){}[))[]}}){{])({([]})(][(]([{)){)[]}])(}}}[}}[(({)[{]])][)][)}{{][]){(}[])}[]}]][[))[}{{{]{([}}})((}]}({({[){}{[)[}}](){((}}}}[[){(])[[{]{[])}{}[}]}}}]()(}}{{{[)]{[{}(([)([[)({[])(]{{)}}{}[)[{}])]}){))[][}))[[]{}{({][{)](}[)}}(]]{({{)[()(}}]{(])({}{){}}{{]))((]{}()[}}}[)]))(]{(])]{({[((()))]}]{]}]]]){()[]]){[{]]]])[([][{(([)}())](}}{[}}{]()[[)(}(}[{)][(}(][]){({[}[}{)()({)]}}}(({([]}]]][)[{)((]{([{][]{})[([]{[([])[[(([{)())[([([}{{){{(){{)]((]}{{({{{{[{({(]{]}}{{[]](][([{(}){)}{)(]({((}([({}]][]}}}[)[){[[](((([]{]}]}()()](}[{}}}]{{](}])[]((){([([){())}]}[}](][)}[}))((]()])[]])](()({})}[(])][](}{{}(([][))([)(}[}((]]{[({])]{[][}){)}}}]]]}}[](()])})}([}{}}(({[})}]]}){][)[[(]}}({[}(){}[((([(}[(]{[[{[[][[[]{(][}){])}]{({({}[(]]}{)}}[}{}}}{{)}[))[)([][{)]}{(((]{][}([)])]([[[[()}}{]})][][({]]][))(]([]}](]{{[{(]}{(}[])}){()[{]}{[)}[(})(({()](()([)]))[)}]]([([[])()]}[[{}[(}][[[({[[]{]})(]]}[[[)){({[()){]([{)]{[)}}[])[{]{[[}[}}[]({[}[]}{)]]]((}})[]](()}}][][[[]{}([}][()](({))({(}{]{]()[({(])}{[(}{[{})}{}(](}){[{}{[{)]}[{{())[{[(][{(]}(})[{()())]([{]([]()}({)]}({]{{{{][]{][[(){[)])}()]{{{]))[})([}[[({]{({)]}[[[}](}][)]{(}[{)}{[[[)([[{}{){{]}()}}}[])}{{}]([(({({[[]})[}}(]}}(]{{}}[]){]{}}())[{[[]){}]]}[{}([{({][}}[[[{(){[{]{(())]([]{)}()[{}))){]]}[(][}){{){{)}))}([)]()]}][}})[])[){[{]){}]{{[)[(][)]]){{}}(}[(([}(]}{(]{}((({}}(())[]{({[){[]{([())])])}(}}())({}(]){(((][[)))[)[]][{})})){}[({}[{{(([[}((({{}}]][((({{}{){{[]}[([({}){{{{}])}()[][])))(){[]])}[]]){}}]){";

            string str = "(()";
            string match = "" ;
            int c1=0, c2=0;

            bool b = false; 

            Stack<string> stack = new Stack<string>();

            foreach (var item in str)
            {
                if (item == '(' || item == '[' || item == '{')
                {
                    stack.Push(item.ToString());
                    c1++;
                }

                else
                {
                    if (stack.Any())
                    {
                        match = stack.Pop();
                        c2++;

                        if (item == ')' && match == "(")
                            b = true;

                        else if (item == ']' && match == "[")
                            b = true;

                        else if (item == '}' && match == "{")
                            b = true;

                        else
                        {
                            b = false;
                            return;
                        }
                    }
                    else
                    {
                        b = false;
                        return;
                    }
                }
            }
            if(c1==c2)
            {
                b = true;
            }
            else
            {
                b = false;
            }
            Console.WriteLine(b);
           // return b;

        }

        public void Height_BinaryTree()
        {
            BinaryTree tree = new BinaryTree();

            tree.root = new NodeBT(1);
            tree.root.left = new NodeBT(2);
            tree.root.right = new NodeBT(3);
            tree.root.left.left = new NodeBT(4);
            tree.root.left.right = new NodeBT(5);

            Console.WriteLine("Height of tree is : " +
                                        tree.maxDepth(tree.root));
        }

        public class NodeBT
        {
            public int data;
            public NodeBT left, right;

            public NodeBT(int item)
            {
                data = item;
                left = right = null;
            }
        }

        public class BinaryTree
        {
            public NodeBT root;

            /* Compute the "maxDepth" of a tree -- the number of
            nodes along the longest path from the root node
            down to the farthest leaf node.*/
            public int maxDepth(NodeBT node)
            {
                if (node == null)
                    return 0;
                else
                {
                    /* compute the depth of each subtree */
                    int lDepth = maxDepth(node.left);
                    int rDepth = maxDepth(node.right);

                    /* use the larger one */
                    if (lDepth > rDepth)
                        return (lDepth + 1);
                    else
                        return (rDepth + 1);
                }
            }
        }


        public void BinarySearchIterative()
        {
            int[] n = { 17,18,19,20,21 };
            int k = 19;

            int min = 0;
            int max = n.Length - 1;
            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (k == n[mid])
                {
                    Console.WriteLine(mid);
                    return;
                    //return ++mid;
                }
                else if (k < n[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            Console.WriteLine("Nil");
        }

        //public void BinarySearchRecursive(int[] inputArray, int key, int min, int max)
        //{
        //    if (min > max)
        //    {
        //        return "Nil";
        //    }
        //    else
        //    {
        //        int mid = (min + max) / 2;
        //        if (key == inputArray[mid])
        //        {
        //            return ++mid;
        //        }
        //        else if (key < inputArray[mid])
        //        {
        //            return BinarySearchRecursive(inputArray, key, min, mid - 1);
        //        }
        //        else
        //        {
        //            return BinarySearchRecursive(inputArray, key, mid + 1, max);
        //        }
        //    }
        //}


        public void sortArray()
        {
            // declaring and initializing the array
            int[] arr = new int[] { 1, 9, 6, 7, 5, 9 };

            // Sort array in ascending order.
            Array.Sort(arr);

            // reverse array
            Array.Reverse(arr);

            // print all element of array
            foreach (int value in arr)
            {
                Console.Write(value + " ");
            }
        }


        public void multiDarray()
        {
            int[,] a = new int[5, 2] { { 0, 0 }, { 1, 2 }, { 2, 4 }, { 3, 6 }, { 4, 8 } };
            int i, j;

            /* output each array element's value */
            for (i = 0; i < 5; i++)
            {

                for (j = 0; j < 2; j++)
                {
                    Console.WriteLine("a[{0},{1}] = {2}", i, j, a[i, j]);
                }
            }
        }














}
}
