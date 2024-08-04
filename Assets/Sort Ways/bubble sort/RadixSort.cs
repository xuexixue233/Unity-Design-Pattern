using System.Linq;


public class RadixSort : Sort
{
    public override void ToSort()
    {
        int max = Nums[0];
        int min = Nums[0];
        max = Nums.Max();
        min = Nums.Min();

        int range = max - min + 1;
        int[] countNum = new int[range];

        for (int i = 0; i < Nums.Length; i++)
        {
            countNum[Nums[i] - min]++;
        }

        int index = 0;

        for (int j = 0; j < range; j++)
        {
            while (countNum[j]-- != 0)
            {
                Nums[index++] = j + min;
            }
        }
    }
}