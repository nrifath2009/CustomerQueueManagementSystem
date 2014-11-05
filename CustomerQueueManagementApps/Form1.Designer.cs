namespace CustomerQueueManagementApps
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
        this.groupBox1 = new System.Windows.Forms.GroupBox();
        this.enqueueButton = new System.Windows.Forms.Button();
        this.label2 = new System.Windows.Forms.Label();
        this.label1 = new System.Windows.Forms.Label();
        this.enqueueComplainTextBox = new System.Windows.Forms.TextBox();
        this.enqueueNameTextBox = new System.Windows.Forms.TextBox();
        this.groupBox2 = new System.Windows.Forms.GroupBox();
        this.dequeueButton = new System.Windows.Forms.Button();
        this.label5 = new System.Windows.Forms.Label();
        this.label4 = new System.Windows.Forms.Label();
        this.label3 = new System.Windows.Forms.Label();
        this.dequeueComplainTextBox = new System.Windows.Forms.TextBox();
        this.dequeueNameTextBox = new System.Windows.Forms.TextBox();
        this.serialNoTextBox = new System.Windows.Forms.TextBox();
        this.groupBox3 = new System.Windows.Forms.GroupBox();
        this.waitingQueueListView = new System.Windows.Forms.ListView();
        this.serialNoColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
        this.nameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
        this.complainColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
        this.groupBox1.SuspendLayout();
        this.groupBox2.SuspendLayout();
        this.groupBox3.SuspendLayout();
        this.SuspendLayout();
        // 
        // groupBox1
        // 
        this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
        this.groupBox1.Controls.Add(this.enqueueButton);
        this.groupBox1.Controls.Add(this.label2);
        this.groupBox1.Controls.Add(this.label1);
        this.groupBox1.Controls.Add(this.enqueueComplainTextBox);
        this.groupBox1.Controls.Add(this.enqueueNameTextBox);
        this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.groupBox1.Location = new System.Drawing.Point(23, 22);
        this.groupBox1.Name = "groupBox1";
        this.groupBox1.Size = new System.Drawing.Size(410, 148);
        this.groupBox1.TabIndex = 0;
        this.groupBox1.TabStop = false;
        this.groupBox1.Text = "Enqueue Customer";
        // 
        // enqueueButton
        // 
        this.enqueueButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
        this.enqueueButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.enqueueButton.Location = new System.Drawing.Point(84, 89);
        this.enqueueButton.Name = "enqueueButton";
        this.enqueueButton.Size = new System.Drawing.Size(91, 31);
        this.enqueueButton.TabIndex = 4;
        this.enqueueButton.Text = "Enqueue";
        this.enqueueButton.UseVisualStyleBackColor = false;
        this.enqueueButton.Click += new System.EventHandler(this.enqueueButton_Click);
        // 
        // label2
        // 
        this.label2.AutoSize = true;
        this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.label2.Location = new System.Drawing.Point(13, 61);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(65, 16);
        this.label2.TabIndex = 3;
        this.label2.Text = "Complain";
        this.label2.Click += new System.EventHandler(this.label2_Click);
        // 
        // label1
        // 
        this.label1.AutoSize = true;
        this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.label1.Location = new System.Drawing.Point(31, 33);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(45, 16);
        this.label1.TabIndex = 2;
        this.label1.Text = "Name";
        // 
        // enqueueComplainTextBox
        // 
        this.enqueueComplainTextBox.Location = new System.Drawing.Point(84, 61);
        this.enqueueComplainTextBox.Name = "enqueueComplainTextBox";
        this.enqueueComplainTextBox.Size = new System.Drawing.Size(310, 22);
        this.enqueueComplainTextBox.TabIndex = 1;
        // 
        // enqueueNameTextBox
        // 
        this.enqueueNameTextBox.Location = new System.Drawing.Point(84, 33);
        this.enqueueNameTextBox.Name = "enqueueNameTextBox";
        this.enqueueNameTextBox.Size = new System.Drawing.Size(165, 22);
        this.enqueueNameTextBox.TabIndex = 0;
       // this.enqueueNameTextBox.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.enqueueNameTextBox_ControlAdded);
        // 
        // groupBox2
        // 
        this.groupBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
        this.groupBox2.Controls.Add(this.dequeueButton);
        this.groupBox2.Controls.Add(this.label5);
        this.groupBox2.Controls.Add(this.label4);
        this.groupBox2.Controls.Add(this.label3);
        this.groupBox2.Controls.Add(this.dequeueComplainTextBox);
        this.groupBox2.Controls.Add(this.dequeueNameTextBox);
        this.groupBox2.Controls.Add(this.serialNoTextBox);
        this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.groupBox2.Location = new System.Drawing.Point(451, 22);
        this.groupBox2.Name = "groupBox2";
        this.groupBox2.Size = new System.Drawing.Size(440, 148);
        this.groupBox2.TabIndex = 1;
        this.groupBox2.TabStop = false;
        this.groupBox2.Text = "Dequeue Customer";
        // 
        // dequeueButton
        // 
        this.dequeueButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
        this.dequeueButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.dequeueButton.Location = new System.Drawing.Point(285, 21);
        this.dequeueButton.Name = "dequeueButton";
        this.dequeueButton.Size = new System.Drawing.Size(126, 28);
        this.dequeueButton.TabIndex = 4;
        this.dequeueButton.Text = "Dequeue";
        this.dequeueButton.UseVisualStyleBackColor = false;
        this.dequeueButton.Click += new System.EventHandler(this.dequeueButton_Click);
        // 
        // label5
        // 
        this.label5.AutoSize = true;
        this.label5.Location = new System.Drawing.Point(13, 87);
        this.label5.Name = "label5";
        this.label5.Size = new System.Drawing.Size(65, 16);
        this.label5.TabIndex = 2;
        this.label5.Text = "Complain";
        // 
        // label4
        // 
        this.label4.AutoSize = true;
        this.label4.Location = new System.Drawing.Point(33, 59);
        this.label4.Name = "label4";
        this.label4.Size = new System.Drawing.Size(45, 16);
        this.label4.TabIndex = 2;
        this.label4.Text = "Name";
        // 
        // label3
        // 
        this.label3.AutoSize = true;
        this.label3.Location = new System.Drawing.Point(14, 30);
        this.label3.Name = "label3";
        this.label3.Size = new System.Drawing.Size(64, 16);
        this.label3.TabIndex = 2;
        this.label3.Text = "Serial No";
        // 
        // dequeueComplainTextBox
        // 
        this.dequeueComplainTextBox.Location = new System.Drawing.Point(84, 89);
        this.dequeueComplainTextBox.Name = "dequeueComplainTextBox";
        this.dequeueComplainTextBox.Size = new System.Drawing.Size(327, 22);
        this.dequeueComplainTextBox.TabIndex = 2;
        // 
        // dequeueNameTextBox
        // 
        this.dequeueNameTextBox.Location = new System.Drawing.Point(84, 59);
        this.dequeueNameTextBox.Name = "dequeueNameTextBox";
        this.dequeueNameTextBox.Size = new System.Drawing.Size(165, 22);
        this.dequeueNameTextBox.TabIndex = 1;
        // 
        // serialNoTextBox
        // 
        this.serialNoTextBox.Location = new System.Drawing.Point(84, 29);
        this.serialNoTextBox.Name = "serialNoTextBox";
        this.serialNoTextBox.Size = new System.Drawing.Size(122, 22);
        this.serialNoTextBox.TabIndex = 0;
        // 
        // groupBox3
        // 
        this.groupBox3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
        this.groupBox3.Controls.Add(this.waitingQueueListView);
        this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.groupBox3.Location = new System.Drawing.Point(23, 185);
        this.groupBox3.Name = "groupBox3";
        this.groupBox3.Size = new System.Drawing.Size(868, 221);
        this.groupBox3.TabIndex = 2;
        this.groupBox3.TabStop = false;
        this.groupBox3.Text = "Waiting Queue";
        // 
        // waitingQueueListView
        // 
        this.waitingQueueListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.waitingQueueListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.serialNoColumn,
            this.nameColumn,
            this.complainColumn});
        this.waitingQueueListView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        this.waitingQueueListView.Location = new System.Drawing.Point(19, 21);
        this.waitingQueueListView.Name = "waitingQueueListView";
        this.waitingQueueListView.Size = new System.Drawing.Size(830, 184);
        this.waitingQueueListView.TabIndex = 5;
        this.waitingQueueListView.UseCompatibleStateImageBehavior = false;
        this.waitingQueueListView.View = System.Windows.Forms.View.Details;
        this.waitingQueueListView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.waitingQueueListView_MouseClick);
        // 
        // serialNoColumn
        // 
        this.serialNoColumn.Text = "Serial No";
        this.serialNoColumn.Width = 100;
        // 
        // nameColumn
        // 
        this.nameColumn.Text = "Name";
        this.nameColumn.Width = 216;
        // 
        // complainColumn
        // 
        this.complainColumn.Text = "Complain";
        this.complainColumn.Width = 500;
        // 
        // Form1
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
        this.ClientSize = new System.Drawing.Size(913, 427);
        this.Controls.Add(this.groupBox3);
        this.Controls.Add(this.groupBox2);
        this.Controls.Add(this.groupBox1);
        this.Name = "Form1";
        this.Text = "Customer Queue Management System";
        this.groupBox1.ResumeLayout(false);
        this.groupBox1.PerformLayout();
        this.groupBox2.ResumeLayout(false);
        this.groupBox2.PerformLayout();
        this.groupBox3.ResumeLayout(false);
        this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button enqueueButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox enqueueComplainTextBox;
        private System.Windows.Forms.TextBox enqueueNameTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox dequeueComplainTextBox;
        private System.Windows.Forms.TextBox dequeueNameTextBox;
        private System.Windows.Forms.TextBox serialNoTextBox;
        private System.Windows.Forms.Button dequeueButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView waitingQueueListView;
        private System.Windows.Forms.ColumnHeader serialNoColumn;
        private System.Windows.Forms.ColumnHeader nameColumn;
        private System.Windows.Forms.ColumnHeader complainColumn;
    }
}

