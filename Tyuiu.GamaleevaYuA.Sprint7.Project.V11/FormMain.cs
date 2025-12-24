using System;
using System.Data;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Tyuiu.GamaleevaYuA.Sprint7.Project.V11.Lib;
using static Tyuiu.GamaleevaYuA.Sprint7.Project.V11.Program;
namespace Tyuiu.GamaleevaYuA.Sprint7.Project.V11
{
    public partial class FormMain_GYA : Form
    {
        public FormMain_GYA()
        {
            InitializeComponent();
            openFileDialogMain_GYA.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogMain_GYA.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            comboBoxSort_GYA.SelectedIndex = 0;


        }

        private void pictureBoxTools_GYA_Click(object sender, EventArgs e)
        {
            if (panelToolbar_GYA.Width == 21)
            {
                panelToolbar_GYA.Size = new System.Drawing.Size(200, 451);

                for (int r = 0; r < rows  ; r++)
                {

                    for (int c = 0; c < cols; c++)
                    {
                        if (c == 4 && !checkedListBoxDepartament_GYA.Items.Contains(arrayValues[r, c]))
                        {
                            checkedListBoxDepartament_GYA.Items.Add(Convert.ToString(arrayValues[r, c]));
                        }
                        if (c == 5 && !checkedListBoxPost_GYA.Items.Contains(arrayValues[r, c]))
                        {
                            checkedListBoxPost_GYA.Items.Add(Convert.ToString(arrayValues[r, c]));
                        }
                    }
                }
            }
            else
            {
                panelToolbar_GYA.Size = new System.Drawing.Size(21, 451);
            }
        }

        private void pictureBoxTools_GYA_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxTools_GYA.Cursor = Cursors.Hand;
        }
        static string[,] arrayValues;

        DataService ds = new DataService();
        static string openFilePath;
        static int rows;
        static int cols;


        private void buttonSearch_GYA_Click(object sender, EventArgs e)
        {
            FormSearch formSearch = new FormSearch();
            formSearch.Owner = this;
            formSearch.ShowDialog();
        }



