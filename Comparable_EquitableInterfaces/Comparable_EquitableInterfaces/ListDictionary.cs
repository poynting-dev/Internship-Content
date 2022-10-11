using System;
using System.Collections;
using System.Collections.Specialized;

public class SamplesListDictionary
{

    public static void ListDictionaryExample()
    {
        // Creates and initializes a new ListDictionary.
        ListDictionary myCol = new ListDictionary();
        myCol.Add("Braeburn Apples", "1.49");
        myCol.Add("Fuji Apples", "1.29");
        myCol.Add("Gala Apples", "1.49");
        myCol.Add("Golden Delicious Apples", "1.29");
        myCol.Add("Granny Smith Apples", "0.89");
        myCol.Add("Red Delicious Apples", "0.99");

        // Display the contents of the collection using foreach. This is the preferred method.
        Console.WriteLine("Displays the elements using foreach:");
        PrintKeysAndValues1(myCol);

        // Copies the ListDictionary to an array with DictionaryEntry elements.
        DictionaryEntry[] myArr = new DictionaryEntry[myCol.Count];
        myCol.CopyTo(myArr, 0);

        // Displays the values in the array.
        Console.WriteLine("Displays the elements in the array:");
        Console.WriteLine("   KEY                       VALUE");
        for (int i = 0; i < myArr.Length; i++)
            Console.WriteLine("   {0,-25} {1}", myArr[i].Key, myArr[i].Value);
        Console.WriteLine();

        // Searches for a key.
        if (myCol.Contains("Kiwis"))
            Console.WriteLine("The collection contains the key \"Kiwis\".");
        else
            Console.WriteLine("The collection does not contain the key \"Kiwis\".");
        Console.WriteLine();

        // Deletes a key.
        myCol.Remove("Plums");
        Console.WriteLine("The collection contains the following elements after removing \"Plums\":");
        PrintKeysAndValues1(myCol);

        // Clears the entire collection.
        myCol.Clear();
        Console.WriteLine("The collection contains the following elements after it is cleared:");
        PrintKeysAndValues1(myCol);
    }

    // Uses the foreach statement which hides the complexity of the enumerator.
    // NOTE: The foreach statement is the preferred way of enumerating the contents of a collection.
    public static void PrintKeysAndValues1(IDictionary myCol)
    {
        Console.WriteLine("   KEY                       VALUE");
        foreach (DictionaryEntry de in myCol)
            Console.WriteLine("   {0,-25} {1}", de.Key, de.Value);
        Console.WriteLine();
    }
}