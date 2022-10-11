using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Display
{
    public int PPI { get; set; }
    public string Resolution { get; set; }
    public string Size { get; set; }
}

public class SortDisplay : IComparer<Display>
{
    public int Compare(Display x, Display y)
    {
        Display firstDisplay = x as Display;
        Display secondDisplay = y as Display;
        if ((firstDisplay.PPI.CompareTo(secondDisplay.PPI))==0)
            return firstDisplay.Size.CompareTo(secondDisplay.Size);
        return firstDisplay.PPI.CompareTo(secondDisplay.PPI);
    }
}

public static class SortUsingIComparerExample
{
    public static void IComparerExample()
    {
        List<Display> displays = new List<Display>()
        {
            new Display()
            {
                PPI = 224,
                Resolution = "1080 * 1920",
                Size = "6.1"
            },
            new Display()
            {
                PPI = 300,
                Resolution = "1440 * 2180",
                Size = "7.1"
            },
            new Display()
            {
                PPI = 160,
                Resolution = "564 * 900",
                Size = "5.4"
            },
            new Display()
            {
                PPI = 160,
                Resolution = "880 * 980",
                Size = "5.2"
            }
        };
        SortDisplay sorted = new SortDisplay();
        displays.Sort(sorted);
        foreach (var item in displays)
            Console.WriteLine("PPI: " + item.PPI + " Resolution: " + item.Resolution + " Size: " + item.Size);
    }
}
