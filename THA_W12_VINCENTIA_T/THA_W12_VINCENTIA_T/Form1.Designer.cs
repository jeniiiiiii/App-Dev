namespace THA_W12_VINCENTIA_T
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
            this.buttonupdate = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.comboboxdelete = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgv_allmanager = new System.Windows.Forms.DataGridView();
            this.dgv_manager = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.comboboxedit = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBoxteamname = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBoxnationality = new System.Windows.Forms.ComboBox();
            this.textBoxteamnum = new System.Windows.Forms.TextBox();
            this.textBoxname = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonadd = new System.Windows.Forms.Button();
            this.textBoxweight = new System.Windows.Forms.TextBox();
            this.textBoxheight = new System.Windows.Forms.TextBox();
            this.textBoxpos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_allmanager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_manager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonupdate
            // 
            this.buttonupdate.Location = new System.Drawing.Point(965, 81);
            this.buttonupdate.Name = "buttonupdate";
            this.buttonupdate.Size = new System.Drawing.Size(128, 40);
            this.buttonupdate.TabIndex = 84;
            this.buttonupdate.Text = "Update";
            this.buttonupdate.UseVisualStyleBackColor = true;
            this.buttonupdate.Click += new System.EventHandler(this.buttonupdate_Click);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(362, 514);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(163, 40);
            this.button_delete.TabIndex = 83;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(52, 524);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(99, 20);
            this.label14.TabIndex = 82;
            this.label14.Text = "Team Name:";
            // 
            // comboboxdelete
            // 
            this.comboboxdelete.FormattingEnabled = true;
            this.comboboxdelete.Location = new System.Drawing.Point(185, 522);
            this.comboboxdelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboboxdelete.Name = "comboboxdelete";
            this.comboboxdelete.Size = new System.Drawing.Size(160, 28);
            this.comboboxdelete.TabIndex = 81;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(52, 475);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(276, 20);
            this.label5.TabIndex = 80;
            this.label5.Text = "Logical delete on removing player";
            // 
            // dgv_allmanager
            // 
            this.dgv_allmanager.AllowUserToAddRows = false;
            this.dgv_allmanager.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_allmanager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_allmanager.Location = new System.Drawing.Point(626, 204);
            this.dgv_allmanager.Name = "dgv_allmanager";
            this.dgv_allmanager.ReadOnly = true;
            this.dgv_allmanager.RowHeadersVisible = false;
            this.dgv_allmanager.RowHeadersWidth = 62;
            this.dgv_allmanager.RowTemplate.Height = 28;
            this.dgv_allmanager.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_allmanager.Size = new System.Drawing.Size(482, 246);
            this.dgv_allmanager.TabIndex = 79;
            // 
            // dgv_manager
            // 
            this.dgv_manager.AllowUserToAddRows = false;
            this.dgv_manager.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_manager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_manager.ColumnHeadersVisible = false;
            this.dgv_manager.Location = new System.Drawing.Point(626, 155);
            this.dgv_manager.Name = "dgv_manager";
            this.dgv_manager.ReadOnly = true;
            this.dgv_manager.RowHeadersVisible = false;
            this.dgv_manager.RowHeadersWidth = 62;
            this.dgv_manager.RowTemplate.Height = 28;
            this.dgv_manager.Size = new System.Drawing.Size(482, 43);
            this.dgv_manager.TabIndex = 77;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(192, 78);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(333, 26);
            this.textBox1.TabIndex = 75;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(65, 81);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(27, 20);
            this.label13.TabIndex = 74;
            this.label13.Text = "Id:";
            // 
            // comboboxedit
            // 
            this.comboboxedit.FormattingEnabled = true;
            this.comboboxedit.Location = new System.Drawing.Point(749, 87);
            this.comboboxedit.Name = "comboboxedit";
            this.comboboxedit.Size = new System.Drawing.Size(188, 28);
            this.comboboxedit.TabIndex = 72;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(622, 90);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 20);
            this.label12.TabIndex = 71;
            this.label12.Text = "Team Name:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(192, 339);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(333, 26);
            this.dateTimePicker1.TabIndex = 70;
            // 
            // comboBoxteamname
            // 
            this.comboBoxteamname.FormattingEnabled = true;
            this.comboBoxteamname.Location = new System.Drawing.Point(192, 374);
            this.comboBoxteamname.Name = "comboBoxteamname";
            this.comboBoxteamname.Size = new System.Drawing.Size(333, 28);
            this.comboBoxteamname.TabIndex = 69;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(65, 382);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 20);
            this.label10.TabIndex = 68;
            this.label10.Text = "Team Name:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(65, 345);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 20);
            this.label11.TabIndex = 67;
            this.label11.Text = "Birthdate:";
            // 
            // comboBoxnationality
            // 
            this.comboBoxnationality.FormattingEnabled = true;
            this.comboBoxnationality.Location = new System.Drawing.Point(192, 187);
            this.comboBoxnationality.Name = "comboBoxnationality";
            this.comboBoxnationality.Size = new System.Drawing.Size(333, 28);
            this.comboBoxnationality.TabIndex = 66;
            // 
            // textBoxteamnum
            // 
            this.textBoxteamnum.Location = new System.Drawing.Point(192, 147);
            this.textBoxteamnum.Name = "textBoxteamnum";
            this.textBoxteamnum.Size = new System.Drawing.Size(333, 26);
            this.textBoxteamnum.TabIndex = 65;
            // 
            // textBoxname
            // 
            this.textBoxname.Location = new System.Drawing.Point(192, 110);
            this.textBoxname.Name = "textBoxname";
            this.textBoxname.Size = new System.Drawing.Size(333, 26);
            this.textBoxname.TabIndex = 64;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(65, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 20);
            this.label7.TabIndex = 63;
            this.label7.Text = "Nationality:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(65, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 20);
            this.label8.TabIndex = 62;
            this.label8.Text = "Team Number:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(65, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 20);
            this.label9.TabIndex = 61;
            this.label9.Text = "Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(622, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(197, 20);
            this.label6.TabIndex = 60;
            this.label6.Text = "Edit manager of a team";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(65, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 20);
            this.label4.TabIndex = 59;
            this.label4.Text = "Add player to a team";
            // 
            // buttonadd
            // 
            this.buttonadd.Location = new System.Drawing.Point(226, 427);
            this.buttonadd.Name = "buttonadd";
            this.buttonadd.Size = new System.Drawing.Size(147, 33);
            this.buttonadd.TabIndex = 58;
            this.buttonadd.Text = "Add ";
            this.buttonadd.UseVisualStyleBackColor = true;
            this.buttonadd.Click += new System.EventHandler(this.buttonadd_Click);
            // 
            // textBoxweight
            // 
            this.textBoxweight.Location = new System.Drawing.Point(192, 302);
            this.textBoxweight.Name = "textBoxweight";
            this.textBoxweight.Size = new System.Drawing.Size(333, 26);
            this.textBoxweight.TabIndex = 57;
            // 
            // textBoxheight
            // 
            this.textBoxheight.Location = new System.Drawing.Point(192, 265);
            this.textBoxheight.Name = "textBoxheight";
            this.textBoxheight.Size = new System.Drawing.Size(333, 26);
            this.textBoxheight.TabIndex = 56;
            // 
            // textBoxpos
            // 
            this.textBoxpos.Location = new System.Drawing.Point(192, 228);
            this.textBoxpos.Name = "textBoxpos";
            this.textBoxpos.Size = new System.Drawing.Size(333, 26);
            this.textBoxpos.TabIndex = 55;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 54;
            this.label3.Text = "Weight:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 53;
            this.label2.Text = "Height:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 52;
            this.label1.Text = "Position:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(51, 560);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1033, 178);
            this.dataGridView1.TabIndex = 85;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1200, 716);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonupdate);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.comboboxdelete);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgv_allmanager);
            this.Controls.Add(this.dgv_manager);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.comboboxedit);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBoxteamname);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.comboBoxnationality);
            this.Controls.Add(this.textBoxteamnum);
            this.Controls.Add(this.textBoxname);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonadd);
            this.Controls.Add(this.textBoxweight);
            this.Controls.Add(this.textBoxheight);
            this.Controls.Add(this.textBoxpos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_allmanager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_manager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonupdate;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox comboboxdelete;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgv_allmanager;
        private System.Windows.Forms.DataGridView dgv_manager;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboboxedit;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBoxteamname;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBoxnationality;
        private System.Windows.Forms.TextBox textBoxteamnum;
        private System.Windows.Forms.TextBox textBoxname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonadd;
        private System.Windows.Forms.TextBox textBoxweight;
        private System.Windows.Forms.TextBox textBoxheight;
        private System.Windows.Forms.TextBox textBoxpos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

