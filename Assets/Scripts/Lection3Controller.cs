using System.Collections.Generic;
using UnityEngine;

public class LectureScript : MonoBehaviour {
    [SerializeField] private List<int> _numbers = new List<int>();

    [SerializeField] private int _value = 0;

    [ContextMenu("Add")]
    private void Add()
    {
        _numbers.Add(_value);
        _value = 0;
    }

    [ContextMenu("Remove")]
    private void Remove()
    {
        _numbers.Remove(_value);
        _value = 0;
    }

    [ContextMenu("Sort")]
    private void Sort()
    {
        _numbers.Sort();
    }


    [ContextMenu("Clear")]
    private void Clear()
    {
        _numbers.Clear();
    }

    [ContextMenu("Print")]
    private void Print()
    {
        if (_numbers.Count == 0) return;

        string result = "\n";
        string separator = ", ";

        for (int i = 0; i < _numbers.Count - 1; i++) {
            result += $"{_numbers[i]}{separator}";
        }

        separator = ".";

        result += $"{_numbers[^1]}{separator}";

        Debug.Log(result);
    }
}
