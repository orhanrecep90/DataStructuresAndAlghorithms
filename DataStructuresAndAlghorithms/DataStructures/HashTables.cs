namespace DataStructuresAndAlghorithms.DataStructures;

public static class HashTables
{
    
    // O(n) Linear Time Complexity
    public static int GetFirstRecurringCharacter(int[] array)
    {
        if (array.Length == 0)
            return 0;
        
        HashSet<int> hashSet = new HashSet<int>();

        foreach (var item in array)
        {
            if (hashSet.Contains(item))
                return item;
            hashSet.Add(item);
        }
        
        return 0;
    }

    // O(n+m) Linear Time Complexity
    public static bool IsSubset(int[] arr1, int[] arr2)
    {
        if (arr1.Length == 0||arr2.Length == 0)
            return false;
        
        HashSet<int> hashSet = new HashSet<int>();

        foreach (var arrItem in arr1)
        {
            hashSet.Add(arrItem);
        }

        foreach (var arrItem in arr2)
        {
            if (!hashSet.Contains(arrItem))
                return false;
        }

        return true;

    }
}