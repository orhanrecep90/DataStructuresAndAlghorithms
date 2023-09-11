// See https://aka.ms/new-console-template for more information

using DataStructuresAndAlghorithms.DataStructures;

int[] array1 = new[] { 0, 3, 4 };
int[] array2 = new []{4,6,30,31};
int[] array3 = new []{4,6,30,31,6};
int[] array4 = new[] { 0, 3, 4,4,3,6,7,8,8 };


// Console.WriteLine( string.Join(",",Arrays.MergeSortedArrays(array1,array2)));
// Console.WriteLine(HashTables.GetFirstRecurringCharacter(array3));
// Console.WriteLine(HashTables.GetFirstRecurringCharacter(array4));

Console.WriteLine(HashTables.IsSubset(array2,array3));
Console.WriteLine(HashTables.IsSubset(array3,array4));
Console.ReadLine();