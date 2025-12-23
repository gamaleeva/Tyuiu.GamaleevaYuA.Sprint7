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
        
        public string GetMax(string[,] array)
        {
            
            var salarys = new List<int>() { };
            for (int i = 0; i <= array.GetUpperBound(0); i++)
            {
             
                 salarys.Add(Convert.ToInt32(array[i, 8]));

            }
            string res = Convert.ToString(salarys.Max());
            return res;
        }
        
        public string GetCount(string[,] array)
        {
            string res = Convert.ToString(array.GetUpperBound(0) + 1);
            return res;
        }
        public string GetMin(string[,] array)
        {

            var salarys = new List<int>() { };
            for (int i = 0; i <= array.GetUpperBound(0); i++)
            {

                salarys.Add(Convert.ToInt32(array[i, 8]));

            }
            string res = Convert.ToString(salarys.Min());
            return res;
        }
        public string GetSum(string[,] array)
        {
            double sumSalarys = 0;
            for (int i = 0; i <= array.GetUpperBound(0); i++)
            {
                sumSalarys += Convert.ToInt32(array[i, 8]);
            }
            string res = Convert.ToString(sumSalarys);
            return res;
        }
        public string GetAverage(string[,] array)
        {
            double sumSalarys = 0;
            for (int i = 0; i <= array.GetUpperBound(0); i++)
            {
                sumSalarys += Convert.ToInt32(array[i, 8]);

            }
            string res = Convert.ToString(Math.Round(sumSalarys/ (array.GetUpperBound(0) + 1), 2));
            return res;

        }
        public int[] GetSalarys(string[,] array)
        {
            int[] salarys = new int[array.GetUpperBound(0) + 1];
            for (int i = 0; i <= array.GetUpperBound(0); i++)
            {

                salarys[i] = (Convert.ToInt32(array[i, 8]));

            }
            return salarys;
        }
        public string[] GetPersonsNames(string[,] array)
        {
            string[] names = new string[array.GetUpperBound(0) + 1];
            string name = "";
            for (int i = 0; i <= array.GetUpperBound(0); i++)
            {
                name = (array[i, 1] + " " + array[i, 2][0] + "." + array[i, 3][0] + ".");
                names[i] = name;
                name = "";

            }
            return names;

        }
    }
    
}
