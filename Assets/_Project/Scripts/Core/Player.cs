using UnityEngine;

namespace Kata.Core
{
    public class Player
    {
        public Vector2 Position => _position;
        private Vector2 _position;

        public Player(Vector2 startingPosition)
        {
            _position = startingPosition;
        }

        public void ExecuteCommand(ICommand command)
        {
            command.Execute();
        }

        public void SetPosition(Vector2 position)
        {
            _position = position;
        }
    }
}