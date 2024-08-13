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
    public partial class CustomerGUI : Form
    {
        public DataTable formdatatable { get; set; }

        public string id { get; set; }

        public int i_right = 0;
        public int i_left = 0;
        public int count = 0;

        public int change = 1;

        public CustomerGUI()
        {
            InitializeComponent();
           
        }

        private void sletkunde_click(object sender, EventArgs e)
        {
            DataRow[] rows;
            rows = formdatatable.Select("ID=" + id + "");
            foreach (DataRow r in rows)
                r.Delete();
            this.Close();
        }

        private void save_Click(object sender, EventArgs e)
        {
            DataRow row = formdatatable.Select("ID=" + id + "").FirstOrDefault();

            row["Fornavn"] = firstnameBox.Text;
            row["Efternavn"] = lastnameBox.Text;
            row["Addresse"] = addressBox.Text;
            row["Mobil"] = mobileBox.Text;
            row["CPR"] = cprBox.Text;
            row["Medlem af Danmark"] = danmarkMedlemBox.Text;

            row["Log"] = richTextBox3.Text;
            row["Helbred01"] = richTextBox5.Text;


            row["Helbred02"] = richTextBox4.Text;
            row["Helbred03"] = richTextBox6.Text;
            row["Helbred04"] = richTextBox7.Text;
            row["Helbred05"] = richTextBox8.Text;
            row["Personlig01"] = richTextBox9.Text;
            row["Personlig02"] = richTextBox10.Text;
            row["Personlig03"] = richTextBox11.Text;
            row["Personlig04"] = richTextBox12.Text;
            row["Personlig05"] = richTextBox13.Text;
            row["Briller01"] = richTextBox1.Text;
            row["Briller02"] = richTextBox19.Text;
            row["Briller03"] = richTextBox20.Text;
            row["Briller04"] = richTextBox14.Text;
            row["Briller05"] = richTextBox21.Text;
            row["Briller06"] = richTextBox22.Text;
            row["Briller07"] = richTextBox16.Text;
            row["Briller08"] = richTextBox23.Text;
            row["Briller09"] = richTextBox17.Text;
            row["Briller10"] = richTextBox24.Text;
            row["Briller11"] = richTextBox18.Text;
            row["Briller12"] = richTextBox33.Text;
            row["Briller13"] = richTextBox28.Text;
            row["Briller14"] = richTextBox29.Text;
            row["Briller15"] = richTextBox26.Text;
            row["Briller16"] = richTextBox34.Text;
            row["Briller17"] = richTextBox30.Text;
            row["Briller18"] = richTextBox35.Text;
            row["Briller19"] = richTextBox32.Text;
            row["Briller20"] = richTextBox31.Text;
            row["Briller21"] = richTextBox36.Text;
            row["Briller22"] = richTextBox40.Text;
            row["Briller23"] = richTextBox37.Text;
            row["Briller24"] = richTextBox41.Text;
            row["Briller25"] = richTextBox38.Text;
            row["Briller26"] = richTextBox42.Text;
            row["Briller27"] = richTextBox39.Text;
            row["Briller28"] = richTextBox43.Text;
            row["Briller29"] = richTextBox46.Text;
            row["Briller30"] = richTextBox49.Text;
            row["Briller31"] = richTextBox45.Text;
            row["Briller32"] = richTextBox50.Text;
            row["Briller33"] = richTextBox44.Text;
            row["Briller34"] = richTextBox47.Text;
            row["Briller35"] = richTextBox27.Text;
            row["Briller36"] = richTextBox48.Text;
            row["Briller37"] = richTextBox77.Text;
            row["Briller38"] = richTextBox83.Text;
            row["Briller39"] = richTextBox78.Text;
            row["Linser01"] = richTextBox84.Text;
            row["Linser02"] = richTextBox79.Text;
            row["Linser03"] = richTextBox85.Text;
            row["Linser04"] = richTextBox80.Text;
            row["Linser05"] = richTextBox86.Text;
            row["Linser06"] = richTextBox81.Text;
            row["Linser07"] = richTextBox87.Text;
            row["Linser08"] = richTextBox82.Text;
            row["Linser09"] = medicin.Text;
            row["Linser10"] = familie.Text;
            row["Linser11"] = richTextBox71.Text;
            row["Linser12"] = richTextBox70.Text;
            row["Linser13"] = richTextBox73.Text;
            row["Linser14"] = richTextBox74.Text;
            row["Linser15"] = richTextBox72.Text;
            row["Linser16"] = richTextBox69.Text;
            row["Linser17"] = richTextBox75.Text;
            row["Linser18"] = richTextBox68.Text;
            row["Linser19"] = richTextBox76.Text;
            row["Linser20"] = richTextBox67.Text;
            row["Linser21"] = richTextBox58.Text;
            row["Linser22"] = richTextBox54.Text;
            row["Linser23"] = richTextBox57.Text;
            row["Linser24"] = richTextBox53.Text;
            row["Linser25"] = richTextBox56.Text;
            row["Linser26"] = richTextBox52.Text;
            row["Linser27"] = richTextBox55.Text;
            row["Linser28"] = richTextBox51.Text;
            row["Linser29"] = richTextBox63.Text;
            row["Linser30"] = richTextBox60.Text;
            row["Linser31"] = richTextBox64.Text;
            row["Linser32"] = richTextBox59.Text;
            row["Linser33"] = richTextBox65.Text;
            row["Linser34"] = richTextBox62.Text;
            row["Linser35"] = richTextBox66.Text;
            row["Linser36"] = richTextBox61.Text;
            row["Linser37"] = richTextBox90.Text;
            row["Linser38"] = richTextBox91.Text;
            row["Linser39"] = richTextBox94.Text;
            row["Konklusion01"] = richTextBox102.Text;
            row["Konklusion02"] = richTextBox95.Text;
            row["Konklusion03"] = richTextBox103.Text;
            row["Konklusion04"] = richTextBox96.Text;
            row["Konklusion05"] = richTextBox104.Text;
            row["Konklusion06"] = richTextBox97.Text;
            row["Konklusion07"] = richTextBox105.Text;
            row["Konklusion08"] = richTextBox98.Text;
            row["Konklusion09"] = richTextBox106.Text;
            row["Konklusion10"] = richTextBox99.Text;
            row["Konklusion11"] = richTextBox107.Text;
            row["Konklusion12"] = richTextBox100.Text;
            row["Konklusion13"] = richTextBox108.Text;
            row["Konklusion14"] = richTextBox92.Text;
            row["Konklusion15"] = richTextBox93.Text;
            row["Left"] = lefteyeBox.Text;
            row["Right"] = righteyeBox.Text;
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void propertyGrid1_Click(object sender, EventArgs e)
        {

        }

        private void rightEyePicture_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureleft_load(object sender, EventArgs e)
        {
            //handle the mouse event
            this.leftEyePicture.MouseUp += new MouseEventHandler(leftEyePicture_MouseUp);
        }

        private void pictureright_load(object sender, EventArgs e)
        {
            //handle the mouse event
            this.rightEyePicture.MouseUp += new MouseEventHandler(rightEyePicture_MouseUp);
        }

        void leftEyePicture_MouseUp(object sender, MouseEventArgs e)
        {
            //Get graphics from image
            Graphics g = Graphics.FromImage(leftEyePicture.Image);
            //draw on image
            PaintCross_left(g, e.Location);

            g.Dispose();

            //Force to refresh UI

            this.leftEyePicture.Refresh();
        }

        void rightEyePicture_MouseUp(object sender, MouseEventArgs e)
        {
            //Get graphics from image
            Graphics g = Graphics.FromImage(rightEyePicture.Image);
            //draw on image
            PaintCross_right(g, e.Location);

            g.Dispose();

            //Force to refresh UI

            this.rightEyePicture.Refresh();
        }


        private void PaintCross_left(Graphics g, Point loc)
        {
            const int HALF_LEN = 10;

            Point p1 = new Point(loc.X - HALF_LEN, loc.Y);
            Point p2 = new Point(loc.X + HALF_LEN, loc.Y);

            g.DrawLine(Pens.Red, p1, p2);

            p1 = new Point(loc.X, loc.Y - HALF_LEN);
            p2 = new Point(loc.X, loc.Y + HALF_LEN);
            g.DrawLine(Pens.Red, p1, p2);



            string output = string.Format("{0}Punkt {1} : ", i_left == 0 ? "" : "\n\n", i_left);

            string drawString = string.Format("{0}", i_left++);

            Font drawFont = new Font("Arial", 16);

            SolidBrush drawBrush = new SolidBrush(Color.Red);

            PointF drawPoint = new PointF(loc.X, loc.Y);

            StringFormat drawFormat = new StringFormat();
            drawFormat.FormatFlags = StringFormatFlags.DirectionRightToLeft;

            g.DrawString(drawString, drawFont, drawBrush, drawPoint, drawFormat);


            lefteyeBox.AppendText("\r" + output);
            lefteyeBox.ScrollToCaret();






        }

        private void PaintCross_right(Graphics g, Point loc)
        {
            const int HALF_LEN = 10;

            Point p1 = new Point(loc.X - HALF_LEN, loc.Y);
            Point p2 = new Point(loc.X + HALF_LEN, loc.Y);

            g.DrawLine(Pens.Red, p1, p2);

            p1 = new Point(loc.X, loc.Y - HALF_LEN);
            p2 = new Point(loc.X, loc.Y + HALF_LEN);
            g.DrawLine(Pens.Red, p1, p2);



            string output = string.Format("{0}Punkt {1}: ", i_right == 0 ? "" : "\n\n", i_right);

            string drawString = string.Format("{0}", i_right++);

            Font drawFont = new Font("Arial", 16);

            SolidBrush drawBrush = new SolidBrush(Color.Red);

            PointF drawPoint = new PointF(loc.X, loc.Y);

            StringFormat drawFormat = new StringFormat();
            drawFormat.FormatFlags = StringFormatFlags.DirectionRightToLeft;

            g.DrawString(drawString, drawFont, drawBrush, drawPoint, drawFormat);



            righteyeBox.AppendText("\r" + output);
            righteyeBox.ScrollToCaret();




        }

        private void leftEyePicture_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void richTextBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void label41_Click(object sender, EventArgs e)
        {

        }

        private void CustomerGUIbackButton(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CustomerGUI_Load(object sender, EventArgs e)
        {

        }

        private void firstnameBox_Validated(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void save_method()
        {
            DataRow row = formdatatable.Select("ID=" + id + "").FirstOrDefault();

            row["Fornavn"] = firstnameBox.Text;
            row["Efternavn"] = lastnameBox.Text;
            row["Addresse"] = addressBox.Text;
            row["Mobil"] = mobileBox.Text;
            row["CPR"] = cprBox.Text;
            row["Medlem af Danmark"] = danmarkMedlemBox.Text;

            row["Log"] = richTextBox3.Text;
            row["Helbred01"] = richTextBox5.Text;


            row["Helbred02"] = richTextBox4.Text;
            row["Helbred03"] = richTextBox6.Text;
            row["Helbred04"] = richTextBox7.Text;
            row["Helbred05"] = richTextBox8.Text;
            row["Personlig01"] = richTextBox9.Text;
            row["Personlig02"] = richTextBox10.Text;
            row["Personlig03"] = richTextBox11.Text;
            row["Personlig04"] = richTextBox12.Text;
            row["Personlig05"] = richTextBox13.Text;
            row["Briller01"] = richTextBox1.Text;
            row["Briller02"] = richTextBox19.Text;
            row["Briller03"] = richTextBox20.Text;
            row["Briller04"] = richTextBox14.Text;
            row["Briller05"] = richTextBox21.Text;
            row["Briller06"] = richTextBox22.Text;
            row["Briller07"] = richTextBox16.Text;
            row["Briller08"] = richTextBox23.Text;
            row["Briller09"] = richTextBox17.Text;
            row["Briller10"] = richTextBox24.Text;
            row["Briller11"] = richTextBox18.Text;
            row["Briller12"] = richTextBox33.Text;
            row["Briller13"] = richTextBox28.Text;
            row["Briller14"] = richTextBox29.Text;
            row["Briller15"] = richTextBox26.Text;
            row["Briller16"] = richTextBox34.Text;
            row["Briller17"] = richTextBox30.Text;
            row["Briller18"] = richTextBox35.Text;
            row["Briller19"] = richTextBox32.Text;
            row["Briller20"] = richTextBox31.Text;
            row["Briller21"] = richTextBox36.Text;
            row["Briller22"] = richTextBox40.Text;
            row["Briller23"] = richTextBox37.Text;
            row["Briller24"] = richTextBox41.Text;
            row["Briller25"] = richTextBox38.Text;
            row["Briller26"] = richTextBox42.Text;
            row["Briller27"] = richTextBox39.Text;
            row["Briller28"] = richTextBox43.Text;
            row["Briller29"] = richTextBox46.Text;
            row["Briller30"] = richTextBox49.Text;
            row["Briller31"] = richTextBox45.Text;
            row["Briller32"] = richTextBox50.Text;
            row["Briller33"] = richTextBox44.Text;
            row["Briller34"] = richTextBox47.Text;
            row["Briller35"] = richTextBox27.Text;
            row["Briller36"] = richTextBox48.Text;
            row["Briller37"] = richTextBox77.Text;
            row["Briller38"] = richTextBox83.Text;
            row["Briller39"] = richTextBox78.Text;
            row["Linser01"] = richTextBox84.Text;
            row["Linser02"] = richTextBox79.Text;
            row["Linser03"] = richTextBox85.Text;
            row["Linser04"] = richTextBox80.Text;
            row["Linser05"] = richTextBox86.Text;
            row["Linser06"] = richTextBox81.Text;
            row["Linser07"] = richTextBox87.Text;
            row["Linser08"] = richTextBox82.Text;
            row["Linser09"] = richTextBox88.Text;
            row["Linser10"] = richTextBox89.Text;
            row["Linser11"] = richTextBox71.Text;
            row["Linser12"] = richTextBox70.Text;
            row["Linser13"] = richTextBox73.Text;
            row["Linser14"] = richTextBox74.Text;
            row["Linser15"] = richTextBox72.Text;
            row["Linser16"] = richTextBox69.Text;
            row["Linser17"] = richTextBox75.Text;
            row["Linser18"] = richTextBox68.Text;
            row["Linser19"] = richTextBox76.Text;
            row["Linser20"] = richTextBox67.Text;
            row["Linser21"] = richTextBox58.Text;
            row["Linser22"] = richTextBox54.Text;
            row["Linser23"] = richTextBox57.Text;
            row["Linser24"] = richTextBox53.Text;
            row["Linser25"] = richTextBox56.Text;
            row["Linser26"] = richTextBox52.Text;
            row["Linser27"] = richTextBox55.Text;
            row["Linser28"] = richTextBox51.Text;
            row["Linser29"] = richTextBox63.Text;
            row["Linser30"] = richTextBox60.Text;
            row["Linser31"] = richTextBox64.Text;
            row["Linser32"] = richTextBox59.Text;
            row["Linser33"] = richTextBox65.Text;
            row["Linser34"] = richTextBox62.Text;
            row["Linser35"] = richTextBox66.Text;
            row["Linser36"] = richTextBox61.Text;
            row["Linser37"] = richTextBox90.Text;
            row["Linser38"] = richTextBox91.Text;
            row["Linser39"] = richTextBox94.Text;
            row["Konklusion01"] = richTextBox102.Text;
            row["Konklusion02"] = richTextBox95.Text;
            row["Konklusion03"] = richTextBox103.Text;
            row["Konklusion04"] = richTextBox96.Text;
            row["Konklusion05"] = richTextBox104.Text;
            row["Konklusion06"] = richTextBox97.Text;
            row["Konklusion07"] = richTextBox105.Text;
            row["Konklusion08"] = richTextBox98.Text;
            row["Konklusion09"] = richTextBox106.Text;
            row["Konklusion10"] = richTextBox99.Text;
            row["Konklusion11"] = richTextBox107.Text;
            row["Konklusion12"] = richTextBox100.Text;
            row["Konklusion13"] = richTextBox108.Text;
            row["Konklusion14"] = richTextBox92.Text;
            row["Konklusion15"] = richTextBox93.Text;
            row["Left"] = lefteyeBox.Text;
            row["Right"] = righteyeBox.Text;
          
        }

        private void CustomerGUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Vil du gemme ændringer, før du lukker vinduet?", 
                "Er du sikker?", 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Information) == DialogResult.No)
            {

            }
            else
            {
                save_method();
            }
        }

        private void healthTab_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            change = 1;
            changeui();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            change = 2;
            changeui();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            change = 3;
            changeui();
        }

        public void changeui()
        {
            if(change == 1)
            {
                panel1.Visible = true;
                panel2.Visible = false;
                panel3.Visible = false;

                button1.BackgroundImage = Image.FromFile(@"C:\\Designs\Person_personlig_knap.png");
                button2.BackgroundImage = Image.FromFile(@"C:\\Designs\Person_Log_Hover.png");
                button5.BackgroundImage = Image.FromFile(@"C:\\Designs\Person_Helbred_Hover.png");
            }
            else if(change == 2)
            {
                panel1.Visible = false;
                panel2.Visible = true;
                panel3.Visible = false;

                button1.BackgroundImage = Image.FromFile(@"C:\\Designs\Person_personlig_Hover.png");
                button2.BackgroundImage = Image.FromFile(@"C:\\Designs\Person_Log_Knap.png");
                button5.BackgroundImage = Image.FromFile(@"C:\\Designs\Person_Helbred_Hover.png");
            }
            else if(change == 3)
            {
                panel1.Visible = false;
                panel2.Visible = false;
                panel3.Visible = true;

                button1.BackgroundImage = Image.FromFile(@"C:\\Designs\Person_personlig_Hover.png");
                button2.BackgroundImage = Image.FromFile(@"C:\\Designs\Person_Log_Hover.png");
                button5.BackgroundImage = Image.FromFile(@"C:\\Designs\Person_Helbred_Knap.png");
            }
        }

        private void addressBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void lastnameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void cprBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void mobileBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click_2(object sender, EventArgs e)
        {

        }

        private void label98_Click(object sender, EventArgs e)
        {

        }

        private void label102_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void gem_MouseEnter(object sender, EventArgs e)
        {
            gem.BackgroundImage = Image.FromFile(@"C:\\Designs\Person_GemÆndringer_Hover.png");
        }
        private void gem_Exit(object sender, EventArgs e)
        {
            gem.BackgroundImage = Image.FromFile(@"C:\\Designs\Person_GemÆndringer_Knap.png");
        }

        private void slet_MouseEnter(object sender, EventArgs e)
        {
            sletkunde.BackgroundImage = Image.FromFile(@"C:\\Designs\Person_SletKunde_Hover.png");
        }
        private void slet_Exit(object sender, EventArgs e)
        {
            sletkunde.BackgroundImage = Image.FromFile(@"C:\\Designs\Person_SletKunde_Knap.png");
        }
    }
}
