using System;
using System.Globalization;

namespace LearningAlgos;

public class CustomStack<T>
{
    public int Size { get; private set; }
    public StackNode<T>? _tail;

    public CustomStack()
    {
        Size = 0;
        _tail = null;
    }
    
    public T? Pop ()
    {
        // This should pop an element from the stack.
        if(_tail is not null)
        {
            var poppingNode = _tail;
            _tail = _tail.NextNode;
            poppingNode.NextNode = null;
            Size--;

            return poppingNode.StackData; 
        }

        return default;
    }
    
    public void Add (T data)
    {
        // This should add an element to the end of the of the stack.
        var node = new StackNode<T> (data);

        if(_tail is null)
        {
            _tail = node;
        }
        else
        {
            node.NextNode = _tail;
            _tail = node;
        }
    }
}

public class StackNode<T>
{
    public T StackData { get; set; }
    public StackNode<T>? NextNode { get; set; }

    public StackNode(T stackData, StackNode<T>? nextNode = null)
    {
       StackData = stackData;
       NextNode = nextNode; 
    }
}

public static class CustomStackHelpers<T>
{
    public static void PrintLinkedList(StackNode<T> headNode)
    {
        Console.WriteLine("Printing linked list...");
        var temp = headNode;
        while(temp is not null)
        {
            Console.WriteLine(temp.StackData);
            temp = temp.NextNode;
        }
    }
}