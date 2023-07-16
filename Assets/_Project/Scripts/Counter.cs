namespace Kata
{
    public class Counter
    {
        private int _count;

        public Counter()
        {
            _count = 0;
        }

        public int GetCount()
        {
            return _count;
        }

        public void Increment()
        {
            _count++;
        }

        public void Decrement()
        {
            _count--;
        }
    }
}
