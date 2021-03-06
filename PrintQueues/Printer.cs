﻿using System;
using MaterialSkin.Controls;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceProcess;
using Microsoft.Management.Infrastructure;
using System.Management.Automation;
using System.Collections.ObjectModel;
using Microsoft.Win32;
using System.IO;

namespace PrintQueues
{
    class Printer
    {
        private System.Printing.PrintServer myPrintServer;
        private System.Printing.PrintQueueCollection pqc;

        public Printer()
        {
            //Attempts to connect to the printserver
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

        //ar is add/remove tab selection
        public void updatePrtList(object checkList, object textBox = null, string ar = "add")
        {
            DataGridView prtList = checkList as DataGridView;
            prtList.Rows.Clear();
            //prtList.Items.Clear();
            if (textBox != null && ar == "add") 
            {
                MaterialSingleLineTextField prtSearch = textBox as MaterialSingleLineTextField;
                foreach (System.Printing.PrintQueue pq in pqc)
                {
                    if (pq.Name.ToLower().Contains(prtSearch.Text.ToLower()) || pq.QueuePort.Name.Contains(prtSearch.Text)) //performs case insensitive search
                    {

                        prtList.Rows.Add(false, pq.Name, pq.QueuePort.Name);
                    }
                }
            }

            //For getting printers from a remote PC
            else if (textBox != null && ar == "remove")
            {
                MaterialSingleLineTextField pcName = textBox as MaterialSingleLineTextField;
                RegistryKey reg;
                RegistryKey env;
                List<string> results = new List<string>();

                try
                {
                    reg = RegistryKey.OpenRemoteBaseKey(RegistryHive.LocalMachine, pcName.Text);
                    env = reg.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Print\Connections");
                    foreach(string s in env.GetSubKeyNames())
                    {
                        RegistryKey printerKey = env.OpenSubKey(s);
                        results.Add(printerKey.GetValue("Printer") as string);
                    }
                }

                catch(Exception e)
                {
                    Console.WriteLine("error with registry");
                }

                foreach (string s in results)
                {
                    if (s!=null && s != "" && !s.Contains("name") && !s.Contains("---"))
                        prtList.Rows.Add(false, s);
                }
               
            }

            else
            {
                foreach (String s in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
                {
                    prtList.Rows.Add(false, s);
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

        public void remoteQueue(String pc, String queue, bool adding)
        {
            string qCmd;

            if (adding)
                qCmd = @"rundll32 printui.dll,PrintUIEntry /in /ga /c\\" + pc + @" /n\\GHSMSPS01\" + queue;
            else
                qCmd = @"rundll32 printui.dll,PrintUIEntry /in /gd /c\\" + pc + @" /n" + queue;
            
            Console.WriteLine(qCmd);
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

        }

        private void restartSpooler()
        {
            //Using the command prompt doesn't work well with Win7 and slower PCs. Sometimes the spooler doesn't start.
            
            ServiceController sc = new ServiceController();
            sc.ServiceName = "Spooler";

            Console.WriteLine("The {0} service status is currently set to {1}", sc.ServiceName, sc.Status.ToString());

            if (sc.Status == ServiceControllerStatus.Running)
            {
                try
                {
                    sc.Stop();
                    sc.WaitForStatus(ServiceControllerStatus.Stopped);
                    sc.Start();
                    sc.WaitForStatus(ServiceControllerStatus.Running);
                }
                catch (InvalidOperationException e)
                {
                    Console.WriteLine("Error starting", sc.ServiceName);
                    Console.WriteLine(e.Message);
                }
            }
            else
            {
                Console.WriteLine("Cannot stop service {0} because it's already inactive.", sc.ServiceName);
            }
        }
    }
}
