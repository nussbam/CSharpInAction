using RobotView;

namespace TestDrive
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
            this.commonRunParameters = new RobotView.CommonRunParameters();
            this.driveView = new RobotView.DriveView();
            this.runLine = new RobotView.RunLine();
            this.runTurn = new RobotView.RunTurn();
            this.runArc = new RobotView.RunArc();
            this.SuspendLayout();
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
            // driveView
            // 
            this.driveView.Drive = null;
            this.driveView.Location = new System.Drawing.Point(4, 134);
            this.driveView.Name = "driveView";
            this.driveView.Size = new System.Drawing.Size(438, 434);
            this.driveView.TabIndex = 4;
            // 
            // runLine
            // 
            this.runLine.Acceleration = 0F;
            this.runLine.Drive = null;
            this.runLine.Location = new System.Drawing.Point(481, 257);
            this.runLine.Name = "runLine";
            this.runLine.Size = new System.Drawing.Size(454, 71);
            this.runLine.Speed = 0F;
            this.runLine.TabIndex = 3;
            // 
            // runTurn
            // 
            this.runTurn.Acceleration = 0F;
            this.runTurn.Drive = null;
            this.runTurn.Location = new System.Drawing.Point(481, 178);
            this.runTurn.Name = "runTurn";
            this.runTurn.Size = new System.Drawing.Size(455, 71);
            this.runTurn.Speed = 0F;
            this.runTurn.TabIndex = 2;
            // 
            // runArc
            // 
            this.runArc.Acceleration = 0F;
            this.runArc.Drive = null;
            this.runArc.Location = new System.Drawing.Point(481, 4);
            this.runArc.Name = "runArc";
            this.runArc.Size = new System.Drawing.Size(449, 156);
            this.runArc.Speed = 0F;
            this.runArc.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1170, 455);
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
    }
}

