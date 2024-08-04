using System.Collections.Generic;
using UnityEngine;

public abstract class Sort : ISort
{
    public int[] Nums { get; set; }
    public abstract void ToSort();

    public float needTime;

    public void SortTime()
    {
        var curTime = Time.realtimeSinceStartup;
        ToSort();
        needTime = Time.realtimeSinceStartup - curTime;
    }

    public void Output()
    {
        for (int i = 0; i < Nums.Length; i++)
        {
            Debug.Log(Nums[i]);
        }
    }

    protected Sort()
    {
        Nums = null;
        needTime = 0f;
    }

    public void SetNum(int[] nums)
    {
        Nums = nums;
    }
}