using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Kata.Core;

namespace Kata
{
    public class CounterViewLogic : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _countText;
        [SerializeField] private Button _incrementButton;
        [SerializeField] private Button _decrementButton;

        private Counter _counter;

        private void Awake()
        {
            _counter = new Counter();
            _countText.text = _counter.GetCount().ToString();

            _incrementButton.onClick.AddListener(IncrementOnClick);
            _decrementButton.onClick.AddListener(DecrementOnClick);
        }

        private void IncrementOnClick()
        {
            Debug.Log("increment!");
            _counter.Increment();
        }

        private void DecrementOnClick()
        {
            Debug.Log("decrement!");
            _counter.Decrement();
        }
    }
}

