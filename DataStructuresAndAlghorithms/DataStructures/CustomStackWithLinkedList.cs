namespace DataStructuresAndAlghorithms.DataStructures;

public class CustomStackWithLinkedList<T>
{
    public Node<T> Top { get; set; }
    public int Count { get; set; }


    public void Push(T value)
    {
        if (Top==null)
        {
            Top = new Node<T>(value);
            Count++;
        }
        else
        {
            var pointer= Top;
            Top = new Node<T>(value);
            Top.Next = pointer;
            Count++;
        }
    }

    public T Pop()
    {
        var pointer = Top.Next;
        var value = Top.Value;
        Top = pointer;
        Count--;
        return value;
    }

    public T Peek()
    {
        return Top.Value;
    }
}
