using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TRPO_lab10
{
    public partial class Enter : Form
    {
        public Enter()
        {
            InitializeComponent();
        }
        bool b = false;
        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection(TRPO_lab10.Properties.Settings.Default.exchange_kursConnectionString);
            if (conn.State != ConnectionState.Open)
                conn.Open();
            SqlCommand cquery = new SqlCommand("Select PAS from Operator WHERE FAM='" + comboBox1.Text+"'", conn);
            string pas = "";
            try 
            { 
                pas = (string)cquery.ExecuteScalar(); 
            }
            catch (Exception ex)
            {
                if (MessageBox.Show(ex.Message, "Ошибка подключения", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                    Application.Exit();
            }
            if (pas.Trim() == textBox1.Text)
            {
                try
                {
                    enterTableAdapter.InsertQueryEnter(comboBox1.Text, DateTime.Now);
                    b = true;
                }
                catch (Exception ex)
                {
                    if (MessageBox.Show(ex.Message, "Ошибка подключения", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                        Application.Exit();
                }
               
                
                this.Close();
                
            }
            else
            {
             MessageBox.Show("Неверный пароль", "Ошибка подключения", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

               
          
        }

        private void Enter_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'exchange_kursDataSet.Operator' table. You can move, or remove it, as needed.
            this.operatorTableAdapter1.Fill(this.exchange_kursDataSet.Operator);
            try
            {
                // TODO: This line of code loads data into the 'exchange_kursDataSet.User' table. You can move, or remove it, as needed.
                this.userTableAdapter.Fill(this.exchange_kursDataSet.User);
                // TODO: This line of code loads data into the 'exchange_kursDataSet.Enter' table. You can move, or remove it, as needed.
                this.enterTableAdapter.Fill(this.exchange_kursDataSet.Enter);
            }
            catch (Exception exc)
            {
                if (MessageBox.Show("" + exc.Message + "", "", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Retry)
                {
                    LoadData();
                }
                else
                    Application.Exit();
            }
        }

        private void LoadData()
        {
            try
            {
                this.userTableAdapter.Fill(this.exchange_kursDataSet.User);
                this.enterTableAdapter.Fill(this.exchange_kursDataSet.Enter);
            }
            catch (Exception exc)
            {
                if (MessageBox.Show("" + exc.Message + "", "", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Retry)
                {
                    LoadData();
                }
                else
                    Application.Exit();
            }
        }

        private void Enter_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (b == false)
            {
                Application.Exit();
            }
            else
                (new Main()).ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}