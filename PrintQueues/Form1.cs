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

            //Enables/disables various objects based off of the radio button selection at startup
            buttonStatus();
            
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
                //prtList.Items.Clear();
                printer.updatePrtList(prtList, prtSearch);
                addLocalButton.Visible = true;
            }

            else if (tabControl1.SelectedTab.Text == "Remove")
            {
                printer.updatePrtList(prtList);
                addLocalButton.Visible = false;
            }

            buttonStatus();
        }

        private void localRadio_CheckedChanged(object sender, EventArgs e)
        {
            buttonStatus();
        }

        private void buttonStatus()
        {
            if (localRadio.Checked)
            {
                addLocalButton.Enabled = true;
                addRemoteButton.Enabled = false;
                pcName.Enabled = false;
            }

            else if(remoteRadio.Checked)
            {
                addLocalButton.Enabled = false;
                addRemoteButton.Enabled = true;
                pcName.Enabled = true;
            }

            if (remLocalRadio.Checked)
            {
                remButton.Enabled = true;
                remPcText.Enabled = false;
                getPrtButton.Enabled = false;
                remRemoveButton.Enabled = false;
            }

            else if (remRemoteRadio.Checked)
            {
                remButton.Enabled = false;
                remPcText.Enabled = true;
                getPrtButton.Enabled = true;
                remRemoveButton.Enabled = true;
            }

        }

        private void addRemoteButton_Click(object sender, EventArgs e)
        {
            string pc = pcName.Text;
            foreach (object o in prtList.)
            {
                String queue = o.ToString();
                //passing pc name, queue name, and add/remove printer(T/F)
                printer.remoteQueue(pc, queue, true);
            }
        }

        private void getPrtButton_Click(object sender, EventArgs e)
        {
            printer.updatePrtList(prtList, remPcText, "remove");
        }

        private void remLocalRadio_CheckedChanged(object sender, EventArgs e)
        {
            buttonStatus();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 about = new AboutBox1();
            about.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
