using System;
using System.Drawing;
using System.Windows.Forms;

namespace ContactBookManagement
{
    public partial class ContactsForm : Form
    {
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
    }
}
