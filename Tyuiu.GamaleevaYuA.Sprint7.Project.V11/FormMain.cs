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



                for (int r = 0; r < rows - 1; r++)
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

            dataGridViewInformation_GYA.AllowUserToAddRows = false;
            FormSearch formSearch = new FormSearch();
            formSearch.Owner = this;
            formSearch.ShowDialog();
            if (formSearch.DialogResult == DialogResult.Cancel)
            {
                dataGridViewInformation_GYA.AllowUserToAddRows = true;
            }

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

        private void loadFileToolStripMenuItem_GYA_Click(object sender, EventArgs e)
        {
            openFileDialogMain_GYA.ShowDialog();
            openFilePath = openFileDialogMain_GYA.FileName;
            arrayValues = new string[rows, cols];
            arrayValues = ds.LoadFromFileData(openFilePath);
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
            dataGridViewInformation_GYA.AllowUserToAddRows = false;
            for (int i = 0; i < dataGridViewInformation_GYA.Rows.Count; i++)
            {
                dataGridViewInformation_GYA.Rows[i].Visible = false;
            }
            foreach (String str in checkedListBoxDepartament_GYA.SelectedItems)
            {
                for (int i = 0; i < rows - 1; i++)
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
                for (int i = 0; i < rows - 1; i++)
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
            foreach (DataGridViewCell cell in dataGridViewInformation_GYA.SelectedCells)
            {
                int numcolumn = cell.ColumnIndex;
                var oper = comboBoxOperators_GYA.SelectedIndex;
                for (int i = 0; i < rows - 1; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        if (oper == 0 && Convert.ToDouble(arrayValues[i, j]) == Convert.ToDouble(textBoxFilter_GYA.Text) && numcolumn == j)
                        {
                            dataGridViewInformation_GYA.Rows[i].Visible = true;
                        }
                        else if (oper == 1 && Convert.ToDouble(arrayValues[i, j]) != Convert.ToDouble(textBoxFilter_GYA.Text) && numcolumn == j)
                        {
                            dataGridViewInformation_GYA.Rows[i].Visible = true;
                        }
                        else if (oper == 2 && Convert.ToDouble(arrayValues[i, j]) > Convert.ToDouble(textBoxFilter_GYA.Text) && numcolumn == j)
                        {
                            dataGridViewInformation_GYA.Rows[i].Visible = true;
                        }
                        else if (oper == 3 && Convert.ToDouble(arrayValues[i, j]) < Convert.ToDouble(textBoxFilter_GYA.Text) && numcolumn == j)
                        {
                            dataGridViewInformation_GYA.Rows[i].Visible = true;
                        }
                        else if (oper == 4 && Convert.ToDouble(arrayValues[i, j]) >= Convert.ToDouble(textBoxFilter_GYA.Text) && numcolumn == j)
                        {
                            dataGridViewInformation_GYA.Rows[i].Visible = true;
                        }
                        else if (oper == 5 && Convert.ToDouble(arrayValues[i, j]) <= Convert.ToDouble(textBoxFilter_GYA.Text) && numcolumn == j)
                        {
                            dataGridViewInformation_GYA.Rows[i].Visible = true;
                        }
                    }
                }
            }
            dataGridViewInformation_GYA.AllowUserToAddRows = true;
        }

        private void buttonResetFilter_GYA_Click(object sender, EventArgs e)
        {
            dataGridViewInformation_GYA.AllowUserToAddRows = false;
            for (int i = 0; i < dataGridViewInformation_GYA.Rows.Count; i++)
            {
                dataGridViewInformation_GYA.Rows[i].Visible = true;
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
            textBoxCount_GYA.Text = Convert.ToString(rows);
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

        private void buttonGraphic_GYA_Click(object sender, EventArgs e)
        {

        }
    }
}
