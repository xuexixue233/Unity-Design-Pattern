using System.Collections.Generic;
using UnityEngine;

public abstract class Sort : ISort
{
    public int[] Nums { get; set; }
    public abstract void ToSort();

    public void Output()
    {
        for (int i = 0; i < Nums.Length; i++)
        {
            Debug.Log(Nums[i]);
        }
    }

    protected Sort(int[] nums)
    {
        Nums = nums;
    }
}