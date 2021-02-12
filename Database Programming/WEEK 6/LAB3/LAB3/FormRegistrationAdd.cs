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

namespace LAB3
{
    public partial class FormRegistrationAdd : Form
    {
        public FormRegistrationAdd()
        {
            InitializeComponent();
        }

        private void FormRegistrationAdd_Load(object sender, EventArgs e)
        {
            SqlConnection conn = TechSupportDB.GetConnection();
            string queryCustomer = "SELECT Name FROM Customers";
            string queryProduct = "SELECT Name FROM Products";
            SqlCommand cmd = new SqlCommand(queryCustomer, conn);

            txtbxDate.Text = DateTime.Now.ToString("MM-dd-yyyy");

            try
            {
                SqlDataAdapter da = new SqlDataAdapter(queryCustomer, conn);
                conn.Open();
                DataSet ds = new DataSet();
                da.Fill(ds, "Name");
                combobxCustomer.DisplayMember = "Name";
                combobxCustomer.DataSource = ds.Tables["Name"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured!");
            }
            finally
            {
                conn.Close();
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter(queryProduct, conn);
                    conn.Open();
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Name");
                    combobxProduct.DisplayMember = "Name";
                    combobxProduct.DataSource = ds.Tables["Name"];
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occured!");
                }
                finally
                {
                    conn.Close();
                }
            } 
        }

        public Registration RegistrationToAdd;

        private void btnRegister_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(combobxCustomer.Text))
            {
                MessageBox.Show("There is no input in the Customer feild. Please select a Customer");
            }
            else
            {
                if (string.IsNullOrEmpty(combobxProduct.Text))
                {
                    MessageBox.Show("There is no input in the Product feild. Please select a Product");
                }
                else
                {
                    try
                    {
                        RegistrationToAdd = new Registration();

                        RegistrationToAdd.CustName = combobxCustomer.Text;
                        RegistrationToAdd.ProdName = combobxProduct.Text;
                        RegistrationToAdd.RegDate = txtbxDate.Text;

                        RegistrationDB.AddRegistration(RegistrationToAdd);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error");
                    }
                    finally
                    {
                        ClearTextBoxes(this.Controls);
                        combobxCustomer.ResetText();
                        combobxProduct.ResetText();
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
            txtbxDate.Text = DateTime.Now.ToString("MM-dd-yyyy");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearTextBoxes(this.Controls);
            combobxCustomer.ResetText();
            combobxProduct.ResetText();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
