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

        //Selected User 
        private User selectedUser = new User();

        private void exit(Object o, EventArgs e)
        {
            userDAO.closeConnection();
            System.Environment.Exit(0);
        }

        public void initList()
        {
            users = userDAO.getUsers();
            items = itemDAO.getItems();
        }


        public MainForm()
        {
            initList();
            InitializeComponent();
            Console.WriteLine("Initializing Database Connection...");
            
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
    }
}
