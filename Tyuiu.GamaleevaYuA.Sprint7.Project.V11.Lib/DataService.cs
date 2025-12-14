namespace Tyuiu.GamaleevaYuA.Sprint7.Project.V11.Lib
{
    public class DataService
    {
        public int[,] GetMatrix(string path)
        {
            string fileData = File.ReadAllText(path);
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
            int rows = lines.Length;
            int cols = lines[0].Split(';').Length;
            int[,] arrayValues = new int[rows, cols];
            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < cols; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);

                }
            }
            int xcol = 1;
            for (int r = 0; r < rows; r++)
            {
                for (int c = xcol; c <= xcol; c++)
                {
                    if (arrayValues[r, c] > 5)
                    {
                        arrayValues[r, c] = 222;
                    }
                }
            }
            return arrayValues;

        }
    }
}
