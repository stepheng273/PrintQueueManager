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
        private Printer printer;

        public Form1()
        {
            InitializeComponent();

            printer = new Printer();
        }

        private void listSite_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (siteList.SelectedItem.Equals("MC"))
            {

            }

        }

        private void prtSearch_TextChanged(object sender, EventArgs e)
        {
            printer.updatePrtList(prtList, prtSearch);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            foreach(object o in prtList.CheckedItems)
            {
                String queue = o.ToString();
                printer.addQueue(queue);
            }
        }

        private void remButton_Click(object sender, EventArgs e)
        {
            foreach (object o in prtList.CheckedItems)
            {
                String queue = o.ToString();
                printer.removeQueue(queue);
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine(tabControl1.SelectedTab.Name);
            if (tabControl1.SelectedTab.Text == "All")
            {
                prtList.Items.Clear();
                printer.updatePrtList(prtList, prtSearch);
            }

            else if (tabControl1.SelectedTab.Text == "Remove")
            {
                prtList.Items.Clear();
                foreach (String s in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
                {
                    prtList.Items.Add(s);
                }
            }
        }
    }
}
