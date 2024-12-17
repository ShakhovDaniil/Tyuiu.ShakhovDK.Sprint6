namespace Tyuiu.ShakhovDK.Sprint6.Task3.V29
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
            groupBoxTask = new GroupBox();
            textBoxCondition = new TextBox();
            groupBoxOutput = new GroupBox();
            dataGridViewResult = new DataGridView();
            buttonDone = new Button();
            buttonHelp = new Button();
            textBoxTitleResult = new TextBox();
            dataGridViewMatrix = new DataGridView();
            groupBoxTask.SuspendLayout();
            groupBoxOutput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(textBoxCondition);
            groupBoxTask.Location = new Point(12, 12);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(389, 426);
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
            textBoxCondition.Size = new Size(377, 271);
            textBoxCondition.TabIndex = 10;
            textBoxCondition.Text = resources.GetString("textBoxCondition.Text");
            textBoxCondition.Enter += textBoxCondition_Enter;
            // 
            // groupBoxOutput
            // 
            groupBoxOutput.Controls.Add(dataGridViewResult);
            groupBoxOutput.Controls.Add(buttonDone);
            groupBoxOutput.Controls.Add(buttonHelp);
            groupBoxOutput.Controls.Add(textBoxTitleResult);
            groupBoxOutput.Location = new Point(545, 12);
            groupBoxOutput.Name = "groupBoxOutput";
            groupBoxOutput.Size = new Size(229, 426);
            groupBoxOutput.TabIndex = 1;
            groupBoxOutput.TabStop = false;
            groupBoxOutput.Text = "Вывод данных";
            // 
            // dataGridViewResult
            // 
            dataGridViewResult.BackgroundColor = SystemColors.Menu;
            dataGridViewResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult.Location = new Point(0, 44);
            dataGridViewResult.Name = "dataGridViewResult";
            dataGridViewResult.ReadOnly = true;
            dataGridViewResult.Size = new Size(170, 291);
            dataGridViewResult.TabIndex = 7;
            // 
            // buttonDone
            // 
            buttonDone.BackColor = SystemColors.Window;
            buttonDone.FlatAppearance.BorderSize = 0;
            buttonDone.FlatStyle = FlatStyle.System;
            buttonDone.Location = new Point(134, 386);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(95, 40);
            buttonDone.TabIndex = 5;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = false;
            buttonDone.Click += buttonDone_Click;
            // 
            // buttonHelp
            // 
            buttonHelp.BackColor = SystemColors.Menu;
            buttonHelp.FlatAppearance.BorderSize = 0;
            buttonHelp.FlatStyle = FlatStyle.System;
            buttonHelp.Location = new Point(0, 404);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(25, 22);
            buttonHelp.TabIndex = 6;
            buttonHelp.Text = "?";
            buttonHelp.UseVisualStyleBackColor = false;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // textBoxTitleResult
            // 
            textBoxTitleResult.BackColor = SystemColors.Menu;
            textBoxTitleResult.BorderStyle = BorderStyle.None;
            textBoxTitleResult.Location = new Point(6, 22);
            textBoxTitleResult.Name = "textBoxTitleResult";
            textBoxTitleResult.Size = new Size(100, 16);
            textBoxTitleResult.TabIndex = 5;
            textBoxTitleResult.Text = "Результат:";
            // 
            // dataGridViewMatrix
            // 
            dataGridViewMatrix.AllowUserToDeleteRows = false;
            dataGridViewMatrix.BackgroundColor = SystemColors.Menu;
            dataGridViewMatrix.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMatrix.Location = new Point(401, 20);
            dataGridViewMatrix.Name = "dataGridViewMatrix";
            dataGridViewMatrix.ReadOnly = true;
            dataGridViewMatrix.RowHeadersVisible = false;
            dataGridViewMatrix.Size = new Size(128, 418);
            dataGridViewMatrix.TabIndex = 7;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(786, 450);
            Controls.Add(groupBoxOutput);
            Controls.Add(groupBoxTask);
            Controls.Add(dataGridViewMatrix);
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Спринт 6 | Таск 3 | Вариант 29 | Шахов Д.К";
            Load += FormMain_Load;
            groupBoxTask.ResumeLayout(false);
            groupBoxTask.PerformLayout();
            groupBoxOutput.ResumeLayout(false);
            groupBoxOutput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask;
        private GroupBox groupBoxOutput;
        private TextBox textBoxCondition;
        private TextBox textBoxTitleResult;
        private Button buttonHelp;
        private Button buttonDone;
        private DataGridView dataGridViewMatrix;
        private DataGridView dataGridViewResult;
    }
}
