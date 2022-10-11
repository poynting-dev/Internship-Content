using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsExamples
{
    internal class Program
    {
        public static object Response { get; private set; }

        public static void Main(string[] args)
        {
			ArrayList al = new ArrayList();
			string s = "Hi There!";
			int a = 10;
			DateTime d = DateTime.Parse("1 - Feb - 2022");
			al.Add(s);
			al.Add(a);
			al.Add(d);
			foreach (object o in al)
			{
                Response.Write(o);
			}
			Response.Read();
		}
    }
}