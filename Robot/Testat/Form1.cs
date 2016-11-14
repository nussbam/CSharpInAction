using RobotCtrl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Testat
{
    public partial class Form1 : Form
    {
        private Drive drive;
        private RobotConsole rc;
        public Form1()
        {
            InitializeComponent();

            // init robot console
            rc = new RobotConsole();
            console.RobotConsole = rc;
            (rc[Switches.Switch1]).SwitchStateChanged += (o, e) => (rc[Leds.Led1]).LedEnabled = (rc[Switches.Switch1]).SwitchEnabled;
            (rc[Switches.Switch2]).SwitchStateChanged += (o, e) => (rc[Leds.Led2]).LedEnabled = (rc[Switches.Switch2]).SwitchEnabled;
            (rc[Switches.Switch3]).SwitchStateChanged += (o, e) => (rc[Leds.Led3]).LedEnabled = (rc[Switches.Switch3]).SwitchEnabled;
            (rc[Switches.Switch4]).SwitchStateChanged += (o, e) => (rc[Leds.Led4]).LedEnabled = (rc[Switches.Switch4]).SwitchEnabled;


            // init drive
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
