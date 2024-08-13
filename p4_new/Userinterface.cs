using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace P4_project
{
    public class UserInterface : Form
    {
        //Objects
        private TextBox searchBox;
        private Button searchBtn;
        private Label header;
        private Button addCustomer;
        private ListBox listBox1;
        private ListBox record;

        public UserInterface()
        {
            //The entire window
            this.Text = "User Interface"; //Maybe change name
            this.Size = new Size(1280, 800);
            this.BackColor = Color.FromArgb(165, 194, 201);

            //The search box
            this.searchBox = new TextBox();
            this.searchBox.Size = new Size(200, 50);
            this.searchBox.Location = new Point(940, 20);
            this.Controls.Add(searchBox);

            //The search button
            this.searchBtn = new Button();
            this.searchBtn.Size = new Size(70, 20);
            this.searchBtn.Location = new Point(1140, 20);
            this.searchBtn.Text = "Søg";
            this.Controls.Add(searchBtn);

            //The header of the screen
            this.header = new Label();
            this.header.Size = new Size(1280, 50);
            this.header.Font = new Font("Arial", 30, FontStyle.Bold);
            this.header.Text = "Nørregade Optik";
            this.header.Location = new Point(0, 0);
            this.Controls.Add(header);
            this.header.BackColor = Color.FromArgb(72, 124, 134);

            //Create customer
            this.addCustomer = new Button();
            this.addCustomer.Size = new Size(72, 20);
            this.addCustomer.Location = new Point(50, 100);
            this.addCustomer.BackColor = Color.FromArgb(72, 124, 134);
            this.addCustomer.Text = "Tilføj kunde";
            this.Controls.Add(addCustomer);

            //Customer Record
            this.record = new ListBox();
            this.record.Size = new Size(1160, 50);
            this.record.Location = new Point(50, 300);
            this.record.BackColor = Color.FromArgb(72, 124, 134);
            this.Controls.Add(record);


           
        }

        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "Mark Marturin Christensen, 53662214, true"});
            this.listBox1.Location = new System.Drawing.Point(30, 166);
            this.listBox1.MultiColumn = true;
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(557, 84);
            this.listBox1.TabIndex = 0;
            // 
            // UserInterface
            // 
            this.ClientSize = new System.Drawing.Size(873, 374);
            this.Controls.Add(this.listBox1);
            this.Name = "UserInterface";
            this.ResumeLayout(false);

        }
    }
}
