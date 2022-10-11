using System;
using System.Collections;
using System.Collections.Specialized;

public class SamplesStringDictionary
{
    public static void StringDictionaryExample()
    {
        // Creates and initializes a new StringDictionary.
        StringDictionary myCol = new StringDictionary();
        myCol.Add("red", "rojo");
        myCol.Add("green", "verde");
        myCol.Add("blue", "azul");

        Console.WriteLine("Displays the elements using foreach:");
        PrintKeysAndValues1(myCol);

        Console.WriteLine("Displays the elements using the Keys, Values, Count, and Item properties:");
        PrintKeysAndValues3(myCol);

        DictionaryEntry[] myArr = new DictionaryEntry[myCol.Count];
        myCol.CopyTo(myArr, 0);

        // Displays the values in the array.
        Console.WriteLine("Displays the elements in the array:");
        Console.WriteLine("   KEY        VALUE");
        for (int i = 0; i < myArr.Length; i++)
            Console.WriteLine("   {0,-10} {1}", myArr[i].Key, myArr[i].Value);
        Console.WriteLine();

        // Searches for a value.
        if (myCol.ContainsValue("amarillo"))
            Console.WriteLine("The collection contains the value \"amarillo\".");
        else
            Console.WriteLine("The collection does not contain the value \"amarillo\".");
        Console.WriteLine();

        // Searches for a key and deletes it.
        if (myCol.ContainsKey("green"))
            myCol.Remove("green");
        Console.WriteLine("The collection contains the following elements after removing \"green\":");
        PrintKeysAndValues1(myCol);

        // Clears the entire collection.
        myCol.Clear();
        Console.WriteLine("The collection contains the following elements after it is cleared:");
        PrintKeysAndValues1(myCol);
    }

    public static void PrintKeysAndValues1(StringDictionary myCol)
    {
        Console.WriteLine("   KEY                       VALUE");
        foreach (DictionaryEntry de in myCol)
            Console.WriteLine("   {0,-25} {1}", de.Key, de.Value);
        Console.WriteLine();
    }

    // Uses the Keys, Values, Count, and Item properties.
    public static void PrintKeysAndValues3(StringDictionary myCol)
    {
        String[] myKeys = new String[myCol.Count];
        myCol.Keys.CopyTo(myKeys, 0);

        Console.WriteLine("   INDEX KEY                       VALUE");
        for (int i = 0; i < myCol.Count; i++)
            Console.WriteLine("   {0,-5} {1,-25} {2}", i, myKeys[i], myCol[myKeys[i]]);
        Console.WriteLine();
    }
}
