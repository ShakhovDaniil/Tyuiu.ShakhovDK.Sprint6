namespace Tyuiu.ShakhovDK.Sprint6.Task0.V10
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
            pictureBoxFormula = new PictureBox();
            textBoxCondition = new TextBox();
            groupBoxInput = new GroupBox();
            textBoxTitle_Var = new TextBox();
            textBoxVar_X = new TextBox();
            buttonDone = new Button();
            groupBoxOutput = new GroupBox();
            buttonHelp = new Button();
            textBoxResult = new TextBox();
            textBoxTitle_Result = new TextBox();
            groupBoxTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula).BeginInit();
            groupBoxInput.SuspendLayout();
            groupBoxOutput.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(pictureBoxFormula);
            groupBoxTask.Controls.Add(textBoxCondition);
            groupBoxTask.Location = new Point(5, 12);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(789, 201);
            groupBoxTask.TabIndex = 0;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Условие";
            // 
            // pictureBoxFormula
            // 
            pictureBoxFormula.Image = (Image)resources.GetObject("pictureBoxFormula.Image");
            pictureBoxFormula.Location = new Point(450, 22);
            pictureBoxFormula.Name = "pictureBoxFormula";
            pictureBoxFormula.Size = new Size(333, 38);
            pictureBoxFormula.TabIndex = 1;
            pictureBoxFormula.TabStop = false;
            // 
            // textBoxCondition
            // 
            textBoxCondition.BackColor = SystemColors.Menu;
            textBoxCondition.BorderStyle = BorderStyle.None;
            textBoxCondition.Location = new Point(6, 22);
            textBoxCondition.Multiline = true;
            textBoxCondition.Name = "textBoxCondition";
            textBoxCondition.Size = new Size(406, 173);
            textBoxCondition.TabIndex = 0;
            textBoxCondition.Text = "Вычислить выражение по формуле";
            // 
            // groupBoxInput
            // 
            groupBoxInput.Controls.Add(textBoxTitle_Var);
            groupBoxInput.Controls.Add(textBoxVar_X);
            groupBoxInput.Location = new Point(5, 219);
            groupBoxInput.Name = "groupBoxInput";
            groupBoxInput.Size = new Size(385, 219);
            groupBoxInput.TabIndex = 1;
            groupBoxInput.TabStop = false;
            groupBoxInput.Text = "Ввод данных";
            // 
            // textBoxTitle_Var
            // 
            textBoxTitle_Var.BackColor = SystemColors.Menu;
            textBoxTitle_Var.BorderStyle = BorderStyle.None;
            textBoxTitle_Var.Location = new Point(7, 85);
            textBoxTitle_Var.Name = "textBoxTitle_Var";
            textBoxTitle_Var.Size = new Size(85, 16);
            textBoxTitle_Var.TabIndex = 1;
            textBoxTitle_Var.Text = "Переменная x:";
            // 
            // textBoxVar_X
            // 
            textBoxVar_X.AccessibleDescription = "";
            textBoxVar_X.BorderStyle = BorderStyle.FixedSingle;
            textBoxVar_X.Location = new Point(6, 107);
            textBoxVar_X.Name = "textBoxVar_X";
            textBoxVar_X.Size = new Size(85, 23);
            textBoxVar_X.TabIndex = 0;
            textBoxVar_X.KeyPress += textBoxVar_X_KeyPress;
            // 
            // buttonDone
            // 
            buttonDone.BackColor = SystemColors.MenuBar;
            buttonDone.FlatStyle = FlatStyle.System;
            buttonDone.Location = new Point(213, 159);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(173, 54);
            buttonDone.TabIndex = 2;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = false;
            buttonDone.Click += buttonDone_Click;
            // 
            // groupBoxOutput
            // 
            groupBoxOutput.Controls.Add(buttonHelp);
            groupBoxOutput.Controls.Add(textBoxResult);
            groupBoxOutput.Controls.Add(textBoxTitle_Result);
            groupBoxOutput.Controls.Add(buttonDone);
            groupBoxOutput.Location = new Point(396, 219);
            groupBoxOutput.Name = "groupBoxOutput";
            groupBoxOutput.Size = new Size(392, 219);
            groupBoxOutput.TabIndex = 3;
            groupBoxOutput.TabStop = false;
            groupBoxOutput.Text = "Вывод данных";
            // 
            // buttonHelp
            // 
            buttonHelp.FlatAppearance.BorderColor = SystemColors.ScrollBar;
            buttonHelp.FlatStyle = FlatStyle.Flat;
            buttonHelp.Location = new Point(172, 182);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(35, 31);
            buttonHelp.TabIndex = 5;
            buttonHelp.Text = "?";
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // textBoxResult
            // 
            textBoxResult.BackColor = SystemColors.Window;
            textBoxResult.BorderStyle = BorderStyle.FixedSingle;
            textBoxResult.Location = new Point(6, 107);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.Size = new Size(380, 46);
            textBoxResult.TabIndex = 4;
            // 
            // textBoxTitle_Result
            // 
            textBoxTitle_Result.BackColor = SystemColors.Menu;
            textBoxTitle_Result.BorderStyle = BorderStyle.None;
            textBoxTitle_Result.Location = new Point(6, 85);
            textBoxTitle_Result.Name = "textBoxTitle_Result";
            textBoxTitle_Result.Size = new Size(100, 16);
            textBoxTitle_Result.TabIndex = 3;
            textBoxTitle_Result.Text = "Результат:";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxOutput);
            Controls.Add(groupBoxInput);
            Controls.Add(groupBoxTask);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 0 | Вариант 10 | Шахов Д.К";
            groupBoxTask.ResumeLayout(false);
            groupBoxTask.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula).EndInit();
            groupBoxInput.ResumeLayout(false);
            groupBoxInput.PerformLayout();
            groupBoxOutput.ResumeLayout(false);
            groupBoxOutput.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask;
        private TextBox textBoxCondition;
        private PictureBox pictureBoxFormula;
        private GroupBox groupBoxInput;
        private TextBox textBoxVar_X;
        private Button buttonDone;
        private GroupBox groupBoxOutput;
        private TextBox textBoxTitle_Var;
        private TextBox textBoxTitle_Result;
        private TextBox textBoxResult;
        private Button buttonHelp;
    }
}
