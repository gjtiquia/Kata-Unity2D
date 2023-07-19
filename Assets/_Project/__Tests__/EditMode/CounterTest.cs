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
        public void StartsWithZero()
        {
            Counter counter = new Counter();
            int count = counter.GetCount();
            Assert.That(count, Is.EqualTo(0));
        }

        [Test]
        public void CanIncrement()
        {
            Counter counter = new Counter();
            counter.Increment();

            int count = counter.GetCount();
            Assert.That(count, Is.EqualTo(1));
        }

        [Test]
        public void CanDecrement()
        {
            Counter counter = new Counter();
            counter.Decrement();

            int count = counter.GetCount();
            Assert.That(count, Is.EqualTo(-1));
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

