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

            //Tries to find the server. If it can't then it will display an error popup
            printer = new Printer();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void depVisible(bool b)
        {
            lbDepartment.Visible = b;
            depList.Visible = b;
        }

        private void printerVisible(bool b)
        {
            lbPrinter.Visible = b;
            prtList.Visible = b;
        }

        private void listSite_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (siteList.SelectedItem.Equals("MC") || siteList.SelectedItem.Equals("BB"))
            {
                depVisible(true);
            }
            else
            {
                depVisible(false);
                printerVisible(true);
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

        private void tabPage3_Click(object sender, EventArgs e)
        {
            prtList.Items.Clear();
            foreach (String s in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
            {
                prtList.Items.Add(s);
            }
        }
    }
}
