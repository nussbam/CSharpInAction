namespace RobotView
{
    partial class RunTurn
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
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonPosNeg = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.angle = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(292, 17);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(72, 28);
            this.buttonStart.TabIndex = 28;
            this.buttonStart.Text = "Start";
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonPosNeg
            // 
            this.buttonPosNeg.Location = new System.Drawing.Point(162, 17);
            this.buttonPosNeg.Name = "buttonPosNeg";
            this.buttonPosNeg.Size = new System.Drawing.Size(43, 28);
            this.buttonPosNeg.TabIndex = 27;
            this.buttonPosNeg.Text = "+/-";
            this.buttonPosNeg.Click += new System.EventHandler(this.buttonPosNeg_Click);
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label16.Location = new System.Drawing.Point(-1, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(105, 20);
            this.label16.Text = "RunTurn";
            // 
            // angle
            // 
            this.angle.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.angle.Location = new System.Drawing.Point(211, 17);
            this.angle.Maximum = new decimal(new int[] {
            8000,
            0,
            0,
            0});
            this.angle.Minimum = new decimal(new int[] {
            8000,
            0,
            0,
            -2147483648});
            this.angle.Name = "angle";
            this.angle.Size = new System.Drawing.Size(75, 28);
            this.angle.TabIndex = 26;
            this.angle.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
            this.label18.Location = new System.Drawing.Point(0, 25);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(172, 20);
            this.label18.Text = "Angle (+/- Degrees)";
            // 
            // RunTurn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.buttonPosNeg);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.angle);
            this.Controls.Add(this.label18);
            this.Name = "RunTurn";
            this.Size = new System.Drawing.Size(379, 59);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonPosNeg;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown angle;
        private System.Windows.Forms.Label label18;
    }
}
