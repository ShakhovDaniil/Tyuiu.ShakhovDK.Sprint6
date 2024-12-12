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
            resources.ApplyResources(groupBoxTask, "groupBoxTask");
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.TabStop = false;
            // 
            // pictureBoxFormula
            // 
            resources.ApplyResources(pictureBoxFormula, "pictureBoxFormula");
            pictureBoxFormula.Name = "pictureBoxFormula";
            pictureBoxFormula.TabStop = false;
            // 
            // textBoxCondition
            // 
            textBoxCondition.BackColor = SystemColors.Menu;
            textBoxCondition.BorderStyle = BorderStyle.None;
            resources.ApplyResources(textBoxCondition, "textBoxCondition");
            textBoxCondition.Name = "textBoxCondition";
            // 
            // groupBoxInput
            // 
            groupBoxInput.Controls.Add(textBoxTitle_Var);
            groupBoxInput.Controls.Add(textBoxVar_X);
            resources.ApplyResources(groupBoxInput, "groupBoxInput");
            groupBoxInput.Name = "groupBoxInput";
            groupBoxInput.TabStop = false;
            // 
            // textBoxTitle_Var
            // 
            textBoxTitle_Var.BackColor = SystemColors.Menu;
            textBoxTitle_Var.BorderStyle = BorderStyle.None;
            resources.ApplyResources(textBoxTitle_Var, "textBoxTitle_Var");
            textBoxTitle_Var.Name = "textBoxTitle_Var";
            // 
            // textBoxVar_X
            // 
            resources.ApplyResources(textBoxVar_X, "textBoxVar_X");
            textBoxVar_X.BorderStyle = BorderStyle.FixedSingle;
            textBoxVar_X.Name = "textBoxVar_X";
            textBoxVar_X.KeyPress += textBoxVar_X_KeyPress;
            // 
            // buttonDone
            // 
            buttonDone.BackColor = SystemColors.MenuBar;
            resources.ApplyResources(buttonDone, "buttonDone");
            buttonDone.Name = "buttonDone";
            buttonDone.UseVisualStyleBackColor = false;
            buttonDone.Click += buttonDone_Click;
            // 
            // groupBoxOutput
            // 
            groupBoxOutput.Controls.Add(buttonHelp);
            groupBoxOutput.Controls.Add(textBoxResult);
            groupBoxOutput.Controls.Add(textBoxTitle_Result);
            groupBoxOutput.Controls.Add(buttonDone);
            resources.ApplyResources(groupBoxOutput, "groupBoxOutput");
            groupBoxOutput.Name = "groupBoxOutput";
            groupBoxOutput.TabStop = false;
            // 
            // buttonHelp
            // 
            buttonHelp.FlatAppearance.BorderColor = SystemColors.ScrollBar;
            resources.ApplyResources(buttonHelp, "buttonHelp");
            buttonHelp.Name = "buttonHelp";
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // textBoxResult
            // 
            textBoxResult.BackColor = SystemColors.Window;
            textBoxResult.BorderStyle = BorderStyle.FixedSingle;
            resources.ApplyResources(textBoxResult, "textBoxResult");
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            // 
            // textBoxTitle_Result
            // 
            textBoxTitle_Result.BackColor = SystemColors.Menu;
            textBoxTitle_Result.BorderStyle = BorderStyle.None;
            resources.ApplyResources(textBoxTitle_Result, "textBoxTitle_Result");
            textBoxTitle_Result.Name = "textBoxTitle_Result";
            // 
            // FormMain
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBoxOutput);
            Controls.Add(groupBoxInput);
            Controls.Add(groupBoxTask);
            MaximizeBox = false;
            Name = "FormMain";
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
