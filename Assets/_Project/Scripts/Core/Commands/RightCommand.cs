using UnityEngine;

namespace Kata.Core.Commands
{
    public class RightCommand : ICommand
    {
        private Player _player;

        public RightCommand(Player player)
        {
            _player = player;
        }

        public void Execute()
        {
            Vector2 currentPosition = _player.Position;
            _player.SetPosition(currentPosition + Vector2.right);
        }

        public void Undo()
        {
            Vector2 currentPosition = _player.Position;
            _player.SetPosition(currentPosition - Vector2.right);
        }
    }
}