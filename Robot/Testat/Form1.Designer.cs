using RobotView;

namespace Testat
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.console = new RobotView.ConsoleView();
            this.runArc = new RobotView.RunArc();
            this.runTurn = new RobotView.RunTurn();
            this.runLine = new RobotView.RunLine();
            this.driveView = new RobotView.DriveView();
            this.commonRunParameters = new RobotView.CommonRunParameters();
            this.btnHalt = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // console
            // 
            this.console.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.console.Location = new System.Drawing.Point(412, 402);
            this.console.Name = "console";
            this.console.RobotConsole = null;
            this.console.Size = new System.Drawing.Size(206, 47);
            this.console.TabIndex = 6;
            // 
            // runArc
            // 
            this.runArc.Acceleration = 0F;
            this.runArc.Drive = null;
            this.runArc.Location = new System.Drawing.Point(412, 73);
            this.runArc.Name = "runArc";
            this.runArc.Size = new System.Drawing.Size(449, 156);
            this.runArc.Speed = 0F;
            this.runArc.TabIndex = 1;
            // 
            // runTurn
            // 
            this.runTurn.Acceleration = 0F;
            this.runTurn.Drive = null;
            this.runTurn.Location = new System.Drawing.Point(412, 247);
            this.runTurn.Name = "runTurn";
            this.runTurn.Size = new System.Drawing.Size(455, 71);
            this.runTurn.Speed = 0F;
            this.runTurn.TabIndex = 2;
            // 
            // runLine
            // 
            this.runLine.Acceleration = 0F;
            this.runLine.Drive = null;
            this.runLine.Location = new System.Drawing.Point(412, 326);
            this.runLine.Name = "runLine";
            this.runLine.Size = new System.Drawing.Size(454, 71);
            this.runLine.Speed = 0F;
            this.runLine.TabIndex = 3;
            // 
            // driveView
            // 
            this.driveView.Drive = null;
            this.driveView.Location = new System.Drawing.Point(0, 101);
            this.driveView.Name = "driveView";
            this.driveView.Size = new System.Drawing.Size(438, 434);
            this.driveView.TabIndex = 4;
            // 
            // commonRunParameters
            // 
            this.commonRunParameters.Acceleration = 0.3F;
            this.commonRunParameters.Location = new System.Drawing.Point(4, 4);
            this.commonRunParameters.Name = "commonRunParameters";
            this.commonRunParameters.Size = new System.Drawing.Size(452, 126);
            this.commonRunParameters.Speed = 0.5F;
            this.commonRunParameters.TabIndex = 5;
            // 
            // btnHalt
            // 
            this.btnHalt.Location = new System.Drawing.Point(624, 402);
            this.btnHalt.Name = "btnHalt";
            this.btnHalt.Size = new System.Drawing.Size(72, 47);
            this.btnHalt.TabIndex = 7;
            this.btnHalt.Text = "Halt";
            this.btnHalt.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(712, 402);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(72, 47);
            this.btnStop.TabIndex = 8;
            this.btnStop.Text = "Stop";
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(298, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 24);
            this.button1.TabIndex = 9;
            this.button1.Text = "Pad";
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(298, 54);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(49, 24);
            this.button2.TabIndex = 10;
            this.button2.Text = "Pad";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(647, 117);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(56, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "Pad";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(581, 176);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(59, 23);
            this.button4.TabIndex = 12;
            this.button4.Text = "Pad";
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(581, 295);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(59, 23);
            this.button5.TabIndex = 13;
            this.button5.Text = "Pad";
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(581, 373);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(59, 23);
            this.button6.TabIndex = 14;
            this.button6.Text = "Pad";
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(883, 483);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnHalt);
            this.Controls.Add(this.console);
            this.Controls.Add(this.runArc);
            this.Controls.Add(this.runTurn);
            this.Controls.Add(this.runLine);
            this.Controls.Add(this.driveView);
            this.Controls.Add(this.commonRunParameters);
            this.Menu = this.mainMenu1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }


        #endregion

        private CommonRunParameters commonRunParameters;
        private DriveView driveView;
        private RunLine runLine;
        private RunTurn runTurn;
        private RunArc runArc;
        private ConsoleView console;
        private System.Windows.Forms.Button btnHalt;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}

