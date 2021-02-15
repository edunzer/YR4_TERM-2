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
            string queryCustomer = "SELECT Name FROM Customers ORDER BY Name ASC";
            string queryProduct = "SELECT Name FROM Products";
            SqlCommand cmd = new SqlCommand(queryCustomer, conn);

            txtbxDate.Text = DateTime.Now.ToString("MM-dd-yyyy");

            try //ADD CUSTOMER NAMES TO CUSTOMER COMBOBOX
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
                MessageBox.Show(ex.Message, "Error occured!");
            }
            finally
            {
                conn.Close();
                try //ADD PRODUCTS TO PRODUCT COMBOBOX
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
                    MessageBox.Show(ex.Message, "Error occured!");
                }
                finally
                {
                    conn.Close();
                }
            } 
        }

        public Registration RegistrationToAdd;
        public Customer GetCustomerID;
        public Product GetProductCode;

        private void btnRegister_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(combobxCustomer.Text)) //CHECK IF COMBOBOX CUSTOMER FEILD IS FILLED OUT
            {
                MessageBox.Show("There is no input in the Customer feild. Please select a Customer");
            }
            else
            {
                if (string.IsNullOrEmpty(combobxProduct.Text)) //CHECK IF COMBOBOX PRODUCT FEILD IS FILLED OUT
                {
                    MessageBox.Show("There is no input in the Product feild. Please select a Product");
                }
                else
                {
                    try
                    {
                        SqlConnection conn = TechSupportDB.GetConnection();
                        string queryCustomerID = "SELECT CustomerID FROM Customers WHERE Name = " + "'" + combobxCustomer + "'";
                        string queryProductCode = "SELECT ProductCode FROM Products WHERE Name = " + "'" + combobxProduct + "'";

                        try //GET CUSTOMER ID FROM NAME
                        {
                            conn.Open();
                            SqlCommand cmd = new SqlCommand(queryCustomerID, conn);
                            int GetCustomerID = Convert.ToInt32(cmd.ExecuteScalar());
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Error occured!");
                        }
                        finally
                        {
                            conn.Close();

                            try //GET PRODUCT CODE FROM PRODUCT NAME
                            {
                                conn.Open();
                                SqlCommand cmd = new SqlCommand(queryProductCode, conn);
                                string GetProductCode = Convert.ToString(cmd.ExecuteScalar());
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message, "Error occured!");
                            }
                            finally
                            {
                                conn.Close();

                                try //ADD TO REGISTRATION
                                {
                                    RegistrationToAdd = new Registration();

                                    RegistrationToAdd.CustID = Convert.ToInt32(GetCustomerID);
                                    RegistrationToAdd.ProdCode = Convert.ToString(GetProductCode);
                                    RegistrationToAdd.RegDate = txtbxDate.Text;

                                    RegistrationDB.AddRegistration(RegistrationToAdd);
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message, "Error occured!");
                                }
                            }
                        }
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
