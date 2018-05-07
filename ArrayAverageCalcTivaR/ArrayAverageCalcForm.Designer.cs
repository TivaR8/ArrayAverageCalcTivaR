namespace ArrayAverageCalcTivaR
{
    partial class frmArrayAverageCalc
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
            this.btnStart = new System.Windows.Forms.Button();
            this.lstNumbers = new System.Windows.Forms.ListBox();
            this.btnCalculateAverage = new System.Windows.Forms.Button();
            this.lblAverageNum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(127, 40);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lstNumbers
            // 
            this.lstNumbers.AccessibleDescription = ".";
            this.lstNumbers.FormattingEnabled = true;
            this.lstNumbers.Location = new System.Drawing.Point(76, 79);
            this.lstNumbers.Name = "lstNumbers";
            this.lstNumbers.Size = new System.Drawing.Size(183, 160);
            this.lstNumbers.TabIndex = 1;
            // 
            // btnCalculateAverage
            // 
            this.btnCalculateAverage.Location = new System.Drawing.Point(53, 249);
            this.btnCalculateAverage.Name = "btnCalculateAverage";
            this.btnCalculateAverage.Size = new System.Drawing.Size(119, 23);
            this.btnCalculateAverage.TabIndex = 2;
            this.btnCalculateAverage.Text = "Calculate Average";
            this.btnCalculateAverage.UseVisualStyleBackColor = true;
            this.btnCalculateAverage.Click += new System.EventHandler(this.btnCalculateAverage_Click);
            // 
            // lblAverageNum
            // 
            this.lblAverageNum.AutoSize = true;
            this.lblAverageNum.Location = new System.Drawing.Point(223, 254);
            this.lblAverageNum.Name = "lblAverageNum";
            this.lblAverageNum.Size = new System.Drawing.Size(53, 13);
            this.lblAverageNum.TabIndex = 3;
            this.lblAverageNum.Text = "Average: ";
            // 
            // frmArrayAverageCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 301);
            this.Controls.Add(this.lblAverageNum);
            this.Controls.Add(this.btnCalculateAverage);
            this.Controls.Add(this.lstNumbers);
            this.Controls.Add(this.btnStart);
            this.Name = "frmArrayAverageCalc";
            this.Text = "Array Average Calculator By Tiva Rait";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ListBox lstNumbers;
        private System.Windows.Forms.Button btnCalculateAverage;
        private System.Windows.Forms.Label lblAverageNum;
    }
}

