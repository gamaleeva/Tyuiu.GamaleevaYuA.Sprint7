using Microsoft.VisualBasic;
using System.Collections.Immutable;
using System.Collections.Specialized;
using System.Data;

namespace Tyuiu.GamaleevaYuA.Sprint7.Project.V11.Lib
{
    public class DataService
    {
        public string[,] SortNumbersAscending(string[,] array, int numcol)
        {
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);

            if (numcol < 0 || numcol >= cols)
            {
                throw new ArgumentOutOfRangeException(nameof(numcol), "Column index is out of range");
            }

            int[] nums = new int[rows];
            int[] indices = new int[rows];

            for (int i = 0; i < rows; i++)
            {
                nums[i] = Convert.ToInt32(array[i, numcol]);
                indices[i] = i;
            }

            Array.Sort(nums, indices);

            string[,] result = new string[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                int originalRowIndex = indices[i];
                for (int j = 0; j < cols; j++)
                {
                    result[i, j] = array[originalRowIndex, j];
                }
            }

            return result;
        }

        public string[,] SortNumbersDecending(string[,] array, int numcol)
        {
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);

            if (numcol < 0 || numcol >= cols)
            {
                throw new ArgumentOutOfRangeException(nameof(numcol), "Column index is out of range");
            }

            int[] nums = new int[rows];
            int[] indices = new int[rows];

            for (int i = 0; i < rows; i++)
            {
                nums[i] = Convert.ToInt32(array[i, numcol]);
                indices[i] = i;
            }

            Array.Sort(nums, indices);
            Array.Reverse(nums);
            Array.Reverse(indices);

            string[,] result = new string[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                int originalRowIndex = indices[i];
                for (int j = 0; j < cols; j++)
                {
                    result[i, j] = array[originalRowIndex, j];
                }
            }

            return result;
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
        public 
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
