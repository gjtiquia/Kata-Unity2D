using System;
using UnityEngine;

public class Counter
{
    public event Action<int> OnCountChanged;

    public int Value
    {
        get => m_Value;
        set
        {
            m_Value = value;
            OnCountChanged?.Invoke(m_Value);
        }
    }
    private int m_Value;

    public void Increment()
    {
        Value++;
    }

    public void Decrement()
    {
        Value--;
    }
}