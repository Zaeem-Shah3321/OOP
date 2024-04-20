using Guna.UI2.WinForms.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectGUI.UI
{
    public partial class AdminMenu : Form
    {
        public AdminMenu()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            LogIn_Page logIn_Page = new LogIn_Page();
            logIn_Page.Show();
            this.Hide();
        }

        private void AdminMenu_Load(object sender, EventArgs e)
        {

        }

        private void add_books_Click(object sender, EventArgs e)
        {
            Add_Books add_Books = new Add_Books();
            add_Books.Show();
            this.Hide();
        }
    }
}
