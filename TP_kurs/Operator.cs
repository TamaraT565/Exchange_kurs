using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TRPO_lab10
{
    public partial class Operator : Form
    {
        public Operator()
        {
            InitializeComponent();
        }

        private void Operator_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'exchange_kursDataSet1.Operator' table. You can move, or remove it, as needed.
            this.operatorTableAdapter.Fill(this.exchange_kursDataSet1.Operator);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "")
                {
                    if (Convert.ToInt32(textBox4.Text) > 22 && Convert.ToInt32(textBox4.Text) < 45)
                    {
                        operatorTableAdapter.InsertQueryOperator(textBox1.Text, textBox2.Text, textBox3.Text, Convert.ToInt32(textBox4.Text), textBox5.Text, textBox6.Text,textBoxPas.Text);
                        operatorTableAdapter.Fill(this.exchange_kursDataSet1.Operator);
                        MessageBox.Show("Запись занесена в базу данных !", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox1.Text = "";
                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox4.Text = "";
                        textBox5.Text = "";
                        textBox6.Text = "";
                        textBoxPas.Text = "";
                    }
                    else
                    { MessageBox.Show("Возраст сотрудника не подходит! Значение должно быть в пределе от 22 лет до 45 ! ", "Ошибка !", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
                else
                {
                    MessageBox.Show("Не все поля заполнены !", "Ошибка !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception  ex)
            {
                MessageBox.Show (ex.Message);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            operatorTableAdapter.DeleteQueryOperator(Convert.ToInt32(dataGridView1 .SelectedCells [0].Value ));
            operatorTableAdapter.Fill(exchange_kursDataSet1.Operator);
            operatorTableAdapter.Update(exchange_kursDataSet1.Operator);
        }

        private void buttonPoisk_Click(object sender, EventArgs e)
        {
            operatorTableAdapter.FillByPoiskFAM(exchange_kursDataSet1.Operator, textBoxPoisk.Text);
        }

        private void buttonVSE_Click(object sender, EventArgs e)
        {
            operatorTableAdapter.Fill(exchange_kursDataSet1.Operator);
            operatorTableAdapter.Update(exchange_kursDataSet1.Operator);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }
    }
}