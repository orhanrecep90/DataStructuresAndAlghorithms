namespace DataStructuresAndAlghorithms.Algorithms;

public class Sorting 
{
    public int[] BubbleSort(int[] array)
    {
        var index = 1;
        while (index < array.Length)
        {
            for (int j = 0; j < array.Length-index; j++)
            {
                if (array[j]>array[j+1])
                {
                    (array[j], array[j+1]) = (array[j+1], array[j]);
                }
            }
            index++;
        }
        
        
        return array;
    }
    public int[] InsertionSort(int[] array)
    {
        for (int i = 1; i < array.Length; i++)
        {
            var current = array[i];
            var j = i-1;
            while (j>=0 && array[j]>current)
            {
                array[j+1] = array[j];
                j--;
            }
            array[j+1] = current;
        }

        return array;
    }
    public int[] SelectionSort(int[] array)
    {
        for (int i = 0; i < array.Length-1; i++)
        {
            var minIndex = i;
            for (int j = i+1; j < array.Length; j++)
            {
                if (array[j]<array[minIndex])
                {
                    minIndex = j;
                }
            }
            (array[i],array[minIndex])=(array[minIndex],array[i]);
        }

        return array;
    }
    public T[] MergeSort<T>(T[] array, int left, int right) where T:IComparable
    {
        if (left < right)
        {
            int middle = left + (right - left) / 2;
            MergeSort(array, left, middle);
            MergeSort(array, middle + 1, right);
            MergeArray(array, left, middle, right);
        }
        return array;
    }
    public void MergeArray<T>(T[] array, int left, int middle, int right) where T : IComparable
    {
        var leftArrayLength = middle - left + 1;
        var rightArrayLength = right - middle;
        var leftTempArray = new T[leftArrayLength];
        var rightTempArray = new T[rightArrayLength];
        int i, j;
        for (i = 0; i < leftArrayLength; ++i)
            leftTempArray[i] = array[left + i];
        for (j = 0; j < rightArrayLength; ++j)
            rightTempArray[j] = array[middle + 1 + j];
        i = 0;
        j = 0;
        int k = left;
        while (i < leftArrayLength && j < rightArrayLength)
        {
            if (leftTempArray[i].CompareTo(rightTempArray[j]) <= 0)
            {
                array[k++] = leftTempArray[i++];
            }
            else
            {
                array[k++] = rightTempArray[j++];
            }
        }
        while (i < leftArrayLength)
        {
            array[k++] = leftTempArray[i++];
        }
        while (j < rightArrayLength)
        {
            array[k++] = rightTempArray[j++];
        }
    }
}