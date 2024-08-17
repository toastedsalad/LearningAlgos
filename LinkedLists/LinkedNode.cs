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
        Console.WriteLine("Printing linked list...");
        var temp = headNode;
        while(temp is not null)
        {
            Console.WriteLine(temp.NodeData);
            temp = temp.NextNode;
        }
    }

    public static void PrependingFirst(LinkedNode<T> headnode, LinkedNode<T> newNode)
    {
        Console.WriteLine("Prepending a new first value...");
        newNode.NextNode = headnode;
        headnode.PrevNode = newNode;
    }

    public static void AppendingLast(LinkedNode<T> headnode, LinkedNode<T> newNode)
    {
        Console.WriteLine("Appending a new last value...");

        // Need to iterate through the linked list until the next is null
        var current = headnode;
        while(current.NextNode is not null)
        {
            current = current.NextNode;
        } 

        newNode.PrevNode = current;
        current.NextNode = newNode;
    }

    public static void InsertAfterValue(int searchValue, int newValue, LinkedNode<int> headNode)
    {
        Console.WriteLine("Inserting a value...");
        var current = headNode;
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
public static void DeleteNode(int nodeIndex, LinkedNode<int> headnode)
    {
        Console.WriteLine($"Deleting node {headnode}");
        var current = headnode;
            // Check the value of the node
        for(int i = 0; i <= nodeIndex; i++)
        {
            if(i != nodeIndex && current is not null)
            {
                // So here if the we're not at the correc node we simply
                // continue...
                current = current.NextNode;
                continue;
            }
            else if(i == nodeIndex && current is not null)
            {
                // When the node indexes match we do the deletion.
                // We remove the pointers and hope that gc collects it.

                // So what's the algo here...
                // 1. Go to next node and set to previous to previous-previous
                // 2. Go to previous and set next to next-next but only if it exists.


                // How to handle first member.
                if(current.NextNode is not null)
                {
                    current.NextNode.PrevNode = current.PrevNode;
                }

                if(current.PrevNode is not null)
                {
                    current.PrevNode.NextNode = current.NextNode;
                }

                current.NextNode = null;
                current.PrevNode = null;
            }
            else
            {
                Console.WriteLine("There was nothing to delete..");
            }
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