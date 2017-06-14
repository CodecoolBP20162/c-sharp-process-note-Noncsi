namespace ProcessNote
{
    partial class Form1
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
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Table = new System.Windows.Forms.ListView();
            this.alwaysOnTopCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.commentBox = new System.Windows.Forms.RichTextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.memoryUsage = new System.Windows.Forms.Label();
            this.startTime = new System.Windows.Forms.Label();
            this.threads = new System.Windows.Forms.Label();
            this.comment = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // id
            // 
            this.id.Text = "PID";
            // 
            // name
            // 
            this.name.Text = "Process name";
            this.name.Width = 150;
            // 
            // Table
            // 
            this.Table.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.id});
            this.Table.GridLines = true;
            this.Table.Location = new System.Drawing.Point(12, 12);
            this.Table.Name = "Table";
            this.Table.Size = new System.Drawing.Size(215, 458);
            this.Table.TabIndex = 0;
            this.Table.UseCompatibleStateImageBehavior = false;
            this.Table.View = System.Windows.Forms.View.Details;
            this.Table.Click += new System.EventHandler(this.Table_Click);
            this.Table.Resize += new System.EventHandler(this.Table_Resize);
            // 
            // alwaysOnTopCheckBox
            // 
            this.alwaysOnTopCheckBox.AutoSize = true;
            this.alwaysOnTopCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.alwaysOnTopCheckBox.Location = new System.Drawing.Point(441, 453);
            this.alwaysOnTopCheckBox.Name = "alwaysOnTopCheckBox";
            this.alwaysOnTopCheckBox.Size = new System.Drawing.Size(92, 17);
            this.alwaysOnTopCheckBox.TabIndex = 1;
            this.alwaysOnTopCheckBox.Text = "Always on top";
            this.alwaysOnTopCheckBox.UseVisualStyleBackColor = true;
            this.alwaysOnTopCheckBox.CheckedChanged += new System.EventHandler(this.alwaysOnTopCheckBox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(346, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Comment";
            // 
            // commentBox
            // 
            this.commentBox.Location = new System.Drawing.Point(273, 148);
            this.commentBox.Name = "commentBox";
            this.commentBox.Size = new System.Drawing.Size(229, 87);
            this.commentBox.TabIndex = 4;
            this.commentBox.Text = "";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(349, 241);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(64, 23);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // memoryUsage
            // 
            this.memoryUsage.AutoSize = true;
            this.memoryUsage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.memoryUsage.Location = new System.Drawing.Point(270, 24);
            this.memoryUsage.Name = "memoryUsage";
            this.memoryUsage.Size = new System.Drawing.Size(105, 17);
            this.memoryUsage.TabIndex = 6;
            this.memoryUsage.Text = "Memory usage:";
            // 
            // startTime
            // 
            this.startTime.AutoSize = true;
            this.startTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.startTime.Location = new System.Drawing.Point(270, 57);
            this.startTime.Name = "startTime";
            this.startTime.Size = new System.Drawing.Size(72, 17);
            this.startTime.TabIndex = 7;
            this.startTime.Text = "Start time:";
            // 
            // threads
            // 
            this.threads.AutoSize = true;
            this.threads.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.threads.Location = new System.Drawing.Point(270, 87);
            this.threads.Name = "threads";
            this.threads.Size = new System.Drawing.Size(61, 17);
            this.threads.TabIndex = 8;
            this.threads.Text = "Threads";
            // 
            // comment
            // 
            this.comment.AutoSize = true;
            this.comment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comment.Location = new System.Drawing.Point(270, 281);
            this.comment.Name = "comment";
            this.comment.Size = new System.Drawing.Size(204, 17);
            this.comment.TabIndex = 9;
            this.comment.Text = "Comment: Nothing to see here.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(545, 483);
            this.Controls.Add(this.comment);
            this.Controls.Add(this.threads);
            this.Controls.Add(this.startTime);
            this.Controls.Add(this.memoryUsage);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.commentBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.alwaysOnTopCheckBox);
            this.Controls.Add(this.Table);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Process Note";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ListView Table;
        private System.Windows.Forms.CheckBox alwaysOnTopCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox commentBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label memoryUsage;
        private System.Windows.Forms.Label startTime;
        private System.Windows.Forms.Label threads;
        private System.Windows.Forms.Label comment;
    }
}

