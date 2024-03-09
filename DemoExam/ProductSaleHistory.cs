using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoExam
{
    public partial class ProductSaleHistory : Form
    {
        public ProductSaleHistory ()
        {
            InitializeComponent();
        }

        private void ProductSaleHistory_Load ( object sender, EventArgs e )
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sellPaper_Test3DataSet.ProductSale". При необходимости она может быть перемещена или удалена.
            this.productSaleTableAdapter.Fill(this.sellPaper_Test3DataSet.ProductSale);
        }

        private void dataGridView1_CellContentClick ( object sender, DataGridViewCellEventArgs e )
        {

        }

        private void button1_Click ( object sender, EventArgs e )
        {
            AddProductSale addProductSale = new AddProductSale();
            addProductSale.Show();
        }

        private void button2_Click ( object sender, EventArgs e )
        {
            SellPaper_Test3Entities modelDB = new SellPaper_Test3Entities();

            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                modelDB.ProductSale.Remove(modelDB.ProductSale.Find(item.Cells[0].Value));
                dataGridView1.Rows.RemoveAt(item.Index);
                modelDB.SaveChanges();
            }
        }
    }
}
