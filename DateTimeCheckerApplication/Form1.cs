using DateTimeChecker;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateTimeCheckerApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure to exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDay.Text = "";
            txtMonth.Text = "";
            txtYear.Text = "";
            txtDay.Focus();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            byte day = 0;
            byte month = 0;
            ushort year = 0;
            // 1.
            try
            {
                day = byte.Parse(txtDay.Text);
                if (day < 1 || day > 31)
                {
                    MessageBox.Show("Input data for Day is out of range!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDay.Focus();
                    return;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Input data for Day is incorrect format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDay.Focus();
                return;
            }
            // 2.
            try
            {
                month = byte.Parse(txtMonth.Text);
                if (month < 1 || month > 12)
                {
                    MessageBox.Show("Input data for Month is out of range!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMonth.Focus();
                    return;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Input data for Month is incorrect format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMonth.Focus();
                return;
            }
            // 3.
            try
            {
                year = ushort.Parse(txtYear.Text);
                if (year < 1000 || year > 3000)
                {
                    MessageBox.Show("Input data for Year is out of range!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Input data for Year is incorrect format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            Checker check = new Checker();

            if (check.IsValidDate(year,month,day))
            {
                MessageBox.Show(day + "/" + month + "/" + year + " is correct date time!");
            }
            else
            {
                MessageBox.Show(day + "/" + month + "/" + year + " is Not correct date time!");
            }
        }
    }
}
