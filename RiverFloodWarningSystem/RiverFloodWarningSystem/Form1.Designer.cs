
namespace RiverFloodWarningSystem
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.floodVal = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rainfallVal = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.floodLow = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.centroid = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            this.resetBtn = new System.Windows.Forms.Button();
            this.floodMod = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.floodHigh = new System.Windows.Forms.Label();
            this.rainfallHeavy = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.rainfallAve = new System.Windows.Forms.Label();
            this.rainfallLow = new System.Windows.Forms.Label();
            this.red = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.orange = new System.Windows.Forms.Label();
            this.yellow = new System.Windows.Forms.Label();
            this.analyzeBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.floodVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rainfallVal)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(303, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "River Flood Warning System";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Input Variables";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(805, 34);
            this.label3.TabIndex = 2;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // floodVal
            // 
            this.floodVal.DecimalPlaces = 2;
            this.floodVal.Location = new System.Drawing.Point(208, 172);
            this.floodVal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.floodVal.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.floodVal.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            65536});
            this.floodVal.Name = "floodVal";
            this.floodVal.Size = new System.Drawing.Size(67, 22);
            this.floodVal.TabIndex = 3;
            this.floodVal.Value = new decimal(new int[] {
            3,
            0,
            0,
            65536});
            this.floodVal.ValueChanged += new System.EventHandler(this.floodValChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Flood Height (m)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Rainfall (mm per hr)";
            // 
            // rainfallVal
            // 
            this.rainfallVal.DecimalPlaces = 2;
            this.rainfallVal.Location = new System.Drawing.Point(207, 257);
            this.rainfallVal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rainfallVal.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.rainfallVal.Minimum = new decimal(new int[] {
            75,
            0,
            0,
            65536});
            this.rainfallVal.Name = "rainfallVal";
            this.rainfallVal.Size = new System.Drawing.Size(67, 22);
            this.rainfallVal.TabIndex = 5;
            this.rainfallVal.Value = new decimal(new int[] {
            75,
            0,
            0,
            65536});
            this.rainfallVal.ValueChanged += new System.EventHandler(this.rainfallValChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(333, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(224, 24);
            this.label6.TabIndex = 7;
            this.label6.Text = "Degree of Membership";
            // 
            // floodLow
            // 
            this.floodLow.AutoSize = true;
            this.floodLow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.floodLow.Location = new System.Drawing.Point(333, 175);
            this.floodLow.Name = "floodLow";
            this.floodLow.Size = new System.Drawing.Size(144, 20);
            this.floodLow.TabIndex = 8;
            this.floodLow.Text = "_ _ _ _ _ _ _ _ _ _";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(29, 402);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 24);
            this.label9.TabIndex = 10;
            this.label9.Text = "Centroid";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(333, 326);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(224, 24);
            this.label10.TabIndex = 11;
            this.label10.Text = "Degree of Membership";
            // 
            // centroid
            // 
            this.centroid.AutoSize = true;
            this.centroid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.centroid.Location = new System.Drawing.Point(131, 402);
            this.centroid.Name = "centroid";
            this.centroid.Size = new System.Drawing.Size(74, 20);
            this.centroid.TabIndex = 12;
            this.centroid.Text = "_ _ _ _ _";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(28, 465);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 24);
            this.label13.TabIndex = 14;
            this.label13.Text = "Result";
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.Location = new System.Drawing.Point(28, 500);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(74, 20);
            this.result.TabIndex = 15;
            this.result.Text = "_ _ _ _ _";
            // 
            // resetBtn
            // 
            this.resetBtn.BackColor = System.Drawing.Color.Maroon;
            this.resetBtn.ForeColor = System.Drawing.Color.White;
            this.resetBtn.Location = new System.Drawing.Point(812, 551);
            this.resetBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(100, 36);
            this.resetBtn.TabIndex = 16;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = false;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // floodMod
            // 
            this.floodMod.AutoSize = true;
            this.floodMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.floodMod.Location = new System.Drawing.Point(531, 176);
            this.floodMod.Name = "floodMod";
            this.floodMod.Size = new System.Drawing.Size(144, 20);
            this.floodMod.TabIndex = 17;
            this.floodMod.Text = "_ _ _ _ _ _ _ _ _ _";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(383, 143);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 24);
            this.label8.TabIndex = 20;
            this.label8.Text = "Low";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(563, 143);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 24);
            this.label11.TabIndex = 21;
            this.label11.Text = "Moderate";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(787, 143);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 24);
            this.label12.TabIndex = 22;
            this.label12.Text = "High";
            // 
            // floodHigh
            // 
            this.floodHigh.AutoSize = true;
            this.floodHigh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.floodHigh.Location = new System.Drawing.Point(728, 176);
            this.floodHigh.Name = "floodHigh";
            this.floodHigh.Size = new System.Drawing.Size(144, 20);
            this.floodHigh.TabIndex = 23;
            this.floodHigh.Text = "_ _ _ _ _ _ _ _ _ _";
            // 
            // rainfallHeavy
            // 
            this.rainfallHeavy.AutoSize = true;
            this.rainfallHeavy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rainfallHeavy.Location = new System.Drawing.Point(728, 261);
            this.rainfallHeavy.Name = "rainfallHeavy";
            this.rainfallHeavy.Size = new System.Drawing.Size(144, 20);
            this.rainfallHeavy.TabIndex = 29;
            this.rainfallHeavy.Text = "_ _ _ _ _ _ _ _ _ _";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(777, 228);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(68, 24);
            this.label16.TabIndex = 28;
            this.label16.Text = "Heavy";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(569, 228);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(88, 24);
            this.label17.TabIndex = 27;
            this.label17.Text = "Average";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(383, 228);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(48, 24);
            this.label18.TabIndex = 26;
            this.label18.Text = "Low";
            // 
            // rainfallAve
            // 
            this.rainfallAve.AutoSize = true;
            this.rainfallAve.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rainfallAve.Location = new System.Drawing.Point(531, 261);
            this.rainfallAve.Name = "rainfallAve";
            this.rainfallAve.Size = new System.Drawing.Size(144, 20);
            this.rainfallAve.TabIndex = 25;
            this.rainfallAve.Text = "_ _ _ _ _ _ _ _ _ _";
            // 
            // rainfallLow
            // 
            this.rainfallLow.AutoSize = true;
            this.rainfallLow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rainfallLow.Location = new System.Drawing.Point(333, 260);
            this.rainfallLow.Name = "rainfallLow";
            this.rainfallLow.Size = new System.Drawing.Size(144, 20);
            this.rainfallLow.TabIndex = 24;
            this.rainfallLow.Text = "_ _ _ _ _ _ _ _ _ _";
            // 
            // red
            // 
            this.red.AutoSize = true;
            this.red.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.red.Location = new System.Drawing.Point(728, 402);
            this.red.Name = "red";
            this.red.Size = new System.Drawing.Size(144, 20);
            this.red.TabIndex = 35;
            this.red.Text = "_ _ _ _ _ _ _ _ _ _";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(777, 369);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(48, 24);
            this.label22.TabIndex = 34;
            this.label22.Text = "Red";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(564, 369);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(80, 24);
            this.label23.TabIndex = 33;
            this.label23.Text = "Orange";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(383, 369);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(72, 24);
            this.label24.TabIndex = 32;
            this.label24.Text = "Yellow";
            // 
            // orange
            // 
            this.orange.AutoSize = true;
            this.orange.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orange.Location = new System.Drawing.Point(531, 402);
            this.orange.Name = "orange";
            this.orange.Size = new System.Drawing.Size(144, 20);
            this.orange.TabIndex = 31;
            this.orange.Text = "_ _ _ _ _ _ _ _ _ _";
            // 
            // yellow
            // 
            this.yellow.AutoSize = true;
            this.yellow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yellow.Location = new System.Drawing.Point(333, 402);
            this.yellow.Name = "yellow";
            this.yellow.Size = new System.Drawing.Size(144, 20);
            this.yellow.TabIndex = 30;
            this.yellow.Text = "_ _ _ _ _ _ _ _ _ _";
            // 
            // analyzeBtn
            // 
            this.analyzeBtn.BackColor = System.Drawing.Color.Navy;
            this.analyzeBtn.ForeColor = System.Drawing.Color.White;
            this.analyzeBtn.Location = new System.Drawing.Point(704, 551);
            this.analyzeBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.analyzeBtn.Name = "analyzeBtn";
            this.analyzeBtn.Size = new System.Drawing.Size(100, 36);
            this.analyzeBtn.TabIndex = 36;
            this.analyzeBtn.Text = "Analyze";
            this.analyzeBtn.UseVisualStyleBackColor = false;
            this.analyzeBtn.Click += new System.EventHandler(this.analyzeBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(928, 602);
            this.Controls.Add(this.analyzeBtn);
            this.Controls.Add(this.red);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.orange);
            this.Controls.Add(this.yellow);
            this.Controls.Add(this.rainfallHeavy);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.rainfallAve);
            this.Controls.Add(this.rainfallLow);
            this.Controls.Add(this.floodHigh);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.floodMod);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.result);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.centroid);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.floodLow);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rainfallVal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.floodVal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "River Flood Warning System";
            ((System.ComponentModel.ISupportInitialize)(this.floodVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rainfallVal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown floodVal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown rainfallVal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label floodLow;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label centroid;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Label floodMod;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label floodHigh;
        private System.Windows.Forms.Label rainfallHeavy;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label rainfallAve;
        private System.Windows.Forms.Label rainfallLow;
        private System.Windows.Forms.Label red;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label orange;
        private System.Windows.Forms.Label yellow;
        private System.Windows.Forms.Button analyzeBtn;
    }
}

