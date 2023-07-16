using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Kata.Core;

namespace Kata
{
    public class GameManager : MonoBehaviour
    {
        [SerializeField] private Button _incrementButton;
        [SerializeField] private Button _decrementButton;
        [SerializeField] private TextMeshProUGUI _counterText;

        private Counter _counter;

        private void Awake()
        {
            _counter = new Counter();
        }

        private void OnDestroy()
        {
            _counter.OnCountChanged -= (_) => SetCounterText();
        }

        private void Start()
        {
            SetCounterText();
            _counter.OnCountChanged += (_) => SetCounterText();

            _incrementButton.onClick.AddListener(() => _counter.Increment());
            _decrementButton.onClick.AddListener(() => _counter.Decrement());
        }

        private void SetCounterText()
        {
            _counterText.text = _counter.GetCount().ToString();
        }
    }
}