        private void buttonDeleteRow_GYA_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewCell cell in dataGridViewInformation_GYA.SelectedCells)
                {
                    dataGridViewInformation_GYA.Rows.RemoveAt(cell.RowIndex);
                    if (cell.RowIndex == -1)
                    {
                        break;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Нельзя удалить последнюю строку", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public string[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
            int rows = lines.Length;
            int cols = lines[0].Split(';').Length;
            string[,] arrayValues = new string[rows, cols];
            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < cols; c++)
                {
                    arrayValues[r, c] = line_r[c];

                }
            }
            return arrayValues;
        }

        private void loadFileToolStripMenuItem_GYA_Click(object sender, EventArgs e)
        {
            openFileDialogMain_GYA.ShowDialog();
            openFilePath = openFileDialogMain_GYA.FileName;
            arrayValues = new string[rows, cols];
            arrayValues = LoadFromFileData(openFilePath);
            rows = arrayValues.GetLength(0);
            cols = arrayValues.GetLength(1);
            dataGridViewInformation_GYA.ColumnCount = cols;
            dataGridViewInformation_GYA.RowCount = rows;
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    dataGridViewInformation_GYA.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            
            buttonAverage_GYA.Enabled = true;
            buttonCount_GYA.Enabled = true;
            buttonDeleteRow_GYA.Enabled = true;
            buttonDoFilter_GYA.Enabled = true;
            buttonGetGraphic_GYA.Enabled = true;
            buttonSearch_GYA.Enabled = true;
            buttonMax_GYA.Enabled = true;
            buttonMin_GYA.Enabled = true;
            buttonSum_GYA.Enabled = true;
            comboBoxSort_GYA.Enabled = true;
            pictureBoxTools_GYA.Enabled = true;
        }

        private void saveFileToolStripMenuItem_GYA_Click(object sender, EventArgs e)
        {
            saveFileDialogMain_GYA.FileName = "OutPutFile.csv";
            saveFileDialogMain_GYA.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMain_GYA.ShowDialog();

            string path = saveFileDialogMain_GYA.FileName;
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }
            int rows = dataGridViewInformation_GYA.RowCount;
            int cols = dataGridViewInformation_GYA.ColumnCount;
            string str = "";
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    if (c != cols - 1)
                    {
                        str = str + dataGridViewInformation_GYA.Rows[r].Cells[c].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewInformation_GYA.Rows[r].Cells[c].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void aboutToolStripMenuItem_GYA_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }



        private void buttonDoFilter_GYA_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridViewInformation_GYA.Rows.Count; i++)
            {
                dataGridViewInformation_GYA.Rows[i].Visible = false;
            }
            foreach (String str in checkedListBoxDepartament_GYA.SelectedItems)
            {
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        if (arrayValues[i, j] == str && j == 4)
                        {
                            dataGridViewInformation_GYA.Rows[i].Visible = true;
                        }
                    }
                }
            }
            foreach (String str in checkedListBoxPost_GYA.SelectedItems)
            {
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        if (arrayValues[i, j] == str && j == 5)
                        {
                            dataGridViewInformation_GYA.Rows[i].Visible = true;
                        }
                    }
                }
            }
            try
            {
                foreach (DataGridViewCell cell in dataGridViewInformation_GYA.SelectedCells)
                {
                    int numcolumn = cell.ColumnIndex;
                    var oper = comboBoxOperators_GYA.SelectedIndex;
                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < cols; j++)
                        {
                            if (numcolumn == j && oper == 0 && Convert.ToDouble(arrayValues[i, j]) == Convert.ToDouble(textBoxFilter_GYA.Text))
                            {
                                dataGridViewInformation_GYA.Rows[i].Visible = true;
                            }
                            else if (numcolumn == j && oper == 1 && Convert.ToDouble(arrayValues[i, j]) != Convert.ToDouble(textBoxFilter_GYA.Text))
                            {
                                dataGridViewInformation_GYA.Rows[i].Visible = true;
                            }
                            else if (numcolumn == j && oper == 2 && Convert.ToDouble(arrayValues[i, j]) > Convert.ToDouble(textBoxFilter_GYA.Text))
                            {
                                dataGridViewInformation_GYA.Rows[i].Visible = true;
                            }
                            else if (numcolumn == j && oper == 3 && Convert.ToDouble(arrayValues[i, j]) < Convert.ToDouble(textBoxFilter_GYA.Text))
                            {
                                dataGridViewInformation_GYA.Rows[i].Visible = true;
                            }
                            else if (numcolumn == j && oper == 4 && Convert.ToDouble(arrayValues[i, j]) >= Convert.ToDouble(textBoxFilter_GYA.Text))
                            {
                                dataGridViewInformation_GYA.Rows[i].Visible = true;
                            }
                            else if (numcolumn == j && oper == 5 && Convert.ToDouble(arrayValues[i, j]) <= Convert.ToDouble(textBoxFilter_GYA.Text))
                            {
                                dataGridViewInformation_GYA.Rows[i].Visible = true;
                            }
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Вы не можете отфильтровать числовым фильтром по этому столбцу", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonResetFilter_GYA_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < dataGridViewInformation_GYA.Rows.Count; i++)
            {
                dataGridViewInformation_GYA.Rows[i].Visible = true;
                checkedListBoxDepartament_GYA.Items.Clear();
                checkedListBoxPost_GYA.Items.Clear();
            }
        }

        private void buttonSorted_GYA_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell cell in dataGridViewInformation_GYA.SelectedCells)
            {
                int numcolumn = cell.ColumnIndex;
                dataGridViewInformation_GYA.Sort(dataGridViewInformation_GYA.Columns[numcolumn], System.ComponentModel.ListSortDirection.Ascending);
            }
        }

        private void comboBoxSort_GYA_SelectedIndexChanged(object sender, EventArgs e)
        {

            foreach (DataGridViewCell cell in dataGridViewInformation_GYA.SelectedCells)
            {
                int numcolumn = cell.ColumnIndex;
                if (comboBoxSort_GYA.SelectedIndex == 0)
                {
                    if (Convert.ToString(cell).ToCharArray().All(char.IsLetter))
                    {
                        dataGridViewInformation_GYA.Sort(dataGridViewInformation_GYA.Columns[numcolumn], System.ComponentModel.ListSortDirection.Ascending);
                    }
                    else
                    {
                        string[,] sortedArray = ds.SortNumbersAscending(arrayValues, numcolumn);
                        for (int r = 0; r < rows; r++)
                        {
                            for (int c = 0; c < cols; c++)
                            {
                                dataGridViewInformation_GYA.Rows[r].Cells[c].Value = sortedArray[r, c];
                            }
                        }
                    }
                }
                else
                {
                    if (Convert.ToString(cell).ToCharArray().All(char.IsLetter))
                    {
                        dataGridViewInformation_GYA.Sort(dataGridViewInformation_GYA.Columns[numcolumn], System.ComponentModel.ListSortDirection.Descending);
                    }
                    else
                    {
                        string[,] sortedArray = ds.SortNumbersDecending(arrayValues, numcolumn);
                        for (int r = 0; r < rows; r++)
                        {
                            for (int c = 0; c < cols; c++)
                            {
                                dataGridViewInformation_GYA.Rows[r].Cells[c].Value = sortedArray[r, c];
                            }
                        }

                    }
                }
            }
        }


        private void buttonCount_GYA_Click(object sender, EventArgs e)
        {

            textBoxCount_GYA.Text = ds.GetCount(arrayValues);
        }

        private void buttonMax_GYA_Click(object sender, EventArgs e)
        {

            textBoxMax_GYA.Text = ds.GetMax(arrayValues);
        }

        private void buttonMin_GYA_Click(object sender, EventArgs e)
        {
            textBoxMin_GYA.Text = ds.GetMin(arrayValues);
        }

        private void buttonSum_GYA_Click(object sender, EventArgs e)
        {
            textBoxSum_GYA.Text = ds.GetSum(arrayValues);
        }

        private void buttonAverage_GYA_Click(object sender, EventArgs e)
        {
            textBoxAverage_GYA.Text = ds.GetAverage(arrayValues);
        }


        private void buttonGetGraphic_GYA_Click(object sender, EventArgs e)
        {

            this.chartSalary_GYA.ChartAreas[0].AxisX.Title = "Работник";
            this.chartSalary_GYA.ChartAreas[0].AxisY.Title = "Оклад";
            chartSalary_GYA.Series[0].Points.Clear();
            chartSalary_GYA.Titles.Clear();
            chartSalary_GYA.Titles.Add("Размеры окладов");
            chartSalary_GYA.Series[0].ChartType = SeriesChartType.Column;
            string[] persons = ds.GetPersonsNames(arrayValues);
            int[] salaries = ds.GetSalarys(arrayValues);
            for (int i = 0; i < persons.Length; i++)
            {
                Series series = this.chartSalary_GYA.Series.Add(persons[i]);
                series.Points.Add(salaries[i]);
            }
        }


        private void buttonAdd_GYA_Click(object sender, EventArgs e)
        {
            FormAddPerson_GYA formAdd = new FormAddPerson_GYA();
            formAdd.Owner = this;
            formAdd.ShowDialog();

        }


        private void forUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show( "1. Первым шагом нужно загрузить файл. Выберите на панели главного меню раздел Файл - Загрузить. \n 2. Чтобы добавить или редактировать строки, нажмите на кнопку Редактировать строку на инструментальной панели. Введите необходимые данные и нажмите на кнопку Добавить или Редактировать \n 3. Чтобы удалить строку нажмите на кнопку Удалить строку на инструментальной панели. \n 4. Чтобы отсортировать таблицу выделите ячейку в столбце, в котором хотите сделать сортировку и выберите в комбинированном списке необходимый параметр. \n 5. Чтобы воспользоваться поиском нажмите на кнопку Поиск на инструментальной панели. В новом окне выберите условие поиска и нажмите на кнопку Найти/Сбросить. \n 6. Чтобы воспользоваться фильтром нажмите на значок фильтра на панели слева. Выберите необходимые условия и нажмите на кнопку Сброс/Применить.\n 7. Чтобы вывести элементы статистики перейдите на вкладку Статистика. Нажмите на кнопки  Найти рядом с полями вывода или на кнопку Вывести график. \n 8. Чтобы сохранить файл нажмите на кнопку Файл-Сохранить на инструментальной панели. \n 9. Чтобы узнать больше о программе нажмите на кнопку Помощь-О программе", "Руководство пользователя", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
