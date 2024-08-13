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
    public partial class Forside : Form
    {
        DataTable customer = new DataTable();
        public Forside()
        {
            InitializeComponent();

            customer.Columns.Add("ID", typeof(int));
            customer.Columns.Add("Fornavn", typeof(string));
            customer.Columns.Add("Efternavn", typeof(string));
            customer.Columns.Add("Addresse", typeof(string));
            customer.Columns.Add("Mobil", typeof(string));
            customer.Columns.Add("Medlem af Danmark", typeof(string));
            customer.Columns.Add("CPR", typeof(string));
            customer.Columns.Add("Log", typeof(string));
            customer.Columns.Add("Helbred01", typeof(string));
            customer.Columns.Add("Helbred02", typeof(string));
            customer.Columns.Add("Helbred03", typeof(string));
            customer.Columns.Add("Helbred04", typeof(string));
            customer.Columns.Add("Helbred05", typeof(string));
            customer.Columns.Add("Personlig01", typeof(string));
            customer.Columns.Add("Personlig02", typeof(string));
            customer.Columns.Add("Personlig03", typeof(string));
            customer.Columns.Add("Personlig04", typeof(string));
            customer.Columns.Add("Personlig05", typeof(string));
            customer.Columns.Add("Briller01", typeof(string));
            customer.Columns.Add("Briller02", typeof(string));
            customer.Columns.Add("Briller03", typeof(string));
            customer.Columns.Add("Briller04", typeof(string));
            customer.Columns.Add("Briller05", typeof(string));
            customer.Columns.Add("Briller06", typeof(string));
            customer.Columns.Add("Briller07", typeof(string));
            customer.Columns.Add("Briller08", typeof(string));
            customer.Columns.Add("Briller09", typeof(string));
            customer.Columns.Add("Briller10", typeof(string));
            customer.Columns.Add("Briller11", typeof(string));
            customer.Columns.Add("Briller12", typeof(string));
            customer.Columns.Add("Briller13", typeof(string));
            customer.Columns.Add("Briller14", typeof(string));
            customer.Columns.Add("Briller15", typeof(string));
            customer.Columns.Add("Briller16", typeof(string));
            customer.Columns.Add("Briller17", typeof(string));
            customer.Columns.Add("Briller18", typeof(string));
            customer.Columns.Add("Briller19", typeof(string));
            customer.Columns.Add("Briller20", typeof(string));
            customer.Columns.Add("Briller21", typeof(string));
            customer.Columns.Add("Briller22", typeof(string));
            customer.Columns.Add("Briller23", typeof(string));
            customer.Columns.Add("Briller24", typeof(string));
            customer.Columns.Add("Briller25", typeof(string));
            customer.Columns.Add("Briller26", typeof(string));
            customer.Columns.Add("Briller27", typeof(string));
            customer.Columns.Add("Briller28", typeof(string));
            customer.Columns.Add("Briller29", typeof(string));
            customer.Columns.Add("Briller30", typeof(string));
            customer.Columns.Add("Briller31", typeof(string));
            customer.Columns.Add("Briller32", typeof(string));
            customer.Columns.Add("Briller33", typeof(string));
            customer.Columns.Add("Briller34", typeof(string));
            customer.Columns.Add("Briller35", typeof(string));
            customer.Columns.Add("Briller36", typeof(string));
            customer.Columns.Add("Briller37", typeof(string));
            customer.Columns.Add("Briller38", typeof(string));
            customer.Columns.Add("Briller39", typeof(string));
            customer.Columns.Add("Linser01", typeof(string));
            customer.Columns.Add("Linser02", typeof(string));
            customer.Columns.Add("Linser03", typeof(string));
            customer.Columns.Add("Linser04", typeof(string));
            customer.Columns.Add("Linser05", typeof(string));
            customer.Columns.Add("Linser06", typeof(string));
            customer.Columns.Add("Linser07", typeof(string));
            customer.Columns.Add("Linser08", typeof(string));
            customer.Columns.Add("Linser09", typeof(string));
            customer.Columns.Add("Linser10", typeof(string));
            customer.Columns.Add("Linser11", typeof(string));
            customer.Columns.Add("Linser12", typeof(string));
            customer.Columns.Add("Linser13", typeof(string));
            customer.Columns.Add("Linser14", typeof(string));
            customer.Columns.Add("Linser15", typeof(string));
            customer.Columns.Add("Linser16", typeof(string));
            customer.Columns.Add("Linser17", typeof(string));
            customer.Columns.Add("Linser18", typeof(string));
            customer.Columns.Add("Linser19", typeof(string));
            customer.Columns.Add("Linser20", typeof(string));
            customer.Columns.Add("Linser21", typeof(string));
            customer.Columns.Add("Linser22", typeof(string));
            customer.Columns.Add("Linser23", typeof(string));
            customer.Columns.Add("Linser24", typeof(string));
            customer.Columns.Add("Linser25", typeof(string));
            customer.Columns.Add("Linser26", typeof(string));
            customer.Columns.Add("Linser27", typeof(string));
            customer.Columns.Add("Linser28", typeof(string));
            customer.Columns.Add("Linser29", typeof(string));
            customer.Columns.Add("Linser30", typeof(string));
            customer.Columns.Add("Linser31", typeof(string));
            customer.Columns.Add("Linser32", typeof(string));
            customer.Columns.Add("Linser33", typeof(string));
            customer.Columns.Add("Linser34", typeof(string));
            customer.Columns.Add("Linser35", typeof(string));
            customer.Columns.Add("Linser36", typeof(string));
            customer.Columns.Add("Linser37", typeof(string));
            customer.Columns.Add("Linser38", typeof(string));
            customer.Columns.Add("Linser39", typeof(string));
            customer.Columns.Add("Konklusion01", typeof(string));
            customer.Columns.Add("Konklusion02", typeof(string));
            customer.Columns.Add("Konklusion03", typeof(string));
            customer.Columns.Add("Konklusion04", typeof(string));
            customer.Columns.Add("Konklusion05", typeof(string));
            customer.Columns.Add("Konklusion06", typeof(string));
            customer.Columns.Add("Konklusion07", typeof(string));
            customer.Columns.Add("Konklusion08", typeof(string));
            customer.Columns.Add("Konklusion09", typeof(string));
            customer.Columns.Add("Konklusion10", typeof(string));
            customer.Columns.Add("Konklusion11", typeof(string));
            customer.Columns.Add("Konklusion12", typeof(string));
            customer.Columns.Add("Konklusion13", typeof(string));
            customer.Columns.Add("Konklusion14", typeof(string));
            customer.Columns.Add("Konklusion15", typeof(string));
            customer.Columns.Add("Konklusion16", typeof(string));
            customer.Columns.Add("Konklusion18", typeof(string));
            customer.Columns.Add("Left", typeof(string));
            customer.Columns.Add("Right", typeof(string));


            customer.Rows.Add(new object[] { "1", "Bente", "Sørensen", "Ledavej 30", "12345678", "Nej", "100380-XXXX" });
            customer.Rows.Add(new object[] { "2", "Stine", "Christensen", "Kastetvej 5", "12345678", "Nej", "100380-XXXX" });
            customer.Rows.Add(new object[] { "3", "Henrik", "Hellufsen", "Vesterbro 4", "12345678", "Ja", "100380-XXXX" });
            customer.Rows.Add(new object[] { "4", "Peter", "Simonsen", "Petervej 8", "12345678", "Nej", "100380-XXXX" });
            customer.Rows.Add(new object[] { "5", "Lone", "Olufsen", "Vinterallé 7", "12345678", "Ja", "100380-XXXX" });
            customer.Rows.Add(new object[] { "6", "Anne", "Vinther", "Herningvej 1", "12345678", "Nej", "100380-XXXX" });

        }



        private void button1_Click(object sender, EventArgs e)
        {
           
            Kundekartotek kundekartotek = new Kundekartotek();

            kundekartotek.dataGridView1.DataSource = customer;
            kundekartotek.formdatatable = this.customer;
            kundekartotek.StartPosition = FormStartPosition.CenterScreen;
            //this.Hide();
            kundekartotek.ShowDialog();

        }
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackgroundImage = Image.FromFile(@"C:\\Designs\Forside_Kartotek_Hover.png");
        }
        private void button1_Mouse_Exit(object sender, EventArgs e)
        {
            button1.BackgroundImage = Image.FromFile(@"C:\\Designs\Forside_Kartotek_Knap.png");
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
button2.BackgroundImage = Image.FromFile(@"C:\\Designs\Forside_NyKunde_Hover.png");
        }
        private void button2_Exit(object sender, EventArgs e)
        {
            button2.BackgroundImage = Image.FromFile(@"C:\\Designs\Forside_NyKunde_Knap.png");
        }

        private void button2_Click(object sender, EventArgs e)
        {

            NewUserGUI createnewcustomer = new NewUserGUI();
            createnewcustomer.formdatatable = this.customer;
            createnewcustomer.StartPosition = FormStartPosition.CenterScreen;
            createnewcustomer.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
private void button1_Hover(object sender, EventArgs e)
        {
            
        }

        private void Forside_Load(object sender, EventArgs e)
        {

        }
    }
}
