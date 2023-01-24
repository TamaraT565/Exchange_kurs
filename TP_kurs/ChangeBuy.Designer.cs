namespace TRPO_lab10
{
    partial class ChangeBuy
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxUSD = new System.Windows.Forms.TextBox();
            this.textBoxEUR = new System.Windows.Forms.TextBox();
            this.textBoxGBR = new System.Windows.Forms.TextBox();
            this.textBoxCNY = new System.Windows.Forms.TextBox();
            this.textBoxRUB = new System.Windows.Forms.TextBox();
            this.exchange_kursDataSet = new TRPO_lab10.exchange_kursDataSet();
            this.pokupkaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pokupkaTableAdapter = new TRPO_lab10.exchange_kursDataSetTableAdapters.PokupkaTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.exchange_kursDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokupkaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(41, 241);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 26);
            this.label5.TabIndex = 14;
            this.label5.Text = "RUB";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(41, 183);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 26);
            this.label4.TabIndex = 13;
            this.label4.Text = "CNY";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(41, 130);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 26);
            this.label3.TabIndex = 12;
            this.label3.Text = "GBR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(41, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 26);
            this.label2.TabIndex = 11;
            this.label2.Text = "EUR";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(77, 309);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(271, 46);
            this.button1.TabIndex = 15;
            this.button1.Text = "Изменить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxUSD
            // 
            this.textBoxUSD.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxUSD.Location = new System.Drawing.Point(145, 20);
            this.textBoxUSD.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxUSD.Name = "textBoxUSD";
            this.textBoxUSD.Size = new System.Drawing.Size(201, 35);
            this.textBoxUSD.TabIndex = 16;
            this.textBoxUSD.TextChanged += new System.EventHandler(this.textBoxUSD_TextChanged);
            // 
            // textBoxEUR
            // 
            this.textBoxEUR.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxEUR.Location = new System.Drawing.Point(145, 73);
            this.textBoxEUR.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxEUR.Name = "textBoxEUR";
            this.textBoxEUR.Size = new System.Drawing.Size(201, 35);
            this.textBoxEUR.TabIndex = 17;
            this.textBoxEUR.TextChanged += new System.EventHandler(this.textBoxEUR_TextChanged);
            // 
            // textBoxGBR
            // 
            this.textBoxGBR.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxGBR.Location = new System.Drawing.Point(145, 127);
            this.textBoxGBR.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxGBR.Name = "textBoxGBR";
            this.textBoxGBR.Size = new System.Drawing.Size(201, 35);
            this.textBoxGBR.TabIndex = 18;
            this.textBoxGBR.TextChanged += new System.EventHandler(this.textBoxMDL_TextChanged);
            // 
            // textBoxCNY
            // 
            this.textBoxCNY.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCNY.Location = new System.Drawing.Point(145, 180);
            this.textBoxCNY.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCNY.Name = "textBoxCNY";
            this.textBoxCNY.Size = new System.Drawing.Size(201, 35);
            this.textBoxCNY.TabIndex = 19;
            this.textBoxCNY.TextChanged += new System.EventHandler(this.textBoxUAH_TextChanged);
            // 
            // textBoxRUB
            // 
            this.textBoxRUB.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxRUB.Location = new System.Drawing.Point(145, 238);
            this.textBoxRUB.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxRUB.Name = "textBoxRUB";
            this.textBoxRUB.Size = new System.Drawing.Size(201, 35);
            this.textBoxRUB.TabIndex = 20;
            this.textBoxRUB.TextChanged += new System.EventHandler(this.textBoxRUB_TextChanged);
            // 
            // exchange_kursDataSet
            // 
            this.exchange_kursDataSet.DataSetName = "exchange_kursDataSet";
            this.exchange_kursDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pokupkaBindingSource
            // 
            this.pokupkaBindingSource.DataMember = "Pokupka";
            this.pokupkaBindingSource.DataSource = this.exchange_kursDataSet;
            // 
            // pokupkaTableAdapter
            // 
            this.pokupkaTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(41, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 26);
            this.label1.TabIndex = 10;
            this.label1.Text = "USD";
            // 
            // ChangeBuy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
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
            this.Name = "ChangeBuy";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменение валют покупки";
            this.Load += new System.EventHandler(this.ChangeBuy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.exchange_kursDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokupkaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxUSD;
        private System.Windows.Forms.TextBox textBoxEUR;
        private System.Windows.Forms.TextBox textBoxGBR;
        private System.Windows.Forms.TextBox textBoxCNY;
        private System.Windows.Forms.TextBox textBoxRUB;
        private exchange_kursDataSet exchange_kursDataSet;
        private System.Windows.Forms.BindingSource pokupkaBindingSource;
        private TRPO_lab10.exchange_kursDataSetTableAdapters.PokupkaTableAdapter pokupkaTableAdapter;
        private System.Windows.Forms.Label label1;
    }
}