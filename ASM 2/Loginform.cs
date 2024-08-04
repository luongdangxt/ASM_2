using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace asm_2
{
    public partial class Loginform : Form
    {
        public Loginform()
        {
            InitializeComponent();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {

        }
        // Login button
        private void button1_Click(object sender, EventArgs e)
        {
            if (TbUsername.Text.ToLower() == "luonghaidang" 
                && TbPassword.Text.ToLower() == "12345")
            {
                CalculateForm calculateform = new CalculateForm();
                this.Hide();
                calculateform.ShowDialog();
            }
            else
            {
                DialogResult exit = MessageBox.Show("Please enter correct account password", 
                    "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
        }
        // Exit button
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult exit = MessageBox.Show("Are you sure you want to exit ?", 
                "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (exit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        // event change form 
        private void Form3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                e.SuppressKeyPress = true;
                CalculateForm calculateform = new CalculateForm();
                this.Hide();
                calculateform.ShowDialog();
            }
        }
        // close program when form close
        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }
    }
}
