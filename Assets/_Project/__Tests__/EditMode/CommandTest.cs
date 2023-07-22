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
        public void UpCommandCanMovePlayerUpwards()
        {
            // Given
            Player player = new Player(Vector2.zero);

            // When
            player.ExecuteCommand(new UpCommand(player));

            // Then
            Assert.That(player.Position, Is.EqualTo(new Vector2(0, 1)));
        }
    }
}

