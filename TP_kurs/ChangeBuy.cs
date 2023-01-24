using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TRPO_lab10
{
    public partial class ChangeBuy : Form
    {
        public ChangeBuy()
        {
            InitializeComponent();
        }

        private void ChangeBuy_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'exchange_kursDataSet.Pokupka' table. You can move, or remove it, as needed.
            this.pokupkaTableAdapter.Fill(this.exchange_kursDataSet.Pokupka);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                pokupkaTableAdapter.UpdateQuery(Convert.ToDecimal(textBoxUSD.Text), Convert.ToDecimal(textBoxEUR.Text), Convert.ToDecimal(textBoxGBR.Text), Convert.ToDecimal(textBoxCNY.Text), Convert.ToDecimal(textBoxRUB.Text),DateTime.Now.Date);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка обновления", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxUSD_TextChanged(object sender, EventArgs e)
        {
            if (textBoxUSD.Text == "-")
            {
                MessageBox.Show("Ошибка ввода.", "Ошибка ввода данных", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxUSD.Text = "";
            }
        }

        private void textBoxEUR_TextChanged(object sender, EventArgs e)
        {
            if (textBoxEUR.Text == "-")
            {
                MessageBox.Show("Ошибка ввода.", "Ошибка ввода данных", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxEUR.Text = "";
            }
        }

        private void textBoxMDL_TextChanged(object sender, EventArgs e)
        {
            if (textBoxGBR.Text == "-")
            {
                MessageBox.Show("Ошибка ввода.", "Ошибка ввода данных", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxGBR.Text = "";
            }
        }

        private void textBoxUAH_TextChanged(object sender, EventArgs e)
        {
            if (textBoxCNY.Text == "-")
            {
                MessageBox.Show("Ошибка ввода.", "Ошибка ввода данных", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxCNY.Text = "";
            }
        }

        private void textBoxRUB_TextChanged(object sender, EventArgs e)
        {
            if (textBoxRUB.Text == "-")
            {
                MessageBox.Show("Ошибка ввода.", "Ошибка ввода данных", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxRUB.Text = "";
            }
        }
    }
}