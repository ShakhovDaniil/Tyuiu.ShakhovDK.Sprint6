namespace Tyuiu.ShakhovDK.Sprint6.Task4.V11
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            groupBoxTask = new GroupBox();
            textBoxCondition = new TextBox();
            groupBoxOutput = new GroupBox();
            chartFunction = new System.Windows.Forms.DataVisualization.Charting.Chart();
            textBoxResult = new TextBox();
            textBoxTitleResult = new TextBox();
            groupBoxInput = new GroupBox();
            buttonSave = new Button();
            buttonHelp = new Button();
            buttonDone = new Button();
            textBoxTitleEndValue_of_the_range = new TextBox();
            textBoxTitleStartValue_of_the_range = new TextBox();
            textBoxEndValue_of_the_range = new TextBox();
            textBoxStartValue_of_the_range = new TextBox();
            groupBoxTask.SuspendLayout();
            groupBoxOutput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction).BeginInit();
            groupBoxInput.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(textBoxCondition);
            groupBoxTask.Location = new Point(12, 12);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(389, 211);
            groupBoxTask.TabIndex = 0;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Условие";
            // 
            // textBoxCondition
            // 
            textBoxCondition.BackColor = SystemColors.Menu;
            textBoxCondition.BorderStyle = BorderStyle.None;
            textBoxCondition.Location = new Point(6, 22);
            textBoxCondition.Multiline = true;
            textBoxCondition.Name = "textBoxCondition";
            textBoxCondition.Size = new Size(377, 189);
            textBoxCondition.TabIndex = 0;
            textBoxCondition.Text = resources.GetString("textBoxCondition.Text");
            // 
            // groupBoxOutput
            // 
            groupBoxOutput.Controls.Add(chartFunction);
            groupBoxOutput.Controls.Add(textBoxResult);
            groupBoxOutput.Controls.Add(textBoxTitleResult);
            groupBoxOutput.Location = new Point(407, 12);
            groupBoxOutput.Name = "groupBoxOutput";
            groupBoxOutput.Size = new Size(581, 426);
            groupBoxOutput.TabIndex = 1;
            groupBoxOutput.TabStop = false;
            groupBoxOutput.Text = "Вывод данных";
            // 
            // chartFunction
            // 
            chartArea1.AxisX.Title = "Ось X";
            chartArea1.AxisY.Title = "Ось Y";
            chartArea1.Name = "ChartArea1";
            chartFunction.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            chartFunction.Legends.Add(legend1);
            chartFunction.Location = new Point(242, 54);
            chartFunction.Name = "chartFunction";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction.Series.Add(series1);
            chartFunction.Size = new Size(333, 366);
            chartFunction.TabIndex = 8;
            title1.Alignment = ContentAlignment.TopCenter;
            title1.Name = "Title1";
            title1.Text = "График функции";
            chartFunction.Titles.Add(title1);
            // 
            // textBoxResult
            // 
            textBoxResult.BackColor = SystemColors.Window;
            textBoxResult.BorderStyle = BorderStyle.None;
            textBoxResult.Location = new Point(6, 54);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.Size = new Size(230, 366);
            textBoxResult.TabIndex = 7;
            // 
            // textBoxTitleResult
            // 
            textBoxTitleResult.BackColor = SystemColors.Menu;
            textBoxTitleResult.BorderStyle = BorderStyle.None;
            textBoxTitleResult.Location = new Point(6, 32);
            textBoxTitleResult.Name = "textBoxTitleResult";
            textBoxTitleResult.Size = new Size(100, 16);
            textBoxTitleResult.TabIndex = 5;
            textBoxTitleResult.Text = "Результат:";
            // 
            // groupBoxInput
            // 
            groupBoxInput.Controls.Add(buttonSave);
            groupBoxInput.Controls.Add(buttonHelp);
            groupBoxInput.Controls.Add(buttonDone);
            groupBoxInput.Controls.Add(textBoxTitleEndValue_of_the_range);
            groupBoxInput.Controls.Add(textBoxTitleStartValue_of_the_range);
            groupBoxInput.Controls.Add(textBoxEndValue_of_the_range);
            groupBoxInput.Controls.Add(textBoxStartValue_of_the_range);
            groupBoxInput.Location = new Point(12, 229);
            groupBoxInput.Name = "groupBoxInput";
            groupBoxInput.Size = new Size(389, 209);
            groupBoxInput.TabIndex = 2;
            groupBoxInput.TabStop = false;
            groupBoxInput.Text = "Ввод данных";
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.DodgerBlue;
            buttonSave.FlatAppearance.BorderSize = 0;
            buttonSave.Location = new Point(308, 169);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 40);
            buttonSave.TabIndex = 7;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonHelp
            // 
            buttonHelp.BackColor = Color.DodgerBlue;
            buttonHelp.FlatAppearance.BorderSize = 0;
            buttonHelp.Location = new Point(0, 169);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(75, 40);
            buttonHelp.TabIndex = 6;
            buttonHelp.Text = "Справка";
            buttonHelp.UseVisualStyleBackColor = false;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // buttonDone
            // 
            buttonDone.BackColor = Color.Green;
            buttonDone.FlatAppearance.BorderSize = 0;
            buttonDone.Location = new Point(207, 169);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(95, 40);
            buttonDone.TabIndex = 5;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = false;
            buttonDone.Click += buttonDone_Click;
            // 
            // textBoxTitleEndValue_of_the_range
            // 
            textBoxTitleEndValue_of_the_range.BackColor = SystemColors.Menu;
            textBoxTitleEndValue_of_the_range.BorderStyle = BorderStyle.None;
            textBoxTitleEndValue_of_the_range.Location = new Point(208, 94);
            textBoxTitleEndValue_of_the_range.Name = "textBoxTitleEndValue_of_the_range";
            textBoxTitleEndValue_of_the_range.Size = new Size(100, 16);
            textBoxTitleEndValue_of_the_range.TabIndex = 4;
            textBoxTitleEndValue_of_the_range.Text = "Конец шага:";
            // 
            // textBoxTitleStartValue_of_the_range
            // 
            textBoxTitleStartValue_of_the_range.BackColor = SystemColors.Menu;
            textBoxTitleStartValue_of_the_range.BorderStyle = BorderStyle.None;
            textBoxTitleStartValue_of_the_range.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxTitleStartValue_of_the_range.Location = new Point(6, 94);
            textBoxTitleStartValue_of_the_range.Name = "textBoxTitleStartValue_of_the_range";
            textBoxTitleStartValue_of_the_range.Size = new Size(100, 16);
            textBoxTitleStartValue_of_the_range.TabIndex = 3;
            textBoxTitleStartValue_of_the_range.Text = "Старт шага:";
            // 
            // textBoxEndValue_of_the_range
            // 
            textBoxEndValue_of_the_range.BorderStyle = BorderStyle.None;
            textBoxEndValue_of_the_range.Location = new Point(208, 116);
            textBoxEndValue_of_the_range.Name = "textBoxEndValue_of_the_range";
            textBoxEndValue_of_the_range.Size = new Size(100, 16);
            textBoxEndValue_of_the_range.TabIndex = 2;
            // 
            // textBoxStartValue_of_the_range
            // 
            textBoxStartValue_of_the_range.BorderStyle = BorderStyle.None;
            textBoxStartValue_of_the_range.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxStartValue_of_the_range.Location = new Point(6, 116);
            textBoxStartValue_of_the_range.Name = "textBoxStartValue_of_the_range";
            textBoxStartValue_of_the_range.Size = new Size(100, 16);
            textBoxStartValue_of_the_range.TabIndex = 1;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 450);
            Controls.Add(groupBoxInput);
            Controls.Add(groupBoxOutput);
            Controls.Add(groupBoxTask);
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Спринт 6 | Таск 4 | Вариант 11 | Шахов Д.К";
            groupBoxTask.ResumeLayout(false);
            groupBoxTask.PerformLayout();
            groupBoxOutput.ResumeLayout(false);
            groupBoxOutput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction).EndInit();
            groupBoxInput.ResumeLayout(false);
            groupBoxInput.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask;
        private GroupBox groupBoxOutput;
        private GroupBox groupBoxInput;
        private TextBox textBoxCondition;
        private TextBox textBoxEndValue_of_the_range;
        private TextBox textBoxStartValue_of_the_range;
        private TextBox textBoxTitleEndValue_of_the_range;
        private TextBox textBoxTitleStartValue_of_the_range;
        private TextBox textBoxTitleResult;
        private Button buttonHelp;
        private Button buttonDone;
        private TextBox textBoxResult;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction;
        private Button buttonSave;
    }
}
