using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P4_project
{
    public partial class NewUserGUI : Form
    {
        public DataTable formdatatable { get; set; }
        public NewUserGUI()
        {
            InitializeComponent();
        }

        private void NewUserGUI_Load(object sender, EventArgs e)
        {
                            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        // Eventhandler for saving a new customer in the datagrid
        private void done_Click(object sender, EventArgs e)
        {
            // Assigns string values from the text fields to the datagridview columns
            string firstName = createUserFirstname.Text;
            string lastName = createUserLastname.Text;
            string adress = CreateUserAddress.Text;
            string phoneNumber = CreateUserMobile.Text;
            string cprNumber = CreateUserCPR.Text;
            string memberDanmark = CreateUserDanmark.Text;

            // New customer is saved if all necessary textboxes are filled out
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                // Set the AutoIncrement feature to true for column ID
                formdatatable.Columns["ID"].AutoIncrement = true;
                // Set start value to 7, as we already have 6 customers on run start
                formdatatable.Columns["ID"].AutoIncrementSeed = 7;
                //Increment the ID by one automatically
                formdatatable.Columns["ID"].AutoIncrementStep = 1;

                // Creates a new row in the datagrid and assigns string values to the datagrid columns
                formdatatable.Rows.Add(new object[] { null, firstName, lastName, adress, phoneNumber, memberDanmark, cprNumber });
                
                // Closes the NewUserGUI form
                this.Close();
            }
        }

        private void CPRlabel_Click(object sender, EventArgs e)
        {

        }

        private void firstnamePicBox_Click(object sender, EventArgs e)
        {

        }

        private void createUserFirstname_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(createUserFirstname.Text))
            {
                e.Cancel = true;
                createUserFirstname.Focus();
                errorProviderFirstname.SetError(createUserFirstname, "Udfyld navn");
            }
            else
            {
                e.Cancel = false;
                errorProviderFirstname.SetError(createUserFirstname, "");
            }
        }

        private void createUserLastname_TextChanged(object sender, EventArgs e)
        {

        }

        private void createUserLastname_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(createUserLastname.Text))
            {
                e.Cancel = true;
                createUserLastname.Focus();
                errorProviderLastname.SetError(createUserLastname, "Udfyld efternavn");
            }
            else
            {
                e.Cancel = false;
                errorProviderLastname.SetError(createUserLastname, "");
            }
        }

        private void CreateUserAddress_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(CreateUserAddress.Text))
            {
                e.Cancel = true;
                CreateUserAddress.Focus();
                errorProviderAddress.SetError(CreateUserAddress, "Udfyld adresse");
            }
            else
            {
                e.Cancel = false;
                errorProviderAddress.SetError(CreateUserAddress, "");
            }
        }

        private void CreateUserMobile_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(CreateUserMobile.Text))
            {
                e.Cancel = true;
                CreateUserMobile.Focus();
                errorProviderMobile.SetError(CreateUserMobile, "Udfyld telefonnummer");
            }
            else
            {
                e.Cancel = false;
                errorProviderMobile.SetError(CreateUserMobile, "");
            }
        }

        private void CPRpicBox_Click(object sender, EventArgs e)
        {

        }

        private void MobilePicBox_Click(object sender, EventArgs e)
        {

        }

        private void AddressPicBox_Click(object sender, EventArgs e)
        {

        }

        private void lastnamePicBox_Click(object sender, EventArgs e)
        {

        }

        private void createUserFirstname_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreateUserDanmark_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CreateUserAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreateUserMobile_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreateUserCPR_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void danmarkPicBox_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    } 
}
