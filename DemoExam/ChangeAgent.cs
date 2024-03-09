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
    public partial class ChangeAgent : Form
    {
        public AgentItem agentItem; 

        public ChangeAgent()
        {
            InitializeComponent();
        }

        private void OnLoadChange()
        {
            using (SellPaper_Test3Entities db = new SellPaper_Test3Entities())
            {
                Agent agent = db.Agent.Find(agentItem.agentInstance);
                //var agent = db.Agent.SingleOrDefault(x => x.ID == agentItem.agentInstance);
                if (agent != null)
                {
                    textBox15.Text = agent.Title;
                    comboBox2.Text = agent.AgentType;
                    numericUpDown1.Text = agent.Priority.ToString();
                    textBox13.Text = agent.Logo;
                    textBox12.Text = agent.Address;
                    maskedTextBox2.Text = agent.INN;
                    maskedTextBox3.Text = agent.KPP;
                    textBox11.Text = agent.DirectorName;
                    maskedTextBox1.Text = agent.Phone;
                    textBox10.Text = agent.Email;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click ( object sender, EventArgs e )
        {
            this.Close();
        }

        private void ChangeAgent_Load ( object sender, EventArgs e )
        {

        }

        private void button1_Click ( object sender, EventArgs e )
        {
            using (SellPaper_Test3Entities db = new SellPaper_Test3Entities())
            {
                Agent agent = db.Agent.Find(agentItem.agentInstance);
                if (agent != null)
                {
                    agent.Title = textBox15.Text;
                    agent.AgentType = comboBox2.Text;
                    agent.Priority = int.Parse(numericUpDown1.Text);
                    agent.Logo = textBox13.Text;
                    agent.Address = textBox12.Text;
                    agent.INN = maskedTextBox2.Text;
                    agent.KPP = maskedTextBox3.Text;
                    agent.DirectorName = textBox11.Text;
                    agent.Phone = maskedTextBox1.Text;
                    agent.Email = textBox10.Text;
                    db.SaveChanges();
                }
            }
            this.Close();
        }

        private void ChangeAgent_Shown ( object sender, EventArgs e )
        {
            OnLoadChange();
        }

        private void button3_Click ( object sender, EventArgs e )
        {
            using (SellPaper_Test3Entities db = new SellPaper_Test3Entities())
            {
                db.ProductSale.RemoveRange(db.ProductSale.Where(x => x.AgentID == agentItem.agentInstance));
                db.Agent.Remove(db.Agent.Find(agentItem.agentInstance));
                db.SaveChanges();
            }
            this.Close();
        }
    }
}
