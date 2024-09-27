namespace TODO_List
{
    partial class ToDoList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            groupBox3 = new GroupBox();
            DGDone = new DataGridView();
            groupBox2 = new GroupBox();
            DGPending = new DataGridView();
            groupBox1 = new GroupBox();
            AddTaskBtn = new Button();
            label2 = new Label();
            Timee = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGDone).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGPending).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox3);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(909, 522);
            panel1.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(DGDone);
            groupBox3.Location = new Point(474, 206);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(423, 304);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Done Task";
            // 
            // DGDone
            // 
            DGDone.AllowUserToAddRows = false;
            DGDone.AllowUserToDeleteRows = false;
            DGDone.AllowUserToResizeColumns = false;
            DGDone.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            DGDone.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DGDone.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGDone.Dock = DockStyle.Fill;
            DGDone.Location = new Point(3, 19);
            DGDone.MultiSelect = false;
            DGDone.Name = "DGDone";
            DGDone.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DGDone.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DGDone.Size = new Size(417, 282);
            DGDone.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(DGPending);
            groupBox2.Location = new Point(12, 206);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(423, 304);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Pending Task";
            // 
            // DGPending
            // 
            DGPending.AllowUserToAddRows = false;
            DGPending.AllowUserToDeleteRows = false;
            DGPending.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGPending.Dock = DockStyle.Fill;
            DGPending.Location = new Point(3, 19);
            DGPending.Name = "DGPending";
            DGPending.ReadOnly = true;
            DGPending.Size = new Size(417, 282);
            DGPending.TabIndex = 0;
            DGPending.CellMouseDoubleClick += DGPending_CellMouseDoubleClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(AddTaskBtn);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(Timee);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 21);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(885, 162);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add Task";
            // 
            // AddTaskBtn
            // 
            AddTaskBtn.Location = new Point(152, 74);
            AddTaskBtn.Name = "AddTaskBtn";
            AddTaskBtn.Size = new Size(75, 23);
            AddTaskBtn.TabIndex = 5;
            AddTaskBtn.Text = "Add Task";
            AddTaskBtn.UseVisualStyleBackColor = true;
            AddTaskBtn.Click += AddTaskBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(571, 42);
            label2.Name = "label2";
            label2.Size = new Size(68, 30);
            label2.TabIndex = 4;
            label2.Text = "label2";
            // 
            // Timee
            // 
            Timee.AutoSize = true;
            Timee.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Timee.Location = new Point(696, 33);
            Timee.Name = "Timee";
            Timee.Size = new Size(68, 30);
            Timee.TabIndex = 3;
            Timee.Text = "label2";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(120, 29);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(135, 23);
            textBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 33);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 0;
            label1.Text = "Task Label:";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // ToDoList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(909, 522);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Name = "ToDoList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "To Do List";
            Load += ToDoList_Load;
            panel1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DGDone).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DGPending).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private DataGridView DGPending;
        private DataGridView DGDone;
        private Label label1;
        private TextBox textBox1;
        private System.Windows.Forms.Timer timer1;
        private Label Timee;
        private Label label2;
        private Button AddTaskBtn;
    }
}