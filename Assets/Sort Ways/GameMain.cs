using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;


public class GameMain : MonoBehaviour
{
    private List<int> nums=new List<int>();
    public BubbleSort bubbleSort;
    public SelectionSort selectionSort;
    public InsertionSort insertionSort;
    public ShellSort shellSort;
    
    private void Start()
    {
        for (int i = 0; i < 10000; i++)
        {
            var x = Random.Range(0,1000000);
            nums.Add(x);
        }

        // bubbleSort = new BubbleSort(nums.ToArray());
        // bubbleSort.ToSort();
        // bubbleSort.Output();

        // selectionSort = new SelectionSort(nums.ToArray());
        // selectionSort.ToSort();
        // selectionSort.Output();

        // insertionSort = new InsertionSort(nums.ToArray());
        // insertionSort.ToSort();
        // insertionSort.Output();

        shellSort = new ShellSort(nums.ToArray());
        shellSort.ToSort();
        shellSort.Output();
    }
    
    
}