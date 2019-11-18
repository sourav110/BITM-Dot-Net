namespace SimpleInterestCalculatorApp
{
    partial class simpleInterestCalculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.solveForLabel = new System.Windows.Forms.Label();
            this.selectOneLabel = new System.Windows.Forms.Label();
            this.firstLabel = new System.Windows.Forms.Label();
            this.secondLabel = new System.Windows.Forms.Label();
            this.thirdLabel = new System.Windows.Forms.Label();
            this.firstTextBox = new System.Windows.Forms.TextBox();
            this.secondTextBox = new System.Windows.Forms.TextBox();
            this.thirdTextBox = new System.Windows.Forms.TextBox();
            this.solveForComboBox = new System.Windows.Forms.ComboBox();
            this.timeComboBox = new System.Windows.Forms.ComboBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.calculateButton = new System.Windows.Forms.Button();
            this.secondPerYearLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.answerTextBox = new System.Windows.Forms.TextBox();
            this.thirdPerYearLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(214, 18);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(217, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Simple Interest Calculator";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // solveForLabel
            // 
            this.solveForLabel.AutoSize = true;
            this.solveForLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.solveForLabel.Location = new System.Drawing.Point(146, 57);
            this.solveForLabel.Name = "solveForLabel";
            this.solveForLabel.Size = new System.Drawing.Size(68, 17);
            this.solveForLabel.TabIndex = 1;
            this.solveForLabel.Text = "Solve For";
            // 
            // selectOneLabel
            // 
            this.selectOneLabel.AutoSize = true;
            this.selectOneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectOneLabel.Location = new System.Drawing.Point(291, 90);
            this.selectOneLabel.Name = "selectOneLabel";
            this.selectOneLabel.Size = new System.Drawing.Size(125, 17);
            this.selectOneLabel.TabIndex = 1;
            this.selectOneLabel.Text = "Where: Select one";
            // 
            // firstLabel
            // 
            this.firstLabel.AutoSize = true;
            this.firstLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstLabel.Location = new System.Drawing.Point(146, 131);
            this.firstLabel.Name = "firstLabel";
            this.firstLabel.Size = new System.Drawing.Size(111, 17);
            this.firstLabel.TabIndex = 1;
            this.firstLabel.Text = "Principal (P): TK";
            // 
            // secondLabel
            // 
            this.secondLabel.AutoSize = true;
            this.secondLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondLabel.Location = new System.Drawing.Point(149, 165);
            this.secondLabel.Name = "secondLabel";
            this.secondLabel.Size = new System.Drawing.Size(82, 17);
            this.secondLabel.TabIndex = 1;
            this.secondLabel.Text = "Rate (R): %";
            // 
            // thirdLabel
            // 
            this.thirdLabel.AutoSize = true;
            this.thirdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thirdLabel.Location = new System.Drawing.Point(166, 198);
            this.thirdLabel.Name = "thirdLabel";
            this.thirdLabel.Size = new System.Drawing.Size(65, 17);
            this.thirdLabel.TabIndex = 1;
            this.thirdLabel.Text = "Time (t): ";
            // 
            // firstTextBox
            // 
            this.firstTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.firstTextBox.Location = new System.Drawing.Point(283, 130);
            this.firstTextBox.Name = "firstTextBox";
            this.firstTextBox.Size = new System.Drawing.Size(189, 20);
            this.firstTextBox.TabIndex = 2;
            // 
            // secondTextBox
            // 
            this.secondTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondTextBox.Location = new System.Drawing.Point(283, 165);
            this.secondTextBox.Name = "secondTextBox";
            this.secondTextBox.Size = new System.Drawing.Size(189, 20);
            this.secondTextBox.TabIndex = 3;
            // 
            // thirdTextBox
            // 
            this.thirdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thirdTextBox.Location = new System.Drawing.Point(283, 197);
            this.thirdTextBox.Name = "thirdTextBox";
            this.thirdTextBox.Size = new System.Drawing.Size(189, 20);
            this.thirdTextBox.TabIndex = 4;
            // 
            // solveForComboBox
            // 
            this.solveForComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.solveForComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.solveForComboBox.FormattingEnabled = true;
            this.solveForComboBox.Location = new System.Drawing.Point(261, 56);
            this.solveForComboBox.Name = "solveForComboBox";
            this.solveForComboBox.Size = new System.Drawing.Size(212, 21);
            this.solveForComboBox.TabIndex = 0;
            this.solveForComboBox.SelectedIndexChanged += new System.EventHandler(this.solveForComboBox_SelectedIndexChanged);
            // 
            // timeComboBox
            // 
            this.timeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.timeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeComboBox.FormattingEnabled = true;
            this.timeComboBox.Location = new System.Drawing.Point(283, 223);
            this.timeComboBox.Name = "timeComboBox";
            this.timeComboBox.Size = new System.Drawing.Size(189, 21);
            this.timeComboBox.TabIndex = 5;
            this.timeComboBox.SelectedIndexChanged += new System.EventHandler(this.timeComboBox_SelectedIndexChanged);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.SystemColors.Info;
            this.clearButton.FlatAppearance.BorderSize = 0;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(202, 260);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(105, 37);
            this.clearButton.TabIndex = 6;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // calculateButton
            // 
            this.calculateButton.BackColor = System.Drawing.SystemColors.Info;
            this.calculateButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.calculateButton.FlatAppearance.BorderSize = 0;
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.Location = new System.Drawing.Point(347, 260);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(126, 37);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // secondPerYearLabel
            // 
            this.secondPerYearLabel.AutoSize = true;
            this.secondPerYearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondPerYearLabel.Location = new System.Drawing.Point(215, 179);
            this.secondPerYearLabel.Name = "secondPerYearLabel";
            this.secondPerYearLabel.Size = new System.Drawing.Size(45, 13);
            this.secondPerYearLabel.TabIndex = 7;
            this.secondPerYearLabel.Text = "per year";
            this.secondPerYearLabel.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(290, 311);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Answer";
            // 
            // answerTextBox
            // 
            this.answerTextBox.Location = new System.Drawing.Point(202, 334);
            this.answerTextBox.Multiline = true;
            this.answerTextBox.Name = "answerTextBox";
            this.answerTextBox.Size = new System.Drawing.Size(270, 37);
            this.answerTextBox.TabIndex = 9;
            this.answerTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // thirdPerYearLabel
            // 
            this.thirdPerYearLabel.AutoSize = true;
            this.thirdPerYearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thirdPerYearLabel.Location = new System.Drawing.Point(215, 212);
            this.thirdPerYearLabel.Name = "thirdPerYearLabel";
            this.thirdPerYearLabel.Size = new System.Drawing.Size(0, 13);
            this.thirdPerYearLabel.TabIndex = 7;
            // 
            // simpleInterestCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 450);
            this.Controls.Add(this.answerTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.thirdPerYearLabel);
            this.Controls.Add(this.secondPerYearLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.timeComboBox);
            this.Controls.Add(this.solveForComboBox);
            this.Controls.Add(this.thirdTextBox);
            this.Controls.Add(this.secondTextBox);
            this.Controls.Add(this.firstTextBox);
            this.Controls.Add(this.selectOneLabel);
            this.Controls.Add(this.thirdLabel);
            this.Controls.Add(this.secondLabel);
            this.Controls.Add(this.firstLabel);
            this.Controls.Add(this.solveForLabel);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "simpleInterestCalculator";
            this.Text = "Interest Calculator";
            this.Load += new System.EventHandler(this.SimpleInterestCalculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label solveForLabel;
        private System.Windows.Forms.Label selectOneLabel;
        private System.Windows.Forms.Label firstLabel;
        private System.Windows.Forms.Label secondLabel;
        private System.Windows.Forms.Label thirdLabel;
        private System.Windows.Forms.TextBox firstTextBox;
        private System.Windows.Forms.TextBox secondTextBox;
        private System.Windows.Forms.TextBox thirdTextBox;
        private System.Windows.Forms.ComboBox solveForComboBox;
        private System.Windows.Forms.ComboBox timeComboBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label secondPerYearLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox answerTextBox;
        private System.Windows.Forms.Label thirdPerYearLabel;
    }
}

