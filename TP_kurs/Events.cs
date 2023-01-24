using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TRPO_lab10
{
    public partial class Events : Form
    {
        public Events()
        {
            InitializeComponent();
        }

        private void Events_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "exchange_kursDataSet1.Events". При необходимости она может быть перемещена или удалена.
            this.eventsTableAdapter.Fill(this.exchange_kursDataSet1.Events);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "" && textBox2.Text != "" && dateTimePicker1.Text != "")
                {
                        eventsTableAdapter.InsertQueryEvents(dateTimePicker1.Value.Date, textBox2.Text, textBox1.Text);
                        eventsTableAdapter.Fill(this.exchange_kursDataSet1.Events);
                        MessageBox.Show("Запись занесена в базу данных !", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox1.Text = "";
                        textBox2.Text = "";
                    }
                else
                {
                    MessageBox.Show("Не все поля заполнены !", "Ошибка !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            eventsTableAdapter.Fill(exchange_kursDataSet1.Events);
            eventsTableAdapter.Update(exchange_kursDataSet1.Events);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            eventsTableAdapter.DeleteQueryEvents(Convert.ToInt32(dataGridView1.SelectedCells[0].Value));
            eventsTableAdapter.Fill(exchange_kursDataSet1.Events);
            eventsTableAdapter.Update(exchange_kursDataSet1.Events);
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker2.MaxDate = dateTimePicker3.Value;
            dateTimePicker3.MinDate = dateTimePicker2.Value;
        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker2.MaxDate = dateTimePicker3.Value;
            dateTimePicker3.MinDate = dateTimePicker2.Value;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.MaxDate = dateTimePicker1.Value;
        }
    }
    }

