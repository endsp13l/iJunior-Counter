using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class CounterView : MonoBehaviour
{
   [SerializeField] private TextMeshPro _text;
   [SerializeField] private Counter _counter;
   
   private void Awake()
   {
      _text = GetComponentInChildren<TextMeshPro>();
      //_counter = GetComponentInParent<Counter>();
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