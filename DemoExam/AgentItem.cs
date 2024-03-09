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
    public partial class AgentItem : UserControl
    {
        public bool itemStatus = false;
        public AgentList agentList;
        public int agentInstance;

        public AgentItem()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void AgentItem_Load(object sender, EventArgs e)
        {

        }

        public string Label1
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }
        public string Label2
        {
            get { return label2.Text; }
            set { label2.Text = value; }
        }
        public string Label3
        {
            get { return label3.Text; }
            set { label3.Text = value; }
        }
        public string Label4
        {
            get { return label4.Text; }
            set { label4.Text = value; }
        }
        public string Label5
        {
            get { return label5.Text; }
            set { label5.Text = value; }
        }
        public void AddPicture(string path)
        {
            if (path != "")
                pictureBox1.Image = Image.FromFile(Environment.CurrentDirectory + path);
        }

        private void AgentItem_Click ( object sender, EventArgs e )
        {
            if (itemStatus == false)
            {
                itemStatus = true;
                label1.ForeColor = Color.Green;
                agentList.chosenItemsCount++;
                agentList.button2.Enabled = true;
            }
            else
            {
                itemStatus = false;
                label1.ForeColor = Color.Black;
                agentList.chosenItemsCount--;
                if (agentList.chosenItemsCount == 0) agentList.button2.Enabled = false;
            }
        }

        private void AgentItem_DoubleClick ( object sender, EventArgs e )
        {
            ChangeAgent changeAgent = new ChangeAgent();
            changeAgent.agentItem = this;
            changeAgent.Show();
        }
    }
}
