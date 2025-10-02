using ContactBookManagement.Entities;
using ContactBookManagement.Validations;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ContactBookManagement
{
    public partial class ContactsForm : Form
    {
        ValidationOfContactData validationOfContactData = new ValidationOfContactData();
        public ContactsForm()
        {
            InitializeComponent();
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            int width = this.Width;
            int height = this.Height;
            Pen greenPen = new Pen(Color.Orange, 5);
            e.Graphics.DrawRectangle(greenPen, 0, 0, width, height);
        }

        private void ContactsForm_Load(object sender, EventArgs e)
        {
        }

        private void textFirstName_TextChanged(object sender, EventArgs e)
        {
            Contact contact = new Contact();
            contact.FirstName = textFirstName.Text;
            Console.WriteLine(contact.FirstName);
        }

        private void textFirstName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!validationOfContactData.ValidatingOfStringData(textFirstName.Text))
            {
                MessageBox.Show($"{textFirstName.Text} is not valid.");
                textFirstName.Text = string.Empty;
                e.Cancel = true;
            }
        }
        private void textLastName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!validationOfContactData.ValidatingOfStringData(textLastName.Text))
            {
                MessageBox.Show($"{textLastName.Text} is not valid.");
                textLastName.Text = string.Empty;
                e.Cancel = true;
            }
        }

        private void textCity_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!validationOfContactData.ValidatingOfStringData(textCity.Text))
            {
                MessageBox.Show($"{textCity.Text} is not valid.");
                textCity.Text = string.Empty;
                e.Cancel = true;
            }
        }
    }
}
