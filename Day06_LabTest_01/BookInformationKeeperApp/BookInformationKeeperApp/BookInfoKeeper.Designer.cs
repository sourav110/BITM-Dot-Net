namespace BookInformationKeeperApp
{
    partial class BookInfoKeeper
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.isbnTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.addListBox = new System.Windows.Forms.ListBox();
            this.addButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchListBox = new System.Windows.Forms.ListBox();
            this.isbnRadioButton = new System.Windows.Forms.RadioButton();
            this.nameRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addButton);
            this.groupBox1.Controls.Add(this.addListBox);
            this.groupBox1.Controls.Add(this.nameTextBox);
            this.groupBox1.Controls.Add(this.isbnTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(75, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 356);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Book";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nameRadioButton);
            this.groupBox2.Controls.Add(this.isbnRadioButton);
            this.groupBox2.Controls.Add(this.searchButton);
            this.groupBox2.Controls.Add(this.searchListBox);
            this.groupBox2.Controls.Add(this.searchTextBox);
            this.groupBox2.Location = new System.Drawing.Point(404, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(288, 356);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search Book";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ISBN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            // 
            // isbnTextBox
            // 
            this.isbnTextBox.Location = new System.Drawing.Point(76, 39);
            this.isbnTextBox.Name = "isbnTextBox";
            this.isbnTextBox.Size = new System.Drawing.Size(179, 20);
            this.isbnTextBox.TabIndex = 0;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(76, 78);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(179, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // addListBox
            // 
            this.addListBox.FormattingEnabled = true;
            this.addListBox.Location = new System.Drawing.Point(23, 159);
            this.addListBox.Name = "addListBox";
            this.addListBox.Size = new System.Drawing.Size(232, 186);
            this.addListBox.TabIndex = 3;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(180, 114);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(33, 78);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(232, 20);
            this.searchTextBox.TabIndex = 2;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(190, 114);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchListBox
            // 
            this.searchListBox.FormattingEnabled = true;
            this.searchListBox.Location = new System.Drawing.Point(33, 159);
            this.searchListBox.Name = "searchListBox";
            this.searchListBox.Size = new System.Drawing.Size(232, 186);
            this.searchListBox.TabIndex = 4;
            // 
            // isbnRadioButton
            // 
            this.isbnRadioButton.AutoSize = true;
            this.isbnRadioButton.Location = new System.Drawing.Point(33, 43);
            this.isbnRadioButton.Name = "isbnRadioButton";
            this.isbnRadioButton.Size = new System.Drawing.Size(50, 17);
            this.isbnRadioButton.TabIndex = 0;
            this.isbnRadioButton.TabStop = true;
            this.isbnRadioButton.Text = "ISBN";
            this.isbnRadioButton.UseVisualStyleBackColor = true;
            // 
            // nameRadioButton
            // 
            this.nameRadioButton.AutoSize = true;
            this.nameRadioButton.Location = new System.Drawing.Point(212, 42);
            this.nameRadioButton.Name = "nameRadioButton";
            this.nameRadioButton.Size = new System.Drawing.Size(53, 17);
            this.nameRadioButton.TabIndex = 1;
            this.nameRadioButton.TabStop = true;
            this.nameRadioButton.Text = "Name";
            this.nameRadioButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 393);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Book Information Keeper";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ListBox addListBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox isbnTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton nameRadioButton;
        private System.Windows.Forms.RadioButton isbnRadioButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ListBox searchListBox;
        private System.Windows.Forms.TextBox searchTextBox;
    }
}

