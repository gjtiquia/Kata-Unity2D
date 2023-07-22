using UnityEngine;

namespace Kata.Core.Commands
{
    public class LeftCommand : ICommand
    {
        private Player _player;

        public LeftCommand(Player player)
        {
            _player = player;
        }

        public void Execute()
        {
            Vector2 currentPosition = _player.Position;
            _player.SetPosition(currentPosition + Vector2.left);
        }

        public void Undo()
        {
            Vector2 currentPosition = _player.Position;
            _player.SetPosition(currentPosition - Vector2.left);
        }
    }
}