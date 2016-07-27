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
    public partial class start : Form
    {
        public start()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
           new Thread(() => new atmSim().ShowDialog()).Start();
          // Program.threadCounter++;
        }
    }
}
