namespace Tyuiu.ShakhovDK.Sprint6.Task5.V23
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            groupBoxTask = new GroupBox();
            textBoxCondition = new TextBox();
            groupBoxOutput = new GroupBox();
            dataGridViewNums = new DataGridView();
            ColumnIndex = new DataGridViewTextBoxColumn();
            ColumnNum = new DataGridViewTextBoxColumn();
            chartDiag = new System.Windows.Forms.DataVisualization.Charting.Chart();
            buttonOpenFile = new Button();
            buttonHelp = new Button();
            buttonDone = new Button();
            panelTask = new Panel();
            panelOutput = new Panel();
            panelDiag = new Panel();
            groupBoxTask.SuspendLayout();
            groupBoxOutput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewNums).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartDiag).BeginInit();
            panelTask.SuspendLayout();
            panelOutput.SuspendLayout();
            panelDiag.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(textBoxCondition);
            groupBoxTask.Dock = DockStyle.Left;
            groupBoxTask.Location = new Point(0, 0);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(713, 107);
            groupBoxTask.TabIndex = 5;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Условие";
            // 
            // textBoxCondition
            // 
            textBoxCondition.BackColor = SystemColors.Menu;
            textBoxCondition.BorderStyle = BorderStyle.None;
            textBoxCondition.Dock = DockStyle.Fill;
            textBoxCondition.Location = new Point(3, 19);
            textBoxCondition.Multiline = true;
            textBoxCondition.Name = "textBoxCondition";
            textBoxCondition.Size = new Size(707, 85);
            textBoxCondition.TabIndex = 6;
            textBoxCondition.Text = "Прочитать данные из файла InPutFileTask5V23.txt. Вывести в dataGridView. Вывести все числа, меньше 0. Построить диаграмму по этим значениям";
            // 
            // groupBoxOutput
            // 
            groupBoxOutput.Controls.Add(dataGridViewNums);
            groupBoxOutput.Dock = DockStyle.Fill;
            groupBoxOutput.Location = new Point(0, 0);
            groupBoxOutput.Name = "groupBoxOutput";
            groupBoxOutput.Size = new Size(235, 343);
            groupBoxOutput.TabIndex = 1;
            groupBoxOutput.TabStop = false;
            groupBoxOutput.Text = "Вывод данных";
            // 
            // dataGridViewNums
            // 
            dataGridViewNums.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewNums.Columns.AddRange(new DataGridViewColumn[] { ColumnIndex, ColumnNum });
            dataGridViewNums.Dock = DockStyle.Fill;
            dataGridViewNums.Location = new Point(3, 19);
            dataGridViewNums.Name = "dataGridViewNums";
            dataGridViewNums.ReadOnly = true;
            dataGridViewNums.RowHeadersVisible = false;
            dataGridViewNums.Size = new Size(229, 321);
            dataGridViewNums.TabIndex = 4;
            // 
            // ColumnIndex
            // 
            ColumnIndex.HeaderText = "";
            ColumnIndex.Name = "ColumnIndex";
            ColumnIndex.ReadOnly = true;
            // 
            // ColumnNum
            // 
            ColumnNum.HeaderText = "";
            ColumnNum.Name = "ColumnNum";
            ColumnNum.ReadOnly = true;
            // 
            // chartDiag
            // 
            chartArea3.AxisX.Title = "Ось X";
            chartArea3.AxisY.Title = "Ось Y";
            chartArea3.Name = "ChartArea1";
            chartDiag.ChartAreas.Add(chartArea3);
            chartDiag.Dock = DockStyle.Fill;
            legend3.Enabled = false;
            legend3.Name = "Legend1";
            chartDiag.Legends.Add(legend3);
            chartDiag.Location = new Point(0, 0);
            chartDiag.Name = "chartDiag";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            chartDiag.Series.Add(series3);
            chartDiag.Size = new Size(751, 343);
            chartDiag.TabIndex = 3;
            title3.Alignment = ContentAlignment.TopCenter;
            title3.Name = "Title1";
            title3.Text = "График функции";
            chartDiag.Titles.Add(title3);
            // 
            // buttonOpenFile
            // 
            buttonOpenFile.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonOpenFile.BackColor = Color.DodgerBlue;
            buttonOpenFile.FlatAppearance.BorderSize = 0;
            buttonOpenFile.Location = new Point(905, 12);
            buttonOpenFile.Name = "buttonOpenFile";
            buttonOpenFile.Size = new Size(75, 40);
            buttonOpenFile.TabIndex = 1;
            buttonOpenFile.Text = "Открыть файл";
            buttonOpenFile.UseVisualStyleBackColor = false;
            buttonOpenFile.Click += buttonOpenFile_Click;
            buttonOpenFile.MouseEnter += buttonDone_MouseEnter;
            // 
            // buttonHelp
            // 
            buttonHelp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp.BackColor = Color.DodgerBlue;
            buttonHelp.FlatAppearance.BorderSize = 0;
            buttonHelp.Location = new Point(823, 12);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(75, 40);
            buttonHelp.TabIndex = 2;
            buttonHelp.Text = "Справка";
            buttonHelp.UseVisualStyleBackColor = false;
            buttonHelp.Click += buttonHelp_Click;
            buttonHelp.MouseEnter += buttonDone_MouseEnter;
            // 
            // buttonDone
            // 
            buttonDone.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonDone.BackColor = Color.Green;
            buttonDone.FlatAppearance.BorderSize = 0;
            buttonDone.Location = new Point(722, 12);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(95, 40);
            buttonDone.TabIndex = 0;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = false;
            buttonDone.Click += buttonDone_Click;
            buttonDone.MouseEnter += buttonDone_MouseEnter;
            // 
            // panelTask
            // 
            panelTask.Controls.Add(groupBoxTask);
            panelTask.Controls.Add(buttonOpenFile);
            panelTask.Controls.Add(buttonHelp);
            panelTask.Controls.Add(buttonDone);
            panelTask.Dock = DockStyle.Top;
            panelTask.Location = new Point(0, 0);
            panelTask.Name = "panelTask";
            panelTask.Size = new Size(992, 107);
            panelTask.TabIndex = 0;
            // 
            // panelOutput
            // 
            panelOutput.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelOutput.AutoSize = true;
            panelOutput.Controls.Add(groupBoxOutput);
            panelOutput.Location = new Point(0, 107);
            panelOutput.Name = "panelOutput";
            panelOutput.Size = new Size(235, 343);
            panelOutput.TabIndex = 4;
            // 
            // panelDiag
            // 
            panelDiag.Controls.Add(chartDiag);
            panelDiag.Dock = DockStyle.Right;
            panelDiag.Location = new Point(241, 107);
            panelDiag.Name = "panelDiag";
            panelDiag.Size = new Size(751, 343);
            panelDiag.TabIndex = 5;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(992, 450);
            Controls.Add(panelDiag);
            Controls.Add(panelOutput);
            Controls.Add(panelTask);
            MinimumSize = new Size(1008, 489);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Спринт 6 | Таск 5 | Вариант 23 | Шахов Д.К";
            groupBoxTask.ResumeLayout(false);
            groupBoxTask.PerformLayout();
            groupBoxOutput.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewNums).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartDiag).EndInit();
            panelTask.ResumeLayout(false);
            panelOutput.ResumeLayout(false);
            panelDiag.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxTask;
        private GroupBox groupBoxOutput;
        private TextBox textBoxCondition;
        private Button buttonHelp;
        private Button buttonDone;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDiag;
        private Button buttonOpenFile;
        private DataGridView dataGridViewNums;
        private DataGridViewTextBoxColumn ColumnIndex;
        private DataGridViewTextBoxColumn ColumnNum;
        private Panel panelTask;
        private Panel panelOutput;
        private Panel panelDiag;
    }
}
