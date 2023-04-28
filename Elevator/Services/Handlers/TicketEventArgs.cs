namespace Elevator.Services.Handlers
{
    public class TicketEventArgs : EventArgs
    {
        public int CallLevel { get; set; }
    }
}
