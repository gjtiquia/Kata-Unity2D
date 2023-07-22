using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using Kata.Core;
using Kata.Core.Commands;

namespace Kata.Tests
{
    public class CommandTest
    {
        readonly Vector2 STARTING_POSITION = Vector2.zero;
        Player player;

        [SetUp]
        public void SetupBeforeEveryTest()
        {
            player = new Player(STARTING_POSITION);
        }

        public class UpCommandTests : CommandTest
        {
            [Test]
            public void UpCommandCanMovePlayerUpwards()
            {
                player.ExecuteCommand(new UpCommand(player));
                Assert.That(player.Position, Is.EqualTo(new Vector2(0, 1)));
            }

            [Test]
            public void PlayerReturnsToStartingPositionAfterUndoUpCommand()
            {
                player.ExecuteCommand(new UpCommand(player));
                player.UndoCommand();
                Assert.That(player.Position, Is.EqualTo(STARTING_POSITION));
            }

            [Test]
            public void UpCommandCanTriggerPositionChangedEvent()
            {
                Vector2 externalPosition = STARTING_POSITION;
                player.OnPositionChangedEvent += (newPosition) => externalPosition = newPosition;

                player.ExecuteCommand(new UpCommand(player));
                Assert.That(externalPosition, Is.EqualTo(new Vector2(0, 1)));
            }
        }

        public class DownCommandTests : CommandTest
        {
            [Test]
            public void DownCommandCanMovePlayerDownwards()
            {
                player.ExecuteCommand(new DownCommand(player));
                Assert.That(player.Position, Is.EqualTo(new Vector2(0, -1)));
            }

            [Test]
            public void PlayerReturnsToStartingPositionAfterUndoDownCommand()
            {
                player.ExecuteCommand(new DownCommand(player));
                player.UndoCommand();
                Assert.That(player.Position, Is.EqualTo(STARTING_POSITION));
            }
        }

        public class LeftCommandTests : CommandTest
        {
            [Test]
            public void LeftCommandCanMovePlayerLeftwards()
            {
                player.ExecuteCommand(new LeftCommand(player));
                Assert.That(player.Position, Is.EqualTo(new Vector2(-1, 0)));
            }

            [Test]
            public void PlayerReturnsToStartingPositionAfterUndoLeftCommand()
            {
                player.ExecuteCommand(new LeftCommand(player));
                player.UndoCommand();
                Assert.That(player.Position, Is.EqualTo(STARTING_POSITION));
            }
        }

        public class RightCommandTests : CommandTest
        {
            [Test]
            public void RightCommandCanMovePlayerRightwards()
            {
                player.ExecuteCommand(new RightCommand(player));
                Assert.That(player.Position, Is.EqualTo(new Vector2(1, 0)));
            }

            [Test]
            public void PlayerReturnsToStartingPositionAfterUndoRightCommand()
            {
                player.ExecuteCommand(new RightCommand(player));
                player.UndoCommand();
                Assert.That(player.Position, Is.EqualTo(STARTING_POSITION));
            }
        }
    }
}

