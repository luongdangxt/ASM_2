using asm_2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASM_2
{
    public partial class BillForm : Form
    {
        public BillForm()
        {
            InitializeComponent();
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label16.Text = CalculateForm.id;
            label17.Text = CalculateForm.name;
            label18.Text = CalculateForm.phone;
            if (CalculateForm.type == 0)
            {
                label19.Text = "Household\r\ncustomer";
            }
            else if (CalculateForm.type == 1)
            {
                label19.Text += "";
                label27.Text = "Administrative\r\n agency,\r\n public services";
            }
            else if (CalculateForm.type == 2)
            {
                label19.Text = "Production\r\nunits";
            }
            else if (CalculateForm.type == 3)
            {
                label19.Text = "Business\r\n services";
            }
            else
            {
                label19.Text = "";
            }

            label20.Text = CalculateForm.WaterLastMonth.ToString();
            label21.Text = CalculateForm.WaterThisMonth.ToString();
            label22.Text = CalculateForm.amount.ToString();
            double roundedPrice = Math.Round(CalculateForm.Price, 2);
            label23.Text = roundedPrice.ToString();
            double evrmt = CalculateForm.Price * 0.1;
            double roundedValue = Math.Round(evrmt, 2);
            label24.Text = roundedValue.ToString();
            double vat = (CalculateForm.Price + evrmt) * 0.1;
            double roundedVat = Math.Round(vat, 2);
            label25.Text = roundedVat.ToString();
            double roundedTotal = Math.Round(CalculateForm.Total, 2);
            label26.Text = roundedTotal.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CalculateForm form1 = new CalculateForm();
            this.Hide();
            form1.ShowDialog();
            //this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult exit = MessageBox.Show("Are you sure you want to exit ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (exit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                e.SuppressKeyPress = true;
                Loginform form3 = new Loginform();
                this.Hide();
                form3.ShowDialog();
                this.Close();
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
