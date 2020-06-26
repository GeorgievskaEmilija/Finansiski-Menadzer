namespace Finansiski_Mendzer
{
    partial class StatisticsForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.settingsButton = new System.Windows.Forms.Button();
            this.accountsButton = new System.Windows.Forms.Button();
            this.statisticsButton = new System.Windows.Forms.Button();
            this.transactionsButton = new System.Windows.Forms.Button();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.transactionComboBox = new System.Windows.Forms.ComboBox();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsButton
            // 
            this.settingsButton.BackColor = System.Drawing.SystemColors.Control;
            this.settingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.12F);
            this.settingsButton.Location = new System.Drawing.Point(587, 710);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(189, 40);
            this.settingsButton.TabIndex = 18;
            this.settingsButton.Text = "Settings";
            this.settingsButton.UseVisualStyleBackColor = false;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // accountsButton
            // 
            this.accountsButton.BackColor = System.Drawing.SystemColors.Control;
            this.accountsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.12F);
            this.accountsButton.Location = new System.Drawing.Point(392, 710);
            this.accountsButton.Name = "accountsButton";
            this.accountsButton.Size = new System.Drawing.Size(189, 40);
            this.accountsButton.TabIndex = 17;
            this.accountsButton.Text = "Accounts";
            this.accountsButton.UseVisualStyleBackColor = false;
            this.accountsButton.Click += new System.EventHandler(this.accountsButton_Click);
            // 
            // statisticsButton
            // 
            this.statisticsButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.statisticsButton.Enabled = false;
            this.statisticsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.12F);
            this.statisticsButton.Location = new System.Drawing.Point(197, 710);
            this.statisticsButton.Name = "statisticsButton";
            this.statisticsButton.Size = new System.Drawing.Size(189, 40);
            this.statisticsButton.TabIndex = 16;
            this.statisticsButton.Text = "Statistics";
            this.statisticsButton.UseVisualStyleBackColor = false;
            this.statisticsButton.Click += new System.EventHandler(this.statisticsButton_Click);
            // 
            // transactionsButton
            // 
            this.transactionsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.12F);
            this.transactionsButton.Location = new System.Drawing.Point(2, 710);
            this.transactionsButton.Name = "transactionsButton";
            this.transactionsButton.Size = new System.Drawing.Size(189, 40);
            this.transactionsButton.TabIndex = 15;
            this.transactionsButton.Text = "Transactions";
            this.transactionsButton.UseVisualStyleBackColor = false;
            this.transactionsButton.Click += new System.EventHandler(this.transactionsButton_Click);
            // 
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(12, 82);
            this.chart.Name = "chart";
            this.chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(758, 600);
            this.chart.TabIndex = 19;
            this.chart.Text = "chart";
            // 
            // transactionComboBox
            // 
            this.transactionComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14F);
            this.transactionComboBox.FormattingEnabled = true;
            this.transactionComboBox.Location = new System.Drawing.Point(12, 12);
            this.transactionComboBox.Name = "transactionComboBox";
            this.transactionComboBox.Size = new System.Drawing.Size(189, 37);
            this.transactionComboBox.TabIndex = 20;
            this.transactionComboBox.SelectedIndexChanged += new System.EventHandler(this.transactionComboBox_SelectedIndexChanged);
            // 
            // typeComboBox
            // 
            this.typeComboBox.Enabled = false;
            this.typeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14F);
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Location = new System.Drawing.Point(581, 12);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(189, 37);
            this.typeComboBox.TabIndex = 21;
            // 
            // StatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 753);
            this.Controls.Add(this.typeComboBox);
            this.Controls.Add(this.transactionComboBox);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.accountsButton);
            this.Controls.Add(this.statisticsButton);
            this.Controls.Add(this.transactionsButton);
            this.Name = "StatisticsForm";
            this.Text = "StatisticsForm";
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button accountsButton;
        private System.Windows.Forms.Button statisticsButton;
        private System.Windows.Forms.Button transactionsButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.ComboBox transactionComboBox;
        private System.Windows.Forms.ComboBox typeComboBox;
    }
}