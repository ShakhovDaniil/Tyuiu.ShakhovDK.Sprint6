namespace Tyuiu.ShakhovDK.Sprint6.Task6.V24
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            labelInfo = new Label();
            buttonOK = new Button();
            pictureBoxAvatar = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar).BeginInit();
            SuspendLayout();
            // 
            // labelInfo
            // 
            labelInfo.AutoSize = true;
            labelInfo.Location = new Point(161, 9);
            labelInfo.Name = "labelInfo";
            labelInfo.Size = new Size(302, 105);
            labelInfo.TabIndex = 0;
            labelInfo.Text = resources.GetString("labelInfo.Text");
            // 
            // buttonOK
            // 
            buttonOK.Location = new Point(388, 143);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(75, 23);
            buttonOK.TabIndex = 1;
            buttonOK.Text = "OK";
            buttonOK.UseVisualStyleBackColor = true;
            buttonOK.Click += buttonOK_Click;
            // 
            // pictureBoxAvatar
            // 
            pictureBoxAvatar.Image = (Image)resources.GetObject("pictureBoxAvatar.Image");
            pictureBoxAvatar.Location = new Point(1, 9);
            pictureBoxAvatar.Name = "pictureBoxAvatar";
            pictureBoxAvatar.Size = new Size(154, 157);
            pictureBoxAvatar.TabIndex = 2;
            pictureBoxAvatar.TabStop = false;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(475, 178);
            Controls.Add(pictureBoxAvatar);
            Controls.Add(buttonOK);
            Controls.Add(labelInfo);
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FormAbout";
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelInfo;
        private Button buttonOK;
        private PictureBox pictureBoxAvatar;
    }
}