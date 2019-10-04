namespace BookListApp
{
    partial class BookDatabase
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
            this.addInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.addButton = new System.Windows.Forms.Button();
            this.infoDetailsTextBox = new System.Windows.Forms.TextBox();
            this.infoIsbnTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.searchGroupBox = new System.Windows.Forms.GroupBox();
            this.findButton = new System.Windows.Forms.Button();
            this.searchDetailsTextBox = new System.Windows.Forms.TextBox();
            this.searchIsbnTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addInfoGroupBox.SuspendLayout();
            this.searchGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // addInfoGroupBox
            // 
            this.addInfoGroupBox.Controls.Add(this.addButton);
            this.addInfoGroupBox.Controls.Add(this.infoDetailsTextBox);
            this.addInfoGroupBox.Controls.Add(this.infoIsbnTextBox);
            this.addInfoGroupBox.Controls.Add(this.label2);
            this.addInfoGroupBox.Controls.Add(this.label1);
            this.addInfoGroupBox.Location = new System.Drawing.Point(144, 25);
            this.addInfoGroupBox.Name = "addInfoGroupBox";
            this.addInfoGroupBox.Size = new System.Drawing.Size(447, 163);
            this.addInfoGroupBox.TabIndex = 0;
            this.addInfoGroupBox.TabStop = false;
            this.addInfoGroupBox.Text = "Add Book Info";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(344, 106);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // infoDetailsTextBox
            // 
            this.infoDetailsTextBox.Location = new System.Drawing.Point(118, 75);
            this.infoDetailsTextBox.Multiline = true;
            this.infoDetailsTextBox.Name = "infoDetailsTextBox";
            this.infoDetailsTextBox.Size = new System.Drawing.Size(187, 54);
            this.infoDetailsTextBox.TabIndex = 1;
            // 
            // infoIsbnTextBox
            // 
            this.infoIsbnTextBox.Location = new System.Drawing.Point(118, 35);
            this.infoIsbnTextBox.Name = "infoIsbnTextBox";
            this.infoIsbnTextBox.Size = new System.Drawing.Size(187, 20);
            this.infoIsbnTextBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Book Details";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ISBN";
            // 
            // searchGroupBox
            // 
            this.searchGroupBox.Controls.Add(this.findButton);
            this.searchGroupBox.Controls.Add(this.searchDetailsTextBox);
            this.searchGroupBox.Controls.Add(this.searchIsbnTextBox);
            this.searchGroupBox.Controls.Add(this.label4);
            this.searchGroupBox.Controls.Add(this.label3);
            this.searchGroupBox.Location = new System.Drawing.Point(144, 203);
            this.searchGroupBox.Name = "searchGroupBox";
            this.searchGroupBox.Size = new System.Drawing.Size(447, 158);
            this.searchGroupBox.TabIndex = 1;
            this.searchGroupBox.TabStop = false;
            this.searchGroupBox.Text = "Search Book";
            // 
            // findButton
            // 
            this.findButton.Location = new System.Drawing.Point(344, 29);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(75, 23);
            this.findButton.TabIndex = 2;
            this.findButton.Text = "Find";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // searchDetailsTextBox
            // 
            this.searchDetailsTextBox.Location = new System.Drawing.Point(118, 71);
            this.searchDetailsTextBox.Multiline = true;
            this.searchDetailsTextBox.Name = "searchDetailsTextBox";
            this.searchDetailsTextBox.Size = new System.Drawing.Size(187, 54);
            this.searchDetailsTextBox.TabIndex = 1;
            // 
            // searchIsbnTextBox
            // 
            this.searchIsbnTextBox.Location = new System.Drawing.Point(118, 31);
            this.searchIsbnTextBox.Name = "searchIsbnTextBox";
            this.searchIsbnTextBox.Size = new System.Drawing.Size(187, 20);
            this.searchIsbnTextBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Book Details";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "ISBN";
            // 
            // BookDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 450);
            this.Controls.Add(this.searchGroupBox);
            this.Controls.Add(this.addInfoGroupBox);
            this.Name = "BookDatabase";
            this.Text = "Book Database UI";
            this.addInfoGroupBox.ResumeLayout(false);
            this.addInfoGroupBox.PerformLayout();
            this.searchGroupBox.ResumeLayout(false);
            this.searchGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox addInfoGroupBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox infoDetailsTextBox;
        private System.Windows.Forms.TextBox infoIsbnTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox searchGroupBox;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.TextBox searchDetailsTextBox;
        private System.Windows.Forms.TextBox searchIsbnTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

