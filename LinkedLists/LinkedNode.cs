using System;

namespace LearningAlgos;

public class LinkedNode<T>
{
    public T NodeData { get; set; }
    public LinkedNode<T>? NextNode { get; set; }
    public LinkedNode<T>? PrevNode { get; set; }

    public LinkedNode(T nodeData, LinkedNode<T>? nextNode = null, LinkedNode<T>? prevNode = null)
    {
        NodeData = nodeData;
        NextNode = nextNode;
        PrevNode = prevNode;
    }
}    

public static class LinkedListHelpers<T>
{
    public static void PrintLinkedList(LinkedNode<T> headNode)
    {
        var temp = headNode;
        while(temp is not null)
        {
            Console.WriteLine(temp.NodeData);
            temp = temp.NextNode;
        }
    }

    public static void InsertAfterValue(int value, LinkedNode<int> headnode)
    {
        Console.WriteLine("Inserting a value...");
    }

    public static void CreateLinkedList(int nodeCount)
    {
        for(int i = 0; i < nodeCount; ++i)
        {
            var name = "LinkedNode" + i;
            Console.WriteLine(name);
        }
    }
}