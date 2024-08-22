using System;

namespace LearningAlgos;

public class CustomQueue<T>
{
    private Node<T>? _head;
    private Node<T>? _tail;
    public int Length { get; private set; }

    public CustomQueue()
    {
        _head = _tail = null;
        Length = 0;
    }

    public void Enqueue(Node<T> item)
    {
        if (Length == 0)
        {
            _head = item;
            _tail = _head;
            Length++;
        }
        else
        {
            _tail.NextNode = item;
            _tail = item;
            Length++;
        }
    }

    public T? Deque()
    {
        if (_head is null)
        {
            return default(T);
        }

        var dequeingNode = _head;

        _head = _head.NextNode;
        dequeingNode.NextNode = null;
        Length--;

        return dequeingNode.NodeData;
    }

    public T? Peek()
    {
        return _head.NodeData;
    }
}

public class Node<T>
{
    public T NodeData { get; set; }
    public Node<T>? NextNode { get; set; }

    public Node(T nodeData, Node<T>? nextNode = null)
    {
        NodeData = nodeData;
        NextNode = nextNode;
    }
}


public static class CustomQueueHelpers<T>
{
    public static void PrintLinkedList(Node<T> headNode)
    {
        Console.WriteLine("Printing linked list...");
        var temp = headNode;
        while (temp is not null)
        {
            Console.WriteLine(temp.NodeData);
            temp = temp.NextNode;
        }
    }
}
