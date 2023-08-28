using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class SampleTest
{
    protected Counter _counter;

    [SetUp]
    public void SetupBeforeEveryTest()
    {
        _counter = new Counter();
    }

    [Test]
    public void _0_CounterStartsWithZero()
    {
        Assert.That(_counter, Is.Not.Null);
        Assert.That(_counter.Value, Is.EqualTo(0));
    }

    [Test]
    public void _1_CounterCanIncrement()
    {
        _counter.Increment();
        Assert.That(_counter.Value, Is.EqualTo(1));
    }

    [Test]
    public void _2_CounterCanDecrement()
    {
        _counter.Decrement();
        Assert.That(_counter.Value, Is.EqualTo(-1));
    }
}
