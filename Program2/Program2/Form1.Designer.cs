namespace Program2
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
            this.incomeLabel = new System.Windows.Forms.Label();
            this.incomeTxt = new System.Windows.Forms.TextBox();
            this.selectLabel = new System.Windows.Forms.Label();
            this.baselineRadio = new System.Windows.Forms.RadioButton();
            this.candidate1Radio = new System.Windows.Forms.RadioButton();
            this.candidate2Radio = new System.Windows.Forms.RadioButton();
            this.candidate3Radio = new System.Windows.Forms.RadioButton();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.taxRateLabel = new System.Windows.Forms.Label();
            this.taxRateLabel2 = new System.Windows.Forms.Label();
            this.taxDueLabel = new System.Windows.Forms.Label();
            this.taxDueLabel2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // incomeLabel
            // 
            this.incomeLabel.AutoSize = true;
            this.incomeLabel.Location = new System.Drawing.Point(44, 43);
            this.incomeLabel.Name = "incomeLabel";
            this.incomeLabel.Size = new System.Drawing.Size(144, 25);
            this.incomeLabel.TabIndex = 0;
            this.incomeLabel.Text = "Enter income:";
            // 
            // incomeTxt
            // 
            this.incomeTxt.Location = new System.Drawing.Point(299, 40);
            this.incomeTxt.Name = "incomeTxt";
            this.incomeTxt.Size = new System.Drawing.Size(100, 31);
            this.incomeTxt.TabIndex = 1;
            // 
            // selectLabel
            // 
            this.selectLabel.AutoSize = true;
            this.selectLabel.Location = new System.Drawing.Point(130, 109);
            this.selectLabel.Name = "selectLabel";
            this.selectLabel.Size = new System.Drawing.Size(178, 25);
            this.selectLabel.TabIndex = 2;
            this.selectLabel.Text = "Select candidate:";
            // 
            // baselineRadio
            // 
            this.baselineRadio.AutoSize = true;
            this.baselineRadio.Location = new System.Drawing.Point(49, 174);
            this.baselineRadio.Name = "baselineRadio";
            this.baselineRadio.Size = new System.Drawing.Size(175, 29);
            this.baselineRadio.TabIndex = 3;
            this.baselineRadio.TabStop = true;
            this.baselineRadio.Text = "Baseline Plan";
            this.baselineRadio.UseVisualStyleBackColor = true;
            // 
            // candidate1Radio
            // 
            this.candidate1Radio.AutoSize = true;
            this.candidate1Radio.Location = new System.Drawing.Point(247, 174);
            this.candidate1Radio.Name = "candidate1Radio";
            this.candidate1Radio.Size = new System.Drawing.Size(159, 29);
            this.candidate1Radio.TabIndex = 4;
            this.candidate1Radio.TabStop = true;
            this.candidate1Radio.Text = "Candidate 1";
            this.candidate1Radio.UseVisualStyleBackColor = true;
            // 
            // candidate2Radio
            // 
            this.candidate2Radio.AutoSize = true;
            this.candidate2Radio.Location = new System.Drawing.Point(49, 244);
            this.candidate2Radio.Name = "candidate2Radio";
            this.candidate2Radio.Size = new System.Drawing.Size(159, 29);
            this.candidate2Radio.TabIndex = 5;
            this.candidate2Radio.TabStop = true;
            this.candidate2Radio.Text = "Candidate 2";
            this.candidate2Radio.UseVisualStyleBackColor = true;
            // 
            // candidate3Radio
            // 
            this.candidate3Radio.AutoSize = true;
            this.candidate3Radio.Location = new System.Drawing.Point(247, 244);
            this.candidate3Radio.Name = "candidate3Radio";
            this.candidate3Radio.Size = new System.Drawing.Size(159, 29);
            this.candidate3Radio.TabIndex = 6;
            this.candidate3Radio.TabStop = true;
            this.candidate3Radio.Text = "Candidate 3";
            this.candidate3Radio.UseVisualStyleBackColor = true;
            // 
            // calculateBtn
            // 
            this.calculateBtn.Location = new System.Drawing.Point(160, 309);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(125, 46);
            this.calculateBtn.TabIndex = 7;
            this.calculateBtn.Text = "Calculate";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // taxRateLabel
            // 
            this.taxRateLabel.AutoSize = true;
            this.taxRateLabel.Location = new System.Drawing.Point(44, 380);
            this.taxRateLabel.Name = "taxRateLabel";
            this.taxRateLabel.Size = new System.Drawing.Size(194, 25);
            this.taxRateLabel.TabIndex = 8;
            this.taxRateLabel.Text = "Marginal Tax Rate:";
            // 
            // taxRateLabel2
            // 
            this.taxRateLabel2.Location = new System.Drawing.Point(294, 380);
            this.taxRateLabel2.Name = "taxRateLabel2";
            this.taxRateLabel2.Size = new System.Drawing.Size(112, 25);
            this.taxRateLabel2.TabIndex = 9;
            this.taxRateLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // taxDueLabel
            // 
            this.taxDueLabel.AutoSize = true;
            this.taxDueLabel.Location = new System.Drawing.Point(44, 465);
            this.taxDueLabel.Name = "taxDueLabel";
            this.taxDueLabel.Size = new System.Drawing.Size(99, 25);
            this.taxDueLabel.TabIndex = 10;
            this.taxDueLabel.Text = "Tax Due:";
            // 
            // taxDueLabel2
            // 
            this.taxDueLabel2.Location = new System.Drawing.Point(180, 465);
            this.taxDueLabel2.Name = "taxDueLabel2";
            this.taxDueLabel2.Size = new System.Drawing.Size(226, 25);
            this.taxDueLabel2.TabIndex = 11;
            this.taxDueLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 557);
            this.Controls.Add(this.taxDueLabel2);
            this.Controls.Add(this.taxDueLabel);
            this.Controls.Add(this.taxRateLabel2);
            this.Controls.Add(this.taxRateLabel);
            this.Controls.Add(this.calculateBtn);
            this.Controls.Add(this.candidate3Radio);
            this.Controls.Add(this.candidate2Radio);
            this.Controls.Add(this.candidate1Radio);
            this.Controls.Add(this.baselineRadio);
            this.Controls.Add(this.selectLabel);
            this.Controls.Add(this.incomeTxt);
            this.Controls.Add(this.incomeLabel);
            this.Name = "Form1";
            this.Text = "Program 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label incomeLabel;
        private System.Windows.Forms.TextBox incomeTxt;
        private System.Windows.Forms.Label selectLabel;
        private System.Windows.Forms.RadioButton baselineRadio;
        private System.Windows.Forms.RadioButton candidate1Radio;
        private System.Windows.Forms.RadioButton candidate2Radio;
        private System.Windows.Forms.RadioButton candidate3Radio;
        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.Label taxRateLabel;
        private System.Windows.Forms.Label taxRateLabel2;
        private System.Windows.Forms.Label taxDueLabel;
        private System.Windows.Forms.Label taxDueLabel2;
    }
}

