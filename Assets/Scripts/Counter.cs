using System;
using System.Collections;
using UnityEngine;

public class Counter : MonoBehaviour
{
    public event Action<int> ValueChanged;

    [SerializeField] private int _value;
    private float _delay = 0.5f;
    private Coroutine _coroutine;
    private bool _isRunning;

    private void OnMouseDown()
    {
        if (_isRunning && _coroutine != null)
        {
            _isRunning = false;
            StopCoroutine(_coroutine);
        }
        else
        {
            _isRunning = true;
            _coroutine = StartCoroutine(Count());
        }
    }

    private IEnumerator Count()
    {
        WaitForSeconds wait = new WaitForSeconds(_delay);

        while (_isRunning)
        {
            _value++;
            ValueChanged?.Invoke(_value);
            
            yield return wait;
        }
    }
}