namespace THA_W4_VINCENTIA_T
{
    partial class Main
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
            this.buttonopen = new System.Windows.Forms.Button();
            this.labelname = new System.Windows.Forms.Label();
            this.textboxname = new System.Windows.Forms.TextBox();
            this.labelartist = new System.Windows.Forms.Label();
            this.textboxartist = new System.Windows.Forms.TextBox();
            this.checkboxtrue = new System.Windows.Forms.CheckBox();
            this.buttonsubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonopen
            // 
            this.buttonopen.Location = new System.Drawing.Point(24, 23);
            this.buttonopen.Name = "buttonopen";
            this.buttonopen.Size = new System.Drawing.Size(149, 66);
            this.buttonopen.TabIndex = 0;
            this.buttonopen.Text = "Open Next Form";
            this.buttonopen.UseVisualStyleBackColor = true;
            this.buttonopen.Click += new System.EventHandler(this.buttonopen_Click);
            // 
            // labelname
            // 
            this.labelname.AutoSize = true;
            this.labelname.Location = new System.Drawing.Point(32, 130);
            this.labelname.Name = "labelname";
            this.labelname.Size = new System.Drawing.Size(51, 20);
            this.labelname.TabIndex = 1;
            this.labelname.Text = "Name";
            // 
            // textboxname
            // 
            this.textboxname.Location = new System.Drawing.Point(200, 124);
            this.textboxname.Name = "textboxname";
            this.textboxname.Size = new System.Drawing.Size(190, 26);
            this.textboxname.TabIndex = 2;
            // 
            // labelartist
            // 
            this.labelartist.AutoSize = true;
            this.labelartist.Location = new System.Drawing.Point(32, 191);
            this.labelartist.Name = "labelartist";
            this.labelartist.Size = new System.Drawing.Size(131, 20);
            this.labelartist.TabIndex = 3;
            this.labelartist.Text = "My Favorite Artist";
            // 
            // textboxartist
            // 
            this.textboxartist.Location = new System.Drawing.Point(200, 188);
            this.textboxartist.Name = "textboxartist";
            this.textboxartist.Size = new System.Drawing.Size(190, 26);
            this.textboxartist.TabIndex = 4;
            // 
            // checkboxtrue
            // 
            this.checkboxtrue.AutoSize = true;
            this.checkboxtrue.Location = new System.Drawing.Point(46, 269);
            this.checkboxtrue.Name = "checkboxtrue";
            this.checkboxtrue.Size = new System.Drawing.Size(289, 24);
            this.checkboxtrue.TabIndex = 5;
            this.checkboxtrue.Text = "All of the content I put above is true!";
            this.checkboxtrue.UseVisualStyleBackColor = true;
            this.checkboxtrue.CheckedChanged += new System.EventHandler(this.checkboxtrue_CheckedChanged);
            // 
            // buttonsubmit
            // 
            this.buttonsubmit.Enabled = false;
            this.buttonsubmit.Location = new System.Drawing.Point(131, 336);
            this.buttonsubmit.Name = "buttonsubmit";
            this.buttonsubmit.Size = new System.Drawing.Size(149, 66);
            this.buttonsubmit.TabIndex = 6;
            this.buttonsubmit.Text = "Submit";
            this.buttonsubmit.UseVisualStyleBackColor = true;
            this.buttonsubmit.Click += new System.EventHandler(this.buttonsubmit_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonsubmit);
            this.Controls.Add(this.checkboxtrue);
            this.Controls.Add(this.textboxartist);
            this.Controls.Add(this.labelartist);
            this.Controls.Add(this.textboxname);
            this.Controls.Add(this.labelname);
            this.Controls.Add(this.buttonopen);
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonopen;
        private System.Windows.Forms.Label labelname;
        private System.Windows.Forms.TextBox textboxname;
        private System.Windows.Forms.Label labelartist;
        private System.Windows.Forms.TextBox textboxartist;
        private System.Windows.Forms.CheckBox checkboxtrue;
        private System.Windows.Forms.Button buttonsubmit;
    }
}

