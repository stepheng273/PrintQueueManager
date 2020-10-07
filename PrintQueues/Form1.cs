using System;
using MaterialSkin.Controls;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using MaterialSkin;
using System.Drawing.Text;
using System.IO;

namespace PrintQueues
{
    public partial class Form1 : MaterialForm
    {
        private Printer printer;
        PrivateFontCollection fonts = new PrivateFontCollection();
        MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;

        public Form1()
        {
            InitializeComponent();

            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            DarkMode.Checked = true;
            materialSkinManager.ColorScheme = new ColorScheme(
            Primary.Blue500, Primary.Blue700,
            Primary.Blue300, Accent.LightBlue200, TextShade.WHITE);

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
            addLocalButton.Cursor = Cursors.WaitCursor;
            bool b;
            string pc = pcName.Text;
            foreach (DataGridViewRow r in prtList.Rows)
            {
                
                try
                {
                    b = (bool)r.Cells[0].Value;
                }
                catch(NullReferenceException ex) 
                {
                    addLocalButton.Cursor = Cursors.Arrow;
                    return;
                }
                if (b == true)
                {
                    String queue = r.Cells[1].Value.ToString();
                    printer.addQueue(queue);
                }
            }
            
        }

        private void remButton_Click(object sender, EventArgs e)
        {
            remButton.Cursor = Cursors.WaitCursor;
            bool b;
            foreach (DataGridViewRow r in prtList.Rows)
            {
                try
                {
                    b = (bool)r.Cells[0].Value;
                }
                catch (NullReferenceException ex) 
                {
                    Thread.Sleep(500);
                    tabControl1_SelectedIndexChanged(sender, e);
                    remButton.Cursor = Cursors.Arrow;
                    return;
                }

                if (b == true)
                {

                    String queue = r.Cells[1].Value.ToString();
                    if (sender == remButton)
                        printer.removeQueue(queue);
                    else if(sender == remRemoveButton)
                    {
                        printer.remoteQueue(removePcName.Text, queue, false);
                    }
                }
            }
            remButton.Cursor = Cursors.Default;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (tabControl1.SelectedTab.Text == "Add")
            {
                //prtList.Items.Clear();
                printer.updatePrtList(prtList, prtSearch);
                addLocalButton.Visible = true;
            }

            else if (tabControl1.SelectedTab.Text == "Remove")
            {
                addLocalButton.Visible = false;

                //also updates the prtList
                remLocalRadio_CheckedChanged(sender, e);
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
                removePcName.Enabled = false;
                getPrtButton.Enabled = false;
                remRemoveButton.Enabled = false;
            }

            else if (remRemoteRadio.Checked)
            {
                remButton.Enabled = false;
                removePcName.Enabled = true;
                getPrtButton.Enabled = true;
                remRemoveButton.Enabled = true;
            }

        }

        private void addRemoteButton_Click(object sender, EventArgs e)
        {
            bool b;
            foreach (DataGridViewRow r in prtList.Rows)
            {
                try
                {
                    b = (bool)r.Cells[0].Value;
                }
                catch (NullReferenceException ex) { return; }

                if (b == true)
                {
                    String queue = r.Cells[1].Value.ToString();
                    printer.remoteQueue(pcName.Text, queue, adding: true);
                }
            }
        }

        private void getPrtButton_Click(object sender, EventArgs e)
        {
            printer.updatePrtList(prtList, removePcName, "remove");
        }

        private void remLocalRadio_CheckedChanged(object sender, EventArgs e)
        {
            buttonStatus();
            if (remLocalRadio.Checked)
                printer.updatePrtList(prtList, null, "remove");
            else
            
                printer.updatePrtList(prtList, removePcName, "remove");
            
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 about = new AboutBox1();
            about.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void remRemoveButton_Click(object sender, EventArgs e)
        {
            remButton_Click(sender, e);
            Thread.Sleep(500);
            getPrtButton_Click(sender, e);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void DarkMode_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as MaterialCheckBox).Checked)
                materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            else
                materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
        }
    }
}
