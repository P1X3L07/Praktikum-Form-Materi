using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trial_Praktikum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (listBoxCollection.Items.Contains(txtBoxData.Text))
            {
                MessageBox.Show("Input Kembali");                
            }
            else
            {
                listBoxCollection.Items.Add(txtBoxData.Text);
            }
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelOutputResult.Text = listBoxCollection.SelectedItem.ToString();
        }

        private void ckBoxAktif_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void labelOutputResult_Click(object sender, EventArgs e)
        {

        }

        private void radioBtnBlue_CheckedChanged(object sender, EventArgs e)
        {
            if(ckBoxAktif.Checked == true)
            {
                labelOutputResult.ForeColor = Color.Blue;
            }
            else
            {
                labelOutputResult.ForeColor = Color.Black;
            }
        }

        private void radioBtnRed_CheckedChanged(object sender, EventArgs e)
        {
            if(ckBoxAktif.Checked == true)
            {
                labelOutputResult.ForeColor = Color.Red;
            }
            else
            {
                labelOutputResult.ForeColor = Color.Black;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBoxData.Text = "";
            listBoxCollection.Items.Clear();
            labelOutputResult.Text = " ";
        }
    }
}
