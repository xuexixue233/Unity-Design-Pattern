public class HeapSort : Sort
{
    public override void ToSort()
    {
        int n = Nums.Length;

        // 构建最大堆
        for (int i = n / 2 - 1; i >= 0; i--)
        {
            Heapify(Nums, n, i);
        }

        // 一个个从堆中取出元素
        for (int i = n - 1; i > 0; i--)
        {
            // 移动当前根到结尾
            Swap(Nums, 0, i);

            // 调整堆
            Heapify(Nums, i, 0);
        }
    }

    static void Heapify(int[] array, int n, int i)
    {
        int largest = i;
        int left = 2 * i + 1;
        int right = 2 * i + 2;

        // 如果左子节点比根大
        if (left < n && array[left] > array[largest])
        {
            largest = left;
        }

        // 如果右子节点比根大
        if (right < n && array[right] > array[largest])
        {
            largest = right;
        }

        // 如果最大值不是根
        if (largest != i)
        {
            Swap(array, i, largest);

            // 递归地堆化受影响的子树
            Heapify(array, n, largest);
        }
    }

    static void Swap(int[] array, int a, int b)
    {
        (array[a], array[b]) = (array[b], array[a]);
    }
}