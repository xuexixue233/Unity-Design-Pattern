public class ShellSort : Sort
{
    public ShellSort(int[] nums) : base(nums)
    {
    }

    public override void ToSort()
    {
        int gap = Nums.Length;
        while (gap>1)
        {
            gap = gap / 3 + 1;
            for (int i = 0; i < Nums.Length - gap; i++)
            {
                int end = i;
                int x = Nums[end + gap];
                while (end >= 0)
                {
                    if (Nums[end] > x)
                    {
                        Nums[end + gap] = Nums[end];
                        end -= gap;
                    }
                    else
                    {
                        break;
                    }
                }
                Nums[end + gap] = x;
            }
        }
    }
}