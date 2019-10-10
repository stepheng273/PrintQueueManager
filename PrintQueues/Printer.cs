using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrintQueues
{
    class Printer
    {
        private System.Printing.PrintServer myPrintServer;
        private System.Printing.PrintQueueCollection pqc;

        public Printer()
        {
            try
            {
                myPrintServer = new System.Printing.PrintServer(@"\\ghsmsps01");
            }
            catch (Exception ex)
            {
                MessageBoxButtons buttons = MessageBoxButtons.RetryCancel;
                DialogResult result;
                result = MessageBox.Show("Server not found", "Check your network connection", buttons);
                if (result == DialogResult.Cancel)
                    Environment.Exit(0);
                else
                {
                    Application.Restart();
                    Environment.Exit(0);
                }
            }
            pqc = myPrintServer.GetPrintQueues();
        }

        public void updatePrtList(object checkList, object textBox)
        {
            CheckedListBox prtList = checkList as CheckedListBox;
            TextBox prtSearch = textBox as TextBox;
            prtList.Items.Clear();
            foreach (System.Printing.PrintQueue pq in pqc)
            {
                
                if (pq.Name.ToLower().Contains(prtSearch.Text.ToLower()) || pq.QueuePort.Name.Contains(prtSearch.Text)) //performs case insensitive search
                {
                    prtList.Items.Add(pq.Name);
                }

            }
        }

        public void addQueue(String queue)
        {
            string qCmd = "rundll32 printui.dll,PrintUIEntry /ga /n\\\\GHSMSPS01\\" + queue;
            //Console.WriteLine(cmd);
            //System.Diagnostics.Process.Start("CMD.exe, cmd");
            System.Diagnostics.Process cmd = new System.Diagnostics.Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = false;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();

            cmd.StandardInput.WriteLine(qCmd);
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            cmd.WaitForExit();
            Console.WriteLine(cmd.StandardOutput.ReadToEnd());

            System.Printing.PrintQueue pq = new System.Printing.PrintQueue(myPrintServer, queue);
            System
        }

        public void removeQueue(String queue)
        {
            string qCmd = "rundll32 printui.dll,PrintUIEntry /gd /n" + queue;
            Console.WriteLine(qCmd);
            //System.Diagnostics.Process.Start("CMD.exe", cmd);
            System.Diagnostics.Process cmd = new System.Diagnostics.Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = false;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();

            cmd.StandardInput.WriteLine(qCmd);
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            cmd.WaitForExit();
            Console.WriteLine(cmd.StandardOutput.ReadToEnd());
            restartSpooler();
        }

        private void restartSpooler()
        {
            string qCmd = "start /wait sc stop spooler\nstart / wait sc start spooler";
            //System.Diagnostics.Process.Start("CMD.exe", cmd);
            System.Diagnostics.Process cmd = new System.Diagnostics.Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = false;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();

            cmd.StandardInput.WriteLine(qCmd);
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            cmd.WaitForExit();
            Console.WriteLine(cmd.StandardOutput.ReadToEnd());

        }
    }
}
