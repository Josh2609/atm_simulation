using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ATM_simulation
{
    public partial class centralServ : Form
    {
        public centralServ()
        {
            InitializeComponent();
        }

        public static int currActTerminals = 0; // variable to store the current number of atm terminals running

        // event handler for the new terminal button
        private void btnNewTerminal_Click(object sender, EventArgs e)
        {
            currActTerminals++; // increment current terminals variable
            lblCurrActTerm.Text = "Current Active Terminals: " + currActTerminals; // update the ui with number of terminals
            Program.newATM(); // call a newATM method in the Program class
        }

        private static int dataRaceFix = 0; // variable to store the current selected choice for data race fix

        // method to return the value of the data race fix option
        public static int getDataRaceFixState()
        {
            return dataRaceFix;
        }

        // event handler for the close terminals button
        private void btnCloseTerminals_Click(object sender, EventArgs e)
        {
            Application.Exit(); // closes the application
        }

        // event handler for the tick of the timer
        private void currentTimer_Tick(object sender, EventArgs e)
        {
            lblCurrTime.Text = DateTime.Now.ToString("h:mm:ss tt"); // display the current time in the timer label
            lblCurrActTerm.Text = "Current Active Terminals: " + currActTerminals; // update the active terminals label
        }

        // event handler for when the form loads
        private void centralServ_Load(object sender, EventArgs e)
        {
            // set maximum and minimum size of the form
            this.MaximumSize = new Size(395, 408);
            this.MinimumSize = new Size(385, 408);

            lblCurrTime.Location = new Point(278,20);

            btnNewTerminal.Location = new Point(10, 144); btnNewTerminal.Size = new Size(107, 32);
            btnCloseTerminals.Location = new Point(244, 144); btnCloseTerminals.Size = new Size(107, 32);

            lblCurrActTerm.Location = new Point(9, 271);

            rbDataRace.Location = new Point(136,192);
            rbLock.Location = new Point(136,214);
            rbSemaphore.Location = new Point(136, 236);

            this.ControlBox = false; // removes the close, minimize and maximize button from the form
            System.Windows.Forms.Timer currentTimer = new System.Windows.Forms.Timer(); // create a new timer
            currentTimer.Interval = 1000; // set the timer interval to 1 second
            currentTimer.Tick += new EventHandler(currentTimer_Tick); // create an event handler for the timer tick
            currentTimer.Start(); // start the timer
        }

        // event handlers to set the value of dataRaceFix based on which radio button is selected
        private void rbDataRace_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDataRace.Checked == true)
            {
                dataRaceFix = 0;
            }
        }
        private void rbLock_CheckedChanged(object sender, EventArgs e)
        {
            if (rbLock.Checked == true)
            {
                dataRaceFix = 1;
            }
        }
        private void rbSemaphore_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSemaphore.Checked == true)
            {
                dataRaceFix = 2;
            }
        }
    }
}
