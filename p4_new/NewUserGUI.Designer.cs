namespace P4_project
{
    partial class NewUserGUI
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
            this.createUserFirstname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.createUserLastname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CreateUserCPR = new System.Windows.Forms.TextBox();
            this.CreateUserMobile = new System.Windows.Forms.TextBox();
            this.CreateUserAddress = new System.Windows.Forms.TextBox();
            this.CreateUserDanmark = new System.Windows.Forms.ComboBox();
            this.opretBrugerKnap = new System.Windows.Forms.Button();
            this.firstnameLabel = new System.Windows.Forms.Label();
            this.lastnameLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.mobileLabel = new System.Windows.Forms.Label();
            this.CPRlabel = new System.Windows.Forms.Label();
            this.errorProviderFirstname = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderLastname = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderAddress = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderMobile = new System.Windows.Forms.ErrorProvider(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFirstname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLastname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMobile)).BeginInit();
            this.SuspendLayout();
            // 
            // createUserFirstname
            // 
            this.createUserFirstname.BackColor = System.Drawing.Color.White;
            this.createUserFirstname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.createUserFirstname.Font = new System.Drawing.Font("Leelawadee UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createUserFirstname.Location = new System.Drawing.Point(104, 74);
            this.createUserFirstname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.createUserFirstname.Name = "createUserFirstname";
            this.createUserFirstname.Size = new System.Drawing.Size(108, 14);
            this.createUserFirstname.TabIndex = 0;
            this.createUserFirstname.TextChanged += new System.EventHandler(this.createUserFirstname_TextChanged);
            this.createUserFirstname.Validating += new System.ComponentModel.CancelEventHandler(this.createUserFirstname_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Leelawadee UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(51, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fornavn";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Leelawadee UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(44, 107);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Efternavn";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // createUserLastname
            // 
            this.createUserLastname.BackColor = System.Drawing.Color.White;
            this.createUserLastname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.createUserLastname.Font = new System.Drawing.Font("Leelawadee UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createUserLastname.Location = new System.Drawing.Point(104, 106);
            this.createUserLastname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.createUserLastname.Name = "createUserLastname";
            this.createUserLastname.Size = new System.Drawing.Size(108, 14);
            this.createUserLastname.TabIndex = 1;
            this.createUserLastname.TextChanged += new System.EventHandler(this.createUserLastname_TextChanged);
            this.createUserLastname.Validating += new System.ComponentModel.CancelEventHandler(this.createUserLastname_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Leelawadee UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(38, 248);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Medlem af Danmark";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Leelawadee UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(69, 210);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "CPR";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Leelawadee UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(78, 179);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tlf";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Leelawadee UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(51, 142);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Adresse";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // CreateUserCPR
            // 
            this.CreateUserCPR.BackColor = System.Drawing.Color.White;
            this.CreateUserCPR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CreateUserCPR.Font = new System.Drawing.Font("Leelawadee UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateUserCPR.Location = new System.Drawing.Point(104, 209);
            this.CreateUserCPR.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CreateUserCPR.Name = "CreateUserCPR";
            this.CreateUserCPR.Size = new System.Drawing.Size(108, 14);
            this.CreateUserCPR.TabIndex = 5;
            this.CreateUserCPR.TextChanged += new System.EventHandler(this.CreateUserCPR_TextChanged);
            // 
            // CreateUserMobile
            // 
            this.CreateUserMobile.BackColor = System.Drawing.Color.White;
            this.CreateUserMobile.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CreateUserMobile.Font = new System.Drawing.Font("Leelawadee UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateUserMobile.Location = new System.Drawing.Point(104, 176);
            this.CreateUserMobile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CreateUserMobile.Name = "CreateUserMobile";
            this.CreateUserMobile.Size = new System.Drawing.Size(108, 14);
            this.CreateUserMobile.TabIndex = 4;
            this.CreateUserMobile.TextChanged += new System.EventHandler(this.CreateUserMobile_TextChanged);
            this.CreateUserMobile.Validating += new System.ComponentModel.CancelEventHandler(this.CreateUserMobile_Validating);
            // 
            // CreateUserAddress
            // 
            this.CreateUserAddress.BackColor = System.Drawing.Color.White;
            this.CreateUserAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CreateUserAddress.Font = new System.Drawing.Font("Leelawadee UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateUserAddress.Location = new System.Drawing.Point(104, 142);
            this.CreateUserAddress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CreateUserAddress.Name = "CreateUserAddress";
            this.CreateUserAddress.Size = new System.Drawing.Size(108, 14);
            this.CreateUserAddress.TabIndex = 2;
            this.CreateUserAddress.TextChanged += new System.EventHandler(this.CreateUserAddress_TextChanged);
            this.CreateUserAddress.Validating += new System.ComponentModel.CancelEventHandler(this.CreateUserAddress_Validating);
            // 
            // CreateUserDanmark
            // 
            this.CreateUserDanmark.BackColor = System.Drawing.Color.White;
            this.CreateUserDanmark.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CreateUserDanmark.Font = new System.Drawing.Font("Leelawadee UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateUserDanmark.FormattingEnabled = true;
            this.CreateUserDanmark.Items.AddRange(new object[] {
            "Ja",
            "Nej"});
            this.CreateUserDanmark.Location = new System.Drawing.Point(152, 245);
            this.CreateUserDanmark.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CreateUserDanmark.Name = "CreateUserDanmark";
            this.CreateUserDanmark.Size = new System.Drawing.Size(60, 20);
            this.CreateUserDanmark.TabIndex = 6;
            this.CreateUserDanmark.SelectedIndexChanged += new System.EventHandler(this.CreateUserDanmark_SelectedIndexChanged);
            // 
            // opretBrugerKnap
            // 
            this.opretBrugerKnap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(220)))), ((int)(((byte)(228)))));
            this.opretBrugerKnap.FlatAppearance.BorderSize = 0;
            this.opretBrugerKnap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.opretBrugerKnap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(94)))), ((int)(((byte)(125)))));
            this.opretBrugerKnap.Location = new System.Drawing.Point(46, 300);
            this.opretBrugerKnap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.opretBrugerKnap.Name = "opretBrugerKnap";
            this.opretBrugerKnap.Size = new System.Drawing.Size(83, 26);
            this.opretBrugerKnap.TabIndex = 7;
            this.opretBrugerKnap.Text = "Opret kunde";
            this.opretBrugerKnap.UseVisualStyleBackColor = false;
            this.opretBrugerKnap.Click += new System.EventHandler(this.done_Click);
            // 
            // firstnameLabel
            // 
            this.firstnameLabel.AutoSize = true;
            this.firstnameLabel.Location = new System.Drawing.Point(249, 20);
            this.firstnameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.firstnameLabel.Name = "firstnameLabel";
            this.firstnameLabel.Size = new System.Drawing.Size(0, 13);
            this.firstnameLabel.TabIndex = 20;
            // 
            // lastnameLabel
            // 
            this.lastnameLabel.AutoSize = true;
            this.lastnameLabel.Location = new System.Drawing.Point(249, 53);
            this.lastnameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lastnameLabel.Name = "lastnameLabel";
            this.lastnameLabel.Size = new System.Drawing.Size(0, 13);
            this.lastnameLabel.TabIndex = 21;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(249, 89);
            this.addressLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(0, 13);
            this.addressLabel.TabIndex = 22;
            // 
            // mobileLabel
            // 
            this.mobileLabel.AutoSize = true;
            this.mobileLabel.Location = new System.Drawing.Point(249, 122);
            this.mobileLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mobileLabel.Name = "mobileLabel";
            this.mobileLabel.Size = new System.Drawing.Size(0, 13);
            this.mobileLabel.TabIndex = 23;
            // 
            // CPRlabel
            // 
            this.CPRlabel.AutoSize = true;
            this.CPRlabel.Location = new System.Drawing.Point(249, 155);
            this.CPRlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CPRlabel.Name = "CPRlabel";
            this.CPRlabel.Size = new System.Drawing.Size(0, 13);
            this.CPRlabel.TabIndex = 24;
            this.CPRlabel.Click += new System.EventHandler(this.CPRlabel_Click);
            // 
            // errorProviderFirstname
            // 
            this.errorProviderFirstname.ContainerControl = this;
            // 
            // errorProviderLastname
            // 
            this.errorProviderLastname.ContainerControl = this;
            // 
            // errorProviderAddress
            // 
            this.errorProviderAddress.ContainerControl = this;
            // 
            // errorProviderMobile
            // 
            this.errorProviderMobile.ContainerControl = this;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(135, 300);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 26);
            this.button1.TabIndex = 8;
            this.button1.Text = "Annuller";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NewUserGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::p4_new.Properties.Resources.CreateCustomer2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(271, 360);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CPRlabel);
            this.Controls.Add(this.mobileLabel);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.lastnameLabel);
            this.Controls.Add(this.firstnameLabel);
            this.Controls.Add(this.opretBrugerKnap);
            this.Controls.Add(this.CreateUserDanmark);
            this.Controls.Add(this.CreateUserAddress);
            this.Controls.Add(this.CreateUserMobile);
            this.Controls.Add(this.CreateUserCPR);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.createUserLastname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.createUserFirstname);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "NewUserGUI";
            this.Text = "NewUserGUI";
            this.Load += new System.EventHandler(this.NewUserGUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFirstname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLastname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMobile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox createUserFirstname;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox createUserLastname;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox CreateUserCPR;
        public System.Windows.Forms.TextBox CreateUserMobile;
        public System.Windows.Forms.TextBox CreateUserAddress;
        public System.Windows.Forms.ComboBox CreateUserDanmark;
        public System.Windows.Forms.Button opretBrugerKnap;
        public System.Windows.Forms.Label firstnameLabel;
        public System.Windows.Forms.Label lastnameLabel;
        public System.Windows.Forms.Label addressLabel;
        public System.Windows.Forms.Label mobileLabel;
        public System.Windows.Forms.Label CPRlabel;
        private System.Windows.Forms.ErrorProvider errorProviderFirstname;
        private System.Windows.Forms.ErrorProvider errorProviderLastname;
        private System.Windows.Forms.ErrorProvider errorProviderAddress;
        private System.Windows.Forms.ErrorProvider errorProviderMobile;
        private System.Windows.Forms.Button button1;
    }
}