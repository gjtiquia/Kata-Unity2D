using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class CounterViewLogic : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _countText;
    [SerializeField] private Button _incrementButton;
    [SerializeField] private Button _decrementButton;

    private void Awake()
    {
        _countText.text = "0";
        _incrementButton.onClick.AddListener(IncrementOnClick);
        _decrementButton.onClick.AddListener(DecrementOnClick);
    }

    private void IncrementOnClick()
    {
        Debug.Log("increment!");
    }

    private void DecrementOnClick()
    {
        Debug.Log("decrement!");
    }
}
