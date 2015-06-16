using DAO;
using FirstApplication.DAO;
using FirstApplication.Model;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstApplication
{
    public partial class MainForm : Form
    {

        //get DAOs
        private UserDAO userDAO = new UserDAO();
        private ItemDAO itemDAO = new ItemDAO();

        private List<User> users;
        private List<Item> items;
        private List<Item> selectedItems;
        private DataTable itemTable;


        //Selected User 
        private User selectedUser = new User();

        //Selected Item
        private Item selectedItem;

        //Current Order
        private Order currentOrder = new Order();

        private void exit(Object o, EventArgs e)
        {
            itemDAO.closeConnection();
            userDAO.closeConnection();
            System.Environment.Exit(0);
        }

        private void initList()
        {
            users = userDAO.getUsers();
            items = itemDAO.getItems();
            selectedItems = new List<Item>();
            this.customerDropdownBox.DataSource = users;
            this.itemDropDownBox.DataSource = items;
        }

        private void initDataTable()
        {
            // Here we create a DataTable with four columns.
            itemTable = new DataTable();
            itemTable.Columns.Add("Item Number", typeof(String));
            itemTable.Columns.Add("U of M", typeof(string));
            itemTable.Columns.Add("Quantity Quoted", typeof(string));
            itemTable.Columns.Add("Line Item Sale Price", typeof(String));
            itemTable.Columns.Add("Extended Line Item Total", typeof(String));

            // Here we add five DataRows.
            /*
            table.Rows.Add(25, "Indocin", "David", DateTime.Now);
            table.Rows.Add(50, "Enebrel", "Sam", DateTime.Now);
            table.Rows.Add(10, "Hydralazine", "Christoff", DateTime.Now);
            table.Rows.Add(21, "Combivent", "Janet", DateTime.Now);
            table.Rows.Add(100, "Dilantin", "Melanie", DateTime.Now);
            */

            Console.WriteLine("Data Table: " + itemDataTable);
            
            itemDataTable.DataSource = itemTable;
        }


        public MainForm()
        {
            InitializeComponent();
            initList();
            initDataTable();
            setClickEvents();
            Console.WriteLine("Initializing app...");
            
        }

        private void getSelectedUser(Object o, EventArgs e)
        {
            // this.customerDropdownBox.SelectedIndex = user;
            this.selectedUser = users[this.customerDropdownBox.SelectedIndex];

            if (this.selectedUser != null)
            {
                this.custNumTextBox.Text = selectedUser.getId().ToString();
                this.custNameTBox.Text = selectedUser.getName();
                this.custAddrTextBox.Text = selectedUser.getAddress();
                this.custPhoneTextBox.Text = selectedUser.getPhoneNumber();
                Console.WriteLine("Selected user: " + selectedUser);
            }
           
        }

        //Item to list
        private void addItem(Object o, EventArgs e)
        {
            selectedItem = items[this.itemDropDownBox.SelectedIndex]; 

            if (selectedItem != null)
            {
                Console.WriteLine("SPM: " + selectedItem.getStandProfitMargin() + " Price: " + selectedItem.getPrice());
                decimal lineItemSalePrice = (selectedItem.getPrice() / (1 - selectedItem.getStandProfitMargin()));
                Console.WriteLine("SalePrice: " + lineItemSalePrice);
                
                //Add to backend list of items for current order
                selectedItems.Add(selectedItem);

                //Format values displayed on screen
                String salePriceStr = String.Format("{0:C}", lineItemSalePrice);

                //add to table
                itemTable.Rows.Add(selectedItem.getName(), selectedItem.getUnitOfMeasure(),
                                1, salePriceStr, salePriceStr);
            }
            
        }

        private void setClickEvents ()
        {
            this.exitBtn.Click += new System.EventHandler(this.exit);
            this.addItemBtn.Click += new System.EventHandler(this.addItem);
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void custNumberLabel_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
