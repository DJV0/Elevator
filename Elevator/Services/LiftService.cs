using Elevator.Models;

namespace Elevator.Services
{
    public class LiftService
    {
        public Lift Lift { get; }

        private Queue<int> ticketsQueue;

        public event EventHandler OnAddTicketHandler;

        public LiftService(Lift lift)
        {
            Lift = lift;
            ticketsQueue = new Queue<int>();
        }

        public async Task AddTicketAsync(int level)
        {
            ticketsQueue.Enqueue(level);

            /*
             * Implement separete service in order to manipulate lift motion. It should have a queue which describes the order of floors that a lift needs to visit.
             * Implement service that will be contained calculating logic of floors.
             */
        }
    }

    public class TicketEventArgs : EventArgs
    {
        public int CallLevel { get; set; }
    }
}
