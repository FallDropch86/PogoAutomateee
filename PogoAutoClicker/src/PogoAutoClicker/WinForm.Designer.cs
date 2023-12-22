namespace PogoAutoClicker
{
    partial class WinForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Close_btn = new System.Windows.Forms.Button();
            this.StartClickbtn = new System.Windows.Forms.Button();
            this.StopClickbtn = new System.Windows.Forms.Button();
            this.rgbpanel1 = new System.Windows.Forms.Panel();
            this.rgbpanel2 = new System.Windows.Forms.Panel();
            this.rgbpanel3 = new System.Windows.Forms.Panel();
            this.DelayTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rightorleftclickdropdown = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(-1, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pogo\'s AutoClicker v1.0.0";
            // 
            // Close_btn
            // 
            this.Close_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Close_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Close_btn.ForeColor = System.Drawing.Color.White;
            this.Close_btn.Location = new System.Drawing.Point(166, -1);
            this.Close_btn.Name = "Close_btn";
            this.Close_btn.Size = new System.Drawing.Size(60, 29);
            this.Close_btn.TabIndex = 2;
            this.Close_btn.Text = "Close";
            this.Close_btn.UseVisualStyleBackColor = false;
            this.Close_btn.Click += new System.EventHandler(this.Close_btn_Click);
            // 
            // StartClickbtn
            // 
            this.StartClickbtn.BackColor = System.Drawing.Color.Cyan;
            this.StartClickbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.StartClickbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartClickbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.StartClickbtn.ForeColor = System.Drawing.Color.Black;
            this.StartClickbtn.Location = new System.Drawing.Point(13, 94);
            this.StartClickbtn.Name = "StartClickbtn";
            this.StartClickbtn.Size = new System.Drawing.Size(93, 29);
            this.StartClickbtn.TabIndex = 3;
            this.StartClickbtn.Text = "Start (F6)";
            this.StartClickbtn.UseVisualStyleBackColor = false;
            this.StartClickbtn.Click += new System.EventHandler(this.StartClickbtn_Click);
            // 
            // StopClickbtn
            // 
            this.StopClickbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.StopClickbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.StopClickbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StopClickbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.StopClickbtn.ForeColor = System.Drawing.Color.Black;
            this.StopClickbtn.Location = new System.Drawing.Point(112, 94);
            this.StopClickbtn.Name = "StopClickbtn";
            this.StopClickbtn.Size = new System.Drawing.Size(93, 29);
            this.StopClickbtn.TabIndex = 4;
            this.StopClickbtn.Text = "Stop (F6)";
            this.StopClickbtn.UseVisualStyleBackColor = false;
            this.StopClickbtn.Click += new System.EventHandler(this.StopClickbtn_Click);
            // 
            // rgbpanel1
            // 
            this.rgbpanel1.BackColor = System.Drawing.Color.Red;
            this.rgbpanel1.Location = new System.Drawing.Point(2, 129);
            this.rgbpanel1.Name = "rgbpanel1";
            this.rgbpanel1.Size = new System.Drawing.Size(216, 10);
            this.rgbpanel1.TabIndex = 5;
            this.rgbpanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.rgbpanel1_MouseDown);
            this.rgbpanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.rgbpanel1_MouseMove);
            this.rgbpanel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.rgbpanel1_MouseUp);
            // 
            // rgbpanel2
            // 
            this.rgbpanel2.BackColor = System.Drawing.Color.Red;
            this.rgbpanel2.Location = new System.Drawing.Point(208, 33);
            this.rgbpanel2.Name = "rgbpanel2";
            this.rgbpanel2.Size = new System.Drawing.Size(10, 90);
            this.rgbpanel2.TabIndex = 6;
            this.rgbpanel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.rgbpanel2_MouseDown);
            this.rgbpanel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.rgbpanel2_MouseMove);
            this.rgbpanel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.rgbpanel2_MouseUp);
            // 
            // rgbpanel3
            // 
            this.rgbpanel3.BackColor = System.Drawing.Color.Red;
            this.rgbpanel3.Location = new System.Drawing.Point(2, 33);
            this.rgbpanel3.Name = "rgbpanel3";
            this.rgbpanel3.Size = new System.Drawing.Size(10, 90);
            this.rgbpanel3.TabIndex = 7;
            this.rgbpanel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.rgbpanel3_MouseDown);
            this.rgbpanel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.rgbpanel3_MouseMove);
            this.rgbpanel3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.rgbpanel3_MouseUp);
            // 
            // DelayTextBox
            // 
            this.DelayTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DelayTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DelayTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.DelayTextBox.ForeColor = System.Drawing.Color.White;
            this.DelayTextBox.Location = new System.Drawing.Point(100, 36);
            this.DelayTextBox.Name = "DelayTextBox";
            this.DelayTextBox.Size = new System.Drawing.Size(104, 16);
            this.DelayTextBox.TabIndex = 8;
            this.DelayTextBox.Text = "0";
            this.DelayTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DelayTextBox_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(18, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Delay (ms):";
            // 
            // rightorleftclickdropdown
            // 
            this.rightorleftclickdropdown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rightorleftclickdropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rightorleftclickdropdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rightorleftclickdropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.rightorleftclickdropdown.ForeColor = System.Drawing.Color.White;
            this.rightorleftclickdropdown.FormattingEnabled = true;
            this.rightorleftclickdropdown.Items.AddRange(new object[] {
            "Left Click",
            "Right Click"});
            this.rightorleftclickdropdown.Location = new System.Drawing.Point(72, 60);
            this.rightorleftclickdropdown.Name = "rightorleftclickdropdown";
            this.rightorleftclickdropdown.Size = new System.Drawing.Size(133, 25);
            this.rightorleftclickdropdown.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(18, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Button:";
            // 
            // WinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(222, 143);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rightorleftclickdropdown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DelayTextBox);
            this.Controls.Add(this.rgbpanel3);
            this.Controls.Add(this.rgbpanel2);
            this.Controls.Add(this.rgbpanel1);
            this.Controls.Add(this.StopClickbtn);
            this.Controls.Add(this.StartClickbtn);
            this.Controls.Add(this.Close_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WinForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WinForm";
            this.Load += new System.EventHandler(this.WinForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.WinForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.WinForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.WinForm_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Close_btn;
        private System.Windows.Forms.Button StartClickbtn;
        private System.Windows.Forms.Button StopClickbtn;
        private System.Windows.Forms.Panel rgbpanel1;
        private System.Windows.Forms.Panel rgbpanel2;
        private System.Windows.Forms.Panel rgbpanel3;
        private System.Windows.Forms.TextBox DelayTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox rightorleftclickdropdown;
        private System.Windows.Forms.Label label4;
    }
}