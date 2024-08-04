public class SelectionSort : Sort
{
    public override void ToSort()
    {
        for (int i = 0; i < Nums.Length-1; i++)
        {
            int k = i;
            for (int j = i+1; j < Nums.Length; j++)
            {
                if (Nums[j]<Nums[k])
                {
                    k = j;
                }
            }
            (Nums[k], Nums[i]) = (Nums[i], Nums[k]);
        }
    }
}