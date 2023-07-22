using System.Collections.Generic;
using UnityEngine;

namespace Kata.Core
{
    public class Player
    {
        // PUBLIC MEMBERS
        public Vector2 Position => _position;

        // PRIVATE MEMBERS
        private Vector2 _position;
        private Stack<ICommand> _executedCommands;

        // CONSTRUCTOR
        public Player(Vector2 startingPosition)
        {
            _position = startingPosition;
            _executedCommands = new Stack<ICommand>();
        }

        // PUBLIC METHODS
        public void ExecuteCommand(ICommand command)
        {
            command.Execute();
            _executedCommands.Push(command);
        }

        public void UndoCommand()
        {
            bool hasAtLeastOneExecutedCommand = _executedCommands.TryPop(out ICommand command);

            if (hasAtLeastOneExecutedCommand)
                command.Undo();
        }

        public void SetPosition(Vector2 position)
        {
            _position = position;
        }
    }
}