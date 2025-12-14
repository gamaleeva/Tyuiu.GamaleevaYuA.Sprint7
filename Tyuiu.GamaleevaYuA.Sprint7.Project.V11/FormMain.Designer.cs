namespace Tyuiu.GamaleevaYuA.Sprint7.Project.V11
{
    partial class FormMain_GYA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain_GYA));
            panelButtonsHelp_GYA = new Panel();
            panelButtonsFunctional_GYA = new Panel();
            panelStatus_GYA = new Panel();
            panelToolbar_GYA = new Panel();
            pictureBoxTools_GYA = new PictureBox();
            splitterTools_GYA = new Splitter();
            panelMainInformation_GYA = new Panel();
            dataGridViewInformaion = new DataGridView();
            ColumnKey = new DataGridViewTextBoxColumn();
            ColumnSurname = new DataGridViewTextBoxColumn();
            ColumnName = new DataGridViewTextBoxColumn();
            ColumnLastName = new DataGridViewTextBoxColumn();
            ColumnDepartament = new DataGridViewTextBoxColumn();
            ColumnPost = new DataGridViewTextBoxColumn();
            panelToolbar_GYA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTools_GYA).BeginInit();
            panelMainInformation_GYA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInformaion).BeginInit();
            SuspendLayout();
            // 
            // panelButtonsHelp_GYA
            // 
            panelButtonsHelp_GYA.BackColor = Color.FromArgb(212, 212, 212);
            panelButtonsHelp_GYA.Dock = DockStyle.Top;
            panelButtonsHelp_GYA.Location = new Point(0, 0);
            panelButtonsHelp_GYA.Name = "panelButtonsHelp_GYA";
            panelButtonsHelp_GYA.Size = new Size(1088, 26);
            panelButtonsHelp_GYA.TabIndex = 0;
            // 
            // panelButtonsFunctional_GYA
            // 
            panelButtonsFunctional_GYA.BackColor = Color.FromArgb(236, 236, 236);
            panelButtonsFunctional_GYA.Dock = DockStyle.Top;
            panelButtonsFunctional_GYA.Location = new Point(0, 26);
            panelButtonsFunctional_GYA.Name = "panelButtonsFunctional_GYA";
            panelButtonsFunctional_GYA.Size = new Size(1088, 83);
            panelButtonsFunctional_GYA.TabIndex = 1;
            // 
            // panelStatus_GYA
            // 
            panelStatus_GYA.BackColor = Color.FromArgb(212, 212, 212);
            panelStatus_GYA.Dock = DockStyle.Bottom;
            panelStatus_GYA.Location = new Point(0, 560);
            panelStatus_GYA.Name = "panelStatus_GYA";
            panelStatus_GYA.Size = new Size(1088, 27);
            panelStatus_GYA.TabIndex = 2;
            // 
            // panelToolbar_GYA
            // 
            panelToolbar_GYA.BackColor = Color.FromArgb(173, 173, 173);
            panelToolbar_GYA.Controls.Add(pictureBoxTools_GYA);
            panelToolbar_GYA.Dock = DockStyle.Left;
            panelToolbar_GYA.Location = new Point(0, 109);
            panelToolbar_GYA.MaximumSize = new Size(200, 1000);
            panelToolbar_GYA.MinimumSize = new Size(21, 451);
            panelToolbar_GYA.Name = "panelToolbar_GYA";
            panelToolbar_GYA.Size = new Size(21, 451);
            panelToolbar_GYA.TabIndex = 3;
            // 
            // pictureBoxTools_GYA
            // 
            pictureBoxTools_GYA.Image = (Image)resources.GetObject("pictureBoxTools_GYA.Image");
            pictureBoxTools_GYA.Location = new Point(0, 18);
            pictureBoxTools_GYA.Name = "pictureBoxTools_GYA";
            pictureBoxTools_GYA.Size = new Size(21, 124);
            pictureBoxTools_GYA.TabIndex = 0;
            pictureBoxTools_GYA.TabStop = false;
            pictureBoxTools_GYA.Click += pictureBoxTools_GYA_Click;
            pictureBoxTools_GYA.DoubleClick += pictureBoxTools_GYA_DoubleClick;
            pictureBoxTools_GYA.MouseEnter += pictureBoxTools_GYA_MouseEnter;
            // 
            // splitterTools_GYA
            // 
            splitterTools_GYA.Location = new Point(21, 109);
            splitterTools_GYA.Name = "splitterTools_GYA";
            splitterTools_GYA.Size = new Size(3, 451);
            splitterTools_GYA.TabIndex = 4;
            splitterTools_GYA.TabStop = false;
            // 
            // panelMainInformation_GYA
            // 
            panelMainInformation_GYA.BackColor = SystemColors.ButtonHighlight;
            panelMainInformation_GYA.Controls.Add(dataGridViewInformaion);
            panelMainInformation_GYA.Dock = DockStyle.Fill;
            panelMainInformation_GYA.Location = new Point(24, 109);
            panelMainInformation_GYA.Name = "panelMainInformation_GYA";
            panelMainInformation_GYA.Size = new Size(1064, 451);
            panelMainInformation_GYA.TabIndex = 5;
            // 
            // dataGridViewInformaion
            // 
            dataGridViewInformaion.BackgroundColor = SystemColors.ButtonFace;
            dataGridViewInformaion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInformaion.Columns.AddRange(new DataGridViewColumn[] { ColumnKey, ColumnSurname, ColumnName, ColumnLastName, ColumnDepartament, ColumnPost });
            dataGridViewInformaion.Dock = DockStyle.Fill;
            dataGridViewInformaion.Location = new Point(0, 0);
            dataGridViewInformaion.Name = "dataGridViewInformaion";
            dataGridViewInformaion.RowHeadersVisible = false;
            dataGridViewInformaion.Size = new Size(1064, 451);
            dataGridViewInformaion.TabIndex = 0;
            // 
            // ColumnKey
            // 
            ColumnKey.HeaderText = "Код";
            ColumnKey.Name = "ColumnKey";
            // 
            // ColumnSurname
            // 
            ColumnSurname.HeaderText = "Фамилия";
            ColumnSurname.Name = "ColumnSurname";
            // 
            // ColumnName
            // 
            ColumnName.HeaderText = "Имя";
            ColumnName.Name = "ColumnName";
            // 
            // ColumnLastName
            // 
            ColumnLastName.HeaderText = "Отчество";
            ColumnLastName.Name = "ColumnLastName";
            // 
            // ColumnDepartament
            // 
            ColumnDepartament.HeaderText = "Отдел";
            ColumnDepartament.Name = "ColumnDepartament";
            // 
            // ColumnPost
            // 
            ColumnPost.HeaderText = "Должность";
            ColumnPost.Name = "ColumnPost";
            // 
            // FormMain_GYA
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1088, 587);
            Controls.Add(panelMainInformation_GYA);
            Controls.Add(splitterTools_GYA);
            Controls.Add(panelToolbar_GYA);
            Controls.Add(panelStatus_GYA);
            Controls.Add(panelButtonsFunctional_GYA);
            Controls.Add(panelButtonsHelp_GYA);
            Name = "FormMain_GYA";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 7 | Вариант 11 | Гамалеева Ю.А.";
            panelToolbar_GYA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxTools_GYA).EndInit();
            panelMainInformation_GYA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewInformaion).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelButtonsHelp_GYA;
        private Panel panelButtonsFunctional_GYA;
        private Panel panelStatus_GYA;
        private Panel panelToolbar_GYA;
        private Splitter splitterTools_GYA;
        private Panel panelMainInformation_GYA;
        private DataGridView dataGridViewInformaion;
        private DataGridViewTextBoxColumn ColumnKey;
        private DataGridViewTextBoxColumn ColumnSurname;
        private DataGridViewTextBoxColumn ColumnName;
        private DataGridViewTextBoxColumn ColumnLastName;
        private DataGridViewTextBoxColumn ColumnDepartament;
        private DataGridViewTextBoxColumn ColumnPost;
        private PictureBox pictureBoxTools_GYA;
    }
}
