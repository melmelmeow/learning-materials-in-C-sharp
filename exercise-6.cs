int LinearSearch(int[] arr, int target)
{
    for (int i = 0; i < arr.Length; i++)
        if (arr[i] == target) return i;
    return -1;
}

int[] data = { 3, 7, 9, 2 };
Console.WriteLine(LinearSearch(data, 9)); // Output: 2
