using System;

namespace LearningAlgos;
public class CustomDicts
{
   // The dicts, hashsets and the like can be categorized as collections that rely on hashed keys for constant time access, sets and deletes.
   // The hash of the key is divided by the modulo of the length of the underlying array to determine its position.
   // Here you can see how the hash of the key is being calculated https://github.com/dotnet/runtime/blob/8db3cab69e3afe8c25d295edb8b1d599518e4eca/src/libraries/System.Private.CoreLib/src/System/Collections/Generic/Dictionary.cs#L526 
   // This hash then acts as the postion of the "bucket" in an int array. You heard it right a bucket implies multiple items in a bucket. That's because of possible collisions for the calculated hash. I'm not sure what exactly happens when a collision is detected... My guess there's an algorithm to move it to the next possible position. It also feels like a good place to LinkedLists...
   // Here's the juice: https://github.com/dotnet/runtime/blob/8db3cab69e3afe8c25d295edb8b1d599518e4eca/src/libraries/System.Private.CoreLib/src/System/Collections/Generic/Dictionary.cs#L1744
   // 
   // So let's try to implement something like a dict.
   //

    // We could probably solve collisions with having an array of linked lists.
    private string[] bucketList = new string[10];
    
    public CustomDicts(){}

    // We have a very empty instance of a dict here.
    // We need need a method to add a value to the bucket list;
    public void AddKeyValue(string key, string value)
    {
        // First we need a hashcode of the key;
        uint keyHash = (uint)key.GetHashCode();
        Console.WriteLine($"This is the hash of the key {key} {keyHash}");

        // Get modulo of the hash divided by the length of an bucketList.
        // This little math trick ensures that the value we get is within the length of the array.
        uint bucket = (uint)(keyHash % bucketList.Length);
        Console.WriteLine($"This is the modulo of keyhash divided by the lenght of the bucketList {bucket}");
        
        Console.WriteLine("Adding keyvalue");
        bucketList[bucket] = value;
    }

    public void GetValueByKey(string key)
    {
        uint keyHash = (uint)key.GetHashCode();
        Console.WriteLine($"This is the hash of the key {key} that we are retrieving {keyHash}");

        uint bucket = (uint)(keyHash % bucketList.Length);
        
        Console.WriteLine($"The value at key {key} is: {bucketList[bucket]}");
    }
}
