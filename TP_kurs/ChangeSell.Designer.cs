namespace TRPO_lab10
{
    partial class ChangeSell
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBoxRUB = new System.Windows.Forms.TextBox();
            this.textBoxCNY = new System.Windows.Forms.TextBox();
            this.textBoxGBR = new System.Windows.Forms.TextBox();
            this.textBoxEUR = new System.Windows.Forms.TextBox();
            this.textBoxUSD = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.exchange_kursDataSet = new TRPO_lab10.exchange_kursDataSet();
            this.prodagaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prodagaTableAdapter = new TRPO_lab10.exchange_kursDataSetTableAdapters.ProdagaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.exchange_kursDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodagaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxRUB
            // 
            this.textBoxRUB.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxRUB.Location = new System.Drawing.Point(145, 234);
            this.textBoxRUB.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxRUB.Name = "textBoxRUB";
            this.textBoxRUB.Size = new System.Drawing.Size(201, 35);
            this.textBoxRUB.TabIndex = 31;
            this.textBoxRUB.TextChanged += new System.EventHandler(this.textBoxRUB_TextChanged);
            // 
            // textBoxCNY
            // 
            this.textBoxCNY.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCNY.Location = new System.Drawing.Point(145, 176);
            this.textBoxCNY.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCNY.Name = "textBoxCNY";
            this.textBoxCNY.Size = new System.Drawing.Size(201, 35);
            this.textBoxCNY.TabIndex = 30;
            this.textBoxCNY.TextChanged += new System.EventHandler(this.textBoxCNY_TextChanged);
            // 
            // textBoxGBR
            // 
            this.textBoxGBR.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxGBR.Location = new System.Drawing.Point(145, 123);
            this.textBoxGBR.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxGBR.Name = "textBoxGBR";
            this.textBoxGBR.Size = new System.Drawing.Size(201, 35);
            this.textBoxGBR.TabIndex = 29;
            this.textBoxGBR.TextChanged += new System.EventHandler(this.textBoxGBR_TextChanged);
            // 
            // textBoxEUR
            // 
            this.textBoxEUR.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxEUR.Location = new System.Drawing.Point(145, 69);
            this.textBoxEUR.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxEUR.Name = "textBoxEUR";
            this.textBoxEUR.Size = new System.Drawing.Size(201, 35);
            this.textBoxEUR.TabIndex = 28;
            this.textBoxEUR.TextChanged += new System.EventHandler(this.textBoxEUR_TextChanged);
            // 
            // textBoxUSD
            // 
            this.textBoxUSD.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxUSD.Location = new System.Drawing.Point(145, 16);
            this.textBoxUSD.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxUSD.Name = "textBoxUSD";
            this.textBoxUSD.Size = new System.Drawing.Size(201, 35);
            this.textBoxUSD.TabIndex = 27;
            this.textBoxUSD.TextChanged += new System.EventHandler(this.textBoxUSD_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(60, 314);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(271, 46);
            this.button1.TabIndex = 26;
            this.button1.Text = "Изменить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(41, 238);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 26);
            this.label5.TabIndex = 25;
            this.label5.Text = "RUB";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(41, 180);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 26);
            this.label4.TabIndex = 24;
            this.label4.Text = "CNY";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(41, 127);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 26);
            this.label3.TabIndex = 23;
            this.label3.Text = "GBR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(41, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 26);
            this.label2.TabIndex = 22;
            this.label2.Text = "EUR";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(41, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 26);
            this.label1.TabIndex = 21;
            this.label1.Text = "USD";
            // 
            // exchange_kursDataSet
            // 
            this.exchange_kursDataSet.DataSetName = "ChangeDatabaseDataSet";
            this.exchange_kursDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prodagaBindingSource
            // 
            this.prodagaBindingSource.DataMember = "Prodaga";
            this.prodagaBindingSource.DataSource = this.exchange_kursDataSet;
            // 
            // prodagaTableAdapter
            // 
            this.prodagaTableAdapter.ClearBeforeFill = true;
            // 
            // ChangeSell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(376, 348);
            this.Controls.Add(this.textBoxRUB);
            this.Controls.Add(this.textBoxCNY);
            this.Controls.Add(this.textBoxGBR);
            this.Controls.Add(this.textBoxEUR);
            this.Controls.Add(this.textBoxUSD);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(394, 395);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(394, 395);
            this.Name = "ChangeSell";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменение валют продажи";
            this.Load += new System.EventHandler(this.ChangeSell_Load);
            ((System.ComponentModel.ISupportInitialize)(this.exchange_kursDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodagaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxRUB;
        private System.Windows.Forms.TextBox textBoxCNY;
        private System.Windows.Forms.TextBox textBoxGBR;
        private System.Windows.Forms.TextBox textBoxEUR;
        private System.Windows.Forms.TextBox textBoxUSD;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private exchange_kursDataSet exchange_kursDataSet;
        private System.Windows.Forms.BindingSource prodagaBindingSource;
        private TRPO_lab10.exchange_kursDataSetTableAdapters.ProdagaTableAdapter prodagaTableAdapter;
    }
}