using CustomerCall;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppCustomerCall
{
    public partial class Form1 : Form
    {
        //List<CallPlan> tPlans = new List<CallPlan> {
        //       new CallPlanSimple(),
        //          new CallPlanFree2andMinuteAfter10(),
        //            new CallPlanTwiceCheaperFirst5Minutes(5) };
       // readonly List<CallPlan> tPlans = Data.CallPlansInit.tPans;
        public List<CallPlan> TPlans => Data.CallPlansInit.tPans;
        
        Customer CustIvan = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCust_Click(object sender, EventArgs e)
        {
            CustIvan = new Customer(txtName.Text, (double)numBalance.Value, (CallPlan)cmbPlan.SelectedItem);
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            if (CustIvan != null)
            {
                MessageBox.Show(CustIvan.ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbPlan.DataSource = TPlans;
        }
    }
}
