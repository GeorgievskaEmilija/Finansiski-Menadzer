namespace Finansiski_Mendzer
{
    partial class EditCategories
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
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.categoriesListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // editButton
            // 
            this.editButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14F);
            this.editButton.Location = new System.Drawing.Point(3, 447);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(285, 66);
            this.editButton.TabIndex = 30;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14F);
            this.deleteButton.Location = new System.Drawing.Point(294, 447);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(285, 66);
            this.deleteButton.TabIndex = 31;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // categoriesListBox
            // 
            this.categoriesListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14F);
            this.categoriesListBox.FormattingEnabled = true;
            this.categoriesListBox.ItemHeight = 29;
            this.categoriesListBox.Location = new System.Drawing.Point(12, 12);
            this.categoriesListBox.Name = "categoriesListBox";
            this.categoriesListBox.Size = new System.Drawing.Size(558, 410);
            this.categoriesListBox.TabIndex = 32;
            // 
            // EditCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 525);
            this.Controls.Add(this.categoriesListBox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Name = "EditCategories";
            this.Text = "EditCategories";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditCategories_FormClosing);
            this.Load += new System.EventHandler(this.EditCategories_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.ListBox categoriesListBox;
    }
}