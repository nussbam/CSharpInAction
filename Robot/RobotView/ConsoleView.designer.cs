namespace RobotView
{
    partial class ConsoleView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ledView0 = new RobotView.LedView();
            this.labelLed0 = new System.Windows.Forms.Label();
            this.ledView1 = new RobotView.LedView();
            this.labelLed1 = new System.Windows.Forms.Label();
            this.ledView2 = new RobotView.LedView();
            this.label1 = new System.Windows.Forms.Label();
            this.ledView3 = new RobotView.LedView();
            this.labelLed3 = new System.Windows.Forms.Label();
            this.switchView0 = new RobotView.SwitchView();
            this.switchView1 = new RobotView.SwitchView();
            this.switchView2 = new RobotView.SwitchView();
            this.switchView3 = new RobotView.SwitchView();
            this.SuspendLayout();
            // 
            // ledView0
            // 
            this.ledView0.Location = new System.Drawing.Point(0, 0);
            this.ledView0.Name = "ledView0";
            this.ledView0.Size = new System.Drawing.Size(20, 20);
            this.ledView0.State = false;
            this.ledView0.TabIndex = 0;
            // 
            // labelLed0
            // 
            this.labelLed0.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelLed0.Location = new System.Drawing.Point(0, 23);
            this.labelLed0.Name = "labelLed0";
            this.labelLed0.Size = new System.Drawing.Size(20, 35);
            this.labelLed0.Text = "0";
            // 
            // ledView1
            // 
            this.ledView1.Location = new System.Drawing.Point(26, 0);
            this.ledView1.Name = "ledView1";
            this.ledView1.Size = new System.Drawing.Size(20, 20);
            this.ledView1.State = false;
            this.ledView1.TabIndex = 2;
            // 
            // labelLed1
            // 
            this.labelLed1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelLed1.Location = new System.Drawing.Point(26, 23);
            this.labelLed1.Name = "labelLed1";
            this.labelLed1.Size = new System.Drawing.Size(20, 35);
            this.labelLed1.Text = "1";
            // 
            // ledView2
            // 
            this.ledView2.Location = new System.Drawing.Point(52, 0);
            this.ledView2.Name = "ledView2";
            this.ledView2.Size = new System.Drawing.Size(20, 18);
            this.ledView2.State = false;
            this.ledView2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(52, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 35);
            this.label1.Text = "2";
            // 
            // ledView3
            // 
            this.ledView3.Location = new System.Drawing.Point(78, 0);
            this.ledView3.Name = "ledView3";
            this.ledView3.Size = new System.Drawing.Size(20, 18);
            this.ledView3.State = false;
            this.ledView3.TabIndex = 8;
            // 
            // labelLed3
            // 
            this.labelLed3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelLed3.Location = new System.Drawing.Point(78, 23);
            this.labelLed3.Name = "labelLed3";
            this.labelLed3.Size = new System.Drawing.Size(20, 35);
            this.labelLed3.Text = "3";
            // 
            // switchView0
            // 
            this.switchView0.Location = new System.Drawing.Point(103, 0);
            this.switchView0.Name = "switchView0";
            this.switchView0.Size = new System.Drawing.Size(20, 40);
            this.switchView0.State = false;
            this.switchView0.TabIndex = 9;
            // 
            // switchView1
            // 
            this.switchView1.Location = new System.Drawing.Point(129, 0);
            this.switchView1.Name = "switchView1";
            this.switchView1.Size = new System.Drawing.Size(20, 40);
            this.switchView1.State = false;
            this.switchView1.TabIndex = 17;
            // 
            // switchView2
            // 
            this.switchView2.Location = new System.Drawing.Point(155, 0);
            this.switchView2.Name = "switchView2";
            this.switchView2.Size = new System.Drawing.Size(20, 40);
            this.switchView2.State = false;
            this.switchView2.TabIndex = 18;
            // 
            // switchView3
            // 
            this.switchView3.Location = new System.Drawing.Point(181, 0);
            this.switchView3.Name = "switchView3";
            this.switchView3.Size = new System.Drawing.Size(20, 40);
            this.switchView3.State = false;
            this.switchView3.TabIndex = 19;
            // 
            // ConsoleView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.switchView3);
            this.Controls.Add(this.switchView2);
            this.Controls.Add(this.switchView1);
            this.Controls.Add(this.labelLed3);
            this.Controls.Add(this.ledView3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ledView2);
            this.Controls.Add(this.labelLed1);
            this.Controls.Add(this.ledView1);
            this.Controls.Add(this.labelLed0);
            this.Controls.Add(this.ledView0);
            this.Controls.Add(this.switchView0);
            this.Name = "ConsoleView";
            this.Size = new System.Drawing.Size(203, 49);
            this.ResumeLayout(false);

        }

        #endregion

        private LedView ledView0;
        private System.Windows.Forms.Label labelLed0;
        private LedView ledView1;
        private System.Windows.Forms.Label labelLed1;
        private LedView ledView2;
        private System.Windows.Forms.Label label1;
        private LedView ledView3;
        private System.Windows.Forms.Label labelLed3;
        private SwitchView switchView0;
        private SwitchView switchView1;
        private SwitchView switchView2;
        private SwitchView switchView3;
    }
}
