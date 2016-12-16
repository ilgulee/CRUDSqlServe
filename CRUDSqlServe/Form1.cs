using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDSqlServe
{
    public partial class Crud : Form
    {
        public Crud()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void crud_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'foxLearnCrudDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.foxLearnCrudDataSet.Customers);
            customersBindingSource.DataSource = this.foxLearnCrudDataSet.Customers;

        }

        private void searchTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            try
            {
                panel1.Enabled = true;
                fullNametxtBox.Focus();
                this.foxLearnCrudDataSet.Customers.AddCustomersRow(this.foxLearnCrudDataSet.Customers.NewCustomersRow());
                customersBindingSource.MoveLast();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            fullNametxtBox.Focus();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            panel1.Enabled = false;
            customersBindingSource.ResetBindings(false);
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                customersBindingSource.EndEdit();
                customersTableAdapter.Update(this.foxLearnCrudDataSet.Customers);
                panel1.Enabled = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
