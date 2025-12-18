using Tyuiu.GamaleevaYuA.Sprint7.Project.V11.Lib;
namespace Tyuiu.GamaleevaYuA.Sprint7.Project.V11
{
    public partial class FormMain_GYA : Form
    {
        public FormMain_GYA()
        {
            InitializeComponent();
            openFileDialogMain_GYA.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogMain_GYA.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }



        private void pictureBoxTools_GYA_Click(object sender, EventArgs e)
        {
            panelToolbar_GYA.Size = new System.Drawing.Size(200, 451);
        }

        private void pictureBoxTools_GYA_DoubleClick(object sender, EventArgs e)
        {
            panelToolbar_GYA.Size = new System.Drawing.Size(21, 451);
        }

        private void pictureBoxTools_GYA_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxTools_GYA.Cursor = Cursors.Hand;
        }

        private void buttonAbout_GYA_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
        DataService ds = new DataService();
        static string openFilePath;
        static int rows;
        static int cols;
        public static string[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
            rows = lines.Length;
            cols = lines[0].Split(';').Length;
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

        private void buttonAddFile_GYA_Click(object sender, EventArgs e)
        {
            openFileDialogMain_GYA.ShowDialog();
            openFilePath = openFileDialogMain_GYA.FileName;
            string[,] arrayValues = new string[rows, cols];
            arrayValues = LoadFromFileData(openFilePath);

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

        private void buttonSearch_GYA_Click(object sender, EventArgs e)
        {

        }
    }
}
