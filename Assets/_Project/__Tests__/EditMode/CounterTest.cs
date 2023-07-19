using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Kata.Tests
{
    public class CounterTest
    {
        [Test]
        public void CounterStartsWithZero()
        {
            Counter counter = new Counter();
            int count = counter.GetCount();
            Assert.That(count, Is.EqualTo(0));
        }
    }

    public class Counter
    {
        private int _count;

        public Counter()
        {
            _count = 0;
        }

        public int GetCount()
        {
            return _count;
        }
    }
}

