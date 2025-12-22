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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain_GYA));
            panelButtonsFunctional_GYA = new Panel();
            labelSort_GYA = new Label();
            comboBoxSort_GYA = new ComboBox();
            buttonDeleteRow_GYA = new Button();
            buttonSearch_GYA = new Button();
            panelStatus_GYA = new Panel();
            panelToolbar_GYA = new Panel();
            groupBoxNumberFilter_GYA = new GroupBox();
            comboBoxOperators_GYA = new ComboBox();
            buttonResetFilter_GYA = new Button();
            buttonDoFilter_GYA = new Button();
            textBoxFilter_GYA = new TextBox();
            groupBoxPostFilter_GYA = new GroupBox();
            checkedListBoxPost_GYA = new CheckedListBox();
            groupBoxDepartamentFilter_GYA = new GroupBox();
            checkedListBoxDepartament_GYA = new CheckedListBox();
            pictureBoxTools_GYA = new PictureBox();
            bindingSourceMain_GYA = new BindingSource(components);
            splitterTools_GYA = new Splitter();
            panelMainInformation_GYA = new Panel();
            tabControlMain_GYA = new TabControl();
            tabPageMain_GYA = new TabPage();
            dataGridViewInformation_GYA = new DataGridView();
            ColumnKey = new DataGridViewTextBoxColumn();
            ColumnSurname = new DataGridViewTextBoxColumn();
            ColumnName = new DataGridViewTextBoxColumn();
            ColumnLastName = new DataGridViewTextBoxColumn();
            ColumnDepartament = new DataGridViewTextBoxColumn();
            ColumnPost = new DataGridViewTextBoxColumn();
            ColumnPhone = new DataGridViewTextBoxColumn();
            ColumnAddress = new DataGridViewTextBoxColumn();
            ColumnSalary = new DataGridViewTextBoxColumn();
            tabPageWorkers_GYA = new TabPage();
            groupBoxStatistic_GYA = new GroupBox();
            groupBoxValues_GYA = new GroupBox();
            buttonAverage_GYA = new Button();
            buttonSum_GYA = new Button();
            buttonMin_GYA = new Button();
            buttonMax_GYA = new Button();
            buttonCount_GYA = new Button();
            textBoxAverage_GYA = new TextBox();
            textBoxSum_GYA = new TextBox();
            textBoxMin_GYA = new TextBox();
            textBoxMax_GYA = new TextBox();
            textBoxCount_GYA = new TextBox();
            labelAverage_GYA = new Label();
            labelSum_GYA = new Label();
            labelMin_GYA = new Label();
            labelMax_GYA = new Label();
            labelCount_GYA = new Label();
            openFileDialogMain_GYA = new OpenFileDialog();
            saveFileDialogMain_GYA = new SaveFileDialog();
            menuStripMain_GYA = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItemFileActions_GYA = new ToolStripMenuItem();
            loadFileToolStripMenuItem_GYA = new ToolStripMenuItem();
            saveFileToolStripMenuItem_GYA = new ToolStripMenuItem();
            toolStripMenuItemHelp_GYA = new ToolStripMenuItem();
            aboutToolStripMenuItem_GYA = new ToolStripMenuItem();
            groupBoxGraphic_GYA = new GroupBox();
            panelButtonsFunctional_GYA.SuspendLayout();
            panelToolbar_GYA.SuspendLayout();
            groupBoxNumberFilter_GYA.SuspendLayout();
            groupBoxPostFilter_GYA.SuspendLayout();
            groupBoxDepartamentFilter_GYA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTools_GYA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceMain_GYA).BeginInit();
            panelMainInformation_GYA.SuspendLayout();
            tabControlMain_GYA.SuspendLayout();
            tabPageMain_GYA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInformation_GYA).BeginInit();
            tabPageWorkers_GYA.SuspendLayout();
            groupBoxStatistic_GYA.SuspendLayout();
            groupBoxValues_GYA.SuspendLayout();
            menuStripMain_GYA.SuspendLayout();
            SuspendLayout();
            // 
            // panelButtonsFunctional_GYA
            // 
            panelButtonsFunctional_GYA.BackColor = Color.FromArgb(236, 236, 236);
            panelButtonsFunctional_GYA.Controls.Add(labelSort_GYA);
            panelButtonsFunctional_GYA.Controls.Add(comboBoxSort_GYA);
            panelButtonsFunctional_GYA.Controls.Add(buttonDeleteRow_GYA);
            panelButtonsFunctional_GYA.Controls.Add(buttonSearch_GYA);
            panelButtonsFunctional_GYA.Dock = DockStyle.Top;
            panelButtonsFunctional_GYA.Location = new Point(0, 24);
            panelButtonsFunctional_GYA.Name = "panelButtonsFunctional_GYA";
            panelButtonsFunctional_GYA.Size = new Size(1088, 83);
            panelButtonsFunctional_GYA.TabIndex = 1;
            // 
            // labelSort_GYA
            // 
            labelSort_GYA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelSort_GYA.AutoSize = true;
            labelSort_GYA.Location = new Point(809, 27);
            labelSort_GYA.Name = "labelSort_GYA";
            labelSort_GYA.Size = new Size(73, 15);
            labelSort_GYA.TabIndex = 5;
            labelSort_GYA.Text = "Сортировка";
            // 
            // comboBoxSort_GYA
            // 
            comboBoxSort_GYA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBoxSort_GYA.FormattingEnabled = true;
            comboBoxSort_GYA.Items.AddRange(new object[] { "По возрастанию", "По убыванию" });
            comboBoxSort_GYA.Location = new Point(784, 45);
            comboBoxSort_GYA.Name = "comboBoxSort_GYA";
            comboBoxSort_GYA.RightToLeft = RightToLeft.Yes;
            comboBoxSort_GYA.Size = new Size(121, 23);
            comboBoxSort_GYA.TabIndex = 4;
            comboBoxSort_GYA.SelectedIndexChanged += comboBoxSort_GYA_SelectedIndexChanged;
            // 
            // buttonDeleteRow_GYA
            // 
            buttonDeleteRow_GYA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonDeleteRow_GYA.FlatStyle = FlatStyle.Flat;
            buttonDeleteRow_GYA.Location = new Point(911, 45);
            buttonDeleteRow_GYA.Name = "buttonDeleteRow_GYA";
            buttonDeleteRow_GYA.Size = new Size(75, 23);
            buttonDeleteRow_GYA.TabIndex = 1;
            buttonDeleteRow_GYA.Text = "Удалить";
            buttonDeleteRow_GYA.UseVisualStyleBackColor = true;
            buttonDeleteRow_GYA.Click += buttonDeleteRow_GYA_Click;
            // 
            // buttonSearch_GYA
            // 
            buttonSearch_GYA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonSearch_GYA.FlatStyle = FlatStyle.Flat;
            buttonSearch_GYA.Location = new Point(992, 45);
            buttonSearch_GYA.Name = "buttonSearch_GYA";
            buttonSearch_GYA.Size = new Size(75, 23);
            buttonSearch_GYA.TabIndex = 0;
            buttonSearch_GYA.Text = "Поиск";
            buttonSearch_GYA.UseVisualStyleBackColor = true;
            buttonSearch_GYA.Click += buttonSearch_GYA_Click;
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
            panelToolbar_GYA.BackColor = SystemColors.ControlLightLight;
            panelToolbar_GYA.Controls.Add(groupBoxNumberFilter_GYA);
            panelToolbar_GYA.Controls.Add(groupBoxPostFilter_GYA);
            panelToolbar_GYA.Controls.Add(groupBoxDepartamentFilter_GYA);
            panelToolbar_GYA.Controls.Add(pictureBoxTools_GYA);
            panelToolbar_GYA.Dock = DockStyle.Left;
            panelToolbar_GYA.Location = new Point(0, 107);
            panelToolbar_GYA.MaximumSize = new Size(200, 1000);
            panelToolbar_GYA.MinimumSize = new Size(21, 451);
            panelToolbar_GYA.Name = "panelToolbar_GYA";
            panelToolbar_GYA.Size = new Size(200, 453);
            panelToolbar_GYA.TabIndex = 3;
            // 
            // groupBoxNumberFilter_GYA
            // 
            groupBoxNumberFilter_GYA.Controls.Add(comboBoxOperators_GYA);
            groupBoxNumberFilter_GYA.Controls.Add(buttonResetFilter_GYA);
            groupBoxNumberFilter_GYA.Controls.Add(buttonDoFilter_GYA);
            groupBoxNumberFilter_GYA.Controls.Add(textBoxFilter_GYA);
            groupBoxNumberFilter_GYA.Location = new Point(39, 312);
            groupBoxNumberFilter_GYA.Name = "groupBoxNumberFilter_GYA";
            groupBoxNumberFilter_GYA.Size = new Size(155, 135);
            groupBoxNumberFilter_GYA.TabIndex = 4;
            groupBoxNumberFilter_GYA.TabStop = false;
            groupBoxNumberFilter_GYA.Text = "Числовой фильтр";
            // 
            // comboBoxOperators_GYA
            // 
            comboBoxOperators_GYA.FormattingEnabled = true;
            comboBoxOperators_GYA.Items.AddRange(new object[] { "=", "!=", ">", "<", ">=", "<=" });
            comboBoxOperators_GYA.Location = new Point(22, 35);
            comboBoxOperators_GYA.Name = "comboBoxOperators_GYA";
            comboBoxOperators_GYA.Size = new Size(121, 23);
            comboBoxOperators_GYA.TabIndex = 5;
            // 
            // buttonResetFilter_GYA
            // 
            buttonResetFilter_GYA.FlatStyle = FlatStyle.Flat;
            buttonResetFilter_GYA.Location = new Point(6, 102);
            buttonResetFilter_GYA.Name = "buttonResetFilter_GYA";
            buttonResetFilter_GYA.Size = new Size(59, 27);
            buttonResetFilter_GYA.TabIndex = 7;
            buttonResetFilter_GYA.Text = "Сброс";
            buttonResetFilter_GYA.UseVisualStyleBackColor = true;
            buttonResetFilter_GYA.Click += buttonResetFilter_GYA_Click;
            // 
            // buttonDoFilter_GYA
            // 
            buttonDoFilter_GYA.FlatStyle = FlatStyle.Flat;
            buttonDoFilter_GYA.Location = new Point(65, 102);
            buttonDoFilter_GYA.Name = "buttonDoFilter_GYA";
            buttonDoFilter_GYA.Size = new Size(84, 27);
            buttonDoFilter_GYA.TabIndex = 4;
            buttonDoFilter_GYA.Text = "Применить";
            buttonDoFilter_GYA.UseVisualStyleBackColor = true;
            buttonDoFilter_GYA.Click += buttonDoFilter_GYA_Click;
            // 
            // textBoxFilter_GYA
            // 
            textBoxFilter_GYA.Location = new Point(22, 64);
            textBoxFilter_GYA.Name = "textBoxFilter_GYA";
            textBoxFilter_GYA.Size = new Size(120, 23);
            textBoxFilter_GYA.TabIndex = 6;
            // 
            // groupBoxPostFilter_GYA
            // 
            groupBoxPostFilter_GYA.Controls.Add(checkedListBoxPost_GYA);
            groupBoxPostFilter_GYA.Location = new Point(39, 157);
            groupBoxPostFilter_GYA.Name = "groupBoxPostFilter_GYA";
            groupBoxPostFilter_GYA.Size = new Size(155, 149);
            groupBoxPostFilter_GYA.TabIndex = 5;
            groupBoxPostFilter_GYA.TabStop = false;
            groupBoxPostFilter_GYA.Text = "Должность";
            // 
            // checkedListBoxPost_GYA
            // 
            checkedListBoxPost_GYA.FormattingEnabled = true;
            checkedListBoxPost_GYA.Location = new Point(22, 22);
            checkedListBoxPost_GYA.Name = "checkedListBoxPost_GYA";
            checkedListBoxPost_GYA.Size = new Size(120, 112);
            checkedListBoxPost_GYA.TabIndex = 4;
            // 
            // groupBoxDepartamentFilter_GYA
            // 
            groupBoxDepartamentFilter_GYA.Controls.Add(checkedListBoxDepartament_GYA);
            groupBoxDepartamentFilter_GYA.Location = new Point(39, 6);
            groupBoxDepartamentFilter_GYA.Name = "groupBoxDepartamentFilter_GYA";
            groupBoxDepartamentFilter_GYA.Size = new Size(155, 145);
            groupBoxDepartamentFilter_GYA.TabIndex = 4;
            groupBoxDepartamentFilter_GYA.TabStop = false;
            groupBoxDepartamentFilter_GYA.Text = "Отдел";
            // 
            // checkedListBoxDepartament_GYA
            // 
            checkedListBoxDepartament_GYA.FormattingEnabled = true;
            checkedListBoxDepartament_GYA.Location = new Point(22, 22);
            checkedListBoxDepartament_GYA.Name = "checkedListBoxDepartament_GYA";
            checkedListBoxDepartament_GYA.Size = new Size(120, 112);
            checkedListBoxDepartament_GYA.TabIndex = 4;
            // 
            // pictureBoxTools_GYA
            // 
            pictureBoxTools_GYA.Image = (Image)resources.GetObject("pictureBoxTools_GYA.Image");
            pictureBoxTools_GYA.Location = new Point(3, 6);
            pictureBoxTools_GYA.Name = "pictureBoxTools_GYA";
            pictureBoxTools_GYA.Size = new Size(21, 124);
            pictureBoxTools_GYA.TabIndex = 0;
            pictureBoxTools_GYA.TabStop = false;
            pictureBoxTools_GYA.Click += pictureBoxTools_GYA_Click;
            pictureBoxTools_GYA.MouseEnter += pictureBoxTools_GYA_MouseEnter;
            // 
            // splitterTools_GYA
            // 
            splitterTools_GYA.Location = new Point(200, 107);
            splitterTools_GYA.Name = "splitterTools_GYA";
            splitterTools_GYA.Size = new Size(3, 453);
            splitterTools_GYA.TabIndex = 4;
            splitterTools_GYA.TabStop = false;
            // 
            // panelMainInformation_GYA
            // 
            panelMainInformation_GYA.BackColor = SystemColors.ButtonHighlight;
            panelMainInformation_GYA.Controls.Add(tabControlMain_GYA);
            panelMainInformation_GYA.Dock = DockStyle.Fill;
            panelMainInformation_GYA.Location = new Point(203, 107);
            panelMainInformation_GYA.Name = "panelMainInformation_GYA";
            panelMainInformation_GYA.Size = new Size(885, 453);
            panelMainInformation_GYA.TabIndex = 5;
            // 
            // tabControlMain_GYA
            // 
            tabControlMain_GYA.Controls.Add(tabPageMain_GYA);
            tabControlMain_GYA.Controls.Add(tabPageWorkers_GYA);
            tabControlMain_GYA.Dock = DockStyle.Fill;
            tabControlMain_GYA.Location = new Point(0, 0);
            tabControlMain_GYA.Name = "tabControlMain_GYA";
            tabControlMain_GYA.SelectedIndex = 0;
            tabControlMain_GYA.Size = new Size(885, 453);
            tabControlMain_GYA.TabIndex = 4;
            // 
            // tabPageMain_GYA
            // 
            tabPageMain_GYA.Controls.Add(dataGridViewInformation_GYA);
            tabPageMain_GYA.Location = new Point(4, 24);
            tabPageMain_GYA.Name = "tabPageMain_GYA";
            tabPageMain_GYA.Padding = new Padding(3);
            tabPageMain_GYA.Size = new Size(877, 425);
            tabPageMain_GYA.TabIndex = 0;
            tabPageMain_GYA.Text = "tabPage1";
            tabPageMain_GYA.UseVisualStyleBackColor = true;
            // 
            // dataGridViewInformation_GYA
            // 
            dataGridViewInformation_GYA.BackgroundColor = SystemColors.ButtonFace;
            dataGridViewInformation_GYA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInformation_GYA.Columns.AddRange(new DataGridViewColumn[] { ColumnKey, ColumnSurname, ColumnName, ColumnLastName, ColumnDepartament, ColumnPost, ColumnPhone, ColumnAddress, ColumnSalary });
            dataGridViewInformation_GYA.Dock = DockStyle.Fill;
            dataGridViewInformation_GYA.Location = new Point(3, 3);
            dataGridViewInformation_GYA.Name = "dataGridViewInformation_GYA";
            dataGridViewInformation_GYA.RowHeadersVisible = false;
            dataGridViewInformation_GYA.Size = new Size(871, 419);
            dataGridViewInformation_GYA.TabIndex = 0;
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
            // ColumnPhone
            // 
            ColumnPhone.HeaderText = "Номер телефона";
            ColumnPhone.Name = "ColumnPhone";
            // 
            // ColumnAddress
            // 
            ColumnAddress.HeaderText = "Адрес";
            ColumnAddress.Name = "ColumnAddress";
            // 
            // ColumnSalary
            // 
            ColumnSalary.HeaderText = "Оклад";
            ColumnSalary.Name = "ColumnSalary";
            // 
            // tabPageWorkers_GYA
            // 
            tabPageWorkers_GYA.Controls.Add(groupBoxStatistic_GYA);
            tabPageWorkers_GYA.Location = new Point(4, 24);
            tabPageWorkers_GYA.Name = "tabPageWorkers_GYA";
            tabPageWorkers_GYA.Padding = new Padding(3);
            tabPageWorkers_GYA.Size = new Size(877, 425);
            tabPageWorkers_GYA.TabIndex = 1;
            tabPageWorkers_GYA.Text = "tabPage2";
            tabPageWorkers_GYA.UseVisualStyleBackColor = true;
            // 
            // groupBoxStatistic_GYA
            // 
            groupBoxStatistic_GYA.Controls.Add(groupBoxGraphic_GYA);
            groupBoxStatistic_GYA.Controls.Add(groupBoxValues_GYA);
            groupBoxStatistic_GYA.Dock = DockStyle.Fill;
            groupBoxStatistic_GYA.Location = new Point(3, 3);
            groupBoxStatistic_GYA.Name = "groupBoxStatistic_GYA";
            groupBoxStatistic_GYA.Size = new Size(871, 419);
            groupBoxStatistic_GYA.TabIndex = 0;
            groupBoxStatistic_GYA.TabStop = false;
            groupBoxStatistic_GYA.Text = "Статистика";
            // 
            // groupBoxValues_GYA
            // 
            groupBoxValues_GYA.Controls.Add(buttonAverage_GYA);
            groupBoxValues_GYA.Controls.Add(buttonSum_GYA);
            groupBoxValues_GYA.Controls.Add(buttonMin_GYA);
            groupBoxValues_GYA.Controls.Add(buttonMax_GYA);
            groupBoxValues_GYA.Controls.Add(buttonCount_GYA);
            groupBoxValues_GYA.Controls.Add(textBoxAverage_GYA);
            groupBoxValues_GYA.Controls.Add(textBoxSum_GYA);
            groupBoxValues_GYA.Controls.Add(textBoxMin_GYA);
            groupBoxValues_GYA.Controls.Add(textBoxMax_GYA);
            groupBoxValues_GYA.Controls.Add(textBoxCount_GYA);
            groupBoxValues_GYA.Controls.Add(labelAverage_GYA);
            groupBoxValues_GYA.Controls.Add(labelSum_GYA);
            groupBoxValues_GYA.Controls.Add(labelMin_GYA);
            groupBoxValues_GYA.Controls.Add(labelMax_GYA);
            groupBoxValues_GYA.Controls.Add(labelCount_GYA);
            groupBoxValues_GYA.Dock = DockStyle.Left;
            groupBoxValues_GYA.Location = new Point(3, 19);
            groupBoxValues_GYA.Name = "groupBoxValues_GYA";
            groupBoxValues_GYA.Size = new Size(276, 397);
            groupBoxValues_GYA.TabIndex = 0;
            groupBoxValues_GYA.TabStop = false;
            groupBoxValues_GYA.Text = "Показатели";
            // 
            // buttonAverage_GYA
            // 
            buttonAverage_GYA.FlatStyle = FlatStyle.Flat;
            buttonAverage_GYA.Location = new Point(160, 341);
            buttonAverage_GYA.Name = "buttonAverage_GYA";
            buttonAverage_GYA.Size = new Size(75, 23);
            buttonAverage_GYA.TabIndex = 14;
            buttonAverage_GYA.Text = "Найти";
            buttonAverage_GYA.UseVisualStyleBackColor = true;
            buttonAverage_GYA.Click += buttonAverage_GYA_Click;
            // 
            // buttonSum_GYA
            // 
            buttonSum_GYA.FlatStyle = FlatStyle.Flat;
            buttonSum_GYA.Location = new Point(160, 266);
            buttonSum_GYA.Name = "buttonSum_GYA";
            buttonSum_GYA.Size = new Size(75, 23);
            buttonSum_GYA.TabIndex = 13;
            buttonSum_GYA.Text = "Найти";
            buttonSum_GYA.UseVisualStyleBackColor = true;
            buttonSum_GYA.Click += buttonSum_GYA_Click;
            // 
            // buttonMin_GYA
            // 
            buttonMin_GYA.FlatStyle = FlatStyle.Flat;
            buttonMin_GYA.Location = new Point(160, 192);
            buttonMin_GYA.Name = "buttonMin_GYA";
            buttonMin_GYA.Size = new Size(75, 23);
            buttonMin_GYA.TabIndex = 12;
            buttonMin_GYA.Text = "Найти";
            buttonMin_GYA.UseVisualStyleBackColor = true;
            buttonMin_GYA.Click += buttonMin_GYA_Click;
            // 
            // buttonMax_GYA
            // 
            buttonMax_GYA.FlatStyle = FlatStyle.Flat;
            buttonMax_GYA.Location = new Point(160, 120);
            buttonMax_GYA.Name = "buttonMax_GYA";
            buttonMax_GYA.Size = new Size(75, 23);
            buttonMax_GYA.TabIndex = 11;
            buttonMax_GYA.Text = "Найти";
            buttonMax_GYA.UseVisualStyleBackColor = true;
            buttonMax_GYA.Click += buttonMax_GYA_Click;
            // 
            // buttonCount_GYA
            // 
            buttonCount_GYA.FlatStyle = FlatStyle.Flat;
            buttonCount_GYA.Location = new Point(160, 57);
            buttonCount_GYA.Name = "buttonCount_GYA";
            buttonCount_GYA.Size = new Size(75, 23);
            buttonCount_GYA.TabIndex = 10;
            buttonCount_GYA.Text = "Найти\r\n\r\n";
            buttonCount_GYA.UseVisualStyleBackColor = true;
            buttonCount_GYA.Click += buttonCount_GYA_Click;
            // 
            // textBoxAverage_GYA
            // 
            textBoxAverage_GYA.Location = new Point(28, 340);
            textBoxAverage_GYA.Name = "textBoxAverage_GYA";
            textBoxAverage_GYA.ReadOnly = true;
            textBoxAverage_GYA.Size = new Size(100, 23);
            textBoxAverage_GYA.TabIndex = 9;
            // 
            // textBoxSum_GYA
            // 
            textBoxSum_GYA.Location = new Point(28, 266);
            textBoxSum_GYA.Name = "textBoxSum_GYA";
            textBoxSum_GYA.ReadOnly = true;
            textBoxSum_GYA.Size = new Size(100, 23);
            textBoxSum_GYA.TabIndex = 8;
            // 
            // textBoxMin_GYA
            // 
            textBoxMin_GYA.Location = new Point(28, 192);
            textBoxMin_GYA.Name = "textBoxMin_GYA";
            textBoxMin_GYA.ReadOnly = true;
            textBoxMin_GYA.Size = new Size(100, 23);
            textBoxMin_GYA.TabIndex = 7;
            // 
            // textBoxMax_GYA
            // 
            textBoxMax_GYA.Location = new Point(28, 120);
            textBoxMax_GYA.Name = "textBoxMax_GYA";
            textBoxMax_GYA.ReadOnly = true;
            textBoxMax_GYA.Size = new Size(100, 23);
            textBoxMax_GYA.TabIndex = 6;
            // 
            // textBoxCount_GYA
            // 
            textBoxCount_GYA.Location = new Point(28, 57);
            textBoxCount_GYA.Name = "textBoxCount_GYA";
            textBoxCount_GYA.ReadOnly = true;
            textBoxCount_GYA.Size = new Size(100, 23);
            textBoxCount_GYA.TabIndex = 5;
            // 
            // labelAverage_GYA
            // 
            labelAverage_GYA.AutoSize = true;
            labelAverage_GYA.Location = new Point(28, 322);
            labelAverage_GYA.Name = "labelAverage_GYA";
            labelAverage_GYA.Size = new Size(90, 15);
            labelAverage_GYA.TabIndex = 4;
            labelAverage_GYA.Text = "Средний оклад";
            // 
            // labelSum_GYA
            // 
            labelSum_GYA.AutoSize = true;
            labelSum_GYA.Location = new Point(28, 245);
            labelSum_GYA.Name = "labelSum_GYA";
            labelSum_GYA.Size = new Size(93, 15);
            labelSum_GYA.TabIndex = 3;
            labelSum_GYA.Text = "Сумма окладов";
            // 
            // labelMin_GYA
            // 
            labelMin_GYA.AutoSize = true;
            labelMin_GYA.Location = new Point(28, 174);
            labelMin_GYA.Name = "labelMin_GYA";
            labelMin_GYA.Size = new Size(125, 15);
            labelMin_GYA.TabIndex = 2;
            labelMin_GYA.Text = "Минимальный оклад";
            // 
            // labelMax_GYA
            // 
            labelMax_GYA.AutoSize = true;
            labelMax_GYA.Location = new Point(28, 102);
            labelMax_GYA.Name = "labelMax_GYA";
            labelMax_GYA.Size = new Size(129, 15);
            labelMax_GYA.TabIndex = 1;
            labelMax_GYA.Text = "Максимальный оклад";
            // 
            // labelCount_GYA
            // 
            labelCount_GYA.AutoSize = true;
            labelCount_GYA.Location = new Point(28, 39);
            labelCount_GYA.Name = "labelCount_GYA";
            labelCount_GYA.Size = new Size(140, 15);
            labelCount_GYA.TabIndex = 0;
            labelCount_GYA.Text = "Количество работников";
            // 
            // openFileDialogMain_GYA
            // 
            openFileDialogMain_GYA.FileName = "openFileDialog1";
            // 
            // menuStripMain_GYA
            // 
            menuStripMain_GYA.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, toolStripMenuItemFileActions_GYA, toolStripMenuItemHelp_GYA });
            menuStripMain_GYA.Location = new Point(0, 0);
            menuStripMain_GYA.Name = "menuStripMain_GYA";
            menuStripMain_GYA.Size = new Size(1088, 24);
            menuStripMain_GYA.TabIndex = 6;
            menuStripMain_GYA.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(12, 20);
            // 
            // toolStripMenuItemFileActions_GYA
            // 
            toolStripMenuItemFileActions_GYA.DropDownItems.AddRange(new ToolStripItem[] { loadFileToolStripMenuItem_GYA, saveFileToolStripMenuItem_GYA });
            toolStripMenuItemFileActions_GYA.Name = "toolStripMenuItemFileActions_GYA";
            toolStripMenuItemFileActions_GYA.Size = new Size(48, 20);
            toolStripMenuItemFileActions_GYA.Text = "Файл";
            // 
            // loadFileToolStripMenuItem_GYA
            // 
            loadFileToolStripMenuItem_GYA.Name = "loadFileToolStripMenuItem_GYA";
            loadFileToolStripMenuItem_GYA.Size = new Size(133, 22);
            loadFileToolStripMenuItem_GYA.Text = "Загрузить";
            loadFileToolStripMenuItem_GYA.Click += loadFileToolStripMenuItem_GYA_Click;
            // 
            // saveFileToolStripMenuItem_GYA
            // 
            saveFileToolStripMenuItem_GYA.Name = "saveFileToolStripMenuItem_GYA";
            saveFileToolStripMenuItem_GYA.Size = new Size(133, 22);
            saveFileToolStripMenuItem_GYA.Text = "Сохранить";
            saveFileToolStripMenuItem_GYA.Click += saveFileToolStripMenuItem_GYA_Click;
            // 
            // toolStripMenuItemHelp_GYA
            // 
            toolStripMenuItemHelp_GYA.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem_GYA });
            toolStripMenuItemHelp_GYA.Name = "toolStripMenuItemHelp_GYA";
            toolStripMenuItemHelp_GYA.Size = new Size(68, 20);
            toolStripMenuItemHelp_GYA.Text = "Помощь";
            // 
            // aboutToolStripMenuItem_GYA
            // 
            aboutToolStripMenuItem_GYA.Name = "aboutToolStripMenuItem_GYA";
            aboutToolStripMenuItem_GYA.Size = new Size(149, 22);
            aboutToolStripMenuItem_GYA.Text = "О программе";
            aboutToolStripMenuItem_GYA.Click += aboutToolStripMenuItem_GYA_Click;
            // 
            // groupBoxGraphic_GYA
            // 
            groupBoxGraphic_GYA.Dock = DockStyle.Fill;
            groupBoxGraphic_GYA.Location = new Point(279, 19);
            groupBoxGraphic_GYA.Name = "groupBoxGraphic_GYA";
            groupBoxGraphic_GYA.Size = new Size(589, 397);
            groupBoxGraphic_GYA.TabIndex = 1;
            groupBoxGraphic_GYA.TabStop = false;
            groupBoxGraphic_GYA.Text = "groupBox1";
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
            Controls.Add(menuStripMain_GYA);
            MainMenuStrip = menuStripMain_GYA;
            Name = "FormMain_GYA";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 7 | Вариант 11 | Гамалеева Ю.А.";
            panelButtonsFunctional_GYA.ResumeLayout(false);
            panelButtonsFunctional_GYA.PerformLayout();
            panelToolbar_GYA.ResumeLayout(false);
            groupBoxNumberFilter_GYA.ResumeLayout(false);
            groupBoxNumberFilter_GYA.PerformLayout();
            groupBoxPostFilter_GYA.ResumeLayout(false);
            groupBoxDepartamentFilter_GYA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxTools_GYA).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceMain_GYA).EndInit();
            panelMainInformation_GYA.ResumeLayout(false);
            tabControlMain_GYA.ResumeLayout(false);
            tabPageMain_GYA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewInformation_GYA).EndInit();
            tabPageWorkers_GYA.ResumeLayout(false);
            groupBoxStatistic_GYA.ResumeLayout(false);
            groupBoxValues_GYA.ResumeLayout(false);
            groupBoxValues_GYA.PerformLayout();
            menuStripMain_GYA.ResumeLayout(false);
            menuStripMain_GYA.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panelButtonsFunctional_GYA;
        private Panel panelStatus_GYA;
        private Panel panelToolbar_GYA;
        private Splitter splitterTools_GYA;
        private Panel panelMainInformation_GYA;
        private PictureBox pictureBoxTools_GYA;
        private OpenFileDialog openFileDialogMain_GYA;
        private SaveFileDialog saveFileDialogMain_GYA;
        private Button buttonSearch_GYA;
        private Button buttonDeleteRow_GYA;
        private MenuStrip menuStripMain_GYA;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItemFileActions_GYA;
        private ToolStripMenuItem toolStripMenuItemHelp_GYA;
        private ToolStripMenuItem loadFileToolStripMenuItem_GYA;
        private ToolStripMenuItem saveFileToolStripMenuItem_GYA;
        private ToolStripMenuItem aboutToolStripMenuItem_GYA;
        private GroupBox groupBoxPostFilter_GYA;
        private GroupBox groupBoxDepartamentFilter_GYA;
        private BindingSource bindingSourceMain_GYA;
        private GroupBox groupBoxNumberFilter_GYA;
        private TextBox textBoxFilter_GYA;
        private CheckedListBox checkedListBoxDepartament_GYA;
        private CheckedListBox checkedListBoxPost_GYA;
        private Button buttonDoFilter_GYA;
        private Button buttonResetFilter_GYA;
        private TabControl tabControlMain_GYA;
        private TabPage tabPageMain_GYA;
        public DataGridView dataGridViewInformation_GYA;
        private TabPage tabPageWorkers_GYA;
        private DataGridViewTextBoxColumn ColumnKey;
        private DataGridViewTextBoxColumn ColumnSurname;
        private DataGridViewTextBoxColumn ColumnName;
        private DataGridViewTextBoxColumn ColumnLastName;
        private DataGridViewTextBoxColumn ColumnDepartament;
        private DataGridViewTextBoxColumn ColumnPost;
        private DataGridViewTextBoxColumn ColumnPhone;
        private DataGridViewTextBoxColumn ColumnAddress;
        private ComboBox comboBoxSort_GYA;
        private DataGridViewTextBoxColumn ColumnSalary;
        private ComboBox comboBoxOperators_GYA;
        private GroupBox groupBoxStatistic_GYA;
        private GroupBox groupBoxValues_GYA;
        private Label labelAverage_GYA;
        private Label labelSum_GYA;
        private Label labelMin_GYA;
        private Label labelMax_GYA;
        private Label labelCount_GYA;
        private TextBox textBoxAverage_GYA;
        private TextBox textBoxSum_GYA;
        private TextBox textBoxMin_GYA;
        private TextBox textBoxMax_GYA;
        private TextBox textBoxCount_GYA;
        private Label labelSort_GYA;
        private Button buttonAverage_GYA;
        private Button buttonSum_GYA;
        private Button buttonMin_GYA;
        private Button buttonMax_GYA;
        private Button buttonCount_GYA;
        private GroupBox groupBoxGraphic_GYA;
    }
}
