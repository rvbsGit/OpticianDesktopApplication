namespace P4_project
{
    partial class Kundekartotek
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.createcustomer = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fornavn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Efternavn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adresse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mobil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Danmark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchbox = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.logo = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // createcustomer
            // 
            this.createcustomer.BackColor = System.Drawing.Color.Transparent;
            this.createcustomer.BackgroundImage = global::p4_new.Properties.Resources.Kartotek__;
            this.createcustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.createcustomer.FlatAppearance.BorderSize = 0;
            this.createcustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createcustomer.Location = new System.Drawing.Point(751, 198);
            this.createcustomer.Name = "createcustomer";
            this.createcustomer.Size = new System.Drawing.Size(30, 30);
            this.createcustomer.TabIndex = 3;
            this.createcustomer.UseVisualStyleBackColor = false;
            this.createcustomer.Click += new System.EventHandler(this.createcustomer_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(156)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Leelawadee UI", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(129)))), ((int)(((byte)(160)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(94)))), ((int)(((byte)(126)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Leelawadee UI", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeight = 35;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Fornavn,
            this.Efternavn,
            this.Adresse,
            this.Mobil,
            this.Danmark,
            this.CPR});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(156)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Leelawadee UI", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(12, 257);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 40, 3, 3);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(94)))), ((int)(((byte)(126)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Leelawadee UI", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 10;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(156)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Leelawadee UI", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1238, 405);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_DoubleClick);
            this.dataGridView1.RowDefaultCellStyleChanged += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView1_RowDefaultCellStyleChanged);
            // 
            // ID
            // 
            this.ID.HeaderText = "       ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Fornavn
            // 
            this.Fornavn.HeaderText = "       FORNAVN";
            this.Fornavn.Name = "Fornavn";
            this.Fornavn.ReadOnly = true;
            // 
            // Efternavn
            // 
            this.Efternavn.HeaderText = "       EFTERNAVN";
            this.Efternavn.Name = "Efternavn";
            this.Efternavn.ReadOnly = true;
            // 
            // Adresse
            // 
            this.Adresse.HeaderText = "       ADRESSE";
            this.Adresse.Name = "Adresse";
            this.Adresse.ReadOnly = true;
            // 
            // Mobil
            // 
            this.Mobil.HeaderText = "       MOBIL";
            this.Mobil.Name = "Mobil";
            this.Mobil.ReadOnly = true;
            // 
            // Danmark
            // 
            this.Danmark.HeaderText = "       MEDLEM AF DANMARK";
            this.Danmark.Name = "Danmark";
            this.Danmark.ReadOnly = true;
            // 
            // CPR
            // 
            this.CPR.HeaderText = "       CPR";
            this.CPR.Name = "CPR";
            this.CPR.ReadOnly = true;
            // 
            // searchbox
            // 
            this.searchbox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.searchbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchbox.ForeColor = System.Drawing.Color.White;
            this.searchbox.Location = new System.Drawing.Point(545, 202);
            this.searchbox.Name = "searchbox";
            this.searchbox.Size = new System.Drawing.Size(200, 15);
            this.searchbox.TabIndex = 2;
            this.searchbox.Text = "Søg efter kunde";
            this.searchbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.searchbox.TextChanged += new System.EventHandler(this.searchbox_TextChanged);
            this.searchbox.Enter += new System.EventHandler(this.searchbox_Enter);
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.logo.Image = global::p4_new.Properties.Resources.Noerregade;
            this.logo.Location = new System.Drawing.Point(526, 24);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(251, 227);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 4;
            this.logo.TabStop = false;
            this.logo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.BackgroundImage = global::p4_new.Properties.Resources.minimer2;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(1190, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(20, 20);
            this.button4.TabIndex = 6;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = global::p4_new.Properties.Resources.cross;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(1230, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(20, 20);
            this.button3.TabIndex = 5;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Kundekartotek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(194)))), ((int)(((byte)(201)))));
            this.BackgroundImage = global::p4_new.Properties.Resources.custom_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1262, 753);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.createcustomer);
            this.Controls.Add(this.searchbox);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.dataGridView1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Kundekartotek";
            this.Text = "Kundekartotek";
            this.Load += new System.EventHandler(this.Kundekartotek_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button createcustomer;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.TextBox searchbox;
        private System.Windows.Forms.BindingSource bindingSource1;
        public System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fornavn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Efternavn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adresse;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mobil;
        private System.Windows.Forms.DataGridViewTextBoxColumn Danmark;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPR;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
    }
}