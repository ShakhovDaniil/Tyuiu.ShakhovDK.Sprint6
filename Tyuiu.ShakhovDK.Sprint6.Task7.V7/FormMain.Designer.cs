namespace Tyuiu.ShakhovDK.Sprint6.Task6.V24
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panelButtons = new Panel();
            groupBoxButtons = new GroupBox();
            buttonSaveFile = new Button();
            buttonAboutProgram = new Button();
            buttonDone = new Button();
            buttonOpenFile = new Button();
            groupBoxTask = new GroupBox();
            textBoxTask = new TextBox();
            panelTask = new Panel();
            panelInput = new Panel();
            splitterIn = new Splitter();
            groupBoxInput = new GroupBox();
            dataGridViewIn = new DataGridView();
            panelOut = new Panel();
            splitterOut = new Splitter();
            groupBoxOutput = new GroupBox();
            dataGridViewOut = new DataGridView();
            openFileDialogTask = new OpenFileDialog();
            toolTipInfo = new ToolTip(components);
            saveFileDialogMatrix = new SaveFileDialog();
            panelButtons.SuspendLayout();
            groupBoxButtons.SuspendLayout();
            groupBoxTask.SuspendLayout();
            panelTask.SuspendLayout();
            panelInput.SuspendLayout();
            groupBoxInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn).BeginInit();
            panelOut.SuspendLayout();
            groupBoxOutput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut).BeginInit();
            SuspendLayout();
            // 
            // panelButtons
            // 
            panelButtons.Controls.Add(groupBoxButtons);
            panelButtons.Dock = DockStyle.Top;
            panelButtons.Location = new Point(0, 0);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new Size(784, 100);
            panelButtons.TabIndex = 1;
            // 
            // groupBoxButtons
            // 
            groupBoxButtons.Controls.Add(buttonSaveFile);
            groupBoxButtons.Controls.Add(buttonAboutProgram);
            groupBoxButtons.Controls.Add(buttonDone);
            groupBoxButtons.Controls.Add(buttonOpenFile);
            groupBoxButtons.Dock = DockStyle.Fill;
            groupBoxButtons.Location = new Point(0, 0);
            groupBoxButtons.Name = "groupBoxButtons";
            groupBoxButtons.Size = new Size(784, 100);
            groupBoxButtons.TabIndex = 0;
            groupBoxButtons.TabStop = false;
            // 
            // buttonSaveFile
            // 
            buttonSaveFile.BackColor = SystemColors.Menu;
            buttonSaveFile.Enabled = false;
            buttonSaveFile.Image = (Image)resources.GetObject("buttonSaveFile.Image");
            buttonSaveFile.Location = new Point(154, 22);
            buttonSaveFile.Name = "buttonSaveFile";
            buttonSaveFile.Size = new Size(66, 66);
            buttonSaveFile.TabIndex = 1;
            buttonSaveFile.UseVisualStyleBackColor = false;
            buttonSaveFile.Click += buttonSaveFile_Click;
            buttonSaveFile.MouseEnter += buttonSaveFile_MouseEnter;
            // 
            // buttonAboutProgram
            // 
            buttonAboutProgram.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            buttonAboutProgram.BackColor = SystemColors.Menu;
            buttonAboutProgram.Image = (Image)resources.GetObject("buttonAboutProgram.Image");
            buttonAboutProgram.Location = new Point(714, 22);
            buttonAboutProgram.Name = "buttonAboutProgram";
            buttonAboutProgram.Size = new Size(66, 66);
            buttonAboutProgram.TabIndex = 0;
            toolTipInfo.SetToolTip(buttonAboutProgram, "Сведения о программе");
            buttonAboutProgram.UseVisualStyleBackColor = false;
            buttonAboutProgram.Click += buttonAboutProgram_Click;
            buttonAboutProgram.MouseEnter += buttonAboutProgram_MouseEnter;
            // 
            // buttonDone
            // 
            buttonDone.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            buttonDone.BackColor = SystemColors.Menu;
            buttonDone.Enabled = false;
            buttonDone.Image = (Image)resources.GetObject("buttonDone.Image");
            buttonDone.Location = new Point(84, 22);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(66, 66);
            buttonDone.TabIndex = 0;
            toolTipInfo.SetToolTip(buttonDone, "Выводит первое слово каждой строки в результирующую строку");
            buttonDone.UseVisualStyleBackColor = false;
            buttonDone.Click += buttonDone_Click;
            buttonDone.MouseEnter += buttonDone_MouseEnter;
            // 
            // buttonOpenFile
            // 
            buttonOpenFile.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            buttonOpenFile.BackColor = SystemColors.Menu;
            buttonOpenFile.Image = (Image)resources.GetObject("buttonOpenFile.Image");
            buttonOpenFile.Location = new Point(12, 22);
            buttonOpenFile.Name = "buttonOpenFile";
            buttonOpenFile.Size = new Size(66, 66);
            buttonOpenFile.TabIndex = 0;
            toolTipInfo.SetToolTip(buttonOpenFile, "Открыть файл\r\nВыберите нужный файл для обработки\r\n");
            buttonOpenFile.UseVisualStyleBackColor = false;
            buttonOpenFile.Click += buttonOpenFile_Click;
            buttonOpenFile.MouseEnter += buttonOpenFile_MouseEnter;
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(textBoxTask);
            groupBoxTask.Dock = DockStyle.Fill;
            groupBoxTask.Location = new Point(0, 0);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(784, 100);
            groupBoxTask.TabIndex = 2;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Условие";
            // 
            // textBoxTask
            // 
            textBoxTask.BackColor = SystemColors.Menu;
            textBoxTask.Dock = DockStyle.Fill;
            textBoxTask.Location = new Point(3, 19);
            textBoxTask.Multiline = true;
            textBoxTask.Name = "textBoxTask";
            textBoxTask.Size = new Size(778, 78);
            textBoxTask.TabIndex = 0;
            textBoxTask.Text = resources.GetString("textBoxTask.Text");
            // 
            // panelTask
            // 
            panelTask.Controls.Add(groupBoxTask);
            panelTask.Dock = DockStyle.Top;
            panelTask.Location = new Point(0, 100);
            panelTask.Name = "panelTask";
            panelTask.Size = new Size(784, 100);
            panelTask.TabIndex = 3;
            // 
            // panelInput
            // 
            panelInput.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelInput.Controls.Add(splitterIn);
            panelInput.Controls.Add(groupBoxInput);
            panelInput.Location = new Point(0, 200);
            panelInput.Name = "panelInput";
            panelInput.Size = new Size(390, 361);
            panelInput.TabIndex = 4;
            // 
            // splitterIn
            // 
            splitterIn.Dock = DockStyle.Right;
            splitterIn.Location = new Point(387, 0);
            splitterIn.Name = "splitterIn";
            splitterIn.Size = new Size(3, 361);
            splitterIn.TabIndex = 1;
            splitterIn.TabStop = false;
            // 
            // groupBoxInput
            // 
            groupBoxInput.Controls.Add(dataGridViewIn);
            groupBoxInput.Dock = DockStyle.Fill;
            groupBoxInput.Location = new Point(0, 0);
            groupBoxInput.Name = "groupBoxInput";
            groupBoxInput.Size = new Size(390, 361);
            groupBoxInput.TabIndex = 0;
            groupBoxInput.TabStop = false;
            groupBoxInput.Text = "Ввод";
            // 
            // dataGridViewIn
            // 
            dataGridViewIn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewIn.ColumnHeadersVisible = false;
            dataGridViewIn.Dock = DockStyle.Fill;
            dataGridViewIn.Location = new Point(3, 19);
            dataGridViewIn.Name = "dataGridViewIn";
            dataGridViewIn.RowHeadersVisible = false;
            dataGridViewIn.Size = new Size(384, 339);
            dataGridViewIn.TabIndex = 0;
            // 
            // panelOut
            // 
            panelOut.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelOut.Controls.Add(splitterOut);
            panelOut.Controls.Add(groupBoxOutput);
            panelOut.Location = new Point(394, 200);
            panelOut.Name = "panelOut";
            panelOut.Size = new Size(390, 361);
            panelOut.TabIndex = 4;
            // 
            // splitterOut
            // 
            splitterOut.Location = new Point(0, 0);
            splitterOut.Name = "splitterOut";
            splitterOut.Size = new Size(3, 361);
            splitterOut.TabIndex = 1;
            splitterOut.TabStop = false;
            // 
            // groupBoxOutput
            // 
            groupBoxOutput.Controls.Add(dataGridViewOut);
            groupBoxOutput.Dock = DockStyle.Fill;
            groupBoxOutput.Location = new Point(0, 0);
            groupBoxOutput.Name = "groupBoxOutput";
            groupBoxOutput.Size = new Size(390, 361);
            groupBoxOutput.TabIndex = 0;
            groupBoxOutput.TabStop = false;
            groupBoxOutput.Text = "Вывод";
            // 
            // dataGridViewOut
            // 
            dataGridViewOut.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOut.ColumnHeadersVisible = false;
            dataGridViewOut.Dock = DockStyle.Fill;
            dataGridViewOut.Location = new Point(3, 19);
            dataGridViewOut.Name = "dataGridViewOut";
            dataGridViewOut.RowHeadersVisible = false;
            dataGridViewOut.Size = new Size(384, 339);
            dataGridViewOut.TabIndex = 0;
            // 
            // openFileDialogTask
            // 
            openFileDialogTask.FileName = "openFileDialogTask";
            // 
            // toolTipInfo
            // 
            toolTipInfo.IsBalloon = true;
            toolTipInfo.ToolTipIcon = ToolTipIcon.Info;
            toolTipInfo.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(panelOut);
            Controls.Add(panelInput);
            Controls.Add(panelTask);
            Controls.Add(panelButtons);
            MinimumSize = new Size(800, 600);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 7 | Вариант 7 | Шахов Д.К";
            panelButtons.ResumeLayout(false);
            groupBoxButtons.ResumeLayout(false);
            groupBoxTask.ResumeLayout(false);
            groupBoxTask.PerformLayout();
            panelTask.ResumeLayout(false);
            panelInput.ResumeLayout(false);
            groupBoxInput.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn).EndInit();
            panelOut.ResumeLayout(false);
            groupBoxOutput.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelButtons;
        private GroupBox groupBoxButtons;
        private Button buttonAboutProgram;
        private Button buttonDone;
        private Button buttonOpenFile;
        private GroupBox groupBoxTask;
        private Panel panelTask;
        private TextBox textBoxTask;
        private Panel panelInput;
        private Panel panelOut;
        private GroupBox groupBoxInput;
        private GroupBox groupBoxOutput;
        private OpenFileDialog openFileDialogTask;
        private ToolTip toolTipInfo;
        private Splitter splitterIn;
        private Splitter splitterOut;
        private DataGridView dataGridViewIn;
        private DataGridView dataGridViewOut;
        private SaveFileDialog saveFileDialogMatrix;
        private Button buttonSaveFile;
    }
}
