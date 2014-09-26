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
    public partial class EditDemoForm : Form
    {
        public EditDemoForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           if (radioButton1.Checked == true)
           {
               ReferenceForm referral = new ReferenceForm();
               referral.Show();
           }
           else if (radioButton2.Checked == true)
           {
               AVForm referral = new AVForm();
               referral.Show();
           }
           else if (radioButton3.Checked == true)
           {
               ElectronicForm referral = new ElectronicForm();
               referral.Show();
           }
           else if (radioButton4.Checked == true)
           {
               GeneralItemForm referral = new GeneralItemForm();
               referral.Show();
           }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ResultsForm results = new ResultsForm();
            results.Show();
            this.Close();
        }
    }
}
