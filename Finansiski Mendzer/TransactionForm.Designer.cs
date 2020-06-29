namespace Finansiski_Mendzer
{
    partial class TransactionForm
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
            this.incomeTextLabel = new System.Windows.Forms.Label();
            this.expensesTextLabel = new System.Windows.Forms.Label();
            this.totalTextLabel = new System.Windows.Forms.Label();
            this.incomeLabel = new System.Windows.Forms.Label();
            this.expensesLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.addTransactionButton = new System.Windows.Forms.Button();
            this.transactionsButton = new System.Windows.Forms.Button();
            this.statisticsButton = new System.Windows.Forms.Button();
            this.accountsButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.typesListBox = new System.Windows.Forms.ListBox();
            this.transactionsListBox = new System.Windows.Forms.ListBox();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // incomeTextLabel
            // 
            this.incomeTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14F);
            this.incomeTextLabel.ForeColor = System.Drawing.Color.Gray;
            this.incomeTextLabel.Location = new System.Drawing.Point(0, 10);
            this.incomeTextLabel.Name = "incomeTextLabel";
            this.incomeTextLabel.Size = new System.Drawing.Size(260, 30);
            this.incomeTextLabel.TabIndex = 0;
            this.incomeTextLabel.Text = "Income";
            this.incomeTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // expensesTextLabel
            // 
            this.expensesTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14F);
            this.expensesTextLabel.ForeColor = System.Drawing.Color.Gray;
            this.expensesTextLabel.Location = new System.Drawing.Point(260, 10);
            this.expensesTextLabel.Name = "expensesTextLabel";
            this.expensesTextLabel.Size = new System.Drawing.Size(260, 30);
            this.expensesTextLabel.TabIndex = 1;
            this.expensesTextLabel.Text = "Expenses";
            this.expensesTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalTextLabel
            // 
            this.totalTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14F);
            this.totalTextLabel.ForeColor = System.Drawing.Color.Gray;
            this.totalTextLabel.Location = new System.Drawing.Point(520, 10);
            this.totalTextLabel.Name = "totalTextLabel";
            this.totalTextLabel.Size = new System.Drawing.Size(260, 30);
            this.totalTextLabel.TabIndex = 2;
            this.totalTextLabel.Text = "Total";
            this.totalTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // incomeLabel
            // 
            this.incomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.12F);
            this.incomeLabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.incomeLabel.Location = new System.Drawing.Point(0, 40);
            this.incomeLabel.Name = "incomeLabel";
            this.incomeLabel.Size = new System.Drawing.Size(260, 30);
            this.incomeLabel.TabIndex = 3;
            this.incomeLabel.Text = "0";
            this.incomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // expensesLabel
            // 
            this.expensesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.12F);
            this.expensesLabel.ForeColor = System.Drawing.Color.Red;
            this.expensesLabel.Location = new System.Drawing.Point(260, 40);
            this.expensesLabel.Name = "expensesLabel";
            this.expensesLabel.Size = new System.Drawing.Size(260, 30);
            this.expensesLabel.TabIndex = 4;
            this.expensesLabel.Text = "0";
            this.expensesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalLabel
            // 
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.12F);
            this.totalLabel.ForeColor = System.Drawing.Color.Gray;
            this.totalLabel.Location = new System.Drawing.Point(520, 40);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(260, 30);
            this.totalLabel.TabIndex = 5;
            this.totalLabel.Text = "0";
            this.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addTransactionButton
            // 
            this.addTransactionButton.AutoSize = true;
            this.addTransactionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.16F);
            this.addTransactionButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.addTransactionButton.Location = new System.Drawing.Point(275, 628);
            this.addTransactionButton.Name = "addTransactionButton";
            this.addTransactionButton.Size = new System.Drawing.Size(230, 60);
            this.addTransactionButton.TabIndex = 6;
            this.addTransactionButton.Text = "Add Transaction";
            this.addTransactionButton.UseVisualStyleBackColor = true;
            this.addTransactionButton.Click += new System.EventHandler(this.addTransactionButton_Click);
            // 
            // transactionsButton
            // 
            this.transactionsButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.transactionsButton.Enabled = false;
            this.transactionsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.12F);
            this.transactionsButton.Location = new System.Drawing.Point(3, 710);
            this.transactionsButton.Name = "transactionsButton";
            this.transactionsButton.Size = new System.Drawing.Size(189, 40);
            this.transactionsButton.TabIndex = 7;
            this.transactionsButton.Text = "Transactions";
            this.transactionsButton.UseVisualStyleBackColor = false;
            this.transactionsButton.Click += new System.EventHandler(this.transactionsButton_Click);
            // 
            // statisticsButton
            // 
            this.statisticsButton.BackColor = System.Drawing.SystemColors.Control;
            this.statisticsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.12F);
            this.statisticsButton.Location = new System.Drawing.Point(198, 710);
            this.statisticsButton.Name = "statisticsButton";
            this.statisticsButton.Size = new System.Drawing.Size(189, 40);
            this.statisticsButton.TabIndex = 8;
            this.statisticsButton.Text = "Statistics";
            this.statisticsButton.UseVisualStyleBackColor = false;
            this.statisticsButton.Click += new System.EventHandler(this.statisticsButton_Click);
            // 
            // accountsButton
            // 
            this.accountsButton.BackColor = System.Drawing.SystemColors.Control;
            this.accountsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.12F);
            this.accountsButton.Location = new System.Drawing.Point(393, 710);
            this.accountsButton.Name = "accountsButton";
            this.accountsButton.Size = new System.Drawing.Size(189, 40);
            this.accountsButton.TabIndex = 9;
            this.accountsButton.Text = "Accounts";
            this.accountsButton.UseVisualStyleBackColor = false;
            this.accountsButton.Click += new System.EventHandler(this.accountsButton_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.BackColor = System.Drawing.SystemColors.Control;
            this.settingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.12F);
            this.settingsButton.Location = new System.Drawing.Point(588, 710);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(189, 40);
            this.settingsButton.TabIndex = 10;
            this.settingsButton.Text = "Settings";
            this.settingsButton.UseVisualStyleBackColor = false;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // typesListBox
            // 
            this.typesListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.12F);
            this.typesListBox.FormattingEnabled = true;
            this.typesListBox.ItemHeight = 25;
            this.typesListBox.Location = new System.Drawing.Point(20, 130);
            this.typesListBox.Name = "typesListBox";
            this.typesListBox.Size = new System.Drawing.Size(360, 454);
            this.typesListBox.TabIndex = 11;
            this.typesListBox.SelectedIndexChanged += new System.EventHandler(this.typesListBox_SelectedIndexChanged);
            // 
            // transactionsListBox
            // 
            this.transactionsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.12F);
            this.transactionsListBox.FormattingEnabled = true;
            this.transactionsListBox.ItemHeight = 25;
            this.transactionsListBox.Location = new System.Drawing.Point(400, 130);
            this.transactionsListBox.Name = "transactionsListBox";
            this.transactionsListBox.Size = new System.Drawing.Size(360, 454);
            this.transactionsListBox.TabIndex = 12;
            this.transactionsListBox.DoubleClick += new System.EventHandler(this.transactionsListBox_DoubleClick);
            // 
            // typeComboBox
            // 
            this.typeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14F);
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Location = new System.Drawing.Point(571, 80);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(189, 37);
            this.typeComboBox.TabIndex = 22;
            this.typeComboBox.SelectedIndexChanged += new System.EventHandler(this.typeComboBox_SelectedIndexChanged);
            // 
            // TransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 753);
            this.Controls.Add(this.typeComboBox);
            this.Controls.Add(this.transactionsListBox);
            this.Controls.Add(this.typesListBox);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.accountsButton);
            this.Controls.Add(this.statisticsButton);
            this.Controls.Add(this.transactionsButton);
            this.Controls.Add(this.addTransactionButton);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.expensesLabel);
            this.Controls.Add(this.incomeLabel);
            this.Controls.Add(this.totalTextLabel);
            this.Controls.Add(this.expensesTextLabel);
            this.Controls.Add(this.incomeTextLabel);
            this.Name = "TransactionForm";
            this.Text = "TransactionForm";
            this.Load += new System.EventHandler(this.TransactionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label incomeTextLabel;
        private System.Windows.Forms.Label expensesTextLabel;
        private System.Windows.Forms.Label totalTextLabel;
        private System.Windows.Forms.Label incomeLabel;
        private System.Windows.Forms.Label expensesLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Button addTransactionButton;
        private System.Windows.Forms.Button transactionsButton;
        private System.Windows.Forms.Button statisticsButton;
        private System.Windows.Forms.Button accountsButton;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.ListBox typesListBox;
        private System.Windows.Forms.ListBox transactionsListBox;
        private System.Windows.Forms.ComboBox typeComboBox;
    }
}