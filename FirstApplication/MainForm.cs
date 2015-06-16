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
        private OrderDAO orderDAO = new OrderDAO();

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

            Console.WriteLine("Data Table: " + itemDataTable);
            
            itemDataTable.DataSource = itemTable;

            this.totalSalesCostTextBox.Text = currentOrder.getTotalCostStr();
            this.totalSalesPriceTextBox.Text = currentOrder.getTotalPriceStr();
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

                //Set customerId for order to be placed
                currentOrder.setCustomerId(selectedUser.getId());
                Console.WriteLine("Current order : " + currentOrder.getCustomerId());
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

                //Update Order Total Price/Cost
                currentOrder.setTotalPrice(currentOrder.getTotalPrice() + lineItemSalePrice);
                currentOrder.setTotalCost(currentOrder.getTotalCost() +
                        (selectedItem.getPrice() * selectedItem.getStandProfitMargin()));

                //Format values displayed on screen
                String salePriceStr = String.Format("{0:C}", lineItemSalePrice);

                //add to table
                itemTable.Rows.Add(selectedItem.getName(), selectedItem.getUnitOfMeasure(),
                                1, salePriceStr, salePriceStr);

                this.totalSalesCostTextBox.Text = currentOrder.getTotalCostStr();
                this.totalSalesPriceTextBox.Text = currentOrder.getTotalPriceStr();

                //Enable buttons
                this.resetBtn.Enabled = true;
                this.placeOrderButton.Enabled = true;

            }

            

        }
        
        //Place Current Order through the OrderDAO
        private void placeOrder (Object o, EventArgs e)
        {
            Console.WriteLine("Placing Order...");

            //Place Order via DAO
            orderDAO.placeOrder(currentOrder, selectedItems);

            clearCart(new Object(), new EventArgs());

        }

        private void clearCart (Object o, EventArgs e)
        {
            Console.WriteLine("Clearing Cart...");

            //Reset Order
            currentOrder = new Order();

            this.totalSalesCostTextBox.Text = currentOrder.getTotalCostStr();
            this.totalSalesPriceTextBox.Text = currentOrder.getTotalPriceStr();

            //Reset Selected Items List
            selectedItems.Clear();

            //Delete Rows From Table
            itemTable.Rows.Clear();

            //Reset buttons
            this.resetBtn.Enabled = false;
            this.placeOrderButton.Enabled = false;
        }

        private void reset(Object o, EventArgs e)
        {
            Console.WriteLine("Reseting Fields...");

            //Reset Order
            currentOrder = new Order();

            this.totalSalesCostTextBox.Text = currentOrder.getTotalCostStr();
            this.totalSalesPriceTextBox.Text = currentOrder.getTotalPriceStr();

            //Reset Selected Items List
            selectedItems.Clear();

            //Delete Rows From Table
            itemTable.Rows.Clear();

            //Reset user fiels
            selectedUser = null;
            this.custNumTextBox.Text = "";
            this.custNameTBox.Text = "";
            this.custAddrTextBox.Text = "";
            this.custPhoneTextBox.Text = "";

            //Reset buttons
            this.resetBtn.Enabled = false;
            this.placeOrderButton.Enabled = false;

        }

        private void exit(Object o, EventArgs e)
        {
            Console.WriteLine("Closing All Connections..");
            itemDAO.closeConnection();
            userDAO.closeConnection();
            orderDAO.closeConnection();
            System.Environment.Exit(0);
        }

        private void setClickEvents ()
        {
            this.exitBtn.Click += new System.EventHandler(this.exit);
            this.addItemBtn.Click += new System.EventHandler(this.addItem);
            this.resetBtn.Click += new System.EventHandler(this.clearCart);
            this.resetBtn.Enabled = false;
            this.placeOrderButton.Click += new System.EventHandler(this.placeOrder);
            this.placeOrderButton.Enabled = false;
            this.newMenuItem.Click += new System.EventHandler(this.reset);
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
