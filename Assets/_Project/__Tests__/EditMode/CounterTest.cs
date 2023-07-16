using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using Kata.Core;

public class CounterTest
{
    private Counter _counterUnderTest = null;

    [SetUp]
    public void SetUp()
    {
        _counterUnderTest = new Counter();
    }

    [Test]
    public void CounterIsNotNull()
    {
        Assert.That(_counterUnderTest, Is.Not.Null);
    }

    [Test]
    public void CounterStartsWithZero()
    {
        int count = _counterUnderTest.GetCount();
        Assert.That(count, Is.EqualTo(0));
    }

    [Test]
    public void CounterCanIncrementOnce()
    {
        _counterUnderTest.Increment();

        int count = _counterUnderTest.GetCount();
        Assert.That(count, Is.EqualTo(1));
    }

    [Test]
    public void CounterCanIncrementTwice()
    {
        _counterUnderTest.Increment();
        _counterUnderTest.Increment();

        int count = _counterUnderTest.GetCount();
        Assert.That(count, Is.EqualTo(2));
    }

    [Test]
    public void CounterCanDecrement()
    {
        _counterUnderTest.Decrement();

        int count = _counterUnderTest.GetCount();
        Assert.That(count, Is.EqualTo(-1));
    }

    [Test]
    public void CounterCanIncrementThenDecrement()
    {
        _counterUnderTest.Increment();
        _counterUnderTest.Increment();
        _counterUnderTest.Increment();
        _counterUnderTest.Decrement();
        _counterUnderTest.Decrement();

        int count = _counterUnderTest.GetCount();
        Assert.That(count, Is.EqualTo(1));
    }

    [Test]
    public void OnCountChangedShouldBeInvokedOnIncrement()
    {
        int subscribedCount = 0;
        _counterUnderTest.OnCountChanged += (newCount) => subscribedCount = newCount;

        _counterUnderTest.Increment();
        _counterUnderTest.Increment();

        Assert.That(subscribedCount, Is.EqualTo(2));
    }

    [Test]
    public void OnCountChangedShouldBeInvokedOnDecrement()
    {
        int subscribedCount = 0;
        _counterUnderTest.OnCountChanged += (newCount) => subscribedCount = newCount;

        _counterUnderTest.Decrement();
        _counterUnderTest.Decrement();

        Assert.That(subscribedCount, Is.EqualTo(-2));
    }
}
