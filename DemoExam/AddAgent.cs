using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoExam
{
    public partial class AddAgent : Form
    {
        public AddAgent()
        {
            InitializeComponent();
        }

        private void AddAgent_Load ( object sender, EventArgs e )
        {

        }

        public void button2_Click ( object sender, EventArgs e )
        {
            this.Close();
        }

        private void button1_Click ( object sender, EventArgs e )
        {
            SellPaper_Test3Entities modelDB = new SellPaper_Test3Entities();

            Agent agent = new Agent();
            agent.Title = textBox1.Text;
            agent.AgentType = comboBox1.Text;
            agent.Priority = int.Parse(numericUpDown1.Text);
            agent.Logo = textBox3.Text;
            agent.Address = textBox4.Text;
            agent.INN = maskedTextBox2.Text;
            agent.KPP = maskedTextBox3.Text;
            agent.DirectorName = textBox7.Text;
            agent.Phone = maskedTextBox1.Text;
            agent.Email = textBox8.Text;

            modelDB.Agent.Add(agent);
            try
            {
                modelDB.SaveChanges();
                this.Close();
            }
            catch (Exception a)
            {
                Console.WriteLine(a);
            }
        }

        private void label11_Click ( object sender, EventArgs e )
        {

        }

        private void textBox1_TextChanged ( object sender, EventArgs e )
        {
        }
    }
}
