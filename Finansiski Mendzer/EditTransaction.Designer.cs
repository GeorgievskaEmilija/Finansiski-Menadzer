namespace Finansiski_Mendzer
{
    partial class EditTransaction
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
            this.transactionGroupBox = new System.Windows.Forms.GroupBox();
            this.expensesRadioButton = new System.Windows.Forms.RadioButton();
            this.incomeRadioButton = new System.Windows.Forms.RadioButton();
            this.contentsTextBox = new System.Windows.Forms.TextBox();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.accountComboBox = new System.Windows.Forms.ComboBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.saveButton = new System.Windows.Forms.Button();
            this.contentsLabel = new System.Windows.Forms.Label();
            this.amountLabel = new System.Windows.Forms.Label();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.accountLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.transactionGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // transactionGroupBox
            // 
            this.transactionGroupBox.Controls.Add(this.expensesRadioButton);
            this.transactionGroupBox.Controls.Add(this.incomeRadioButton);
            this.transactionGroupBox.Location = new System.Drawing.Point(8, 372);
            this.transactionGroupBox.Name = "transactionGroupBox";
            this.transactionGroupBox.Size = new System.Drawing.Size(564, 73);
            this.transactionGroupBox.TabIndex = 26;
            this.transactionGroupBox.TabStop = false;
            this.transactionGroupBox.Text = "Transaction Type";
            // 
            // expensesRadioButton
            // 
            this.expensesRadioButton.AutoSize = true;
            this.expensesRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14F);
            this.expensesRadioButton.Location = new System.Drawing.Point(380, 21);
            this.expensesRadioButton.Name = "expensesRadioButton";
            this.expensesRadioButton.Size = new System.Drawing.Size(140, 33);
            this.expensesRadioButton.TabIndex = 13;
            this.expensesRadioButton.Text = "Expenses";
            this.expensesRadioButton.UseVisualStyleBackColor = true;
            this.expensesRadioButton.CheckedChanged += new System.EventHandler(this.expensesRadioButton_CheckedChanged);
            // 
            // incomeRadioButton
            // 
            this.incomeRadioButton.AutoSize = true;
            this.incomeRadioButton.Checked = true;
            this.incomeRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14F);
            this.incomeRadioButton.Location = new System.Drawing.Point(261, 21);
            this.incomeRadioButton.Name = "incomeRadioButton";
            this.incomeRadioButton.Size = new System.Drawing.Size(113, 33);
            this.incomeRadioButton.TabIndex = 12;
            this.incomeRadioButton.TabStop = true;
            this.incomeRadioButton.Text = "Income";
            this.incomeRadioButton.UseVisualStyleBackColor = true;
            this.incomeRadioButton.CheckedChanged += new System.EventHandler(this.incomeRadioButton_CheckedChanged);
            // 
            // contentsTextBox
            // 
            this.contentsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14F);
            this.contentsTextBox.Location = new System.Drawing.Point(201, 319);
            this.contentsTextBox.Name = "contentsTextBox";
            this.contentsTextBox.Size = new System.Drawing.Size(374, 34);
            this.contentsTextBox.TabIndex = 25;
            this.contentsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // amountTextBox
            // 
            this.amountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14F);
            this.amountTextBox.Location = new System.Drawing.Point(201, 245);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(374, 34);
            this.amountTextBox.TabIndex = 24;
            this.amountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14F);
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(201, 169);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(374, 37);
            this.categoryComboBox.TabIndex = 23;
            // 
            // accountComboBox
            // 
            this.accountComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14F);
            this.accountComboBox.FormattingEnabled = true;
            this.accountComboBox.Location = new System.Drawing.Point(201, 95);
            this.accountComboBox.Name = "accountComboBox";
            this.accountComboBox.Size = new System.Drawing.Size(374, 37);
            this.accountComboBox.TabIndex = 22;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14.14F);
            this.dateTimePicker.Location = new System.Drawing.Point(201, 25);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(374, 22);
            this.dateTimePicker.TabIndex = 21;
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14F);
            this.saveButton.Location = new System.Drawing.Point(8, 451);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(374, 66);
            this.saveButton.TabIndex = 19;
            this.saveButton.Text = "Save Changes";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // contentsLabel
            // 
            this.contentsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14F);
            this.contentsLabel.Location = new System.Drawing.Point(8, 303);
            this.contentsLabel.Name = "contentsLabel";
            this.contentsLabel.Size = new System.Drawing.Size(187, 66);
            this.contentsLabel.TabIndex = 18;
            this.contentsLabel.Text = "Contents";
            this.contentsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // amountLabel
            // 
            this.amountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14F);
            this.amountLabel.Location = new System.Drawing.Point(8, 229);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(187, 66);
            this.amountLabel.TabIndex = 17;
            this.amountLabel.Text = "Amount";
            this.amountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // categoryLabel
            // 
            this.categoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14F);
            this.categoryLabel.Location = new System.Drawing.Point(8, 155);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(187, 66);
            this.categoryLabel.TabIndex = 16;
            this.categoryLabel.Text = "Category";
            this.categoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // accountLabel
            // 
            this.accountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14F);
            this.accountLabel.Location = new System.Drawing.Point(8, 81);
            this.accountLabel.Name = "accountLabel";
            this.accountLabel.Size = new System.Drawing.Size(187, 66);
            this.accountLabel.TabIndex = 15;
            this.accountLabel.Text = "Account";
            this.accountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateLabel
            // 
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14F);
            this.dateLabel.Location = new System.Drawing.Point(8, 7);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(187, 66);
            this.dateLabel.TabIndex = 14;
            this.dateLabel.Text = "Date";
            this.dateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14F);
            this.deleteButton.Location = new System.Drawing.Point(388, 451);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(187, 66);
            this.deleteButton.TabIndex = 27;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // EditTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 525);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.transactionGroupBox);
            this.Controls.Add(this.contentsTextBox);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.accountComboBox);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.contentsLabel);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.categoryLabel);
            this.Controls.Add(this.accountLabel);
            this.Controls.Add(this.dateLabel);
            this.Name = "EditTransaction";
            this.Text = "EditTransaction";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditTransaction_FormClosing);
            this.Load += new System.EventHandler(this.EditTransaction_Load);
            this.transactionGroupBox.ResumeLayout(false);
            this.transactionGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox transactionGroupBox;
        private System.Windows.Forms.RadioButton expensesRadioButton;
        private System.Windows.Forms.RadioButton incomeRadioButton;
        private System.Windows.Forms.TextBox contentsTextBox;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.ComboBox accountComboBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label contentsLabel;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Label accountLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Button deleteButton;
    }
}