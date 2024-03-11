using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
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
            SellPaper_Test3DataSet modelDB = new SellPaper_Test3DataSet();
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sellPaper_Test3DataSet.ProductSale". При необходимости она может быть перемещена или удалена.
            this.productSaleTableAdapter.Fill(this.sellPaper_Test3DataSet.ProductSale);
            var rows = dataGridView1.Rows;
            for ( int i = 0; i < rows.Count; i++)
            {
                var agentData = modelDB.Agent.SingleOrDefault(x => x.ID == int.Parse(rows[i].Cells[1].Value.ToString()));
                var productData = modelDB.Product.SingleOrDefault(x => x.ID == int.Parse(rows[i].Cells[2].Value.ToString()));
                rows[i].Cells[1].Value = agentData.Title;
                rows[i].Cells[2].Value = productData.Title;
            }
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
