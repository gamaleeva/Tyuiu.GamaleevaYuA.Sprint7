namespace Tyuiu.GamaleevaYuA.Sprint7.Project.V11
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
            pictureBoxAbout_GYA = new PictureBox();
            labelAbout_GYA = new Label();
            buttonOK_GYA = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAbout_GYA).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxAbout_GYA
            // 
            pictureBoxAbout_GYA.Image = (Image)resources.GetObject("pictureBoxAbout_GYA.Image");
            pictureBoxAbout_GYA.Location = new Point(29, 39);
            pictureBoxAbout_GYA.Name = "pictureBoxAbout_GYA";
            pictureBoxAbout_GYA.Size = new Size(138, 177);
            pictureBoxAbout_GYA.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxAbout_GYA.TabIndex = 0;
            pictureBoxAbout_GYA.TabStop = false;
            // 
            // labelAbout_GYA
            // 
            labelAbout_GYA.AutoSize = true;
            labelAbout_GYA.Location = new Point(173, 39);
            labelAbout_GYA.Name = "labelAbout_GYA";
            labelAbout_GYA.Size = new Size(303, 150);
            labelAbout_GYA.TabIndex = 1;
            labelAbout_GYA.Text = resources.GetString("labelAbout_GYA.Text");
            // 
            // buttonOK_GYA
            // 
            buttonOK_GYA.BackColor = Color.LightGray;
            buttonOK_GYA.FlatStyle = FlatStyle.System;
            buttonOK_GYA.Location = new Point(390, 211);
            buttonOK_GYA.Name = "buttonOK_GYA";
            buttonOK_GYA.Size = new Size(75, 23);
            buttonOK_GYA.TabIndex = 2;
            buttonOK_GYA.Text = "OK";
            buttonOK_GYA.UseVisualStyleBackColor = false;
            buttonOK_GYA.Click += buttonOK_GYA_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(488, 255);
            Controls.Add(buttonOK_GYA);
            Controls.Add(labelAbout_GYA);
            Controls.Add(pictureBoxAbout_GYA);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBoxAbout_GYA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxAbout_GYA;
        private Label labelAbout_GYA;
        private Button buttonOK_GYA;
    }
}