public class InsertionSort : Sort
{
    public InsertionSort(int[] nums) : base(nums)
    {
    }

    public override void ToSort()
    {
        for (int i = 0; i < Nums.Length-1; i++)
        {
            int x=Nums[i+1];
            int j = i;
            for (; j >=0; j--)
            {
                if (Nums[j]>x)
                {
                    Nums[j + 1] = Nums[j];
                }
                else
                {
                    break;
                }
            }
            Nums[j + 1] = x;
        }
    }
}