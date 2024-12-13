namespace Tyuiu.ShakhovDK.Sprint6.Task1.V20
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
            textBoxTitleResult = new TextBox();
            textBoxResult = new TextBox();
            groupBoxInput = new GroupBox();
            buttonHelp = new Button();
            buttonDone = new Button();
            textBoxTitleEndValue_of_the_range = new TextBox();
            textBoxTitleStartValue_of_the_range = new TextBox();
            textBoxEndValue_of_the_range = new TextBox();
            textBoxStartValue_of_the_range = new TextBox();
            groupBoxTask.SuspendLayout();
            groupBoxOutput.SuspendLayout();
            groupBoxInput.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(textBoxCondition);
            groupBoxTask.Location = new Point(12, 12);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(424, 211);
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
            textBoxCondition.Size = new Size(412, 183);
            textBoxCondition.TabIndex = 0;
            textBoxCondition.Text = resources.GetString("textBoxCondition.Text");
            // 
            // groupBoxOutput
            // 
            groupBoxOutput.Controls.Add(textBoxTitleResult);
            groupBoxOutput.Controls.Add(textBoxResult);
            groupBoxOutput.Location = new Point(442, 12);
            groupBoxOutput.Name = "groupBoxOutput";
            groupBoxOutput.Size = new Size(346, 426);
            groupBoxOutput.TabIndex = 1;
            groupBoxOutput.TabStop = false;
            groupBoxOutput.Text = "Вывод данных";
            // 
            // textBoxTitleResult
            // 
            textBoxTitleResult.BackColor = SystemColors.Menu;
            textBoxTitleResult.BorderStyle = BorderStyle.None;
            textBoxTitleResult.Location = new Point(6, 54);
            textBoxTitleResult.Name = "textBoxTitleResult";
            textBoxTitleResult.Size = new Size(100, 16);
            textBoxTitleResult.TabIndex = 5;
            textBoxTitleResult.Text = "Результат:";
            // 
            // textBoxResult
            // 
            textBoxResult.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxResult.Location = new Point(6, 76);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.ScrollBars = ScrollBars.Vertical;
            textBoxResult.Size = new Size(334, 344);
            textBoxResult.TabIndex = 3;
            // 
            // groupBoxInput
            // 
            groupBoxInput.Controls.Add(buttonHelp);
            groupBoxInput.Controls.Add(buttonDone);
            groupBoxInput.Controls.Add(textBoxTitleEndValue_of_the_range);
            groupBoxInput.Controls.Add(textBoxTitleStartValue_of_the_range);
            groupBoxInput.Controls.Add(textBoxEndValue_of_the_range);
            groupBoxInput.Controls.Add(textBoxStartValue_of_the_range);
            groupBoxInput.Location = new Point(12, 229);
            groupBoxInput.Name = "groupBoxInput";
            groupBoxInput.Size = new Size(424, 209);
            groupBoxInput.TabIndex = 2;
            groupBoxInput.TabStop = false;
            groupBoxInput.Text = "Ввод данных";
            // 
            // buttonHelp
            // 
            buttonHelp.BackColor = Color.DodgerBlue;
            buttonHelp.FlatAppearance.BorderSize = 0;
            buttonHelp.Location = new Point(242, 161);
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
            buttonDone.Location = new Point(323, 161);
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
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxInput);
            Controls.Add(groupBoxOutput);
            Controls.Add(groupBoxTask);
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Спринт 6 | Таск 1 | Вариант 20 | Шахов Д.К";
            groupBoxTask.ResumeLayout(false);
            groupBoxTask.PerformLayout();
            groupBoxOutput.ResumeLayout(false);
            groupBoxOutput.PerformLayout();
            groupBoxInput.ResumeLayout(false);
            groupBoxInput.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask;
        private GroupBox groupBoxOutput;
        private GroupBox groupBoxInput;
        private TextBox textBoxCondition;
        private TextBox textBoxResult;
        private TextBox textBoxEndValue_of_the_range;
        private TextBox textBoxStartValue_of_the_range;
        private TextBox textBoxTitleEndValue_of_the_range;
        private TextBox textBoxTitleStartValue_of_the_range;
        private TextBox textBoxTitleResult;
        private Button buttonHelp;
        private Button buttonDone;
    }
}
