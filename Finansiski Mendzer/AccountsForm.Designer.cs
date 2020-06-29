using System;

namespace Finansiski_Mendzer
{
    partial class AccountsForm
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
            this.settingsButton = new System.Windows.Forms.Button();
            this.accountsButton = new System.Windows.Forms.Button();
            this.statisticsButton = new System.Windows.Forms.Button();
            this.transactionsButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.accountsListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // settingsButton
            // 
            this.settingsButton.BackColor = System.Drawing.SystemColors.Control;
            this.settingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.12F);
            this.settingsButton.Location = new System.Drawing.Point(588, 710);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(189, 40);
            this.settingsButton.TabIndex = 14;
            this.settingsButton.Text = "Settings";
            this.settingsButton.UseVisualStyleBackColor = false;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // accountsButton
            // 
            this.accountsButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.accountsButton.Enabled = false;
            this.accountsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.12F);
            this.accountsButton.Location = new System.Drawing.Point(393, 710);
            this.accountsButton.Name = "accountsButton";
            this.accountsButton.Size = new System.Drawing.Size(189, 40);
            this.accountsButton.TabIndex = 13;
            this.accountsButton.Text = "Accounts";
            this.accountsButton.UseVisualStyleBackColor = false;
            this.accountsButton.Click += new System.EventHandler(this.accountsButton_Click);
            // 
            // statisticsButton
            // 
            this.statisticsButton.BackColor = System.Drawing.SystemColors.Control;
            this.statisticsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.12F);
            this.statisticsButton.Location = new System.Drawing.Point(198, 710);
            this.statisticsButton.Name = "statisticsButton";
            this.statisticsButton.Size = new System.Drawing.Size(189, 40);
            this.statisticsButton.TabIndex = 12;
            this.statisticsButton.Text = "Statistics";
            this.statisticsButton.UseVisualStyleBackColor = false;
            this.statisticsButton.Click += new System.EventHandler(this.statisticsButton_Click);
            // 
            // transactionsButton
            // 
            this.transactionsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.12F);
            this.transactionsButton.Location = new System.Drawing.Point(3, 710);
            this.transactionsButton.Name = "transactionsButton";
            this.transactionsButton.Size = new System.Drawing.Size(189, 40);
            this.transactionsButton.TabIndex = 11;
            this.transactionsButton.Text = "Transactions";
            this.transactionsButton.UseVisualStyleBackColor = false;
            this.transactionsButton.Click += new System.EventHandler(this.transactionsButton_Click);
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14F);
            this.addButton.Location = new System.Drawing.Point(390, 12);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(125, 66);
            this.addButton.TabIndex = 16;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // editButton
            // 
            this.editButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14F);
            this.editButton.Location = new System.Drawing.Point(521, 12);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(125, 66);
            this.editButton.TabIndex = 17;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14F);
            this.deleteButton.Location = new System.Drawing.Point(652, 12);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(125, 66);
            this.deleteButton.TabIndex = 18;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // accountsListBox
            // 
            this.accountsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14F);
            this.accountsListBox.FormattingEnabled = true;
            this.accountsListBox.ItemHeight = 29;
            this.accountsListBox.Location = new System.Drawing.Point(12, 113);
            this.accountsListBox.Name = "accountsListBox";
            this.accountsListBox.Size = new System.Drawing.Size(765, 555);
            this.accountsListBox.TabIndex = 21;
            // 
            // AccountsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 753);
            this.Controls.Add(this.accountsListBox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.accountsButton);
            this.Controls.Add(this.statisticsButton);
            this.Controls.Add(this.transactionsButton);
            this.Name = "AccountsForm";
            this.Text = "AccountsForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AccountsForm_FormClosing);
            this.Load += new System.EventHandler(this.AccountsForm_Load);
            this.ResumeLayout(false);

        }

        

        #endregion

        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button accountsButton;
        private System.Windows.Forms.Button statisticsButton;
        private System.Windows.Forms.Button transactionsButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.ListBox accountsListBox;
    }
}