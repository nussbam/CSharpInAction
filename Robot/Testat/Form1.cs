using System;
using System.Windows.Forms;
using RobotCtrl;

namespace Testat
{
    public partial class Form1 : Form
    {
        private RobotConsole rc;

        public Form1()
        {
            InitializeComponent();

            InitConsole();

            // init drive
            commonRunParameters.SpeedChanged += SpeedChanged;
            commonRunParameters.AccelerationChanged += AccelerationChanged;

            var drive = new Drive {Power = true};
            runLine.Drive = drive;
            runTurn.Drive = drive;
            runArc.Drive = drive;

            SpeedChanged(null, EventArgs.Empty);
            AccelerationChanged(null, EventArgs.Empty);
        }

        private void AccelerationChanged(object sender, EventArgs e)
        {
            runLine.Acceleration = commonRunParameters.Acceleration;
            runTurn.Acceleration = commonRunParameters.Acceleration;
            runArc.Acceleration = commonRunParameters.Acceleration;
        }

        private void SpeedChanged(object sender, EventArgs e)
        {
            runLine.Speed = commonRunParameters.Speed;
            runTurn.Speed = commonRunParameters.Speed;
            runArc.Speed = commonRunParameters.Speed;
        }

        private void InitConsole()
        {
            rc = new RobotConsole();
            console.RobotConsole = rc;
            rc[Switches.Switch1].SwitchStateChanged +=
                (_, __) => rc[Leds.Led1].LedEnabled = rc[Switches.Switch1].SwitchEnabled;
            rc[Switches.Switch2].SwitchStateChanged +=
                (_, __) => rc[Leds.Led2].LedEnabled = rc[Switches.Switch2].SwitchEnabled;
            rc[Switches.Switch3].SwitchStateChanged +=
                (_, __) => rc[Leds.Led3].LedEnabled = rc[Switches.Switch3].SwitchEnabled;
            rc[Switches.Switch4].SwitchStateChanged +=
                (_, __) => rc[Leds.Led4].LedEnabled = rc[Switches.Switch4].SwitchEnabled;
        }
    }
}