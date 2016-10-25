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
    public partial class SwitchView : UserControl
    {
        private bool state = false;
        private Switch swi;

        public SwitchView()
        {
            InitializeComponent();
            State = false;
        }

        public bool State
        {
            get { return state; }
            set
            {
                state = value;
                pictureBox.Image = (value ? Resources.SwitchOn : Resources.SwitchOff);
            }

        }

        /// <summary>
        /// Liefert bzw. setzt das Switch-Objekt (Model).
        /// Die SwitchView registriert sich beim Model und wird so über Änderungen per Event informiert.
        /// </summary>
        public Switch Switch
        {
            get { return swi; }
            set
            {
                // Falls bereits ein Eventhandler registriert war => diesen zuerst beim alten Led-Objekt entfernen
                if (swi != null) swi.SwitchStateChanged -= SwitchStateChanged;

                // Handler beim Led-Objekt (Model) registrieren.
                swi = value;
                if (swi != null) this.swi.SwitchStateChanged += SwitchStateChanged;
            }
        }

        #region methods
        /// <summary>
        /// Diese Methode wir aufgerufen, wenn sich im Model der Zustand des Schalters verändert. Somit
        /// kann die View den aktuellen Zustand darstellen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SwitchStateChanged(object sender, SwitchEventArgs e)
        {
            if (InvokeRequired)
            {
                Invoke(new EventHandler<SwitchEventArgs>(SwitchStateChanged),
                    sender, e);
            }
            else State = e.SwitchEnabled;

        }
        #endregion
    }
}