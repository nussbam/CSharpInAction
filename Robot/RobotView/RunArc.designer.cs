namespace RobotView
{
    partial class RunArc
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
            this.label1 = new System.Windows.Forms.Label();
            this.radius = new System.Windows.Forms.NumericUpDown();
            this.radioButtonLeft = new System.Windows.Forms.RadioButton();
            this.radioButtonRight = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(292, 94);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(72, 28);
            this.buttonStart.TabIndex = 33;
            this.buttonStart.Text = "Start";
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonPosNeg
            // 
            this.buttonPosNeg.Location = new System.Drawing.Point(162, 94);
            this.buttonPosNeg.Name = "buttonPosNeg";
            this.buttonPosNeg.Size = new System.Drawing.Size(43, 28);
            this.buttonPosNeg.TabIndex = 32;
            this.buttonPosNeg.Text = "+/-";
            this.buttonPosNeg.Click += new System.EventHandler(this.buttonPosNeg_Click);
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label16.Location = new System.Drawing.Point(0, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(105, 20);
            this.label16.Text = "RunArc";
            // 
            // angle
            // 
            this.angle.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.angle.Location = new System.Drawing.Point(211, 94);
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
            this.angle.TabIndex = 31;
            this.angle.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
            this.label18.Location = new System.Drawing.Point(0, 102);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(172, 20);
            this.label18.Text = "Angle (+/- Degrees)";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
            this.label1.Location = new System.Drawing.Point(0, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 20);
            this.label1.Text = "Radius (+ mm)";
            // 
            // radius
            // 
            this.radius.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.radius.Location = new System.Drawing.Point(211, 54);
            this.radius.Maximum = new decimal(new int[] {
            8000,
            0,
            0,
            0});
            this.radius.Minimum = new decimal(new int[] {
            8000,
            0,
            0,
            -2147483648});
            this.radius.Name = "radius";
            this.radius.Size = new System.Drawing.Size(75, 28);
            this.radius.TabIndex = 38;
            this.radius.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // radioButtonLeft
            // 
            this.radioButtonLeft.Checked = true;
            this.radioButtonLeft.Location = new System.Drawing.Point(211, 15);
            this.radioButtonLeft.Name = "radioButtonLeft";
            this.radioButtonLeft.Size = new System.Drawing.Size(75, 20);
            this.radioButtonLeft.TabIndex = 39;
            this.radioButtonLeft.Text = "Left";
            // 
            // radioButtonRight
            // 
            this.radioButtonRight.Location = new System.Drawing.Point(292, 15);
            this.radioButtonRight.Name = "radioButtonRight";
            this.radioButtonRight.Size = new System.Drawing.Size(75, 20);
            this.radioButtonRight.TabIndex = 40;
            this.radioButtonRight.Text = "Right";
            // 
            // RunArc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.radioButtonRight);
            this.Controls.Add(this.radioButtonLeft);
            this.Controls.Add(this.radius);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.buttonPosNeg);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.angle);
            this.Controls.Add(this.label18);
            this.Name = "RunArc";
            this.Size = new System.Drawing.Size(374, 130);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonPosNeg;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown angle;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown radius;
        private System.Windows.Forms.RadioButton radioButtonLeft;
        private System.Windows.Forms.RadioButton radioButtonRight;
    }
}
