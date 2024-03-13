namespace DemoExam
{
    partial class ProductSaleHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductSaleHistory));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.productSaleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sellPaper_Test3DataSet = new DemoExam.SellPaper_Test3DataSet();
            this.productSaleTableAdapter = new DemoExam.SellPaper_Test3DataSetTableAdapters.ProductSaleTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sellPaper_Test3DataSet1 = new DemoExam.SellPaper_Test3DataSet1();
            this.sellPaperTest3DataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productSaleWithNamesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productSaleWithNamesTableAdapter = new DemoExam.SellPaper_Test3DataSet1TableAdapters.ProductSaleWithNamesTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expr1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productSaleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellPaper_Test3DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellPaper_Test3DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellPaperTest3DataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productSaleWithNamesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.expr1DataGridViewTextBoxColumn,
            this.saleDateDataGridViewTextBoxColumn,
            this.productCountDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productSaleWithNamesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(14, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(393, 395);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // productSaleBindingSource
            // 
            this.productSaleBindingSource.DataMember = "ProductSale";
            this.productSaleBindingSource.DataSource = this.sellPaper_Test3DataSet;
            // 
            // sellPaper_Test3DataSet
            // 
            this.sellPaper_Test3DataSet.DataSetName = "SellPaper_Test3DataSet";
            this.sellPaper_Test3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productSaleTableAdapter
            // 
            this.productSaleTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.button1.Location = new System.Drawing.Point(12, 483);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Добавить запись";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MediumAquamarine;
            this.button2.Location = new System.Drawing.Point(216, 483);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(189, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Удалить запись";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Gabriola", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(86, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(231, 59);
            this.label11.TabIndex = 62;
            this.label11.Text = "Приятный Шелест";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(14, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 61;
            this.pictureBox1.TabStop = false;
            // 
            // sellPaper_Test3DataSet1
            // 
            this.sellPaper_Test3DataSet1.DataSetName = "SellPaper_Test3DataSet1";
            this.sellPaper_Test3DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sellPaperTest3DataSet1BindingSource
            // 
            this.sellPaperTest3DataSet1BindingSource.DataSource = this.sellPaper_Test3DataSet1;
            this.sellPaperTest3DataSet1BindingSource.Position = 0;
            // 
            // productSaleWithNamesBindingSource
            // 
            this.productSaleWithNamesBindingSource.DataMember = "ProductSaleWithNames";
            this.productSaleWithNamesBindingSource.DataSource = this.sellPaperTest3DataSet1BindingSource;
            // 
            // productSaleWithNamesTableAdapter
            // 
            this.productSaleWithNamesTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 30;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Агент";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.Width = 80;
            // 
            // expr1DataGridViewTextBoxColumn
            // 
            this.expr1DataGridViewTextBoxColumn.DataPropertyName = "Expr1";
            this.expr1DataGridViewTextBoxColumn.HeaderText = "Продукт";
            this.expr1DataGridViewTextBoxColumn.Name = "expr1DataGridViewTextBoxColumn";
            this.expr1DataGridViewTextBoxColumn.Width = 80;
            // 
            // saleDateDataGridViewTextBoxColumn
            // 
            this.saleDateDataGridViewTextBoxColumn.DataPropertyName = "SaleDate";
            this.saleDateDataGridViewTextBoxColumn.HeaderText = "Дата продажи";
            this.saleDateDataGridViewTextBoxColumn.Name = "saleDateDataGridViewTextBoxColumn";
            this.saleDateDataGridViewTextBoxColumn.Width = 80;
            // 
            // productCountDataGridViewTextBoxColumn
            // 
            this.productCountDataGridViewTextBoxColumn.DataPropertyName = "ProductCount";
            this.productCountDataGridViewTextBoxColumn.HeaderText = "Кол-во продукта";
            this.productCountDataGridViewTextBoxColumn.Name = "productCountDataGridViewTextBoxColumn";
            this.productCountDataGridViewTextBoxColumn.Width = 80;
            // 
            // ProductSaleHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 518);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ProductSaleHistory";
            this.Text = "История продаж";
            this.Load += new System.EventHandler(this.ProductSaleHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productSaleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellPaper_Test3DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellPaper_Test3DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellPaperTest3DataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productSaleWithNamesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private SellPaper_Test3DataSet sellPaper_Test3DataSet;
        private System.Windows.Forms.BindingSource productSaleBindingSource;
        private SellPaper_Test3DataSetTableAdapters.ProductSaleTableAdapter productSaleTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource sellPaperTest3DataSet1BindingSource;
        private SellPaper_Test3DataSet1 sellPaper_Test3DataSet1;
        private System.Windows.Forms.BindingSource productSaleWithNamesBindingSource;
        private SellPaper_Test3DataSet1TableAdapters.ProductSaleWithNamesTableAdapter productSaleWithNamesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productCountDataGridViewTextBoxColumn;
    }
}