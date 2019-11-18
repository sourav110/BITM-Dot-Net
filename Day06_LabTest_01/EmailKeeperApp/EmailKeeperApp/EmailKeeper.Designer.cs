namespace EmailKeeperApp
{
    partial class EmailKeeper
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
            this.addTextBox = new System.Windows.Forms.TextBox();
            this.addListBox = new System.Windows.Forms.ListBox();
            this.addButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchListBox = new System.Windows.Forms.ListBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email to add";
            // 
            // addTextBox
            // 
            this.addTextBox.Location = new System.Drawing.Point(156, 56);
            this.addTextBox.Name = "addTextBox";
            this.addTextBox.Size = new System.Drawing.Size(163, 20);
            this.addTextBox.TabIndex = 0;
            // 
            // addListBox
            // 
            this.addListBox.FormattingEnabled = true;
            this.addListBox.Location = new System.Drawing.Point(156, 145);
            this.addListBox.Name = "addListBox";
            this.addListBox.Size = new System.Drawing.Size(163, 173);
            this.addListBox.TabIndex = 2;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(244, 98);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(382, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Email to search";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(475, 56);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(163, 20);
            this.searchTextBox.TabIndex = 3;
            // 
            // searchListBox
            // 
            this.searchListBox.FormattingEnabled = true;
            this.searchListBox.Location = new System.Drawing.Point(475, 145);
            this.searchListBox.Name = "searchListBox";
            this.searchListBox.Size = new System.Drawing.Size(163, 173);
            this.searchListBox.TabIndex = 5;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(563, 98);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 4;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // EmailKeeper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 450);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.searchListBox);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.addListBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addTextBox);
            this.Controls.Add(this.label1);
            this.Name = "EmailKeeper";
            this.Text = "Email Keeper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox addTextBox;
        private System.Windows.Forms.ListBox addListBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.ListBox searchListBox;
        private System.Windows.Forms.Button searchButton;
    }
}

