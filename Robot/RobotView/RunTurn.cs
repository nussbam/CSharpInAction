using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using RobotCtrl;

namespace RobotView
{
    public partial class RunTurn : UserControl
    {
        public Drive Drive { get; set; }
        public float Speed { get; set; }
        public float Acceleration { get; set; }

        public RunTurn()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            Drive.RunTurn((float)angle.Value, Speed, Acceleration);
        }

        private void buttonPosNeg_Click(object sender, EventArgs e)
        {
            angle.Value = angle.Value * -1;
        }
    }
}
