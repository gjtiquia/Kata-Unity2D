using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Kata.Core;

namespace Kata
{
    public class GameManager : MonoBehaviour
    {
        [SerializeField] TextMeshProUGUI _counterText;

        private Counter _counter;

        private void Awake()
        {
            _counter = new Counter();
        }

        void Start()
        {
            _counterText.text = _counter.GetCount().ToString();
        }
    }
}

