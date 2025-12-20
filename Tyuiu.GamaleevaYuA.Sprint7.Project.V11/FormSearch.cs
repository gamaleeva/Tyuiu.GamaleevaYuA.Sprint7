using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static Tyuiu.GamaleevaYuA.Sprint7.Project.V11.Program;

namespace Tyuiu.GamaleevaYuA.Sprint7.Project.V11
{
    public partial class FormSearch : Form
    {
       
        public FormSearch()
        {
            InitializeComponent();

            
        }

        private void buttonDoSearch_GYA_Click(object sender, EventArgs e)
        {
            FormMain_GYA formMain = this.Owner as FormMain_GYA;
            if (formMain != null)
            {
                for (int i = 0; i < formMain.dataGridViewInformation_GYA.Rows.Count - 1; i++)
                {
                    formMain.dataGridViewInformation_GYA.Rows[i].Visible = false;
                    for (int c = 0; c < formMain.dataGridViewInformation_GYA.Columns.Count - 1; c++)
                    {
                        if (formMain.dataGridViewInformation_GYA[c, i].Value.ToString() == textBoxInputSearch_GYA.Text)
                        {
                            formMain.dataGridViewInformation_GYA.Rows[i].Visible = true;
                            formMain.dataGridViewInformation_GYA.Rows[i].Cells[c].Style.BackColor = Color.Yellow;
                            break;
                        }
                    }
                }

            }

        }
    }
}
