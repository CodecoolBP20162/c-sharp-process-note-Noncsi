using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcessNote
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Process[] process = Process.GetProcesses();
        Dictionary<int, string> ProcessesAndComments = new Dictionary<int, string>();
        int processID;

        // Gets all the processes
        void GetProcesses()
        {
            foreach (Process p in process)
            {
                string[] attributes = { p.ProcessName, p.Id.ToString() };
                ListViewItem row = new ListViewItem(attributes);
                Table.Items.Add(row);
            }
        }

        // Table: Outputs the memory usage, start time and threads
        private void Table_Click(object sender, EventArgs e)
        {
            // check if there's unsaved comment
            if (commentBox.Text.Length != 0)
            {
                DialogResult result = MessageBox.Show("You have unsaved comments. Do you want to save it?", "Unsaved process", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    Save_Comment();
                }
            }
            processID = Convert.ToInt32(Table.SelectedItems[0].SubItems[1].Text);
            commentBox.Clear();
            {
                Process choosedProcess = Process.GetProcessById(processID);
                memoryUsage.Text = "Memory usage: " + choosedProcess.WorkingSet64.ToString("N1");

                try
                {
                    startTime.Text = "Start time: " + choosedProcess.StartTime.ToString();
                }
                catch
                {
                    startTime.Text = "Start time: Not known";
                }
                threads.Text = "Threads: " + choosedProcess.Threads.Count;

                if (ProcessesAndComments.ContainsKey(processID))
                {
                    SearchCommentByProcessID();
                }
                else
                {
                    comment.Text = "Comment: Nothing to see here.";
                }
            }
        }

        // Checkbox : To be the page always on top
        private void alwaysOnTopCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (alwaysOnTopCheckBox.Checked)
            {
                TopMost = true;
            }
            else
            {
                TopMost = false;
            }

        }

        // Saves the text in a dictionary if button pushed
        private void saveButton_Click(object sender, EventArgs e)
        {
            Save_Comment();
        }

        // Saves the text in a dictionary
        void Save_Comment()
        {
            int processID = Convert.ToInt32(Table.SelectedItems[0].SubItems[1].Text);
            try
            {
                ProcessesAndComments.Add(processID, commentBox.Text);
                SearchCommentByProcessID();
            }
            catch
            {

            }
        }

        // Searches the correct comment
        void SearchCommentByProcessID()
        {
            foreach (KeyValuePair<int, string> pair in ProcessesAndComments)
            {
                if (pair.Key == processID)
                {
                    comment.Text = "Comment: " + pair.Value;
                    commentBox.Clear();
                }
            }
        }

        // Autoresizing the Table
        private void Table_Resize(object sender, EventArgs e)
        {
            Table.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        // Loads the application
        private void Form1_Load(object sender, EventArgs e)
        {
            GetProcesses();
        }
    }
}
