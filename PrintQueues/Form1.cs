using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PrintQueues
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Printing.PrintServer myPrintServer = new System.Printing.PrintServer(@"\\ghsmsps01");
            System.Printing.PrintQueueCollection pqc = myPrintServer.GetPrintQueues();
            foreach (System.Printing.PrintQueue pq in pqc)
            {
                cmbPrinters.Items.Add(pq.Name);
            }
        }
    }
}
