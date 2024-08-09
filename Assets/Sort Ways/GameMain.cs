using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Cysharp.Threading.Tasks;
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
        sortButton.onClick.AddListener((() =>
        {
            Output().Forget();
        }));
    }
    
    IEnumerable<Type> GetDerivedTypes(Type baseType, Assembly assembly)
    {
        return assembly.GetTypes().Where(type => type.IsSubclassOf(baseType));
    }

    private async UniTask Output()
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
            await instance.SortTime();
            tmpText.text += $"{derivedType.Name}————{instance.needTime}\n";
        }
        
    }
}