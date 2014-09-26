using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CITLMockup
{
    public partial class ResultsForm : Form
    {
        
        struct LibraryItem
	{
	        public string itemName;
            public string ISBN;
            public bool isElectronic;
            public string author;
            public string publisher;
            public string publishDate;
	}

        public ResultsForm()
        {
            InitializeComponent();
        }

        private void ResultsForm_Load(object sender, EventArgs e)
        {
            LibraryItem testShow = new LibraryItem();
            string bar = "______________________________________________";

            testShow.itemName = "Harry Potter and the Balance of Earth";
            testShow.ISBN = "9-999-999-9-999";
            testShow.isElectronic = false;
            testShow.author = "Al Gore";
            testShow.publisher = "Penguin";
            testShow.publishDate = "2013";

            string result = "";
            result = result + "Name: " + testShow.itemName + "\n" + bar + "\n" + "ISBN: "+ testShow.ISBN + "\n" + "Is Electroinc? " + testShow.isElectronic.ToString() + "\n" + "Author: " + testShow.author + "\n" + "Publisher:" + testShow.publisher + "\n" + "Published On: " + testShow.publishDate + "\n" + bar;
            richTextBox1.Text = result;


            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EditDemoForm showMe = new EditDemoForm();
            showMe.Show();
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
