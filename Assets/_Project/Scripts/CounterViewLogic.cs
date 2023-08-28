using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CounterViewLogic : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _countText;
    [SerializeField] private Button _increment;
    [SerializeField] private Button _decrement;

    private Counter _counterLogic;

    private void Awake()
    {
        _counterLogic = new Counter();

        _countText.text = _counterLogic.Value.ToString();
        _counterLogic.OnCountChanged += (newValue) => _countText.text = newValue.ToString();

        _increment.onClick.AddListener(OnIncrementClick);
        _decrement.onClick.AddListener(OnDecrementClick);
    }

    private void OnIncrementClick()
    {
        _counterLogic.Increment();
    }

    private void OnDecrementClick()
    {
        _counterLogic.Decrement();
    }
}