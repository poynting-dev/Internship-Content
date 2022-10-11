using System;
using System.Collections;
using System.Collections.Specialized;

public class SamplesHybridDictionary
{

    public static void Main()
    {
        // Creates and initializes a new HybridDictionary.
        HybridDictionary myCol = new HybridDictionary();
        myCol.Add("Braeburn Apples", "1.49");
        myCol.Add("Fuji Apples", "1.29");
        myCol.Add("Gala Apples", "1.49");
        myCol.Add("Golden Delicious Apples", "1.29");
        myCol.Add("Granny Smith Apples", "0.89");
        myCol.Add("Red Delicious Apples", "0.99");
        myCol.Add("Plantain Bananas", "1.49");
        myCol.Add("Yellow Bananas", "0.79");
        myCol.Add("Strawberries", "3.33");
        myCol.Add("Cranberries", "5.98");
        myCol.Add("Navel Oranges", "1.29");
        myCol.Add("Grapes", "1.99");
        myCol.Add("Honeydew Melon", "0.59");
        myCol.Add("Seedless Watermelon", "0.49");
        myCol.Add("Pineapple", "1.49");
        myCol.Add("Nectarine", "1.99");
        myCol.Add("Plums", "1.69");
        myCol.Add("Peaches", "1.99");

        Console.WriteLine("Displays the elements using foreach:");
        PrintKeysAndValues1(myCol);

        // Copies the HybridDictionary to an array with DictionaryEntry elements.
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

    public static void PrintKeysAndValues1(IDictionary myCol)
    {
        Console.WriteLine("   KEY                       VALUE");
        foreach (DictionaryEntry de in myCol)
            Console.WriteLine("   {0,-25} {1}", de.Key, de.Value);
        Console.WriteLine();
    }
}
