using System;
using static ConsoleApp1.ThreadSafeCollections;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	public class Program
	{
		public static void Main()
		{
			ThreadCollec();
			//NON_GENRIC COLLECTIONS EXAMPLE
			//ArrayList Example
			ArrayList al = new ArrayList();
			string s = "Hi There!";
			int a = 10;
			DateTime date = DateTime.Parse("1 - Feb - 2012");
			al.Add(s);
			al.Add(a);
			al.Add(date);
			Console.WriteLine("Printing ArrayList Elements:-");
			foreach (object o in al)
			{
				Console.WriteLine(o);
			}
			Console.WriteLine();
			/////////////////////////////////
			Hashtable ht = new Hashtable();
			ht.Add(1, "Priyanshu");
			ht.Add(2, "Manish");
			ht.Add(3, "Salman Tella");
			ht.Add(4, "Shreyas Chandak");
			ht.Add("Aman", "Maurya");		//Inserting different datatype key from previous items keys
			Console.WriteLine("Printing HashTable Elements(each consist of KEY & corresponding VALUE):-");
			foreach (DictionaryEntry d in ht)
			{
				Console.WriteLine(d.Key + ": " + d.Value);
			}
			//////////////////////////////////
			int b = 1;
			float f = 5.789f;
			Stack st = new Stack();
			st.Push("item 1");
			st.Push(b);
			st.Push(f);
			Console.WriteLine("Printing STACK Elements(follows Last In First Out order):-");
			while (st.Count != 0)
            {
				Console.WriteLine(st.Pop());
				//st.Pop();
            }
			Console.WriteLine();

			////////////////////////////
			//--------------------------------------------------------------
			//Queue Example
			Queue q = new Queue();
			for (int i = 1; i <= 10; i++)
			{
				q.Enqueue(i);
			}
			while(q.Count!=0)
            {
				Console.Write(q.Peek() + " ");
				q.Dequeue();
            }
			Console.WriteLine();
			//////////////////////////////////
			//--------------------------------------------------------------
			//GENERIC COLLECTIONS EXAMPLES

			//List Example
			List<char> ls = new List<char>();
			string str = "NEVER SAY NEVER";
			for (int i = 0; i < str.Length; i++)
				ls.Add(str[i]);
			Console.WriteLine("Printing List Elements:-");
			foreach (object o in ls)
			{
				Console.Write(o + " ");
			}
			Console.WriteLine();
			/////////////////////////////////

			////////////////////////////
			//--------------------------------------------------------------
			//Dictionary Example
			Dictionary<string, char> dct = new Dictionary<string, char>();
			for (int i = 0; i < str.Length; i++)
			{
				string ind = "index " + i.ToString();
				dct.Add(ind, str[i]);
			}
            Console.WriteLine("Printing Dictionary Elements:-");
			foreach (KeyValuePair<string, char> el in dct)
			{
				Console.WriteLine(el.Key + ": " + el.Value);
			}
			Console.WriteLine();

			////////////////////////////
			//--------------------------------------------------------------
			//SortedList Example
			SortedList<string, int> sl = new SortedList<string, int>();
			sl.Add("def", 546);
			sl.Add("xyz", 785);
			sl.Add("mno", 987);
			sl.Add("fno", 123);

			foreach (KeyValuePair<string, int> kvp in sl)
			{
				Console.WriteLine(kvp.Key + " " + kvp.Value);
			}
			Console.WriteLine();
			

			////////////////////////////
			//--------------------------------------------------------------
			//Stack Example
			Stack<string> stk = new Stack<string>();
			ArrayList als = new ArrayList() {"Hi! There", "How", "are", "you ?"};
			for (int i = 0; i < als.Count; i++)
				stk.Push((string)als[i]);
			foreach (object o in stk)
			{
				Console.WriteLine(o);
			}
			Console.WriteLine();

			////////////////////////////
			//--------------------------------------------------------------
			//Queue Generic Collection Example:
			Queue<string> qu = new Queue<string>();
			for (int i = 0; i < als.Count; i++)
				qu.Enqueue((string)als[i]);
			while (qu.Count != 0)
				Console.WriteLine(qu.Dequeue());
			Console.WriteLine();



			Console.Read();
		}

	}
}
