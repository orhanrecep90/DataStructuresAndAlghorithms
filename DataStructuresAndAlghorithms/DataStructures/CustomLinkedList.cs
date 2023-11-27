using System.Collections;
using System.Security.Cryptography.X509Certificates;

namespace DataStructuresAndAlghorithms.DataStructures;

public class CustomLinkedList<T>:IEnumerable<T>
{
    //        value a next b   value b next c      value c next d     value d next null
    // (head) a             -> b                -> c                 -> d (tail)
    public Node<T> Head { get; private set; } 
    public Node<T> Tail { get;private set; }
    public void AddFirst(T value)
    {
        Node<T> node = new (value);
        if (Head is null)
        {
            Head = node;
            Tail = node;
        }
        else
        {
            node.Next = Head;
            Head = node;
        }
    }

    public void AddLast(T value)
    {
        Node<T> node = new(value);
        if (Tail is null)
        {
            Head = node;
            Tail = node;
        }
        else
        {
            Tail.Next = node;
            Tail = node;
        }
    }

    public void AddLast(IEnumerable<T> data)
    {
        foreach (var item in data)
        {
            AddLast(item);
        }
    }

    public void AddMiddle(T Value)
    {
        if (Head is null)
        {
            AddFirst(Value);
            return;
        }
        var current = Head;
        int counter = 0;
        var middleIndex= this.Count() / 2;

        while (current.Next is not null)
        {
            if (counter == middleIndex-1)
            {
                var node = new Node<T>(Value);
                node.Next = current.Next;
                current.Next = node;
                return;
            }
            current = current.Next;
            counter++;
        }
    }
    
    public void RemoveFirst()
    {
        if (Head is not null)
        {
            Head = Head.Next;
        }
    }

    public void RemoveLast()
    {
        if (Head is null)
        {
            return;
        }

        if (Head==Tail)
        {
            Head=Tail=null;
            return;
        }
        
        var current = Head;
        while (current is not null)
        {
            var currentNext = current.Next;
            if (currentNext.Next is null)
            {
                current.Next = null;
                Tail = current;
                return;
            }
            current = current.Next;
        }
    }

    public void RemoveWithValue(T value)
    {
        if (Head is null)
        {
            return;
        }
        if (Head==Tail && Head.Value.Equals(value))
        {
            Head=Tail=null;
            return;
        }
        var current = Head;
        var previous = Head;
        while (current is not null)
        {
            if (current.Value.Equals(value))
            {
                previous.Next = current.Next;
                return;
            }
            previous = current;
            current = current.Next;
        }
    }

    public IEnumerator<T> GetEnumerator()
    {
        Node<T> current = Head;
        while (current is not null)
        {
            yield return current.Value;
            current = current.Next;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

public class Node<T>
{
    public Node(T value)
    {
        Value = value;
    }
    public T Value { get; set; }
    public Node<T> Next { get; set; }
}