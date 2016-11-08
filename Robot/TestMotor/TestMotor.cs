using RobotCtrl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestMotor
{
    public partial class TestMotor : Form
    {
           
        public TestMotor()
        {
            InitializeComponent();
            driveCtrlView.DriveCtrl = new RobotCtrl.DriveCtrl(RobotCtrl.Constants.IODriveCtrl);
            motorCtrlViewLeft.MotorCtrl = new RobotCtrl.MotorCtrl(RobotCtrl.Constants.IOMotorCtrlLeft);
            motorCtrlViewRight.MotorCtrl = new RobotCtrl.MotorCtrl(RobotCtrl.Constants.IOMotorCtrlRight);
        }

        private void driveCtrlView_Click(object sender, EventArgs e)
        {

        }
    }
}
