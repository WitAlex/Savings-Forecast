namespace Savings_Forecast
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series16 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series17 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series18 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.calculateSavingsButton = new System.Windows.Forms.Button();
            this.savingsLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.earningsValueTextBox = new System.Windows.Forms.TextBox();
            this.addEarningsButton = new System.Windows.Forms.Button();
            this.earningsListBox = new System.Windows.Forms.ListBox();
            this.monthRadioButton = new System.Windows.Forms.RadioButton();
            this.halfOfYearRadioButton = new System.Windows.Forms.RadioButton();
            this.yearRadioButton = new System.Windows.Forms.RadioButton();
            this.earningsNameTextBox = new System.Windows.Forms.TextBox();
            this.expensensNameTextBox = new System.Windows.Forms.TextBox();
            this.expensesListBox = new System.Windows.Forms.ListBox();
            this.addExpensesButton = new System.Windows.Forms.Button();
            this.expensesValueTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.removeEarningsButton = new System.Windows.Forms.Button();
            this.removeExpensesButton = new System.Windows.Forms.Button();
            this.savingsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.savedCheckBox = new System.Windows.Forms.CheckBox();
            this.earnedCheckBox = new System.Windows.Forms.CheckBox();
            this.expensedCheckBox = new System.Windows.Forms.CheckBox();
            this.customRadioButton = new System.Windows.Forms.RadioButton();
            this.customTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.savingsChart)).BeginInit();
            this.SuspendLayout();
            // 
            // calculateSavingsButton
            // 
            this.calculateSavingsButton.Location = new System.Drawing.Point(75, 438);
            this.calculateSavingsButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.calculateSavingsButton.Name = "calculateSavingsButton";
            this.calculateSavingsButton.Size = new System.Drawing.Size(185, 44);
            this.calculateSavingsButton.TabIndex = 8;
            this.calculateSavingsButton.Text = "Calculate";
            this.calculateSavingsButton.UseVisualStyleBackColor = true;
            this.calculateSavingsButton.Click += new System.EventHandler(this.calculateSavingsButton_Click);
            // 
            // savingsLabel
            // 
            this.savingsLabel.AutoSize = true;
            this.savingsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.savingsLabel.Location = new System.Drawing.Point(568, 439);
            this.savingsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.savingsLabel.Name = "savingsLabel";
            this.savingsLabel.Size = new System.Drawing.Size(30, 31);
            this.savingsLabel.TabIndex = 12;
            this.savingsLabel.Text = "0";
            this.savingsLabel.TextChanged += new System.EventHandler(this.savingsLabel_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(50, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Earnings";
            // 
            // earningsValueTextBox
            // 
            this.earningsValueTextBox.Location = new System.Drawing.Point(197, 54);
            this.earningsValueTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.earningsValueTextBox.Name = "earningsValueTextBox";
            this.earningsValueTextBox.Size = new System.Drawing.Size(65, 20);
            this.earningsValueTextBox.TabIndex = 2;
            this.earningsValueTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.isDigit);
            // 
            // addEarningsButton
            // 
            this.addEarningsButton.Location = new System.Drawing.Point(197, 75);
            this.addEarningsButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addEarningsButton.Name = "addEarningsButton";
            this.addEarningsButton.Size = new System.Drawing.Size(63, 27);
            this.addEarningsButton.TabIndex = 4;
            this.addEarningsButton.Text = "Add";
            this.addEarningsButton.UseVisualStyleBackColor = true;
            this.addEarningsButton.Click += new System.EventHandler(this.addEarningsButton_Click);
            // 
            // earningsListBox
            // 
            this.earningsListBox.FormattingEnabled = true;
            this.earningsListBox.Location = new System.Drawing.Point(53, 105);
            this.earningsListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.earningsListBox.Name = "earningsListBox";
            this.earningsListBox.Size = new System.Drawing.Size(208, 82);
            this.earningsListBox.TabIndex = 6;
            // 
            // monthRadioButton
            // 
            this.monthRadioButton.AutoSize = true;
            this.monthRadioButton.Checked = true;
            this.monthRadioButton.Location = new System.Drawing.Point(436, 55);
            this.monthRadioButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.monthRadioButton.Name = "monthRadioButton";
            this.monthRadioButton.Size = new System.Drawing.Size(55, 17);
            this.monthRadioButton.TabIndex = 9;
            this.monthRadioButton.TabStop = true;
            this.monthRadioButton.Text = "Month";
            this.monthRadioButton.UseVisualStyleBackColor = true;
            // 
            // halfOfYearRadioButton
            // 
            this.halfOfYearRadioButton.AutoSize = true;
            this.halfOfYearRadioButton.Location = new System.Drawing.Point(493, 55);
            this.halfOfYearRadioButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.halfOfYearRadioButton.Name = "halfOfYearRadioButton";
            this.halfOfYearRadioButton.Size = new System.Drawing.Size(79, 17);
            this.halfOfYearRadioButton.TabIndex = 10;
            this.halfOfYearRadioButton.Text = "Half of year";
            this.halfOfYearRadioButton.UseVisualStyleBackColor = true;
            // 
            // yearRadioButton
            // 
            this.yearRadioButton.AutoSize = true;
            this.yearRadioButton.Location = new System.Drawing.Point(574, 54);
            this.yearRadioButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.yearRadioButton.Name = "yearRadioButton";
            this.yearRadioButton.Size = new System.Drawing.Size(47, 17);
            this.yearRadioButton.TabIndex = 11;
            this.yearRadioButton.Text = "Year";
            this.yearRadioButton.UseVisualStyleBackColor = true;
            // 
            // earningsNameTextBox
            // 
            this.earningsNameTextBox.Location = new System.Drawing.Point(53, 54);
            this.earningsNameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.earningsNameTextBox.Name = "earningsNameTextBox";
            this.earningsNameTextBox.Size = new System.Drawing.Size(141, 20);
            this.earningsNameTextBox.TabIndex = 14;
            // 
            // expensensNameTextBox
            // 
            this.expensensNameTextBox.Location = new System.Drawing.Point(53, 248);
            this.expensensNameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.expensensNameTextBox.Name = "expensensNameTextBox";
            this.expensensNameTextBox.Size = new System.Drawing.Size(141, 20);
            this.expensensNameTextBox.TabIndex = 19;
            // 
            // expensesListBox
            // 
            this.expensesListBox.FormattingEnabled = true;
            this.expensesListBox.Location = new System.Drawing.Point(53, 299);
            this.expensesListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.expensesListBox.Name = "expensesListBox";
            this.expensesListBox.Size = new System.Drawing.Size(208, 82);
            this.expensesListBox.TabIndex = 18;
            // 
            // addExpensesButton
            // 
            this.addExpensesButton.Location = new System.Drawing.Point(197, 268);
            this.addExpensesButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addExpensesButton.Name = "addExpensesButton";
            this.addExpensesButton.Size = new System.Drawing.Size(63, 27);
            this.addExpensesButton.TabIndex = 17;
            this.addExpensesButton.Text = "Add";
            this.addExpensesButton.UseVisualStyleBackColor = true;
            this.addExpensesButton.Click += new System.EventHandler(this.addExpensesButton_Click);
            // 
            // expensesValueTextBox
            // 
            this.expensesValueTextBox.Location = new System.Drawing.Point(197, 248);
            this.expensesValueTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.expensesValueTextBox.Name = "expensesValueTextBox";
            this.expensesValueTextBox.Size = new System.Drawing.Size(65, 20);
            this.expensesValueTextBox.TabIndex = 16;
            this.expensesValueTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.isDigit);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(50, 229);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Expenses";
            // 
            // removeEarningsButton
            // 
            this.removeEarningsButton.Location = new System.Drawing.Point(197, 190);
            this.removeEarningsButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.removeEarningsButton.Name = "removeEarningsButton";
            this.removeEarningsButton.Size = new System.Drawing.Size(63, 27);
            this.removeEarningsButton.TabIndex = 20;
            this.removeEarningsButton.Text = "Remove";
            this.removeEarningsButton.UseVisualStyleBackColor = true;
            this.removeEarningsButton.Click += new System.EventHandler(this.removeEarningsButton_Click);
            // 
            // removeExpensesButton
            // 
            this.removeExpensesButton.Location = new System.Drawing.Point(197, 383);
            this.removeExpensesButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.removeExpensesButton.Name = "removeExpensesButton";
            this.removeExpensesButton.Size = new System.Drawing.Size(63, 27);
            this.removeExpensesButton.TabIndex = 21;
            this.removeExpensesButton.Text = "Remove";
            this.removeExpensesButton.UseVisualStyleBackColor = true;
            this.removeExpensesButton.Click += new System.EventHandler(this.removeExpensesButton_Click);
            // 
            // savingsChart
            // 
            chartArea6.Name = "ChartArea1";
            this.savingsChart.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.savingsChart.Legends.Add(legend6);
            this.savingsChart.Location = new System.Drawing.Point(369, 112);
            this.savingsChart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.savingsChart.Name = "savingsChart";
            series16.BorderWidth = 4;
            series16.ChartArea = "ChartArea1";
            series16.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series16.Legend = "Legend1";
            series16.Name = "Saved";
            series17.ChartArea = "ChartArea1";
            series17.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series17.Legend = "Legend1";
            series17.Name = "Earned";
            series18.ChartArea = "ChartArea1";
            series18.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series18.Legend = "Legend1";
            series18.Name = "Expensed";
            this.savingsChart.Series.Add(series16);
            this.savingsChart.Series.Add(series17);
            this.savingsChart.Series.Add(series18);
            this.savingsChart.Size = new System.Drawing.Size(392, 298);
            this.savingsChart.TabIndex = 22;
            this.savingsChart.Text = "chart1";
            // 
            // savedCheckBox
            // 
            this.savedCheckBox.AutoSize = true;
            this.savedCheckBox.Checked = true;
            this.savedCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.savedCheckBox.Location = new System.Drawing.Point(766, 228);
            this.savedCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.savedCheckBox.Name = "savedCheckBox";
            this.savedCheckBox.Size = new System.Drawing.Size(57, 17);
            this.savedCheckBox.TabIndex = 23;
            this.savedCheckBox.Text = "Saved";
            this.savedCheckBox.UseVisualStyleBackColor = true;
            // 
            // earnedCheckBox
            // 
            this.earnedCheckBox.AutoSize = true;
            this.earnedCheckBox.Checked = true;
            this.earnedCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.earnedCheckBox.Location = new System.Drawing.Point(765, 248);
            this.earnedCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.earnedCheckBox.Name = "earnedCheckBox";
            this.earnedCheckBox.Size = new System.Drawing.Size(60, 17);
            this.earnedCheckBox.TabIndex = 24;
            this.earnedCheckBox.Text = "Earned";
            this.earnedCheckBox.UseVisualStyleBackColor = true;
            // 
            // expensedCheckBox
            // 
            this.expensedCheckBox.AutoSize = true;
            this.expensedCheckBox.Checked = true;
            this.expensedCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.expensedCheckBox.Location = new System.Drawing.Point(765, 267);
            this.expensedCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.expensedCheckBox.Name = "expensedCheckBox";
            this.expensedCheckBox.Size = new System.Drawing.Size(73, 17);
            this.expensedCheckBox.TabIndex = 25;
            this.expensedCheckBox.Text = "Expensed";
            this.expensedCheckBox.UseVisualStyleBackColor = true;
            // 
            // customRadioButton
            // 
            this.customRadioButton.AutoSize = true;
            this.customRadioButton.Location = new System.Drawing.Point(627, 56);
            this.customRadioButton.Name = "customRadioButton";
            this.customRadioButton.Size = new System.Drawing.Size(60, 17);
            this.customRadioButton.TabIndex = 26;
            this.customRadioButton.TabStop = true;
            this.customRadioButton.Text = "Custom";
            this.customRadioButton.UseVisualStyleBackColor = true;
            this.customRadioButton.CheckedChanged += new System.EventHandler(this.customTextBoxHidding);
            // 
            // customTextBox
            // 
            this.customTextBox.Location = new System.Drawing.Point(694, 56);
            this.customTextBox.MaxLength = 3;
            this.customTextBox.Name = "customTextBox";
            this.customTextBox.Size = new System.Drawing.Size(50, 20);
            this.customTextBox.TabIndex = 27;
            this.customTextBox.Visible = false;
            this.customTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.isDigit);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 512);
            this.Controls.Add(this.customTextBox);
            this.Controls.Add(this.customRadioButton);
            this.Controls.Add(this.expensedCheckBox);
            this.Controls.Add(this.earnedCheckBox);
            this.Controls.Add(this.savedCheckBox);
            this.Controls.Add(this.savingsChart);
            this.Controls.Add(this.removeExpensesButton);
            this.Controls.Add(this.removeEarningsButton);
            this.Controls.Add(this.expensensNameTextBox);
            this.Controls.Add(this.expensesListBox);
            this.Controls.Add(this.addExpensesButton);
            this.Controls.Add(this.expensesValueTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.earningsNameTextBox);
            this.Controls.Add(this.savingsLabel);
            this.Controls.Add(this.yearRadioButton);
            this.Controls.Add(this.halfOfYearRadioButton);
            this.Controls.Add(this.monthRadioButton);
            this.Controls.Add(this.calculateSavingsButton);
            this.Controls.Add(this.earningsListBox);
            this.Controls.Add(this.addEarningsButton);
            this.Controls.Add(this.earningsValueTextBox);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Savings Forecast";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.isDigit);
            ((System.ComponentModel.ISupportInitialize)(this.savingsChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button calculateSavingsButton;
        private System.Windows.Forms.Label savingsLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox earningsValueTextBox;
        private System.Windows.Forms.Button addEarningsButton;
        private System.Windows.Forms.ListBox earningsListBox;
        private System.Windows.Forms.RadioButton monthRadioButton;
        private System.Windows.Forms.RadioButton halfOfYearRadioButton;
        private System.Windows.Forms.RadioButton yearRadioButton;
        private System.Windows.Forms.TextBox earningsNameTextBox;
        private System.Windows.Forms.TextBox expensensNameTextBox;
        private System.Windows.Forms.ListBox expensesListBox;
        private System.Windows.Forms.Button addExpensesButton;
        private System.Windows.Forms.TextBox expensesValueTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button removeEarningsButton;
        private System.Windows.Forms.Button removeExpensesButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart savingsChart;
        private System.Windows.Forms.CheckBox savedCheckBox;
        private System.Windows.Forms.CheckBox earnedCheckBox;
        private System.Windows.Forms.CheckBox expensedCheckBox;
        private System.Windows.Forms.RadioButton customRadioButton;
        private System.Windows.Forms.TextBox customTextBox;
    }
}

