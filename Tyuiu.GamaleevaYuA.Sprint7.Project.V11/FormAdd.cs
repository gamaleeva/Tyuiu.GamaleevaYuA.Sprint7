using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.GamaleevaYuA.Sprint7.Project.V11
{
    public partial class FormAddPerson_GYA : Form
    {
        public FormAddPerson_GYA()
        {
            InitializeComponent();
        }

        private void buttonDoAdd_GYA_Click(object sender, EventArgs e)
        {
            FormMain_GYA formMain = this.Owner as FormMain_GYA;
            if (formMain != null)
            {
                formMain.dataGridViewInformation_GYA.Rows.Add();
                int rows = formMain.dataGridViewInformation_GYA.RowCount - 1;
                formMain.dataGridViewInformation_GYA.Rows[rows].Cells[0].Value = textBoxKeyAdd_GYA.Text;
                formMain.dataGridViewInformation_GYA.Rows[rows].Cells[1].Value = textBoxSurnameAdd_GYA.Text;
                formMain.dataGridViewInformation_GYA.Rows[rows].Cells[2].Value = textBoxNameAdd_GYA.Text;
                formMain.dataGridViewInformation_GYA.Rows[rows].Cells[3].Value = textBoxLastnameAdd_GYA.Text;
                formMain.dataGridViewInformation_GYA.Rows[rows].Cells[4].Value = textBoxDepartamentAdd_GYA.Text;
                formMain.dataGridViewInformation_GYA.Rows[rows].Cells[5].Value = textBoxPostAdd_GYA.Text;
                formMain.dataGridViewInformation_GYA.Rows[rows].Cells[6].Value = textBoxPhoneAdd_GYA.Text;
                formMain.dataGridViewInformation_GYA.Rows[rows].Cells[7].Value = textBoxAddressAdd_GYA.Text;
                formMain.dataGridViewInformation_GYA.Rows[rows].Cells[8].Value = textBoxSalaryAdd_GYA.Text;

            }
        }

        private void textBoxKeyAdd_GYA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }
        private void textBoxNameAdd_GYA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == ',' || e.KeyChar == 32)
            {
                e.Handled = true;
            }
        }

        
    }
}
