namespace DataStructuresAndAlghorithms.DataStructures;


public static class Arrays
{
    // O(n) Linear Time Complexity
    public static int[] MergeSortedArrays(int[] arr1, int[] arr2)
    {
        if (arr1.Length == 0)
            return arr2;
        if (arr2.Length == 0)
            return arr1;

        int[] response = new int[arr1.Length + arr2.Length];
        
        int index1 = 0;
        int index2 = 0;
        while (arr1.Length>index1 || arr2.Length>index2 )
        {
            if (arr1.Length>index1&&(arr2.Length==index2 || arr1[index1] < arr2[index2]))
            {
                response[index1 + index2] = arr1[index1];
                index1++;
            }
            else
            {
                response[index1 + index2] = arr2[index2];
                index2++;
            }
        }

        return response;
    }
}