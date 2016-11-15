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
    public partial class RunLine : UserControl
    {
        public Drive Drive { get; set; }
        public float Speed { get; set; }
        public float Acceleration { get { return (float)length.Value / 1000; } set { length.Value = (decimal)value * 1000; } }

        public RunLine()
        {
            InitializeComponent();

        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            Drive.RunLine((float)(length.Value/1000), Speed, Acceleration);
        }

        private void buttonPosNeg_Click(object sender, EventArgs e)
        {
            length.Value = length.Value * -1;
        }
    }
}
