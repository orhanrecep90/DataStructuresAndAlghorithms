namespace DataStructuresAndAlghorithms.DataStructures;

public class CustomStackWithArray<T>
{
    private T[] _array { get;  set; }
    private uint _size { get;  set; }
    
    private readonly uint _capacity;

    public CustomStackWithArray(uint capacity)
    {
        if (capacity==0)
        {
            throw new ArgumentException("Capacity cannot be 0");
        }
        _capacity = capacity;
        _array = new T[_capacity];
    }

    public void Push(T value)
    {
        if (_array.Length==_size)
        {
            var pointer = _array;
            _array = new T[(((_size/_capacity)+1)*_capacity)];
            pointer.CopyTo(_array,0);
            _array[_size] = value;
        }
        else
        {
            _array[_size] = value;
        }
        _size++;
    }

    public T Pop()
    {
        _size--;
        var value = _array[_size];
        _array[_size] = default(T);
        return value;
    }

    public T Peek()
    {
        return _array[_size-1];
    }
}