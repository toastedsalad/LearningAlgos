using System;
using System.ComponentModel.DataAnnotations;

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

    public static void InsertAfterValue(int searchValue, int newValue, LinkedNode<int> headnode)
    {
        Console.WriteLine("Inserting a value...");
        var current = headnode;
        while(current is not null)
        {
            // Check the value of the node
            if(searchValue == current.NodeData)
            {
                var newNode = new LinkedNode<int>(newValue);
                newNode.PrevNode = current;
                newNode.NextNode = current.NextNode;
                // We only need to deal with the previous of next if it is not null
                if (current.NextNode is not null)
                    current.NextNode.PrevNode = newNode;
                current.NextNode = newNode;  
            }

            current = current.NextNode;
        }
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