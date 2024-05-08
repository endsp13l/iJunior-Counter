using UnityEngine;
using TMPro;

public class CounterView : MonoBehaviour
{
    private TMP_Text _text;
    private Counter _counter;

    private void Awake()
    {
        _text = GetComponentInChildren<TMP_Text>();
        _counter = GetComponent<Counter>();
    }

    private void OnEnable()
    {
        _counter.ValueChanged += SetValue;
    }

    private void OnDisable()
    {
        _counter.ValueChanged -= SetValue;
    }

    private void SetValue(int value)
    {
        _text.text = value.ToString();
    }
}