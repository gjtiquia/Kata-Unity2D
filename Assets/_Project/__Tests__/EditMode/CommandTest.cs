using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using Kata.Core;

namespace Kata.Tests
{
    public class CommandTest
    {
        [Test]
        public void CommandTestSimplePasses()
        {
            Assert.That(false, Is.EqualTo(true));
        }

        public class TestCommand : ICommand
        {
            public void Execute()
            {

            }

            public void Undo()
            {

            }
        }
    }
}

