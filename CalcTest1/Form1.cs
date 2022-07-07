using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcTest1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            CalcTextBox.ScrollBars = ScrollBars.Vertical;
            CalcTextBox.WordWrap = true;
        }

        private void Button_click(object sender, EventArgs e)
        {
            CalcTextBox.Text += (sender as Button).Text;
        }

        private void equals_Click(object sender, EventArgs e)
        {
            try
            {
                CalcTextBox.Text = Convert.ToString(new System.Data.DataTable().Compute(CalcTextBox.Text, ""));
            }
            catch
            {
                MessageBox.Show("Ein fehler ist aufgetreten!", "Sorry!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            DialogResult result = DialogResult.None; //Default none

            result = DialogResult.Yes;

            if (checkBox1.Checked == false)
            {
                result = MessageBox.Show("Sicher das du die eingabe löschen willst?", "Bist du dir sicher?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            if (result == DialogResult.Yes)
            {
                CalcTextBox.Text = "";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (CalcTextBox.Text != "")
            {
                CalcTextBox.Text = CalcTextBox.Text.Remove(CalcTextBox.Text.Length - 1, 1);
            }
        }
    }
}
