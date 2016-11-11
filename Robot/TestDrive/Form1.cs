using RobotCtrl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestDrive
{
    public partial class Form1 : Form
    {
        Drive drive;
        public Form1()
        {
            InitializeComponent();
            commonRunParameters.SpeedChanged += new EventHandler(SpeedChanged);
            commonRunParameters.AccelerationChanged += new EventHandler(AccelerationChanged);

            drive = new Drive();
            drive.Power = true;
            runLine.Drive = drive;
            runTurn.Drive = drive;
            runArc.Drive = drive;

            SpeedChanged(null, EventArgs.Empty);
            AccelerationChanged(null, EventArgs.Empty);
        }

        void AccelerationChanged(object sender, EventArgs e)
        {
            runLine.Acceleration = commonRunParameters.Acceleration;
            runTurn.Acceleration = commonRunParameters.Acceleration;
            runArc.Acceleration = commonRunParameters.Acceleration;
        }

        void SpeedChanged(object sender, EventArgs e)
        {
            runLine.Speed = commonRunParameters.Speed;
            runTurn.Speed = commonRunParameters.Speed;
            runArc.Speed = commonRunParameters.Speed;
        }


    }
}
