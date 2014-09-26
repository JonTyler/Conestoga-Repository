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
    public partial class AdvancedSearch : Form
    {
        public AdvancedSearch()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ResultsForm results = new ResultsForm();
            results.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            EditDemoForm editor = new EditDemoForm();
            editor.Show();
        }
    }
}
