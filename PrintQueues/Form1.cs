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
            printer.updatePrtList(prtList, prtSearch);
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
                System.Console.WriteLine(queue);
                printer.removeQueue(queue);
            }
            printer.updatePrtList(prtList);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Console.WriteLine(tabControl1.SelectedTab.Name);
            if (tabControl1.SelectedTab.Text == "Add")
            {
                prtList.Items.Clear();
                printer.updatePrtList(prtList, prtSearch);
                addButton.Visible = true;
            }

            else if (tabControl1.SelectedTab.Text == "Remove")
            {
                printer.updatePrtList(prtList);
                addButton.Visible = false;
            }
        }
    }
}
