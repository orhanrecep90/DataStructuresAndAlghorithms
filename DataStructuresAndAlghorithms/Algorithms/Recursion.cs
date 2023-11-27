namespace DataStructuresAndAlghorithms.Algorithms;

public class Recursion
{
    public int Factorial(int number)
    {
        if (number==1)
        {
            return number;
        }

        return number * Factorial(number - 1);
    }
    // 0, 1, 1, 2, 3, 5, 8, 13, 21, 34   = n + (n-1)
    public int Fibonacci(int index)
    {
        if (index<2)
        {
            return index;
        }

        return Fibonacci(index - 1) + Fibonacci(index - 2);
    }

    // abc => cba
    public string ReverseString(string str)
    {
        if (str.Length==1)
        {
            return str;
        }

        return str[str.Length - 1] + ReverseString(str.Substring(0, str.Length - 1));
    }
}