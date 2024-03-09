using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DemoExam
{
    public partial class AddProductSale : Form
    {
        public AddProductSale ()
        {
            InitializeComponent();
        }

        private void button2_Click ( object sender, EventArgs e )
        {
            SellPaper_Test3Entities modelDB = new SellPaper_Test3Entities();

            ProductSale productSale = new ProductSale();
            productSale.AgentID = int.Parse(comboBox1.SelectedValue.ToString());
            productSale.ProductID = int.Parse(comboBox2.SelectedValue.ToString());
            productSale.SaleDate = DateTime.Parse(maskedTextBox1.Text);
            productSale.ProductCount = int.Parse(numericUpDown1.Text);

            modelDB.ProductSale.Add(productSale);
            try
            {
                modelDB.SaveChanges();
                this.productSaleTableAdapter.Fill(this.sellPaper_Test3DataSet.ProductSale);
                this.Close();
            }
            catch (Exception a)
            {
                Console.WriteLine(a);
            }
        }

        private void AddProductSale_Load ( object sender, EventArgs e )
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sellPaper_Test3DataSet.Product". При необходимости она может быть перемещена или удалена.
            this.productTableAdapter.Fill(this.sellPaper_Test3DataSet.Product);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sellPaper_Test3DataSet.ProductSale". При необходимости она может быть перемещена или удалена.
            this.productSaleTableAdapter.Fill(this.sellPaper_Test3DataSet.ProductSale);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sellPaper_Test3DataSet.Agent". При необходимости она может быть перемещена или удалена.
            this.agentTableAdapter.Fill(this.sellPaper_Test3DataSet.Agent);

        }

        private void button1_Click ( object sender, EventArgs e )
        {
            this.Close();
        }

        private void label1_Click ( object sender, EventArgs e )
        {

        }

        private void label11_Click ( object sender, EventArgs e )
        {

        }
    }
}
