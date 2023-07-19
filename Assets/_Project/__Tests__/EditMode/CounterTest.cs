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
        Counter _counterUnderTest;

        [SetUp]
        public void SetupBeforeEveryTest()
        {
            _counterUnderTest = new Counter();
        }

        [Test]
        public void StartsWithZero()
        {
            int startingCount = _counterUnderTest.GetCount();
            Assert.That(startingCount, Is.EqualTo(0));
        }

        [Test]
        public void CanIncrement()
        {
            _counterUnderTest.Increment();

            int count = _counterUnderTest.GetCount();
            Assert.That(count, Is.EqualTo(1));
        }

        [Test]
        public void CanDecrement()
        {
            _counterUnderTest.Decrement();

            int count = _counterUnderTest.GetCount();
            Assert.That(count, Is.EqualTo(-1));
        }

        [Test]
        public void ShouldUpdateExternalCount()
        {
            // Given
            int externalCount = 0;
            _counterUnderTest.OnCountChange += (newCount) => externalCount = newCount;

            // When
            _counterUnderTest.Increment();

            // Then
            Assert.That(externalCount, Is.EqualTo(1));
        }
    }
}

