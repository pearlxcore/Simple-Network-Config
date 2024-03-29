﻿namespace IP_Config
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnActivateFTP = new System.Windows.Forms.Button();
            this.btnActivateNormal = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.profileSettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetSettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetNetworkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSaveConfig = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDNS = new System.Windows.Forms.TextBox();
            this.tbGateway = new System.Windows.Forms.TextBox();
            this.tbSubnet = new System.Windows.Forms.TextBox();
            this.tbIP = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnCloseSetting = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnActivateFTP
            // 
            this.btnActivateFTP.Location = new System.Drawing.Point(21, 33);
            this.btnActivateFTP.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnActivateFTP.Name = "btnActivateFTP";
            this.btnActivateFTP.Size = new System.Drawing.Size(450, 118);
            this.btnActivateFTP.TabIndex = 0;
            this.btnActivateFTP.Text = "Activate PS3 FTP Profile";
            this.btnActivateFTP.UseVisualStyleBackColor = true;
            this.btnActivateFTP.Click += new System.EventHandler(this.BtnActivateFTP_Click);
            // 
            // btnActivateNormal
            // 
            this.btnActivateNormal.Location = new System.Drawing.Point(21, 165);
            this.btnActivateNormal.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnActivateNormal.Name = "btnActivateNormal";
            this.btnActivateNormal.Size = new System.Drawing.Size(450, 118);
            this.btnActivateNormal.TabIndex = 1;
            this.btnActivateNormal.Text = "Activate Normal Profile";
            this.btnActivateNormal.UseVisualStyleBackColor = true;
            this.btnActivateNormal.Click += new System.EventHandler(this.BtnActivateNormal_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(492, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profileSettingToolStripMenuItem,
            this.resetSettingToolStripMenuItem,
            this.resetNetworkToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(57, 22);
            this.toolStripDropDownButton1.Text = "Setting";
            this.toolStripDropDownButton1.Click += new System.EventHandler(this.ToolStripDropDownButton1_Click);
            // 
            // profileSettingToolStripMenuItem
            // 
            this.profileSettingToolStripMenuItem.Name = "profileSettingToolStripMenuItem";
            this.profileSettingToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.profileSettingToolStripMenuItem.Text = "Profile Setting";
            this.profileSettingToolStripMenuItem.Click += new System.EventHandler(this.ProfileSettingToolStripMenuItem_Click);
            // 
            // resetSettingToolStripMenuItem
            // 
            this.resetSettingToolStripMenuItem.Name = "resetSettingToolStripMenuItem";
            this.resetSettingToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.resetSettingToolStripMenuItem.Text = "Reset setting";
            this.resetSettingToolStripMenuItem.Visible = false;
            this.resetSettingToolStripMenuItem.Click += new System.EventHandler(this.ResetSettingToolStripMenuItem_Click);
            // 
            // resetNetworkToolStripMenuItem
            // 
            this.resetNetworkToolStripMenuItem.Name = "resetNetworkToolStripMenuItem";
            this.resetNetworkToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.resetNetworkToolStripMenuItem.Text = "Reset Network";
            this.resetNetworkToolStripMenuItem.Visible = false;
            this.resetNetworkToolStripMenuItem.Click += new System.EventHandler(this.ResetNetworkToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnCloseSetting);
            this.panel1.Controls.Add(this.btnReset);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnSaveConfig);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbDNS);
            this.panel1.Controls.Add(this.tbGateway);
            this.panel1.Controls.Add(this.tbSubnet);
            this.panel1.Controls.Add(this.tbIP);
            this.panel1.Location = new System.Drawing.Point(69, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(355, 231);
            this.panel1.TabIndex = 3;
            this.panel1.Visible = false;
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(127, 198);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(99, 23);
            this.btnReset.TabIndex = 13;
            this.btnReset.Text = "Reset all ";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.Button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(126, 42);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(206, 23);
            this.comboBox1.Sorted = true;
            this.comboBox1.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Interface Name";
            // 
            // btnSaveConfig
            // 
            this.btnSaveConfig.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveConfig.Location = new System.Drawing.Point(22, 198);
            this.btnSaveConfig.Name = "btnSaveConfig";
            this.btnSaveConfig.Size = new System.Drawing.Size(99, 23);
            this.btnSaveConfig.TabIndex = 9;
            this.btnSaveConfig.Text = "Save and Close";
            this.btnSaveConfig.UseVisualStyleBackColor = true;
            this.btnSaveConfig.Click += new System.EventHandler(this.Save_and_exit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(72, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(209, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Network Profile Config";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Primary DNS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Default Gateway";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Subnet Mask";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "IP Address";
            // 
            // tbDNS
            // 
            this.tbDNS.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDNS.Location = new System.Drawing.Point(126, 166);
            this.tbDNS.Name = "tbDNS";
            this.tbDNS.Size = new System.Drawing.Size(119, 23);
            this.tbDNS.TabIndex = 3;
            this.tbDNS.TabStop = false;
            this.tbDNS.Text = "10.1.1.1";
            this.tbDNS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbGateway
            // 
            this.tbGateway.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGateway.Location = new System.Drawing.Point(126, 135);
            this.tbGateway.Name = "tbGateway";
            this.tbGateway.Size = new System.Drawing.Size(119, 23);
            this.tbGateway.TabIndex = 2;
            this.tbGateway.TabStop = false;
            this.tbGateway.Text = "10.1.1.1";
            this.tbGateway.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbSubnet
            // 
            this.tbSubnet.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSubnet.Location = new System.Drawing.Point(126, 104);
            this.tbSubnet.Name = "tbSubnet";
            this.tbSubnet.Size = new System.Drawing.Size(119, 23);
            this.tbSubnet.TabIndex = 1;
            this.tbSubnet.TabStop = false;
            this.tbSubnet.Text = "255.255.255.0";
            this.tbSubnet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbIP
            // 
            this.tbIP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIP.Location = new System.Drawing.Point(126, 73);
            this.tbIP.Name = "tbIP";
            this.tbIP.Size = new System.Drawing.Size(119, 23);
            this.tbIP.TabIndex = 0;
            this.tbIP.TabStop = false;
            this.tbIP.Text = "10.1.1.2";
            this.tbIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI Light", 8.75F);
            this.textBox1.Location = new System.Drawing.Point(54, 255);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(343, 23);
            this.textBox1.TabIndex = 4;
            this.textBox1.Visible = false;
            // 
            // btnCloseSetting
            // 
            this.btnCloseSetting.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseSetting.Location = new System.Drawing.Point(232, 198);
            this.btnCloseSetting.Name = "btnCloseSetting";
            this.btnCloseSetting.Size = new System.Drawing.Size(99, 23);
            this.btnCloseSetting.TabIndex = 14;
            this.btnCloseSetting.Text = "Close";
            this.btnCloseSetting.UseVisualStyleBackColor = true;
            this.btnCloseSetting.Click += new System.EventHandler(this.BtnCloseSetting_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 298);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnActivateNormal);
            this.Controls.Add(this.btnActivateFTP);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Network Config For PS3 FTP";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnActivateFTP;
        private System.Windows.Forms.Button btnActivateNormal;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDNS;
        private System.Windows.Forms.TextBox tbGateway;
        private System.Windows.Forms.TextBox tbSubnet;
        private System.Windows.Forms.TextBox tbIP;
        private System.Windows.Forms.Button btnSaveConfig;
        private System.Windows.Forms.ToolStripMenuItem profileSettingToolStripMenuItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripMenuItem resetSettingToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripMenuItem resetNetworkToolStripMenuItem;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCloseSetting;
    }
}

