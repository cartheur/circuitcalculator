using System;
using System.Windows.Forms;

namespace CircuitCalculator
{
    /// <summary>
    /// Simulates the constant pressing of a button on a WinForm.
    /// </summary>
    public class RepeatButton : Button
    {
        public Timer timer = new Timer();

        public RepeatButton()
        {
            MouseUp += RepeatButton_MouseUp;
            MouseDown += RepeatButton_MouseDown;
            timer.Tick += OnTimer;
            timer.Enabled = false;
        }
        /// <summary>
        /// Gets or sets the timer interval.
        /// </summary>
        public int Interval { get { return timer.Interval; } set { timer.Interval = value; } }

        private void OnTimer(object sender, EventArgs e)
        {
            // Fire off a click on each timer tick.
            OnClick(EventArgs.Empty);
        }

        private void RepeatButton_MouseDown(object sender, MouseEventArgs e)
        {
            // Turn on the timer.
            timer.Enabled = true;
        }

        private void RepeatButton_MouseUp(object sender, MouseEventArgs e)
        {
            // Turn off the timer.
            timer.Enabled = false;
        }
    }
}
