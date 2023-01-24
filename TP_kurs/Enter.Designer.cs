namespace TRPO_lab10
{
    partial class Enter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Enter));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.exchange_kursDataSet = new TRPO_lab10.exchange_kursDataSet();
            this.enterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.enterTableAdapter = new TRPO_lab10.exchange_kursDataSetTableAdapters.EnterTableAdapter();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userTableAdapter = new TRPO_lab10.exchange_kursDataSetTableAdapters.UserTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.operatorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.operatorTableAdapter1 = new TRPO_lab10.exchange_kursDataSetTableAdapters.OperatorTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.exchange_kursDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.operatorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightBlue;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(54, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите фамилию";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(36, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "Вход";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // exchange_kursDataSet
            // 
            this.exchange_kursDataSet.DataSetName = "exchange_kursDataSet";
            this.exchange_kursDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // enterBindingSource
            // 
            this.enterBindingSource.DataMember = "Enter";
            this.enterBindingSource.DataSource = this.exchange_kursDataSet;
            // 
            // enterTableAdapter
            // 
            this.enterTableAdapter.ClearBeforeFill = true;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "User";
            this.userBindingSource.DataSource = this.exchange_kursDataSet;
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.White;
            this.comboBox1.DataSource = this.operatorBindingSource;
            this.comboBox1.DisplayMember = "FAM";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.Location = new System.Drawing.Point(36, 50);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(201, 31);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.ValueMember = "ID";
            // 
            // operatorBindingSource
            // 
            this.operatorBindingSource.DataMember = "Operator";
            this.operatorBindingSource.DataSource = this.exchange_kursDataSet;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(36, 201);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(201, 39);
            this.button2.TabIndex = 4;
            this.button2.Text = "Выход";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(36, 111);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(201, 30);
            this.textBox1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightBlue;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(93, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "Пароль";
            // 
            // operatorTableAdapter1
            // 
            this.operatorTableAdapter1.ClearBeforeFill = true;
            // 
            // Enter
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(262, 233);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(280, 280);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(280, 280);
            this.Name = "Enter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вход";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Enter_FormClosed);
            this.Load += new System.EventHandler(this.Enter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.exchange_kursDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.operatorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private exchange_kursDataSet exchange_kursDataSet;
        private System.Windows.Forms.BindingSource enterBindingSource;
        private TRPO_lab10.exchange_kursDataSetTableAdapters.EnterTableAdapter enterTableAdapter;
        private System.Windows.Forms.BindingSource userBindingSource;
        private TRPO_lab10.exchange_kursDataSetTableAdapters.UserTableAdapter userTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource operatorBindingSource;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private exchange_kursDataSetTableAdapters.OperatorTableAdapter operatorTableAdapter1;
    }
}