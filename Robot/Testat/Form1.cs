using System;
using System.Windows.Forms;
using RobotCtrl;

namespace Testat
{
    public partial class Form1 : Form
    {
        private RobotConsole rc;
        private Drive drive;

        public Form1()
        {
            InitializeComponent();

            InitConsole();

            // init drive
            commonRunParameters.SpeedChanged += SpeedChanged;
            commonRunParameters.AccelerationChanged += AccelerationChanged;

            drive = new Drive {Power = true};
            driveView.Drive = drive;
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

        private void button1_Click(object sender, EventArgs e) {
            drive.Halt();
        }

        private void btnStop_Click(object sender, EventArgs e) {
            drive.Stop();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            NumKeyboard nk = new NumKeyboard();
            if (nk.ShowDialog() == DialogResult.OK)
            {
                commonRunParameters.Speed = (float) nk.getWert() / 1000; //Speed
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NumKeyboard nk = new NumKeyboard();
            if (nk.ShowDialog() == DialogResult.OK)
            {
                commonRunParameters.Acceleration = (float) nk.getWert() / 1000; //Acceleration
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NumKeyboard nk = new NumKeyboard();
            if (nk.ShowDialog() == DialogResult.OK)
            {
                runArc.Acceleration = (float) nk.getWert() / 1000; //Radius
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            NumKeyboard nk = new NumKeyboard();
            if (nk.ShowDialog() == DialogResult.OK)
            {
                runArc.Speed = (float) nk.getWert() / 1000; //AngelRunArc
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            NumKeyboard nk = new NumKeyboard();
            if (nk.ShowDialog() == DialogResult.OK)
            {
                runTurn.Speed = (float) nk.getWert() / 1000; //AngelRunTurn
            }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            NumKeyboard nk = new NumKeyboard();
            if (nk.ShowDialog() == DialogResult.OK)
            {
                runLine.Acceleration = (float) nk.getWert() / 1000; //LengthRunLine
            }
        }
    }
}