using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TODO_List
{
    public partial class ToDoList : Form
    {
        float tick = 0;
        int num;
        public ToDoList()
        {
            InitializeComponent();
        }

        private void ToDoList_Load(object sender, EventArgs e)
        {
            label2.Visible = false;
            label2.Text = DateTime.Now.ToString("H mm");
            num = Convert.ToInt32(label2.Text[0]);
            Timee.Text = "--:-- --";  
            DGPending.Columns.Add("TaskName", "Task Name");
            DGPending.Columns.Add("Stat", "Status");
            DGPending.Columns["TaskName"].Width = 274;
            DGDone.Columns.Add("TaskName", "Task Name");
            DGDone.Columns.Add("TimeFinished", "Time Finished");
            DGDone.Columns.Add("Stat", "Status");
            DGDone.Columns["TaskName"].Width = 150;
            DGDone.Columns["TimeFinished"].Width = 124;
            DGPending.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            tick++;

            if (num >= 12)
            {
                if (tick % 2 == 0)
                {
                    Timee.Text = DateTime.Now.ToString("hh:mm") + " PM";
                }
                else
                {
                    Timee.Text = DateTime.Now.ToString("hh mm") + " PM";
                }
            }
            else
            {
                if (tick % 2 == 0)
                {
                    Timee.Text = DateTime.Now.ToString("hh:mm") + " AM";
                }
                else
                {
                    Timee.Text = DateTime.Now.ToString("hh mm") + " AM";
                }
            }
        }

        private void AddTaskBtn_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength > 0)
            {
                DGPending.Rows.Add(textBox1.Text, "Active");
                textBox1.Clear();
            }
            else
            {
                MessageBox.Show("Please Specify Task Name.", "Notification.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DGPending_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DialogResult D = MessageBox.Show("Do you want to mark this task as Done?", "Information!",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
            if (D == DialogResult.OK)
            {
                string taskname = DGPending.SelectedRows[0].Cells["TaskName"].Value.ToString();
                DGDone.Rows.Add(taskname, Timee.Text, "Done");
                DataGridViewSelectedRowCollection selectedrows = DGPending.SelectedRows;
                DGPending.Rows.Remove(selectedrows[0]);
            }
        }
    }
}
