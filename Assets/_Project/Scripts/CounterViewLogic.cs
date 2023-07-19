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
            InitCounter();
            InitListeners();
            InitCountText();
        }

        private void InitCounter()
        {
            _counter = new Counter();
        }

        private void InitListeners()
        {
            _counter.OnCountChange += SetCountText;
            _incrementButton.onClick.AddListener(IncrementOnClick);
            _decrementButton.onClick.AddListener(DecrementOnClick);
        }

        private void InitCountText()
        {
            SetCountText(_counter.GetCount());
        }

        private void IncrementOnClick()
        {
            _counter.Increment();
        }

        private void DecrementOnClick()
        {
            _counter.Decrement();
        }

        private void SetCountText(int count)
        {
            _countText.text = count.ToString();
        }
    }
}

