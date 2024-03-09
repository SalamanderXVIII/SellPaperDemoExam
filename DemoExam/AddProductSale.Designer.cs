namespace DemoExam
{
    partial class AddProductSale
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose ( bool disposing )
        {
            if (disposing && ( components != null ))
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
        private void InitializeComponent ()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProductSale));
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.agentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sellPaper_Test3DataSet = new DemoExam.SellPaper_Test3DataSet();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agentTableAdapter = new DemoExam.SellPaper_Test3DataSetTableAdapters.AgentTableAdapter();
            this.productSaleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productSaleTableAdapter = new DemoExam.SellPaper_Test3DataSetTableAdapters.ProductSaleTableAdapter();
            this.productTableAdapter = new DemoExam.SellPaper_Test3DataSetTableAdapters.ProductTableAdapter();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellPaper_Test3DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productSaleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Gabriola", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(50, 2);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(157, 40);
            this.label11.TabIndex = 62;
            this.label11.Text = "Приятный Шелест";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 61;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 63;
            this.label1.Text = "Агент";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 64;
            this.label2.Text = "Продукт";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 65;
            this.label3.Text = "Дата продажи";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 66;
            this.label4.Text = "Кол-во продаж";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(97, 105);
            this.maskedTextBox1.Mask = "00.00.00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 70;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.button1.Location = new System.Drawing.Point(15, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 23);
            this.button1.TabIndex = 71;
            this.button1.Text = "Отмена";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MediumAquamarine;
            this.button2.Location = new System.Drawing.Point(97, 158);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 72;
            this.button2.Text = "Потдвердить";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.agentBindingSource, "ID", true));
            this.comboBox1.DataSource = this.agentBindingSource;
            this.comboBox1.DisplayMember = "Title";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(97, 51);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 73;
            this.comboBox1.ValueMember = "ID";
            // 
            // agentBindingSource
            // 
            this.agentBindingSource.DataMember = "Agent";
            this.agentBindingSource.DataSource = this.sellPaper_Test3DataSet;
            // 
            // sellPaper_Test3DataSet
            // 
            this.sellPaper_Test3DataSet.DataSetName = "SellPaper_Test3DataSet";
            this.sellPaper_Test3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productBindingSource, "ID", true));
            this.comboBox2.DataSource = this.productBindingSource;
            this.comboBox2.DisplayMember = "Title";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(97, 78);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(100, 21);
            this.comboBox2.TabIndex = 74;
            this.comboBox2.ValueMember = "ID";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.sellPaper_Test3DataSet;
            // 
            // agentTableAdapter
            // 
            this.agentTableAdapter.ClearBeforeFill = true;
            // 
            // productSaleBindingSource
            // 
            this.productSaleBindingSource.DataMember = "ProductSale";
            this.productSaleBindingSource.DataSource = this.sellPaper_Test3DataSet;
            // 
            // productSaleTableAdapter
            // 
            this.productSaleTableAdapter.ClearBeforeFill = true;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(97, 131);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(100, 20);
            this.numericUpDown1.TabIndex = 75;
            // 
            // AddProductSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(209, 194);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AddProductSale";
            this.Text = "Добавить продажу";
            this.Load += new System.EventHandler(this.AddProductSale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellPaper_Test3DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productSaleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private SellPaper_Test3DataSet sellPaper_Test3DataSet;
        private System.Windows.Forms.BindingSource agentBindingSource;
        private SellPaper_Test3DataSetTableAdapters.AgentTableAdapter agentTableAdapter;
        private System.Windows.Forms.BindingSource productSaleBindingSource;
        private SellPaper_Test3DataSetTableAdapters.ProductSaleTableAdapter productSaleTableAdapter;
        private System.Windows.Forms.BindingSource productBindingSource;
        private SellPaper_Test3DataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}