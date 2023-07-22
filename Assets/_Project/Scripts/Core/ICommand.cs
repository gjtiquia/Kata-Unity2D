namespace Kata.Core
{
    public interface ICommand
    {
        public void Execute();
        public void Undo();
    }
}

