using Elevator.Models;
using Elevator.Services;

namespace Elevator
{
    public partial class Form1 : Form
    {
        private LiftService _liftService;

        public Form1()
        {
            InitializeComponent();
            var lift = new Lift(tableLayoutPanel1.RowCount, 4);
            _liftService = new LiftService(lift);
            _liftService.OnAddTicketHandler += MoveLift;
        }

        private async void buttonDown_Click(object sender, EventArgs e)
        {
            var callLevel = tableLayoutPanel1.GetRow((Button)sender);

            await _liftService.AddTicketAsync(callLevel);
        }

        private async void buttonUp_Click(object sender, EventArgs e)
        {
            var callLevel = tableLayoutPanel1.GetRow((Button)sender);

            await _liftService.AddTicketAsync(callLevel);
        }

        private void MoveLift(object sender, EventArgs e)
        {
            int callLevel = ((TicketEventArgs)e).CallLevel;
            var liftLevel = tableLayoutPanel1.GetRow(label1);

            if (callLevel < liftLevel)
                ShiftControlVerticaly(liftLevel, callLevel, true);
            else
                ShiftControlVerticaly(liftLevel, callLevel);
        }

        private void ShiftControlVerticaly(int startRow, int finishRow, bool shiftUp = false)
        {
            while (startRow != finishRow)
            {
                tableLayoutPanel1.Controls.Remove(label1);
                startRow = shiftUp ? startRow - 1 : startRow + 1;
                tableLayoutPanel1.Controls.Add(label1, 1, startRow);
                tableLayoutPanel1.Refresh();

                Thread.Sleep(500);
            }
        }
    }
}