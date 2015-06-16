using Model;
using FirstApplication.DAO;
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

   


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.additionalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.itemDataTable = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.itemDropDownBox = new System.Windows.Forms.ComboBox();
            this.addItemBtn = new System.Windows.Forms.Button();
            this.totalSalesPriceTextBox = new System.Windows.Forms.TextBox();
            this.totalSalesCostTextBox = new System.Windows.Forms.TextBox();
            this.totalSalesPriceLabel = new System.Windows.Forms.Label();
            this.totalSalesCostLabel = new System.Windows.Forms.Label();
            this.placeOrderButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.resetBtn = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemDataTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(827, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newMenuItem,
            this.exitBtn});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newMenuItem
            // 
            this.newMenuItem.Name = "newMenuItem";
            this.newMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newMenuItem.Text = "New";
            // 
            // exitBtn
            // 
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(152, 22);
            this.exitBtn.Text = "Exit";
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
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
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
            // itemDataTable
            // 
            this.itemDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemDataTable.Location = new System.Drawing.Point(22, 204);
            this.itemDataTable.Name = "itemDataTable";
            this.itemDataTable.Size = new System.Drawing.Size(531, 129);
            this.itemDataTable.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Line Items";
            // 
            // itemDropDownBox
            // 
            this.itemDropDownBox.FormattingEnabled = true;
            this.itemDropDownBox.Location = new System.Drawing.Point(111, 170);
            this.itemDropDownBox.Name = "itemDropDownBox";
            this.itemDropDownBox.Size = new System.Drawing.Size(212, 21);
            this.itemDropDownBox.TabIndex = 17;
            // 
            // addItemBtn
            // 
            this.addItemBtn.Location = new System.Drawing.Point(350, 167);
            this.addItemBtn.Name = "addItemBtn";
            this.addItemBtn.Size = new System.Drawing.Size(100, 23);
            this.addItemBtn.TabIndex = 18;
            this.addItemBtn.Text = "Add To Order";
            this.addItemBtn.UseVisualStyleBackColor = true;
            // 
            // totalSalesPriceTextBox
            // 
            this.totalSalesPriceTextBox.Location = new System.Drawing.Point(702, 244);
            this.totalSalesPriceTextBox.Name = "totalSalesPriceTextBox";
            this.totalSalesPriceTextBox.ReadOnly = true;
            this.totalSalesPriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.totalSalesPriceTextBox.TabIndex = 19;
            // 
            // totalSalesCostTextBox
            // 
            this.totalSalesCostTextBox.Location = new System.Drawing.Point(702, 218);
            this.totalSalesCostTextBox.Name = "totalSalesCostTextBox";
            this.totalSalesCostTextBox.ReadOnly = true;
            this.totalSalesCostTextBox.Size = new System.Drawing.Size(100, 20);
            this.totalSalesCostTextBox.TabIndex = 20;
            // 
            // totalSalesPriceLabel
            // 
            this.totalSalesPriceLabel.AutoSize = true;
            this.totalSalesPriceLabel.Location = new System.Drawing.Point(593, 247);
            this.totalSalesPriceLabel.Name = "totalSalesPriceLabel";
            this.totalSalesPriceLabel.Size = new System.Drawing.Size(104, 13);
            this.totalSalesPriceLabel.TabIndex = 22;
            this.totalSalesPriceLabel.Text = "Total Sales Price";
            // 
            // totalSalesCostLabel
            // 
            this.totalSalesCostLabel.AutoSize = true;
            this.totalSalesCostLabel.Location = new System.Drawing.Point(593, 222);
            this.totalSalesCostLabel.Name = "totalSalesCostLabel";
            this.totalSalesCostLabel.Size = new System.Drawing.Size(100, 13);
            this.totalSalesCostLabel.TabIndex = 23;
            this.totalSalesCostLabel.Text = "Total Sales Cost";
            // 
            // placeOrderButton
            // 
            this.placeOrderButton.Location = new System.Drawing.Point(652, 287);
            this.placeOrderButton.Name = "placeOrderButton";
            this.placeOrderButton.Size = new System.Drawing.Size(98, 23);
            this.placeOrderButton.TabIndex = 24;
            this.placeOrderButton.Text = "Place Order";
            this.placeOrderButton.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(596, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 43);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(641, 167);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(120, 30);
            this.resetBtn.TabIndex = 26;
            this.resetBtn.Text = "Empty Cart";
            this.resetBtn.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 352);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.placeOrderButton);
            this.Controls.Add(this.totalSalesCostLabel);
            this.Controls.Add(this.totalSalesPriceLabel);
            this.Controls.Add(this.totalSalesCostTextBox);
            this.Controls.Add(this.totalSalesPriceTextBox);
            this.Controls.Add(this.addItemBtn);
            this.Controls.Add(this.itemDropDownBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.itemDataTable);
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
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Sales Transaction History";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemDataTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.ToolStripMenuItem newMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitBtn;
        private System.Windows.Forms.Button getCustomerBtn;
        private System.Windows.Forms.Label custNumberLabel;
        private System.Windows.Forms.Label custNameLabel;
        private System.Windows.Forms.TextBox custNameTBox;
        private TextBox custNumTextBox;
        private Label custAddrLabel;
        private Label custPhoneNumberLabel;
        private TextBox custAddrTextBox;
        private TextBox custPhoneTextBox;
        private DataGridView itemDataTable;
        private Label label1;
        private ComboBox itemDropDownBox;
        private Button addItemBtn;
        private TextBox totalSalesPriceTextBox;
        private TextBox totalSalesCostTextBox;
        private Label totalSalesPriceLabel;
        private Label totalSalesCostLabel;
        private Button placeOrderButton;
        private PictureBox pictureBox1;
        private Button resetBtn;
    }
}

