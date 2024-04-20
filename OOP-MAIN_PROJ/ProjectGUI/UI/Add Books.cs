using ProjectDLL.BL;
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
    public partial class Add_Books : Form
    {
        public Add_Books()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            bool isUserBookExist = ObjectHandler.GetBookDL().IsExist(namebox.Text);
            if (isUserBookExist)
            {
                MessageBox.Show("Book already exist");
                return;
            }
            bool isValid = InputValidate();
            if (!isValid)
            {
                MessageBox.Show("Please fill all the fields");
                return;
            }
            Book book = new Book(namebox.Text , authorbox.Text , locationbox.Text , int.Parse(totalbox.Text) , int.Parse(availablebox.Text));
            ObjectHandler.GetBookDL().Create(book);
            MessageBox.Show("Book Added Sucessfully");
            AdminMenu adminMenu = new AdminMenu();
            adminMenu.Show();
            this.Hide();
        }
        private bool InputValidate()
        {
            if (namebox.Text == "" || authorbox.Text == "" || locationbox.Text == "" || totalbox.Text == "" || availablebox.Text == "")
            {
                return false;
            }
            return true;
        }
    }
}
