using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using RobotCtrl;

namespace RobotView
{
    public partial class ConsoleView : UserControl
    {
        private RobotConsole robotConsole;

        public ConsoleView()
        {
            SwitchView switchView0 = new SwitchView();
            InitializeComponent();
            
        }

        #region properties
        /// <summary>
        /// Liefert bzw. setzt das Konsolenobjekt.
        /// Sobald ein Konsolenobjekt gesetzt wird, werden die Led's und Schalter damit verknüpft.
        /// </summary>
        public RobotConsole RobotConsole
        {
            get { return robotConsole; }
            set
            {
                robotConsole = value;

                if (robotConsole != null)
                {
                    // jeder LedView die entsprechende Led zuweisen
                    ledView0.Led = robotConsole[Leds.Led1];
                    ledView1.Led = robotConsole[Leds.Led2];
                    ledView2.Led = robotConsole[Leds.Led3];
                    ledView3.Led = robotConsole[Leds.Led4];

                    // jeder SwitchView den entsprechenden Schalter zuweisen
                    switchView0.Switch = robotConsole[Switches.Switch1];
                    switchView1.Switch = robotConsole[Switches.Switch2];
                    switchView2.Switch = robotConsole[Switches.Switch3];
                    switchView3.Switch = robotConsole[Switches.Switch4];
                    
                }
            }
        }
        #endregion
    }
}