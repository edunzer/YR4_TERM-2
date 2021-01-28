using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LAB2_P2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tECHSUPPORTDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void customerIDTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(customerIDTextBox.Text))
            {
                btnCancel.Enabled = false;
                btnAdd.Enabled = false;
                comboBox1.Enabled = false;
                descriptionTextBox.Enabled = false;
                titleTextBox.Enabled = false;

            }
            else
            {
                btnCancel.Enabled = true;
                btnAdd.Enabled = true;
                comboBox1.Enabled = true;
                descriptionTextBox.Enabled = true;
                titleTextBox.Enabled = true;
            }
        }

        private void tsbtnGetCustomer_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tstxtbxCustomerID.Text))
            {
                MessageBox.Show("There is no input in the Customer ID feild. Please enter in a Customer ID");
            }
            else
            {
                int intCustomerID = Convert.ToInt32(tstxtbxCustomerID.Text);

                try
                {
                    this.customersTableAdapter.FillByCustomerID(this.tECHSUPPORTDataSet.Customers, intCustomerID);

                    if (customersBindingSource.Count == 0)
                    {
                        MessageBox.Show("No Customer found.");
                    }
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                txtbxDateOpened.Text = DateTime.Now.ToString("MM-dd-yyyy");

                try
                {
                    this.productsTableAdapter.FillByCustomerIDProducts(this.tECHSUPPORTDataSet.Products, intCustomerID);

                    if (productsBindingSource.Count == 0)
                    {
                        MessageBox.Show("No Customer found.");
                    }
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(customerIDTextBox.Text))
            {
                MessageBox.Show("There is no input in the Customer ID feild. Please enter in a Customer ID");
            }
            else
            {
                int CustomerID = Convert.ToInt32(customerIDTextBox.Text);
                var DateOpened = Convert.ToDateTime(txtbxDateOpened.Text);
                var ProductName = comboBox1.Text;

                //For some reason this line below doesnt work. No idea why. I checked the sql (FillByProductCodeFind) and when the product name is inputed it pops out the product code that goes with that name. 
                var ProductCode = Convert.ToString(this.productsTableAdapter.FillByProductCodeFind(this.tECHSUPPORTDataSet.Products, ProductName));

                var Title = titleTextBox.Text;
                var Description = descriptionTextBox.Text;

                if (String.IsNullOrEmpty(titleTextBox.Text))
                {
                    MessageBox.Show("There is no input in the Title box feild. Please enter in a Title");
                }
                else
                {
                    if (String.IsNullOrEmpty(descriptionTextBox.Text))
                    {
                        MessageBox.Show("There is no input in the Description box feild. Please enter in a Description");
                    }
                    else
                    {
                        try
                        {
                            this.incidentsTableAdapter.InsertQuery(CustomerID, DateOpened, Title, Description, ProductCode);

                            MessageBox.Show("Update successful." + Convert.ToString(Title) + "Has been added to the incidents table." + Environment.NewLine + Convert.ToString(CustomerID) + " | " + Convert.ToString(DateOpened) + " | " + Convert.ToString(ProductName) + " | " + Convert.ToString(ProductCode) + " | " + Convert.ToString(Title) + " | " + Convert.ToString(Description));
                        }
                        catch (System.Exception)
                        {
                            MessageBox.Show("Update failed");
                        }
                    }
                }
            }
        }

        public void ClearTextBoxes(Control.ControlCollection ctrlCollection)
        {
                foreach (Control ctrl in ctrlCollection)
                {
                    if (ctrl is TextBoxBase)
                    {
                        ctrl.Text = String.Empty;
                    }
                    else
                    {
                        ClearTextBoxes(ctrl.Controls);
                    }
                }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearTextBoxes(this.Controls);
            comboBox1.ResetText();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
