namespace THA_W4_VINCENTIA_T_JADI
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
            this.comboboxplayerposition = new System.Windows.Forms.ComboBox();
            this.buttonremove = new System.Windows.Forms.Button();
            this.buttonaddplayer = new System.Windows.Forms.Button();
            this.textboxplayernumber = new System.Windows.Forms.TextBox();
            this.textboxplayername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.buttonaddteam = new System.Windows.Forms.Button();
            this.textboxteamcountry = new System.Windows.Forms.TextBox();
            this.textboxteamcity = new System.Windows.Forms.TextBox();
            this.textboxteamname = new System.Windows.Forms.TextBox();
            this.comboboxteam = new System.Windows.Forms.ComboBox();
            this.comboboxcountry = new System.Windows.Forms.ComboBox();
            this.listboxsoccer = new System.Windows.Forms.ListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboboxplayerposition
            // 
            this.comboboxplayerposition.FormattingEnabled = true;
            this.comboboxplayerposition.Items.AddRange(new object[] {
            "GK",
            "DF",
            "MF",
            "FW"});
            this.comboboxplayerposition.Location = new System.Drawing.Point(946, 211);
            this.comboboxplayerposition.Name = "comboboxplayerposition";
            this.comboboxplayerposition.Size = new System.Drawing.Size(157, 28);
            this.comboboxplayerposition.TabIndex = 51;
            // 
            // buttonremove
            // 
            this.buttonremove.Location = new System.Drawing.Point(47, 483);
            this.buttonremove.Name = "buttonremove";
            this.buttonremove.Size = new System.Drawing.Size(105, 36);
            this.buttonremove.TabIndex = 50;
            this.buttonremove.Text = "Remove";
            this.buttonremove.UseVisualStyleBackColor = true;
            this.buttonremove.Click += new System.EventHandler(this.buttonremove_Click);
            // 
            // buttonaddplayer
            // 
            this.buttonaddplayer.Location = new System.Drawing.Point(912, 273);
            this.buttonaddplayer.Name = "buttonaddplayer";
            this.buttonaddplayer.Size = new System.Drawing.Size(78, 36);
            this.buttonaddplayer.TabIndex = 49;
            this.buttonaddplayer.Text = "Add";
            this.buttonaddplayer.UseVisualStyleBackColor = true;
            this.buttonaddplayer.Click += new System.EventHandler(this.buttonaddplayer_Click);
            // 
            // textboxplayernumber
            // 
            this.textboxplayernumber.Location = new System.Drawing.Point(946, 163);
            this.textboxplayernumber.Name = "textboxplayernumber";
            this.textboxplayernumber.Size = new System.Drawing.Size(157, 26);
            this.textboxplayernumber.TabIndex = 48;
            // 
            // textboxplayername
            // 
            this.textboxplayername.Location = new System.Drawing.Point(946, 117);
            this.textboxplayername.Name = "textboxplayername";
            this.textboxplayername.Size = new System.Drawing.Size(157, 26);
            this.textboxplayername.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(796, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 46;
            this.label2.Text = "Player Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(796, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 45;
            this.label3.Text = "Player Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(796, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 20);
            this.label5.TabIndex = 44;
            this.label5.Text = "Player Position";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(887, 66);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(114, 20);
            this.label12.TabIndex = 43;
            this.label12.Text = "Adding Players";
            // 
            // buttonaddteam
            // 
            this.buttonaddteam.Location = new System.Drawing.Point(533, 273);
            this.buttonaddteam.Name = "buttonaddteam";
            this.buttonaddteam.Size = new System.Drawing.Size(78, 36);
            this.buttonaddteam.TabIndex = 42;
            this.buttonaddteam.Text = "Add";
            this.buttonaddteam.UseVisualStyleBackColor = true;
            this.buttonaddteam.Click += new System.EventHandler(this.buttonaddteam_Click);
            // 
            // textboxteamcountry
            // 
            this.textboxteamcountry.Location = new System.Drawing.Point(567, 163);
            this.textboxteamcountry.Name = "textboxteamcountry";
            this.textboxteamcountry.Size = new System.Drawing.Size(157, 26);
            this.textboxteamcountry.TabIndex = 41;
            // 
            // textboxteamcity
            // 
            this.textboxteamcity.Location = new System.Drawing.Point(567, 211);
            this.textboxteamcity.Name = "textboxteamcity";
            this.textboxteamcity.Size = new System.Drawing.Size(157, 26);
            this.textboxteamcity.TabIndex = 40;
            // 
            // textboxteamname
            // 
            this.textboxteamname.Location = new System.Drawing.Point(567, 117);
            this.textboxteamname.Name = "textboxteamname";
            this.textboxteamname.Size = new System.Drawing.Size(157, 26);
            this.textboxteamname.TabIndex = 39;
            // 
            // comboboxteam
            // 
            this.comboboxteam.FormattingEnabled = true;
            this.comboboxteam.Items.AddRange(new object[] {
            "Chelsea",
            "Liverpool",
            "PSG"});
            this.comboboxteam.Location = new System.Drawing.Point(194, 192);
            this.comboboxteam.Name = "comboboxteam";
            this.comboboxteam.Size = new System.Drawing.Size(151, 28);
            this.comboboxteam.TabIndex = 38;
            this.comboboxteam.SelectedIndexChanged += new System.EventHandler(this.comboboxteam_SelectedIndexChanged);
            // 
            // comboboxcountry
            // 
            this.comboboxcountry.FormattingEnabled = true;
            this.comboboxcountry.Items.AddRange(new object[] {
            "England",
            "France"});
            this.comboboxcountry.Location = new System.Drawing.Point(194, 140);
            this.comboboxcountry.Name = "comboboxcountry";
            this.comboboxcountry.Size = new System.Drawing.Size(151, 28);
            this.comboboxcountry.TabIndex = 37;
            this.comboboxcountry.SelectedIndexChanged += new System.EventHandler(this.comboboxcountry_SelectedIndexChanged);
            // 
            // listboxsoccer
            // 
            this.listboxsoccer.FormattingEnabled = true;
            this.listboxsoccer.ItemHeight = 20;
            this.listboxsoccer.Location = new System.Drawing.Point(47, 273);
            this.listboxsoccer.Name = "listboxsoccer";
            this.listboxsoccer.Size = new System.Drawing.Size(332, 184);
            this.listboxsoccer.TabIndex = 36;
            this.listboxsoccer.ValueMemberChanged += new System.EventHandler(this.listboxsoccer_ValueMemberChanged);
            this.listboxsoccer.SelectedValueChanged += new System.EventHandler(this.listboxsoccer_SelectedValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(44, 140);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(123, 20);
            this.label11.TabIndex = 35;
            this.label11.Text = "Choose Country";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(417, 117);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 20);
            this.label10.TabIndex = 34;
            this.label10.Text = "Team Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(44, 192);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 20);
            this.label9.TabIndex = 33;
            this.label9.Text = "Choose Team";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(417, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 20);
            this.label8.TabIndex = 32;
            this.label8.Text = "Team Country";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(417, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 20);
            this.label7.TabIndex = 31;
            this.label7.Text = "Team City";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(878, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 20);
            this.label6.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(508, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 29;
            this.label4.Text = "Adding Team";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "Soccer Team List";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 564);
            this.Controls.Add(this.comboboxplayerposition);
            this.Controls.Add(this.buttonremove);
            this.Controls.Add(this.buttonaddplayer);
            this.Controls.Add(this.textboxplayernumber);
            this.Controls.Add(this.textboxplayername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.buttonaddteam);
            this.Controls.Add(this.textboxteamcountry);
            this.Controls.Add(this.textboxteamcity);
            this.Controls.Add(this.textboxteamname);
            this.Controls.Add(this.comboboxteam);
            this.Controls.Add(this.comboboxcountry);
            this.Controls.Add(this.listboxsoccer);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboboxplayerposition;
        private System.Windows.Forms.Button buttonremove;
        private System.Windows.Forms.Button buttonaddplayer;
        private System.Windows.Forms.TextBox textboxplayernumber;
        private System.Windows.Forms.TextBox textboxplayername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button buttonaddteam;
        private System.Windows.Forms.TextBox textboxteamcountry;
        private System.Windows.Forms.TextBox textboxteamcity;
        private System.Windows.Forms.TextBox textboxteamname;
        private System.Windows.Forms.ComboBox comboboxteam;
        private System.Windows.Forms.ComboBox comboboxcountry;
        private System.Windows.Forms.ListBox listboxsoccer;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
    }
}

