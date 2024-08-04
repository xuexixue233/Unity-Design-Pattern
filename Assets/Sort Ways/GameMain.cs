using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;


public class GameMain : MonoBehaviour
{
    public Button sortButton;
    public TMP_Text tmpText;
    public TMP_InputField inputField;
    
    private List<int> nums=new List<int>();
    private IEnumerable<Type> derivedTypes;

    private void Start()
    {
        Type baseType = typeof(Sort);
        derivedTypes = GetDerivedTypes(baseType, Assembly.GetExecutingAssembly());
        sortButton.onClick.RemoveAllListeners();
        sortButton.onClick.AddListener(Output);
    }
    
    IEnumerable<Type> GetDerivedTypes(Type baseType, Assembly assembly)
    {
        return assembly.GetTypes().Where(type => type.IsSubclassOf(baseType));
    }

    private void Output()
    {
        var numsLength = long.Parse(inputField.text);
        for (long i = 0; i < numsLength; i++)
        {
            var x = Random.Range(0,1000000);
            nums.Add(x);
        }
        
        tmpText.text = $"SortNumLength:{numsLength}\n";
        
        foreach (var derivedType in derivedTypes)
        {
            Sort instance = (Sort)Activator.CreateInstance(derivedType);
            instance.SetNum(nums.ToArray());
            instance.SortTime();
            tmpText.text += $"{derivedType.Name}————{instance.needTime}\n";
        }
        
        // var bubble = new BubbleSort(nums.ToArray());
        // bubble.SortTime();
        // tmpText.text += $"BubbleSort————{bubble.needTime}\n";
        //
        // var selection = new SelectionSort(nums.ToArray());
        // selection.SortTime();
        // tmpText.text += $"SelectionSort————{selection.needTime}\n";
        //
        // var insertion = new InsertionSort(nums.ToArray());
        // insertion.SortTime();
        // tmpText.text += $"InsertionSort————{insertion.needTime}\n";
        //
        // var radix = new RadixSort(nums.ToArray());
        // radix.SortTime();
        // tmpText.text += $"RadixSort———{radix.needTime}\n";
        //
        // var heap = new HeapSort(nums.ToArray());
        // heap.SortTime();
        // tmpText.text += $"HeapSort————{heap.needTime}\n";
        //
        // var quick = new QuickSort(nums.ToArray());
        // quick.SortTime();
        // tmpText.text += $"QuickSort————{quick.needTime}\n";
        //
        // var merge = new MergeSort(nums.ToArray());
        // merge.SortTime();
        // tmpText.text += $"MergeSort————{merge.needTime}\n";
        //
        // var shell = new ShellSort(nums.ToArray());
        // shell.SortTime();
        // tmpText.text += $"ShellSort————{shell.needTime}\n";
    }
}