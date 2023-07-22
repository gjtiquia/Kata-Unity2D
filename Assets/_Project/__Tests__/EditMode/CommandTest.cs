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

        [Test]
        public void PlayerReturnsToStartingPositionAfterUndoUpCommand()
        {
            // Given
            Player player = new Player(Vector2.zero);

            // When
            player.ExecuteCommand(new UpCommand(player));
            player.UndoCommand();

            // Then
            Assert.That(player.Position, Is.EqualTo(Vector2.zero));
        }

        [Test]
        public void UpCommandCanTriggerPositionChangedEvent()
        {
            // Given
            Vector2 externalPosition = Vector2.zero;
            Player player = new Player(externalPosition);

            // When
            player.OnPositionChangedEvent += (newPosition) => externalPosition = newPosition;
            player.ExecuteCommand(new UpCommand(player));

            // Then
            Assert.That(externalPosition, Is.EqualTo(new Vector2(0, 1)));
        }
    }
}

