using System.Collections.Generic;
using System.Threading.Tasks;
using Cysharp.Threading.Tasks;
using UnityEngine;

public abstract class Sort : ISort
{
    public int[] Nums { get; set; }
    public abstract void ToSort();

    public float needTime;

    public async UniTask SortTime()
    {
        var curTime = Time.realtimeSinceStartup;
        await Task.Run(ToSort);
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