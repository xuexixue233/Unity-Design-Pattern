public class QuickSort : Sort
{
    public override void ToSort()
    {
        QuickToSort(Nums, 0, Nums.Length - 1);
    }
    void QuickToSort(int[] array, int left, int right)
    {
        if (left < right)
        {
            int pivotIndex = Partition(array, left, right);
            QuickToSort(array, left, pivotIndex - 1);
            QuickToSort(array, pivotIndex + 1, right);
        }
    }
    
    int Partition(int[] array, int left, int right)
    {
        int pivot = array[right];
        int i = left - 1;

        for (int j = left; j < right; j++)
        {
            if (array[j] <= pivot)
            {
                i++;
                Swap(array, i, j);
            }
        }

        Swap(array, i + 1, right);
        return i + 1;
    }
    
    void Swap(int[] array, int a, int b)
    {
        (array[a], array[b]) = (array[b], array[a]);
    }
}