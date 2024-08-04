using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleSort : Sort
{
    public override void ToSort()
    {
        for (int i = 0; i < Nums.Length; i++)
        {
            for (int j = 0; j < Nums.Length-i-1; j++)
            {
                if (Nums[j]>Nums[j+1])
                {
                    (Nums[j], Nums[j+1]) = (Nums[j+1], Nums[j]);
                }
            }
        }
    }
}
