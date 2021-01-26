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

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-DK99MGG; Initial Catalog=TECHSUPPORT ; Integrated Security=True;");
        SqlCommand cmd;

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

        private void tsbtnGetCustomer_Click(object sender, EventArgs e)
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            /*
            var CustomerName = nameTextBox.Text;
            var CustomerDate = dateOpenedDateTimePicker.Text;
            var CustomerProduct = comboBox1.Text;
            var CustomerTitle = titleTextBox.Text;
            var CustomerDescription = descriptionTextBox.Text;
            
           
            this.incidentsBindingSource.AddNew();

            try
            {
                this.incidentsTableAdapter.Fill(this.tECHSUPPORTDataSet.Incidents);
            }
            catch
            {
                MessageBox.Show("Database error");
            }
            */
            con.Open();
            cmd = new SqlCommand("INSERT INTO Incidents VALUES('"+customerIDTextBox.Text+"','" + nameTextBox.Text + "','" + dateOpenedDateTimePicker.Text + "','NULL','" + comboBox1.Text + "','" + titleTextBox.Text + "','" + descriptionTextBox.Text + "')",con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data has been saved in database");
            con.Close();
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
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
