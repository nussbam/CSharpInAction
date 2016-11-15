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
    public partial class RunArc : UserControl
    {
        public Drive Drive { get; set; }
        public float Speed { get { return (float) angle.Value / 1000; } set { angle.Value = (decimal)value * 1000;} }
        public float Acceleration { get { return (float)radius.Value / 1000; } set { radius.Value = (decimal)value * 1000; }}

        public RunArc()
        {
            InitializeComponent();
        }

        private void buttonPosNeg_Click(object sender, EventArgs e)
        {
            angle.Value = angle.Value * -1;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if(radioButtonLeft.Checked){
                Drive.RunArcLeft((float)radius.Value/1000, (float)angle.Value, Speed, Acceleration);
            }
            else if(radioButtonRight.Checked) {
                Drive.RunArcRight((float)radius.Value/1000, (float)angle.Value, Speed, Acceleration);
            }
        }
    }
}
