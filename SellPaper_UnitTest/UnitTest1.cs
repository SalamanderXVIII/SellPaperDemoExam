using DemoExam;
using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Interfaces.Streaming;
using Microsoft.Analytics.Types.Sql;
using Microsoft.Analytics.UnitTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace SellPaper_UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        public UnitTest1 ()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        private AgentList form;
        private SellPaper_Test3Entities dbContext;
        private AddAgent addForm;

        [TestInitialize]
        public void Setup()
        {
            dbContext = new SellPaper_Test3Entities();
            form = new AgentList();
            addForm = new AddAgent();
        }

        [TestMethod]
        public void button2_Click_PageChange()
        {
            form.button4_Click(null, null);
            Assert.AreEqual("1", form.currentPage.ToString());
        }

        [TestMethod]
        public void Exit_Click_ClosesForm()
        {
            addForm.button2_Click(null, null);
            Assert.IsFalse(addForm.Visible);
        }

        [TestMethod]
        public void TextBox1_TextChanged_Test()
        {
            form.textBox1.Text = "100";
            form.textBox1_TextChanged(null, null);
            Assert.AreEqual("100", form.textBox1.Text);
        }

        [TestMethod]
        public void button3_Click_PageChange()
        {
            form.button3_Click(null, null);
            Assert.AreEqual("2", form.currentPage.ToString());
        }

        [TestMethod]
        public void TestAgentRetrieval()
        {
            // Arrange
            using (SellPaper_Test3Entities db = new SellPaper_Test3Entities())
            {
                // Act
                var agents = db.Agent.ToList();

                // Assert
                Assert.IsNotNull(agents);
                Assert.IsTrue(agents.Count > 0);
            }
        }

        [TestCleanup]
        public void TearDown()
        {
            form.Dispose();
        }
    }
}
