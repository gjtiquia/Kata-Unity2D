using UnityEngine;

namespace Kata.Core
{
    public class UpCommand : ICommand
    {
        private Player _player;

        public UpCommand(Player player)
        {
            _player = player;
        }

        public void Execute()
        {
            Vector2 currentPosition = _player.Position;
            _player.SetPosition(currentPosition + Vector2.up);
        }

        public void Undo()
        {
            Vector2 currentPosition = _player.Position;
            _player.SetPosition(currentPosition - Vector2.up);
        }
    }
}