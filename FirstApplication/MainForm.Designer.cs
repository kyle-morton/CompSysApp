using Model;
using DAO;
using System.Collections.Generic;
using System;
using System.Windows.Forms;

namespace FirstApplication
{
    partial class MainForm
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

    
        private void getSelectedUser(Object o, EventArgs e)
        {
            // this.customerDropdownBox.SelectedIndex = user;
            this.selectedUser = users[this.customerDropdownBox.SelectedIndex];
            this.custNumTextBox.Text = selectedUser.getId().ToString();
            this.custNameTBox.Text = selectedUser.getName();
            this.custAddrTextBox.Text = selectedUser.getAddress();
            this.custPhoneTextBox.Text = selectedUser.getPhoneNumber();
            Console.WriteLine("Selected user: " + selectedUser);
        }


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.additionalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.custDropdownLabel = new System.Windows.Forms.Label();
            this.customerDropdownBox = new System.Windows.Forms.ComboBox();
            this.getCustomerBtn = new System.Windows.Forms.Button();
            this.custNumberLabel = new System.Windows.Forms.Label();
            this.custNameLabel = new System.Windows.Forms.Label();
            this.custNameTBox = new System.Windows.Forms.TextBox();
            this.custNumTextBox = new System.Windows.Forms.TextBox();
            this.custAddrLabel = new System.Windows.Forms.Label();
            this.custPhoneNumberLabel = new System.Windows.Forms.Label();
            this.custAddrTextBox = new System.Windows.Forms.TextBox();
            this.custPhoneTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(14, 144);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(986, 120);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.additionalToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.debugToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1015, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.exitBtn});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // exitBtn
            // 
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(103, 22);
            this.exitBtn.Text = "Exit";
            this.exitBtn.Click += new System.EventHandler(this.exit);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // additionalToolStripMenuItem
            // 
            this.additionalToolStripMenuItem.Name = "additionalToolStripMenuItem";
            this.additionalToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.additionalToolStripMenuItem.Text = "Additional";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // debugToolStripMenuItem
            // 
            this.debugToolStripMenuItem.Name = "debugToolStripMenuItem";
            this.debugToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.debugToolStripMenuItem.Text = "Debug";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // custDropdownLabel
            // 
            this.custDropdownLabel.AutoSize = true;
            this.custDropdownLabel.Font = new System.Drawing.Font("OpenSymbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custDropdownLabel.Location = new System.Drawing.Point(14, 29);
            this.custDropdownLabel.Name = "custDropdownLabel";
            this.custDropdownLabel.Size = new System.Drawing.Size(77, 19);
            this.custDropdownLabel.TabIndex = 3;
            this.custDropdownLabel.Text = "Customer";
            this.customerDropdownBox.DataSource = users;
            // 
            // customerDropdownBox
            // 
            this.customerDropdownBox.FormattingEnabled = true;
            this.customerDropdownBox.Location = new System.Drawing.Point(111, 27);
            this.customerDropdownBox.Name = "customerDropdownBox";
            this.customerDropdownBox.Size = new System.Drawing.Size(159, 21);
            this.customerDropdownBox.TabIndex = 4;
            // 
            // getCustomerBtn
            // 
            this.getCustomerBtn.Location = new System.Drawing.Point(278, 25);
            this.getCustomerBtn.Name = "getCustomerBtn";
            this.getCustomerBtn.Size = new System.Drawing.Size(103, 23);
            this.getCustomerBtn.TabIndex = 5;
            this.getCustomerBtn.Text = "Select";
            this.getCustomerBtn.UseVisualStyleBackColor = true;
            this.getCustomerBtn.Click += new System.EventHandler(this.getSelectedUser);
            // 
            // custNumberLabel
            // 
            this.custNumberLabel.AutoSize = true;
            this.custNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custNumberLabel.Location = new System.Drawing.Point(19, 68);
            this.custNumberLabel.Name = "custNumberLabel";
            this.custNumberLabel.Size = new System.Drawing.Size(106, 13);
            this.custNumberLabel.TabIndex = 6;
            this.custNumberLabel.Text = "Customer Number";
            this.custNumberLabel.Click += new System.EventHandler(this.custNumberLabel_Click);
            // 
            // custNameLabel
            // 
            this.custNameLabel.AutoSize = true;
            this.custNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custNameLabel.Location = new System.Drawing.Point(19, 93);
            this.custNameLabel.Name = "custNameLabel";
            this.custNameLabel.Size = new System.Drawing.Size(39, 13);
            this.custNameLabel.TabIndex = 7;
            this.custNameLabel.Text = "Name";
            // 
            // custNameTBox
            // 
            this.custNameTBox.Location = new System.Drawing.Point(141, 90);
            this.custNameTBox.Name = "custNameTBox";
            this.custNameTBox.ReadOnly = true;
            this.custNameTBox.Size = new System.Drawing.Size(116, 20);
            this.custNameTBox.TabIndex = 9;
            // 
            // custNumTextBox
            // 
            this.custNumTextBox.Location = new System.Drawing.Point(141, 63);
            this.custNumTextBox.Name = "custNumTextBox";
            this.custNumTextBox.ReadOnly = true;
            this.custNumTextBox.Size = new System.Drawing.Size(116, 20);
            this.custNumTextBox.TabIndex = 10;
            // 
            // custAddrLabel
            // 
            this.custAddrLabel.AutoSize = true;
            this.custAddrLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custAddrLabel.Location = new System.Drawing.Point(288, 66);
            this.custAddrLabel.Name = "custAddrLabel";
            this.custAddrLabel.Size = new System.Drawing.Size(52, 13);
            this.custAddrLabel.TabIndex = 11;
            this.custAddrLabel.Text = "Address";
            // 
            // custPhoneNumberLabel
            // 
            this.custPhoneNumberLabel.AutoSize = true;
            this.custPhoneNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custPhoneNumberLabel.Location = new System.Drawing.Point(291, 90);
            this.custPhoneNumberLabel.Name = "custPhoneNumberLabel";
            this.custPhoneNumberLabel.Size = new System.Drawing.Size(90, 13);
            this.custPhoneNumberLabel.TabIndex = 12;
            this.custPhoneNumberLabel.Text = "Phone Number";
            // 
            // custAddrTextBox
            // 
            this.custAddrTextBox.Location = new System.Drawing.Point(391, 63);
            this.custAddrTextBox.Name = "custAddrTextBox";
            this.custAddrTextBox.ReadOnly = true;
            this.custAddrTextBox.Size = new System.Drawing.Size(116, 20);
            this.custAddrTextBox.TabIndex = 13;
            // 
            // custPhoneTextBox
            // 
            this.custPhoneTextBox.Location = new System.Drawing.Point(391, 89);
            this.custPhoneTextBox.Name = "custPhoneTextBox";
            this.custPhoneTextBox.ReadOnly = true;
            this.custPhoneTextBox.Size = new System.Drawing.Size(116, 20);
            this.custPhoneTextBox.TabIndex = 14;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 391);
            this.Controls.Add(this.custPhoneTextBox);
            this.Controls.Add(this.custAddrTextBox);
            this.Controls.Add(this.custPhoneNumberLabel);
            this.Controls.Add(this.custAddrLabel);
            this.Controls.Add(this.custNumTextBox);
            this.Controls.Add(this.custNameTBox);
            this.Controls.Add(this.custNameLabel);
            this.Controls.Add(this.custNumberLabel);
            this.Controls.Add(this.getCustomerBtn);
            this.Controls.Add(this.customerDropdownBox);
            this.Controls.Add(this.custDropdownLabel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Sales Transaction History";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem additionalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem debugToolStripMenuItem;
        private System.Windows.Forms.Label custDropdownLabel;
        private System.Windows.Forms.ComboBox customerDropdownBox;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitBtn;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button getCustomerBtn;
        private System.Windows.Forms.Label custNumberLabel;
        private System.Windows.Forms.Label custNameLabel;
        private System.Windows.Forms.TextBox custNameTBox;
        private TextBox custNumTextBox;
        private Label custAddrLabel;
        private Label custPhoneNumberLabel;
        private TextBox custAddrTextBox;
        private TextBox custPhoneTextBox;
    }
}

