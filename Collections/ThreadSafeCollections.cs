using System;
using System.Collections.Concurrent;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ThreadSafeCollections
    {
        public static void ThreadCollec()
        {
            ConcurrentStack<int> stk = new ConcurrentStack<int>();
            stk.Push(1);
            stk.Push(2);
            stk.Push(3);
            stk.Push(4);
            Console.WriteLine("ConcurrentStack Example: \n");
            //int val;
            //while(stk.TryPop(out val))
            //{
            //    Console.WriteLine("Popped: "+ val);
            //}
            stk.PushRange(new int[] { 6, 7, 8, 9, 10 });
            int[] arr = new int[4];
            stk.TryPopRange(arr);
            foreach (int i in arr)
                Console.WriteLine(i);
            Console.WriteLine();

            //////////////////--------------------------------------------------------------------
            Console.WriteLine("ConcurrentQUEUE Example: \n");
            ConcurrentQueue<int> cque = new ConcurrentQueue<int>();
            cque.Enqueue(1);
            int res;
            Console.WriteLine("Concurrent Queue: ");
            while (cque.TryDequeue(out res))
                Console.WriteLine("Dequeued: " + res);
            Console.WriteLine();

            //////////////////--------------------------------------------------------------------
            ///ConcurrentDictionary Example
            ConcurrentDictionary<string, int > cdict = new ConcurrentDictionary<string, int>();
            if (cdict.TryAdd("Aman", 12345))
                Console.WriteLine("Pair Added");
            if(cdict.TryUpdate("Aman", 54321, 12345))
                Console.WriteLine("Aman Value Updated");
            cdict["Aman"] = 67897;
            Console.WriteLine(cdict["Aman"]);

            //cdict.AddOrUpdate("Aman", 23456, (s, i) => 50000);
            //Console.WriteLine(cdict["Prateek"]);
            int ans = cdict.GetOrAdd("Aman", 20000);
            Console.WriteLine(ans);
            Console.WriteLine();

            //////////////////--------------------------------------------------------------------
            ///ConcurrentBag Example
            ConcurrentBag<int> cbag = new ConcurrentBag<int>();
            cbag.Add(25);
            cbag.Add(55);
            int tmp;
            if (cbag.TryTake(out tmp))
                Console.WriteLine(tmp);
            if (cbag.TryPeek(out tmp))
                Console.WriteLine(tmp);
            Console.WriteLine();

            //////////////////--------------------------------------------------------------------
            ///BlockingCollection Example
            BlockingCollection<int> blockcollec = new BlockingCollection<int>(boundedCapacity: 10);
            blockcollec.Add(55);
            blockcollec.Add(77);
            blockcollec.Add(88);
            int temp;
            while(cbag.TryTake(out temp))
                Console.WriteLine(temp);
        }
    }
}
