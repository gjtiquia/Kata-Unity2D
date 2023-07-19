using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Kata.Core
{
    public class Counter
    {
        public event Action<int> OnCountChange;

        private int _count
        {
            get => m_count;
            set
            {
                m_count = value;
                OnCountChange?.Invoke(m_count);
            }
        }
        private int m_count;

        public Counter()
        {
            _count = 0;
        }

        public int GetCount()
        {
            return _count;
        }

        public void Increment()
        {
            _count++;
        }

        public void Decrement()
        {
            _count--;
        }
    }
}

