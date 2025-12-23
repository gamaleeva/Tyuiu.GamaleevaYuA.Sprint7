namespace Tyuiu.GamaleevaYuA.Sprint7.Project.V11
{
    partial class FormSearch
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
            components = new System.ComponentModel.Container();
            textBoxInputSearch_GYA = new TextBox();
            buttonDoSearch_GYA = new Button();
            labelSearch_GYA = new Label();
            buttonReset_GYA = new Button();
            comboBoxCoincidence_GYA = new ComboBox();
            toolTipSearch_GYA = new ToolTip(components);
            SuspendLayout();
            // 
            // textBoxInputSearch_GYA
            // 
            textBoxInputSearch_GYA.Location = new Point(71, 55);
            textBoxInputSearch_GYA.Multiline = true;
            textBoxInputSearch_GYA.Name = "textBoxInputSearch_GYA";
            textBoxInputSearch_GYA.Size = new Size(444, 25);
            textBoxInputSearch_GYA.TabIndex = 0;
            toolTipSearch_GYA.SetToolTip(textBoxInputSearch_GYA, "Ввод текста\r\nВведите текст для поиска\r\n");
            // 
            // buttonDoSearch_GYA
            // 
            buttonDoSearch_GYA.FlatStyle = FlatStyle.Flat;
            buttonDoSearch_GYA.Location = new Point(390, 237);
            buttonDoSearch_GYA.Name = "buttonDoSearch_GYA";
            buttonDoSearch_GYA.Size = new Size(125, 29);
            buttonDoSearch_GYA.TabIndex = 1;
            buttonDoSearch_GYA.Text = "Выполнить поиск";
            toolTipSearch_GYA.SetToolTip(buttonDoSearch_GYA, "Выполнение поиска\r\nНажмите чтобы выполнить поиск\r\n");
            buttonDoSearch_GYA.UseVisualStyleBackColor = true;
            buttonDoSearch_GYA.Click += buttonDoSearch_GYA_Click;
            // 
            // labelSearch_GYA
            // 
            labelSearch_GYA.AutoSize = true;
            labelSearch_GYA.Location = new Point(21, 55);
            labelSearch_GYA.Name = "labelSearch_GYA";
            labelSearch_GYA.Size = new Size(44, 15);
            labelSearch_GYA.TabIndex = 3;
            labelSearch_GYA.Text = "Найти:";
            // 
            // buttonReset_GYA
            // 
            buttonReset_GYA.FlatStyle = FlatStyle.Flat;
            buttonReset_GYA.Location = new Point(21, 237);
            buttonReset_GYA.Name = "buttonReset_GYA";
            buttonReset_GYA.Size = new Size(128, 29);
            buttonReset_GYA.TabIndex = 4;
            buttonReset_GYA.Text = "Сброс";
            toolTipSearch_GYA.SetToolTip(buttonReset_GYA, "Сброс поиска\r\nНажмите чтобы сбросить поиск\r\n\r\n");
            buttonReset_GYA.UseVisualStyleBackColor = true;
            buttonReset_GYA.Click += buttonReset_GYA_Click;
            // 
            // comboBoxCoincidence_GYA
            // 
            comboBoxCoincidence_GYA.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCoincidence_GYA.FormattingEnabled = true;
            comboBoxCoincidence_GYA.Items.AddRange(new object[] { "Точное совпадение", "Частичное совпадение" });
            comboBoxCoincidence_GYA.Location = new Point(71, 86);
            comboBoxCoincidence_GYA.Name = "comboBoxCoincidence_GYA";
            comboBoxCoincidence_GYA.Size = new Size(121, 23);
            comboBoxCoincidence_GYA.TabIndex = 5;
            toolTipSearch_GYA.SetToolTip(comboBoxCoincidence_GYA, "Параметры\r\nВыберите нужный параметр поиска\r\n");
            comboBoxCoincidence_GYA.SelectedIndexChanged += comboBoxCoincidence_GYA_SelectedIndexChanged;
            // 
            // toolTipSearch_GYA
            // 
            toolTipSearch_GYA.IsBalloon = true;
            toolTipSearch_GYA.ToolTipIcon = ToolTipIcon.Info;
            toolTipSearch_GYA.ToolTipTitle = "Подсказка";
            // 
            // FormSearch
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(540, 278);
            Controls.Add(comboBoxCoincidence_GYA);
            Controls.Add(buttonReset_GYA);
            Controls.Add(labelSearch_GYA);
            Controls.Add(buttonDoSearch_GYA);
            Controls.Add(textBoxInputSearch_GYA);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormSearch";
            Text = "Поиск";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBoxInputSearch_GYA;
        private Button buttonDoSearch_GYA;
        private Label labelSearch_GYA;
        private Button buttonReset_GYA;
        private ComboBox comboBoxCoincidence_GYA;
        private ToolTip toolTipSearch_GYA;
    }
}