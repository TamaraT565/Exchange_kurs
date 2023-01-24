using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Printing;
using System.Data.SqlClient;

namespace TRPO_lab10
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private Font printFont; // переменная для задачи шрифта при печати 
        private StreamReader streamToPrint; // поток чтения для печати  
        static string filePath = @"Чек.txt"; // строка полного пути к распечатываемому файлу

        // Метод загружающий основную часть данных программы 
        private void Main_Load(object sender, EventArgs e)
        {
      
            this.obmen_ValutTableAdapter.Fill(this.exchange_kursDataSet.Obmen_Valut);
            try
            {   // макс ID из таблицы Enter
                int a = (int)enterTableAdapter.ScalarQueryMAXID();
                // тот кто зашел в программу на данный момент 
                toolStripStatusLabel1.Text = enterTableAdapter.ScalarQueryFIObyID(a).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            try
            {
                // TODO: This line of code loads data into the 'exchange_kursDataSet.Enter' table. You can move, or remove it, as needed.
                this.enterTableAdapter.Fill(this.exchange_kursDataSet.Enter);
                // TODO: This line of code loads data into the 'exchange_kursDataSet.Obmen_Valut' table. You can move, or remove it, as needed.
                this.obmen_ValutTableAdapter.Fill(this.exchange_kursDataSet.Obmen_Valut);
                // TODO: This line of code loads data into the 'exchange_kursDataSet.Prodaga' table. You can move, or remove it, as needed.
                this.prodagaTableAdapter.Fill(this.exchange_kursDataSet.Prodaga);
                // TODO: This line of code loads data into the 'exchange_kursDataSet.Pokupka' table. You can move, or remove it, as needed.
                this.pokupkaTableAdapter.Fill(this.exchange_kursDataSet.Pokupka);
            }
            catch (Exception exc)
            {
                if (MessageBox.Show("Ошибка: /n" + exc.Message + "/n Хотите побровать снова ?", " Ошибка", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Retry)
                {
                    LoadData();
                }
                else
                    Application.Exit();
            }
            UpdateBuyLabels();
            UpdateSellLabels();
        }

        // загрузка данных из базы данных в приложение (рекурсия)  
        private void LoadData()
        {
            try
            {
                this.enterTableAdapter.Fill(this.exchange_kursDataSet.Enter);
                this.obmen_ValutTableAdapter.Fill(this.exchange_kursDataSet.Obmen_Valut);
                this.prodagaTableAdapter.Fill(this.exchange_kursDataSet.Prodaga);
                this.pokupkaTableAdapter.Fill(this.exchange_kursDataSet.Pokupka);
            }
            catch (Exception exc)
            {
                if (MessageBox.Show("Ошибка: /n" + exc.Message + "/n Хотите побровать снова ?", " Ошибка", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Retry)
                {
                    LoadData();
                }
                else
                    Application.Exit();
            }
        }

        // Выборка из базы данных курса валют ПОКУПКИ для вычисления расчетной суммы 
        private double DoChangeBuy(string sum)
        {
            try
            {
                double val = 0;
                switch (comboBox1.Text)
                {
                    case "USD":
                        val = Convert.ToDouble(sum) * Convert.ToDouble(pokupkaTableAdapter.ScalarQueryUSDPokupka());
                        break;
                    case "EUR":
                        val = Convert.ToDouble(sum) * Convert.ToDouble(pokupkaTableAdapter.ScalarQueryEURPokupka());
                        break;
                    case "GBR":
                        val = Convert.ToDouble(sum) * Convert.ToDouble(pokupkaTableAdapter.ScalarQueryGBRPokupka());
                        break;
                    case "CNY":
                        val = Convert.ToDouble(sum) * Convert.ToDouble(pokupkaTableAdapter.ScalarQueryCNYPokupka());
                        break;
                    case "RUB":
                        val = Convert.ToDouble(sum) * Convert.ToDouble(pokupkaTableAdapter.ScalarQueryRUBPokupka());
                        break;
                }
                return val;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
        // Выборка из базы данных курса валют ПРОДАЖИ для вычисления расчетной суммы 
        private double DoChangeSell(string sum)
        {
            try
            {
                double val = 0;
                switch (comboBox2.Text)
                {
                    case "USD":
                        val = Convert.ToDouble(sum) * Convert.ToDouble(prodagaTableAdapter.ScalarQueryUSDProdaga());
                        break;
                    case "EUR":
                        val = Convert.ToDouble(sum) * Convert.ToDouble(prodagaTableAdapter.ScalarQueryEURProdaga());
                        break;
                    case "GBR":
                        val = Convert.ToDouble(sum) * Convert.ToDouble(prodagaTableAdapter.ScalarQueryGBRProdaga());
                        break;
                    case "CNY":
                        val = Convert.ToDouble(sum) * Convert.ToDouble(prodagaTableAdapter.ScalarQueryCNYProdaga());
                        break;
                    case "RUB":
                        val = Convert.ToDouble(sum) * Convert.ToDouble(prodagaTableAdapter.ScalarQueryRUBProdaga());
                        break;
                }
                return val;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
        // Выборка из базы данных курса валют ПОКУПКИ (Buy)
        private Single SelectKursBuy()
        {
            Single val = 0;
            switch (comboBox1.Text)
            {
                case "USD":
                    val = (Single)pokupkaTableAdapter.ScalarQueryUSDPokupka();
                    break;
                case "EUR":
                    val = (Single)pokupkaTableAdapter.ScalarQueryEURPokupka();
                    break;
                case "GBR":
                    val = (Single)pokupkaTableAdapter.ScalarQueryGBRPokupka();
                    break;
                case "CNY":
                    val = (Single)pokupkaTableAdapter.ScalarQueryCNYPokupka();
                    break;
                case "RUB":
                    val = (Single)pokupkaTableAdapter.ScalarQueryRUBPokupka();
                    break;
            }
            return val;
        }

        // Выборка из базы данных курса валют Продажи (Sell)
        private Single SelectKursSell()
        {
            Single val = 0;
            switch (comboBox2.Text)
            {
                case "USD":
                    val = (Single)prodagaTableAdapter.ScalarQueryUSDProdaga();
                    break;
                case "EUR":
                    val = (Single)prodagaTableAdapter.ScalarQueryEURProdaga();
                    break;
                case "GBR":
                    val = (Single)prodagaTableAdapter.ScalarQueryGBRProdaga();
                    break;
                case "CNY":
                    val = (Single)prodagaTableAdapter.ScalarQueryCNYProdaga();
                    break;
                case "RUB":
                    val = (Single)prodagaTableAdapter.ScalarQueryRUBProdaga();
                    break;
            }
            return val;
        }

        // Обновление текущих курсов валют для ПОКУПКИ
        private void UpdateBuyLabels()
        {
            try
            {
                labelUSD_p.Text = pokupkaTableAdapter.ScalarQueryUSDPokupka().ToString();
                labelEUR_p.Text = pokupkaTableAdapter.ScalarQueryEURPokupka().ToString();
                labelUAH_p.Text = pokupkaTableAdapter.ScalarQueryCNYPokupka().ToString();
                labelRUB_p.Text = pokupkaTableAdapter.ScalarQueryRUBPokupka().ToString();
                labelMDL_p.Text = pokupkaTableAdapter.ScalarQueryGBRPokupka().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Обновление текущих курсов валют для ПРОДАЖИ
        private void UpdateSellLabels()
        {
            try
            {
                labelUSD.Text = prodagaTableAdapter.ScalarQueryUSDProdaga().ToString();
                labelEUR.Text = prodagaTableAdapter.ScalarQueryEURProdaga().ToString();
                labelUAH.Text = prodagaTableAdapter.ScalarQueryCNYProdaga().ToString();
                labelRUB.Text = prodagaTableAdapter.ScalarQueryRUBProdaga().ToString();
                labelMDL.Text = prodagaTableAdapter.ScalarQueryGBRProdaga().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Печать чека ПОКУПКИ
        private void PrintCheckBuy()
        {
            try
            {
                StreamWriter stwr = new StreamWriter(@"Чек.txt", false); // поток открытия по записи  
                stwr.NewLine = Separ("", "", "", "", "", "-") + "-----\r\n";
                stwr.WriteLine();
                for (int i = 0; i < 2; i++)
                {
                    stwr.NewLine = "Квитанция о валютно-обменной операции\r\n";
                    stwr.WriteLine();
                    stwr.NewLine = Separ("", "--- Получено ", "", " Выдано ", "", "-") + "\r\n";
                    stwr.WriteLine();
                    //stwr.NewLine = Separ("Сумма", textBoxPolucheno.Text, comboBox1.Text, DoChangeBuy(textBoxSumma_Obmena.Text).ToString(), "ПМР", " ") + "\r\n";
                    //stwr.WriteLine();
                    stwr.NewLine = Separ("Курс      ", "1", "", SelectKursBuy().ToString(), "", " ") + "\r\n";
                    stwr.WriteLine();
                    stwr.NewLine = Separ("Итого ", textBoxSumma_Obmena.Text, comboBox1.Text, DoChangeBuy(textBoxSumma_Obmena.Text).ToString(), "ПМР", " ") + "\r\n";
                    stwr.WriteLine();
                    stwr.NewLine = Separ("", "", "", "", "", "-") + "-----\r\n";
                    stwr.WriteLine();
                    stwr.NewLine = DateTime.Now + " --- " + "Код " + obmen_ValutTableAdapter.ScalarQueryID().ToString() + "\r\n";
                    stwr.WriteLine();
                    stwr.NewLine = "  \r\n";
                    stwr.WriteLine();
                    stwr.NewLine = toolStripStatusLabel2.Text + toolStripStatusLabel1.Text + "  ___________ \r\n";
                    stwr.WriteLine();
                    stwr.NewLine = "  \r\n";
                    stwr.WriteLine();
                    stwr.NewLine = Separ("", "", "", "", "", "-") + "-----\r\n";
                    stwr.WriteLine();
                }
                stwr.Close(); // зактрытие файла
            }
            catch (Exception exc)
            {
                if (MessageBox.Show("Ошибка подготовки к печати:\n" + exc.Message, "Ошибка", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Retry)
                    PrintCheckSell();
            }
            Printing();
        }

        // Печать чека ПРОДАЖИ
        private void PrintCheckSell()
        {
            try
            {
                StreamWriter stwr = new StreamWriter(@"Чек.txt", false);
                stwr.NewLine = Separ("", "", "", "", "", "-") + "-----\r\n";
                stwr.WriteLine();
                for (int i = 0; i < 2; i++)
                {
                    stwr.NewLine = "Квитанция о валютно-обменной операции\r\n";
                    stwr.WriteLine();
                    stwr.NewLine = Separ("", "--- Получено ", "", " Выдано ", "", "-") + "\r\n";
                    stwr.WriteLine();
                    stwr.NewLine = Separ("Сумма", DoChangeSell(textBoxSum.Text).ToString(), "ПМР", textBoxSum.Text, comboBox2.Text, " ") + "\r\n";
                    stwr.WriteLine();
                    stwr.NewLine = Separ("Курс      ", SelectKursSell().ToString(), "", "1", "", " ") + "\r\n";
                    stwr.WriteLine();
                    stwr.NewLine = Separ("Итого ", DoChangeSell(textBoxSum.Text).ToString(), "ПМР", textBoxSum.Text, comboBox2.Text, " ") + "\r\n";
                    stwr.WriteLine();
                    stwr.NewLine = Separ("", "", "", "", "", "-") + "-----\r\n";
                    stwr.WriteLine();
                    stwr.NewLine = DateTime.Now + " --- " + "Код " + obmen_ValutTableAdapter.ScalarQueryID().ToString() + "\r\n";
                    stwr.WriteLine();
                    stwr.NewLine = "  \r\n";
                    stwr.WriteLine();
                    stwr.NewLine = toolStripStatusLabel2.Text + toolStripStatusLabel1.Text + "  ___________ \r\n";
                    stwr.WriteLine();
                    stwr.NewLine = "  \r\n";
                    stwr.WriteLine();
                    stwr.NewLine = Separ("", "", "", "", "", "-") + "-----\r\n";
                    stwr.WriteLine();
                }
                stwr.Close();
            }
            catch (Exception exc)
            {
                if (MessageBox.Show("Ошибка подготовки к печати:\n" + exc.Message, "Ошибка", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Retry)
                    PrintCheckSell();
            }
            Printing();
        }

        // Вычисление длины строк 
        private string Separ(string str1, string str2, string str3, string str4, string str5, string sep)
        {
            int countSer = 0;
            string temp = str1;
            countSer = 5 - str1.Length;
            for (int i = 0; i < countSer; i++)
                temp += sep;
            countSer = 15 - str2.Length;
            for (int i = 0; i < countSer; i++)
                temp += sep;
            temp += str2;
            countSer = 5 - str3.Length;
            for (int i = 0; i < countSer; i++)
                temp += sep;
            temp += str3;
            countSer = 15 - str4.Length;
            for (int i = 0; i < countSer; i++)
                temp += sep;
            temp += str4;
            countSer = 5 - str5.Length;
            for (int i = 0; i < countSer; i++)
                temp += sep;
            temp += str5;
            countSer = 45 - temp.Length;
            for (int i = 0; i < countSer; i++)
                temp += sep;
            return temp;
        }

        //метод распечатки файла
        public void Printing()
        {
            try
            {
                streamToPrint = new StreamReader(filePath); // печать файла
                try
                {
                    printFont = new Font("Arial", 10);
                    PrintDocument pd = new PrintDocument();
                    pd.PrintPage += new PrintPageEventHandler(pd_PrintPage);
                    pd.Print();
                }
                finally
                {
                    streamToPrint.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка печати", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //метод добавления события распечатки
        void pd_PrintPage(object sender, PrintPageEventArgs ev)
        {
            float linesPerPage = 0;
            float yPos = 0;
            int count = 0;
            float leftMargin = ev.MarginBounds.Left;
            float topMargin = ev.MarginBounds.Top;
            String line = null;
            // Calculate the number of lines per page.
            linesPerPage = ev.MarginBounds.Height /
               printFont.GetHeight(ev.Graphics);
            // Iterate over the file, printing each line.
            while (count < linesPerPage &&
               ((line = streamToPrint.ReadLine()) != null))
            {
                yPos = topMargin + (count * printFont.GetHeight(ev.Graphics));
                ev.Graphics.DrawString(line, printFont, Brushes.Black,
                   leftMargin, yPos, new StringFormat());
                count++;
            }
            // If more lines exist, print another page.
            if (line != null)
                ev.HasMorePages = true;
            else
                ev.HasMorePages = false;
        }

        //Проверка правильности значений на ввод в графу получено 
        private void textBoxPolucheno_TextChanged(object sender, EventArgs e)
        {
            if (textBoxPolucheno.Text.StartsWith("-") == true || textBoxPolucheno.Text.StartsWith("0") == true)
            {
                MessageBox.Show("Ошибка ввода.", "Ошибка ввода данных", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxPolucheno.Text = "";
            }

        }
        // Запись в базу данных значений произведенной операции Покупки 
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxPolucheno.Text == "" || comboBox1.Text == "" || textBoxSumma_Obmena.Text == "")
                {
                    MessageBox.Show("Не все поля заполнены или не выбрана валюта обмена.\nПопробуйте еще раз.", "Ошибка ввода данных", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    obmen_ValutTableAdapter.InsertQueryObmen_Valut(Convert.ToSingle(textBoxPolucheno.Text),"RUB" , SelectKursBuy(), Convert.ToSingle(DoChangeBuy(textBoxSumma_Obmena.Text)), Convert.ToSingle(labelITOGO.Text), DateTime.Now.Date, toolStripStatusLabel1.Text,comboBox1.Text);
                    if (MessageBox.Show("Данные занесены в базу данных.\nХотите распечатать чек?", "База данных", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        PrintCheckBuy();
                    }
                    textBoxPolucheno.Text = "";
                    textBoxSumma_Obmena.Text = "";
                    labelITOGO.Text = "";
                    labelSdacha_po.Text = "";
                    comboBox1.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Расчет суммы 
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBoxPolucheno.Text == "" || textBoxSumma_Obmena.Text == "" || comboBox1.Text == "")
            {
                MessageBox.Show("Не все поля заполнены или не выбрана валюта обмена.\nПопробуйте еще раз.", "Ошибка ввода данных", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {// Проверка на ввод суммы обмена ( полученная сумма > суммы обмена ) 
                if (Convert.ToDouble(textBoxPolucheno.Text) >= Convert.ToDouble(textBoxSumma_Obmena.Text))
                {
                    double sdacha = 0;
                    sdacha = Convert.ToDouble(textBoxPolucheno.Text) - Convert.ToDouble(textBoxSumma_Obmena.Text);
                    labelITOGO.Text = DoChangeBuy(textBoxSumma_Obmena.Text).ToString();
                    labelSdacha_po.Text = sdacha.ToString() + " " + comboBox1.Text;
                }
                else
                {
                    MessageBox.Show("Не верный ввод данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        // Расчет про операции Продажа 
        private void button3_Click(object sender, EventArgs e)
        {
            if (textBoxSum.Text == "" || textBoxPolucheno_p.Text == "" || comboBox2.Text == "")
            {
                MessageBox.Show("Не все поля заполнены или не выбрана валюта обмена.\nПопробуйте еще раз.", "Ошибка ввода данных", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                double sum = DoChangeSell(textBoxSum.Text);

                if (Convert.ToDouble(textBoxPolucheno_p.Text) >= sum)
                {
                    float c = (float)(Convert.ToDouble(textBoxPolucheno_p.Text) - sum);
                    labelSdacha.Text = c.ToString() + " руб. RUB";
                }
                else
                {
                    MessageBox.Show("Полученой суммы не достаточно.", "Ошибка ввода данных", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        // Проверка на ввод даных в графу Сумма
        private void textBoxSum_TextChanged(object sender, EventArgs e)
        {
            if (textBoxSum.Text.StartsWith("-") == true || textBoxSum.Text.StartsWith("0") == true)
            {
                MessageBox.Show("Ошибка ввода.", "Ошибка ввода данных", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxSum.Text = "";
            }
            else
            {
                if (textBoxSum.Text != "" && comboBox2.Text != "")
                {
                    labelStoimost.Text = DoChangeSell(textBoxSum.Text).ToString();
                }
            }
        }

        // Если получена сумма денег для произведения операции покупки валюты  
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (textBoxSum.Text != "")
            {
                labelStoimost.Text = DoChangeSell(textBoxSum.Text).ToString();
            }
        }

        // Проверка на ввод даных в графу получено денег в продаже 
        private void textBoxPolucheno_p_TextChanged(object sender, EventArgs e)
        {
            if (textBoxPolucheno_p.Text.StartsWith("-") == true || textBoxPolucheno_p.Text.StartsWith("0") == true)
            {
                MessageBox.Show("Ошибка ввода.", "Ошибка ввода данных", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxPolucheno_p.Text = "";
            }
        }

        // Проверка на ввод даных в графу Сумма обмена в продаже 
        private void textBoxSumma_Obmena_TextChanged(object sender, EventArgs e)
        {
            if (textBoxSumma_Obmena.Text.StartsWith("-") == true || textBoxSumma_Obmena.Text.StartsWith("0") == true)
            {
                MessageBox.Show("Ошибка ввода.", "Ошибка ввода данных", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxSumma_Obmena.Text = "";
            }
        }

        // Произвести обмен и запись в базу данных Продажа
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxSum.Text == "" || comboBox2.Text == "" || textBoxSum.Text == "")
                {
                    MessageBox.Show("Не все поля заполнены или не выбрана валюта обмена.\nПопробуйте еще раз.", "Ошибка ввода данных", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    obmen_ValutTableAdapter.InsertQueryObmen_Valut(Convert.ToSingle(textBoxPolucheno_p.Text), comboBox2.Text, SelectKursSell(), Convert.ToSingle(textBoxSum.Text), Convert.ToSingle(DoChangeSell(textBoxSum.Text)), DateTime.Now.Date, toolStripStatusLabel1.Text, "RUB");
                    if (MessageBox.Show("Данные занесены в базу данных.\nХотите распечатать чек?", "База данных", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        PrintCheckSell(); // Распечатать чек 
                    }
                    textBoxSum.Text = "";
                    textBoxPolucheno_p.Text = "";
                    labelStoimost.Text = "";
                    labelSdacha.Text = "";
                    comboBox2.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Обновить таблицу обмена валют
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                obmen_ValutTableAdapter.Fill(exchange_kursDataSet.Obmen_Valut);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Выборка данных об обмене валют  за день 
        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                obmen_ValutTableAdapter.FillByDate(exchange_kursDataSet.Obmen_Valut, DateTime.Now.Date);
                double sumpribl = 0;
                double pribl = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (dataGridView1.Rows[i].Cells[1].Value.ToString() == "RUB")
                    {

                        switch (dataGridView1.Rows[i].Cells[5].Value.ToString())
                        {
                            case "USD":
                                pribl = Math.Abs(Convert.ToDouble(prodagaTableAdapter.ScalarQueryUSDProdaga()) - Convert.ToDouble(pokupkaTableAdapter.ScalarQueryUSDPokupka()));
                                break;
                            case "EUR":
                                pribl = Math.Abs(Convert.ToDouble(prodagaTableAdapter.ScalarQueryEURProdaga()) - Convert.ToDouble(pokupkaTableAdapter.ScalarQueryEURPokupka()));
                                break;
                            case "GBR":
                                pribl = Math.Abs(Convert.ToDouble(prodagaTableAdapter.ScalarQueryGBRProdaga()) - Convert.ToDouble(pokupkaTableAdapter.ScalarQueryGBRPokupka()));
                                break;
                            case "CNY":
                                pribl = Math.Abs(Convert.ToDouble(prodagaTableAdapter.ScalarQueryCNYProdaga()) - Convert.ToDouble(pokupkaTableAdapter.ScalarQueryCNYPokupka()));
                                break;
                            case "RUB":
                                pribl = Math.Abs(Convert.ToDouble(prodagaTableAdapter.ScalarQueryRUBProdaga()) - Convert.ToDouble(pokupkaTableAdapter.ScalarQueryRUBPokupka()));
                                break;
                        }

                        sumpribl += pribl * Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value);
                    }
                    else
                    {

                        switch (dataGridView1.Rows[i].Cells[1].Value.ToString())
                        {
                            case "USD":
                                pribl = Math.Abs(Convert.ToDouble(prodagaTableAdapter.ScalarQueryUSDProdaga()) - Convert.ToDouble(pokupkaTableAdapter.ScalarQueryUSDPokupka()));
                                break;
                            case "EUR":
                                pribl = Math.Abs(Convert.ToDouble(prodagaTableAdapter.ScalarQueryEURProdaga()) - Convert.ToDouble(pokupkaTableAdapter.ScalarQueryEURPokupka()));
                                break;
                            case "GBR":
                                pribl = Math.Abs(Convert.ToDouble(prodagaTableAdapter.ScalarQueryGBRProdaga()) - Convert.ToDouble(pokupkaTableAdapter.ScalarQueryGBRPokupka()));
                                break;
                            case "CNY":
                                pribl = Math.Abs(Convert.ToDouble(prodagaTableAdapter.ScalarQueryCNYProdaga()) - Convert.ToDouble(pokupkaTableAdapter.ScalarQueryCNYPokupka()));
                                break;
                            case "RUB":
                                pribl = Math.Abs(Convert.ToDouble(prodagaTableAdapter.ScalarQueryRUBProdaga()) - Convert.ToDouble(pokupkaTableAdapter.ScalarQueryRUBPokupka()));
                                break;
                        }

                        sumpribl += pribl * Convert.ToDouble(dataGridView1.Rows[i].Cells[0].Value);
                    }
                }
                labelpribl.Text = "Прибыль за день: " + Convert.ToInt32(sumpribl).ToString() + " руб.";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Обновление базы данных при переходе из вклодок
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                obmen_ValutTableAdapter.Fill(exchange_kursDataSet.Obmen_Valut);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // вызов формы добавления кассира 
        private void операторыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Operator s = new Operator();
            s.ShowDialog();

        }

        // вызов формы изменение валют покупки
        private void покупкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pokupkaTableAdapter.ScalarQueryDateChange() != DateTime.Now.Date)
            {
                ChangeBuy ChB = new ChangeBuy();
                ChB.ShowDialog();
                UpdateBuyLabels();
            }
            else
            {
                MessageBox.Show("Невозможно изменить данные.\nСегодня уже была произведена установка курса валют покупки.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // вызов формы изменение валют продажи
        private void продажаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (prodagaTableAdapter.ScalarQueryDateChange() != DateTime.Now.Date)
            {

                ChangeSell ChS = new ChangeSell();
                ChS.ShowDialog();
                UpdateSellLabels();
            }
            else
            {
                MessageBox.Show("Невозможно изменить данные.\nСегодня уже была произведена установка курса валют продажи.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        //private void операторыToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    if (toolStripStatusLabel1.Text.Trim() == "Администратор")
        //    {
        //        Operator s = new Operator();
        //        s.ShowDialog();
        //    }
        //    else MessageBox.Show("Только администратор имеет право добавлять сотрудников", "Запрещено", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //}

        private void button7_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(TRPO_lab10.Properties.Settings.Default.exchange_kursConnectionString);
            if (conn.State != ConnectionState.Open)
                conn.Open();
            string SQL = "Select * from Obmen_Valut WHERE (Data >= @date1) AND (Data <= @date2) ";
            StreamWriter sw = new StreamWriter("Inf.html");
            SqlDataReader reader = null;
            sw.WriteLine("<HTML>");
            sw.WriteLine("<HEAD>");
            sw.WriteLine("<TITLE>Отчет о совершённых операциях</TITLE>");
            sw.WriteLine("<META HTTP-EQUIV=Content-Type CONTENT=charset=UTF-8>");
            sw.WriteLine("</HEAD>");
            sw.WriteLine("<BODY>");
            //sw.WriteLine("<BR><BR><BR><BR>");
            sw.WriteLine("<TABLE width = 100% BORDER=1>");
            sw.WriteLine("<caption>Отчет о совершённых операциях с по </caption>");
            //sw.WriteLine("<BR><BR>");

            if (reader != null)
                reader = null;
            SqlCommand cmd = new SqlCommand(SQL, conn);
            SqlParameter p1 = new SqlParameter("date1", dateTimePicker1.Value.Date);
            p1.SqlDbType = SqlDbType.SmallDateTime;
            SqlParameter p2 = new SqlParameter("date2", dateTimePicker1.Value.Date);
            p1.SqlDbType = SqlDbType.SmallDateTime;
            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            try
            {//word 

                reader = cmd.ExecuteReader();
                sw.Write("<TR>");
                sw.Write("<TH bgcolor = #FFFFFF>№ Операции</TH>");
                sw.Write("<TH bgcolor = #FFFFFF align = center>Получено</TH>");
                sw.Write("<TH bgcolor = #FFFFFF align = center>Полученная валюта</TH>");
                sw.Write("<TH bgcolor = #FFFFFF align = center>Выдано</TH>");
                sw.Write("<TH bgcolor = #FFFFFF align = center>Выданная валюта</TH>");
                sw.Write("<TH bgcolor = #FFFFFF align = center>Курс</TH>");
                sw.Write("<TH bgcolor = #FFFFFF align = center>Сумма обмена</TH>");
                sw.Write("<TH bgcolor = #FFFFFF align = center>Дата</TH>");
                sw.Write("<TH bgcolor = #FFFFFF align = center>Оператор</TH>");

                sw.WriteLine("</TR>");
                sw.WriteLine("</TR>");
                while (reader.Read())
                {
                    sw.WriteLine("<TR>");
                    sw.Write("<TH>{0}\t</TH>", reader.GetInt32(0));
                    sw.Write("<TH>{0}\t</TH>", (Single)reader.GetValue(1));
                    sw.Write("<TH>{0}\t</TH>", reader.GetString(2));
                    sw.Write("<TH>{0}\t</TH>", (Single)reader.GetValue(5));
                    sw.Write("<TH>{0}\t</TH>", reader.GetString(3));
                    sw.Write("<TH>{0}\t</TH>", (Single)reader.GetValue(4));
                    sw.Write("<TH>{0}\t</TH>", (Single)reader.GetValue(6));
                    sw.Write("<TH>{0}\t</TH>", reader.GetDateTime(7).Date);
                    sw.Write("<TH>{0}\t</TH>", reader.GetString(8));

                    sw.WriteLine("</TR>");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }
            sw.WriteLine(@"</table>");
            sw.WriteLine("<br><br>");
            sw.WriteLine("<br><br>");
            sw.WriteLine("</BODY>");
            sw.WriteLine("</HTML>");
            sw.Close();
            System.Diagnostics.Process.Start("IExplore.exe", Path.GetFullPath("Inf.html"));
        }

        private void событияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Events v = new Events();
            v.ShowDialog();
        }
    }
}