using System;
using static ConsoleApp1.ThreadSafeCollections;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomCollectionDemo;

namespace ConsoleApp1
{
	public class Program
	{
		public static void Main()
		{
			CustomCollection customColl = new CustomCollection();
			for(int i=2; i<=20; i+=2)
				customColl.Add(i);
			//Printing items from customCollection
			foreach(int i in customColl)
				Console.Write(i + " ");
			Console.WriteLine();

			//Insertion Operation
			customColl.Add(90);
			foreach (int i in customColl)
				Console.Write(i + " ");
			Console.WriteLine();

			//Deletion Operation
			Console.WriteLine("Capacity of collection is : " + customColl.Capacity());
			Console.WriteLine("Size is :" + customColl.Size());
			customColl.Remove(12);
			customColl.Remove(14);
			customColl.Remove(16);

			customColl.Update(20, 40);

			Console.WriteLine("After Deletion & Updation:");
			foreach (int i in customColl)
			{
				Console.Write(i + " ");
			}
			Console.WriteLine("Capacity of collection is : " + customColl.Capacity());
			Console.WriteLine("Size is :" + customColl.Size());


			//ThreadCollec();
			//Console.WriteLine();

			Console.Read();
		}

	}
}
