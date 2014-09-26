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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ResultsForm results = new ResultsForm();
            results.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdvancedSearch results = new AdvancedSearch();
            results.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            EditDemoForm editor = new EditDemoForm();
            editor.Show();
        }
    }
}
