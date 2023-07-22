using UnityEngine;

namespace Kata.Core.Commands
{
    public class DownCommand : ICommand
    {
        private Player _player;

        public DownCommand(Player player)
        {
            _player = player;
        }

        public void Execute()
        {
            Vector2 currentPosition = _player.Position;
            _player.SetPosition(currentPosition + Vector2.down);
        }

        public void Undo()
        {
            Vector2 currentPosition = _player.Position;
            _player.SetPosition(currentPosition - Vector2.down);
        }
    }
}