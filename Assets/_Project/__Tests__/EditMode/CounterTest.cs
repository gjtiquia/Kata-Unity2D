using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using Kata.Core;

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

        [Test]
        public void ShouldUpdateExternalCount()
        {
            Counter counter = new Counter();
            int externalCount = 0;

            counter.OnCountChange += (newCount) => externalCount = newCount;

            counter.Increment();

            Assert.That(externalCount, Is.EqualTo(1));
        }
    }
}

