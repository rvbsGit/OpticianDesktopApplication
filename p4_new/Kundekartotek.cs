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
    public partial class Kundekartotek : Form
    {
        public DataTable formdatatable { get; set; }

        public Kundekartotek()
        {
           
            InitializeComponent();
            searchbox.Font = new Font("Leelawadee UI", 15f); 

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.GridColor = Color.FromArgb(75,129,160);
            

            dataGridView1.DataSource = this.formdatatable;
            dataGridView1.Columns["ID"].DataPropertyName = "ID";
            dataGridView1.Columns["Fornavn"].DataPropertyName = "Fornavn";
            dataGridView1.Columns["Efternavn"].DataPropertyName = "Efternavn";
            dataGridView1.Columns["Adresse"].DataPropertyName = "Addresse";
            dataGridView1.Columns["Mobil"].DataPropertyName = "Mobil";
            dataGridView1.Columns["Danmark"].DataPropertyName = "Medlem af Danmark";
            dataGridView1.Columns["CPR"].DataPropertyName = "CPR";


            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            /*
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Blue;
            dataGridView1.ForeColor = Color.White;
            dataGridView1.RowsDefaultCellStyle.BackColor = Color.Black;
            dataGridView1.EnableHeadersVisualStyles = false;
            */

        }

        private void dataGridView1_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CustomerGUI customerGUI = new CustomerGUI();
            customerGUI.formdatatable = formdatatable;

            customerGUI.id = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            string currentrowid = dataGridView1.CurrentRow.Cells[0].Value.ToString();



            DataRow[] rows;
            rows = formdatatable.Select("ID=" + currentrowid + "");

            foreach (DataRow row in rows)
            {
                customerGUI.firstnameBox.Text = row.Field<string>("Fornavn");

                customerGUI.lastnameBox.Text = row.Field<string>("Efternavn");
                customerGUI.addressBox.Text = row.Field<string>("Addresse");
                customerGUI.mobileBox.Text = row.Field<string>("Mobil");
                customerGUI.danmarkMedlemBox.Text = row.Field<string>("Medlem af Danmark");
                customerGUI.cprBox.Text = row.Field<string>("CPR");

                customerGUI.richTextBox3.Text = row.Field<string>("Log");
                customerGUI.richTextBox5.Text = row.Field<string>("Helbred01");


                customerGUI.richTextBox4.Text = row.Field<string>("Helbred02");
                customerGUI.richTextBox6.Text = row.Field<string>("Helbred03");
                customerGUI.richTextBox7.Text = row.Field<string>("Helbred04");
                customerGUI.richTextBox8.Text = row.Field<string>("Helbred05");
                customerGUI.medicin.Text = row.Field<string>("Personlig01");
                customerGUI.familie.Text = row.Field<string>("Personlig02");
                customerGUI.richTextBox11.Text = row.Field<string>("Personlig03");
                customerGUI.richTextBox12.Text = row.Field<string>("Personlig04");
                customerGUI.richTextBox13.Text = row.Field<string>("Personlig05");
                customerGUI.richTextBox1.Text = row.Field<string>("Briller01");
                customerGUI.richTextBox19.Text = row.Field<string>("Briller02");
                customerGUI.richTextBox20.Text = row.Field<string>("Briller03");
                customerGUI.richTextBox14.Text = row.Field<string>("Briller04");
                customerGUI.richTextBox21.Text = row.Field<string>("Briller05");
                customerGUI.richTextBox22.Text = row.Field<string>("Briller06");
                customerGUI.richTextBox16.Text = row.Field<string>("Briller07");
                customerGUI.richTextBox23.Text = row.Field<string>("Briller08");
                customerGUI.richTextBox17.Text = row.Field<string>("Briller09");
                customerGUI.richTextBox24.Text = row.Field<string>("Briller10");
                customerGUI.richTextBox18.Text = row.Field<string>("Briller11");
                customerGUI.richTextBox33.Text = row.Field<string>("Briller12");
                customerGUI.richTextBox28.Text = row.Field<string>("Briller13");
                customerGUI.richTextBox29.Text = row.Field<string>("Briller14");
                customerGUI.richTextBox26.Text = row.Field<string>("Briller15");
                customerGUI.richTextBox34.Text = row.Field<string>("Briller16");
                customerGUI.richTextBox30.Text = row.Field<string>("Briller17");
                customerGUI.richTextBox35.Text = row.Field<string>("Briller18");
                customerGUI.richTextBox32.Text = row.Field<string>("Briller19");
                customerGUI.richTextBox31.Text = row.Field<string>("Briller20");
                customerGUI.richTextBox36.Text = row.Field<string>("Briller21");
                customerGUI.richTextBox40.Text = row.Field<string>("Briller22");
                customerGUI.richTextBox37.Text = row.Field<string>("Briller23");
                customerGUI.richTextBox41.Text = row.Field<string>("Briller24");
                customerGUI.richTextBox38.Text = row.Field<string>("Briller25");
                customerGUI.richTextBox42.Text = row.Field<string>("Briller26");
                customerGUI.richTextBox39.Text = row.Field<string>("Briller27");
                customerGUI.richTextBox43.Text = row.Field<string>("Briller28");
                customerGUI.richTextBox46.Text = row.Field<string>("Briller29");
                customerGUI.richTextBox49.Text = row.Field<string>("Briller30");
                customerGUI.richTextBox45.Text = row.Field<string>("Briller31");
                customerGUI.richTextBox50.Text = row.Field<string>("Briller32");
                customerGUI.richTextBox44.Text = row.Field<string>("Briller33");
                customerGUI.richTextBox47.Text = row.Field<string>("Briller34");
                customerGUI.richTextBox27.Text = row.Field<string>("Briller35");
                customerGUI.richTextBox48.Text = row.Field<string>("Briller36");
                customerGUI.richTextBox77.Text = row.Field<string>("Briller37");
                customerGUI.richTextBox83.Text = row.Field<string>("Briller38");
                customerGUI.richTextBox78.Text = row.Field<string>("Briller39");
                customerGUI.richTextBox84.Text = row.Field<string>("Linser01");
                customerGUI.richTextBox79.Text = row.Field<string>("Linser02");
                customerGUI.richTextBox85.Text = row.Field<string>("Linser03");
                customerGUI.richTextBox80.Text = row.Field<string>("Linser04");
                customerGUI.richTextBox86.Text = row.Field<string>("Linser05");
                customerGUI.richTextBox81.Text = row.Field<string>("Linser06");
                customerGUI.richTextBox87.Text = row.Field<string>("Linser07");
                customerGUI.richTextBox82.Text = row.Field<string>("Linser08");
                customerGUI.richTextBox88.Text = row.Field<string>("Linser09");
                customerGUI.richTextBox89.Text = row.Field<string>("Linser10");
                customerGUI.richTextBox71.Text = row.Field<string>("Linser11");
                customerGUI.richTextBox70.Text = row.Field<string>("Linser12");
                customerGUI.richTextBox73.Text = row.Field<string>("Linser13");
                customerGUI.richTextBox74.Text = row.Field<string>("Linser14");
                customerGUI.richTextBox72.Text = row.Field<string>("Linser15");
                customerGUI.richTextBox69.Text = row.Field<string>("Linser16");
                customerGUI.richTextBox75.Text = row.Field<string>("Linser17");
                customerGUI.richTextBox68.Text = row.Field<string>("Linser18");
                customerGUI.richTextBox76.Text = row.Field<string>("Linser19");
                customerGUI.richTextBox67.Text = row.Field<string>("Linser20");
                customerGUI.richTextBox58.Text = row.Field<string>("Linser21");
                customerGUI.richTextBox54.Text = row.Field<string>("Linser22");
                customerGUI.richTextBox57.Text = row.Field<string>("Linser23");
                customerGUI.richTextBox53.Text = row.Field<string>("Linser24");
                customerGUI.richTextBox56.Text = row.Field<string>("Linser25");
                customerGUI.richTextBox52.Text = row.Field<string>("Linser26");
                customerGUI.richTextBox55.Text = row.Field<string>("Linser27");
                customerGUI.richTextBox51.Text = row.Field<string>("Linser28");
                customerGUI.richTextBox63.Text = row.Field<string>("Linser29");
                customerGUI.richTextBox60.Text = row.Field<string>("Linser30");
                customerGUI.richTextBox64.Text = row.Field<string>("Linser31");
                customerGUI.richTextBox59.Text = row.Field<string>("Linser32");
                customerGUI.richTextBox65.Text = row.Field<string>("Linser33");
                customerGUI.richTextBox62.Text = row.Field<string>("Linser34");
                customerGUI.richTextBox66.Text = row.Field<string>("Linser35");
                customerGUI.richTextBox61.Text = row.Field<string>("Linser36");
                customerGUI.richTextBox90.Text = row.Field<string>("Linser37");
                customerGUI.richTextBox91.Text = row.Field<string>("Linser38");
                customerGUI.richTextBox94.Text = row.Field<string>("Linser39");
                customerGUI.richTextBox102.Text = row.Field<string>("Konklusion01");
                customerGUI.richTextBox95.Text = row.Field<string>("Konklusion02");
                customerGUI.richTextBox103.Text = row.Field<string>("Konklusion03");
                customerGUI.richTextBox96.Text = row.Field<string>("Konklusion04");
                customerGUI.richTextBox104.Text = row.Field<string>("Konklusion05");
                customerGUI.richTextBox97.Text = row.Field<string>("Konklusion06");
                customerGUI.richTextBox105.Text = row.Field<string>("Konklusion07");
                customerGUI.richTextBox98.Text = row.Field<string>("Konklusion08");
                customerGUI.richTextBox106.Text = row.Field<string>("Konklusion09");
                customerGUI.richTextBox99.Text = row.Field<string>("Konklusion10");
                customerGUI.richTextBox107.Text = row.Field<string>("Konklusion11");
                customerGUI.richTextBox100.Text = row.Field<string>("Konklusion12");
                customerGUI.richTextBox108.Text = row.Field<string>("Konklusion13");
                customerGUI.richTextBox92.Text = row.Field<string>("Konklusion14");
                customerGUI.richTextBox93.Text = row.Field<string>("Konklusion15");
                customerGUI.lefteyeBox.Text = row.Field<string>("Left");
                customerGUI.righteyeBox.Text = row.Field<string>("Right");
            }
            customerGUI.ShowDialog();

            
        }


        private void kundekartotek_Close(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Kundekartotek_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void createcustomer_Click(object sender, EventArgs e)
        {

            NewUserGUI newuserGUI = new NewUserGUI();
            newuserGUI.formdatatable = this.formdatatable;
            newuserGUI.ShowDialog();

        }
        // Eventhandler for searching through information in the database linked to the datagrid 
        private void searchbox_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format
            ("Fornavn LIKE '%{0}%' OR Efternavn LIKE '%{0}%' OR Mobil LIKE '%{0}%' OR CPR LIKE '%{0}%'", searchbox.Text);
        }
        private void searchbox_Enter(object sender, EventArgs e)
        {
            this.searchbox.Text = "";
        }

        private void searchbox_Leave(object sender, EventArgs e)
        {
            this.searchbox.Text = "Søg";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void kundekartotek_Close(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void buttonBackToFrontpage(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void dataGridView1_RowDefaultCellStyleChanged(object sender, DataGridViewRowEventArgs e)
        { 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
