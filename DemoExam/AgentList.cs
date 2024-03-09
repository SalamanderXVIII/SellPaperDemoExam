using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Metadata.Edm;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DemoExam
{
    public partial class AgentList : Form
    {
        public int AgentCount = 0;
        public int pages = 1;
        public int currentPage = 1;
        public int chosenItemsCount = 0;
        private bool CheckStatus = true;

        public AgentList()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AgentItemsCreation();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            AgentItemsCreation();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            AgentItemsCreation();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AgentItemsCreation()
        {
            string searchText = textBox1.Text.ToLower();

            flowLayoutPanel1.Controls.Clear();
            using (SellPaper_Test3Entities db = new SellPaper_Test3Entities())
            {
                var agents = from agent in db.Agent
                             join sale in db.ProductSale on agent.ID equals sale.AgentID
                             join product in db.Product on sale.ProductID equals product.ID
                             select new
                             {
                                 agent.ID,
                                 Name = agent.Title,
                                 AgentEmail = agent.Email,
                                 Cost = sale.ProductCount * product.MinCostForAgent,
                                 Number = agent.Phone,
                                 TypeAgent = agent.AgentType,
                                 Agent = agent.Title,
                                 AgentPriority = agent.Priority,
                                 Picture = agent.Logo
                             };

                var list = agents.ToList();

                switch (comboBox2.SelectedIndex)
                {
                    default:
                        list = agents.Where(p =>
                        p.TypeAgent.StartsWith(comboBox2.SelectedItem.ToString()) &&
                        ( p.AgentEmail.StartsWith(searchText) ||
                        p.Agent.StartsWith(searchText) ||
                        p.Number.StartsWith(searchText) )).ToList();
                        break;

                    case 0:
                        list = agents.Where(p =>
                        p.AgentEmail.StartsWith(searchText) ||
                        p.TypeAgent.StartsWith(searchText) ||
                        p.Agent.StartsWith(searchText) ||
                        p.Number.StartsWith(searchText)).ToList();
                        break;

                    case -1:
                        list = agents.Where(p =>
                        p.AgentEmail.StartsWith(searchText) ||
                        p.TypeAgent.StartsWith(searchText) ||
                        p.Agent.StartsWith(searchText) ||
                        p.Number.StartsWith(searchText)).ToList();
                        break;
                }

                if (radioButton2.Checked)
                {
                    switch (comboBox1.SelectedIndex)
                    {
                        case 0:
                            list = list.OrderByDescending(agent => agent.Name).ToList();
                            break;
                        case 1:
                            list = list.OrderByDescending(agent => agent.AgentPriority).ToList();
                            break;
                        case 2:
                            list = list.OrderByDescending(agent => agent.Cost).ToList();
                            break;
                        default:
                            list = list.OrderByDescending(agent => agent.ID).ToList();
                            break;
                    }
                }

                else
                {
                    switch (comboBox1.SelectedIndex)
                    {
                        case 0:
                            list = list.OrderBy(agent => agent.Name).ToList();
                            break;
                        case 1:
                            list = list.OrderBy(agent => agent.AgentPriority).ToList();
                            break;
                        case 2:
                            list = list.OrderBy(agent => agent.Cost).ToList();
                            break;
                        default:
                            list = list.OrderBy(agent => agent.ID).ToList();
                            break;
                    }
                }

                if (list.Count() > 3)
                    pages = list.Count() / 3 + 1;
                else pages = 1;
                if (currentPage > pages)
                {
                    currentPage = 1;
                    AgentCount = 0;
                }

                for (int i = AgentCount; i < Math.Min(AgentCount + 3, list.Count); i++)
                {
                    int disc = 0;
                    if (list[i].Cost <= 10000) disc = 0;
                    else if (list[i].Cost > 10000 && list[i].Cost <= 50000) disc = 5;
                    else if (list[i].Cost > 50000 && list[i].Cost <= 150000) disc = 10;
                    else if (list[i].Cost > 150000 && list[i].Cost <= 500000) disc = 20;
                    else disc = 25;

                    AgentItem userAgent = new AgentItem()
                    {
                        Label1 = list[i].TypeAgent + " | " + list[i].Agent,
                        Label2 = list[i].Cost + " сумма продаж за год",
                        Label3 = list[i].Number,
                        Label4 = "Приоритет: " + list[i].AgentPriority.ToString(),
                        Label5 = disc.ToString() + "%"
                    };
                    userAgent.agentInstance = list[i].ID;
                    userAgent.agentList = this;
                    userAgent.AddPicture(list[i].Picture);
                    flowLayoutPanel1.Controls.Add(userAgent);
                }

                label1.Text = currentPage +  " из " + pages;
            }
        }

        private void comboBox2_SelectedIndexChanged ( object sender, EventArgs e )
        {
            AgentItemsCreation();
        }

        private void radioButton2_CheckedChanged ( object sender, EventArgs e )
        {
            AgentItemsCreation();
        }

        private void radioButton1_CheckedChanged ( object sender, EventArgs e )
        {
            AgentItemsCreation();
        }

        private void button3_Click ( object sender, EventArgs e )
        {
            if (currentPage != pages)
            {
                AgentCount += 3;
                currentPage++;
                label1.Text = currentPage + " из " + pages;
                AgentItemsCreation();
            }
        }

        private void button4_Click ( object sender, EventArgs e )
        {
            if (AgentCount != 0)
            {
                AgentCount -= 3;
                currentPage--;
                label1.Text = currentPage + " из " + pages;
                AgentItemsCreation();
            }
        }

        private void button1_Click ( object sender, EventArgs e )
        {
            AddAgent addAgent = new AddAgent();
            addAgent.Show();
        }

        private void button2_Click ( object sender, EventArgs e )
        {
            ChangeAgentsPriority changeAgentsPriority = new ChangeAgentsPriority();
            changeAgentsPriority.Show();
        }

        private void label2_Click ( object sender, EventArgs e )
        {

        }

        private void button5_Click ( object sender, EventArgs e )
        {
            ProductSaleHistory productSaleHistory = new ProductSaleHistory();
            productSaleHistory.Show();
        }
    }
}
