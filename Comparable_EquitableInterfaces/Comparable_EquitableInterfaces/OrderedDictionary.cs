using System;
using System.Collections;
using System.Collections.Specialized;

public class OrderedDictionarySample
{
    public static void OrderedDictionaryExample()
    {
        OrderedDictionary myOrderedDictionary = new OrderedDictionary();
        myOrderedDictionary.Add("testKey1", "testValue1");
        myOrderedDictionary.Add("testKey2", "testValue2");
        myOrderedDictionary.Add("keyToDelete", "valueToDelete");
        myOrderedDictionary.Add("testKey3", "testValue3");

        ICollection keyCollection = myOrderedDictionary.Keys;
        ICollection valueCollection = myOrderedDictionary.Values;

        // Display the contents using the key and value collections
        DisplayContents(keyCollection, valueCollection, myOrderedDictionary.Count);

        // Modifying the OrderedDictionary
        if (!myOrderedDictionary.IsReadOnly)
        {
            // Insert a new key to the beginning of the OrderedDictionary
            myOrderedDictionary.Insert(0, "insertedKey1", "insertedValue1");

            // Modify the value of the entry with the key "testKey2"
            myOrderedDictionary["testKey2"] = "modifiedValue";

            // Remove the last entry from the OrderedDictionary: "testKey3"
            myOrderedDictionary.RemoveAt(myOrderedDictionary.Count - 1);

            // Remove the "keyToDelete" entry, if it exists
            if (myOrderedDictionary.Contains("keyToDelete"))
            {
                myOrderedDictionary.Remove("keyToDelete");
            }
        }

        Console.WriteLine();
        DisplayContents(keyCollection, valueCollection, myOrderedDictionary.Count);

        // Clear the OrderedDictionary and add new values
        myOrderedDictionary.Clear();
        myOrderedDictionary.Add("newKey1", "newValue1");
        myOrderedDictionary.Add("newKey2", "newValue2");
        myOrderedDictionary.Add("newKey3", "newValue3");

        // Display the contents of the "new" Dictionary using an enumerator
        IDictionaryEnumerator myEnumerator = myOrderedDictionary.GetEnumerator();

        Console.WriteLine();

        DisplayEnumerator(myEnumerator);
    }

    // Displays the contents of the OrderedDictionary from its keys and values
    public static void DisplayContents(
        ICollection keyCollection, ICollection valueCollection, int dictionarySize)
    {
        String[] myKeys = new String[dictionarySize];
        String[] myValues = new String[dictionarySize];
        keyCollection.CopyTo(myKeys, 0);
        valueCollection.CopyTo(myValues, 0);

        // Displays the contents of the OrderedDictionary
        Console.WriteLine("   INDEX KEY                       VALUE");
        for (int i = 0; i < dictionarySize; i++)
        {
            Console.WriteLine("   {0,-5} {1,-25} {2}",
                i, myKeys[i], myValues[i]);
        }
        Console.WriteLine();
    }

    // Displays the contents of the OrderedDictionary using its enumerator
    public static void DisplayEnumerator(IDictionaryEnumerator myEnumerator)
    {
        Console.WriteLine("   KEY                       VALUE");
        while (myEnumerator.MoveNext())
        {
            Console.WriteLine("   {0,-25} {1}",
                myEnumerator.Key, myEnumerator.Value);
        }
    }
}