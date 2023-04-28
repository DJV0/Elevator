namespace Elevator.Models
{
    public class Lift
    {
        public int Capacity { get; }
        public int Count { get; private set; }
        public int Level { get; private set; }
        public int MaxLevel { get; }

        public Lift(int maxLevel, int capacity)
        {
            MaxLevel = maxLevel;
            Capacity = capacity;
            Level = 1;
        }

        public bool MoveUp()
        {
            if (Level < MaxLevel && Count <= Capacity)
            {
                Level++;
                return true;
            }

            return false;
        }

        public bool MoveDown()
        {
            if(Level > 1 && Count <= Capacity)
            {
                Level--;
                return true;
            }

            return false;
        }

        public void ChangeCount(int count)
        {
            if (count < 0 || count > Capacity)
                return;

            Count = count;
        }
    }
}
