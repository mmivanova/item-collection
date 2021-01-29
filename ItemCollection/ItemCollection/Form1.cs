using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ItemCollection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tbCountNames.Text = "6";
            tbCountNumbers.Text = "9";
        }

        private void btnAddName_Click(object sender, EventArgs e)
        {
            var name = lbNames.SelectedItem;
            lbCollection.Items.Add(name);
        }

        private void btnAddNumber_Click(object sender, EventArgs e)
        {
            var number = lbNumbers.SelectedItem;
            lbCollection.Items.Add(number);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            tbCountCollection.Text = lbCollection.Items.Count.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            var itemToDelete = lbCollection.SelectedItem;
            lbCollection.Items.Remove(itemToDelete);
            tbCountCollection.Text = lbCollection.Items.Count.ToString();
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            lbCollection.Items.Clear();
            tbCountCollection.Text = lbCollection.Items.Count.ToString();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            lbNames.Sorted = true;
            lbNumbers.Sorted = true;
        }

        private void lbCollection_KeyPress(object sender, KeyPressEventArgs e)
        {
            var selectedItem = lbCollection.SelectedItem;
            if (e.KeyChar == (char)Keys.Enter)
            {
                tbEnter.Text = selectedItem.ToString();
            }
        }
    }
}
