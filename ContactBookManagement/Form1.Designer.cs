using System.Windows.Forms;

namespace ContactBookManagement
{
    partial class ContactsForm
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
        /// #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addressLabel = new System.Windows.Forms.Label();
            this.firstName = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.Label();
            this.phoneNr = new System.Windows.Forms.Label();
            this.textFirstName = new System.Windows.Forms.TextBox();
            this.textLastName = new System.Windows.Forms.TextBox();
            this.textPhoneNr = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.Label();
            this.zipCode = new System.Windows.Forms.Label();
            this.city = new System.Windows.Forms.Label();
            this.textAddress = new System.Windows.Forms.TextBox();
            this.textZipCode = new System.Windows.Forms.TextBox();
            this.textCity = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.Label();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPhoneNr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColZipCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.add = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Liberation Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLabel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.addressLabel.Location = new System.Drawing.Point(12, 24);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(144, 26);
            this.addressLabel.TabIndex = 0;
            this.addressLabel.Text = "Address book";
            // 
            // firstName
            // 
            this.firstName.AutoSize = true;
            this.firstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstName.Location = new System.Drawing.Point(23, 82);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(94, 20);
            this.firstName.TabIndex = 1;
            this.firstName.Text = "First name";
            // 
            // lastName
            // 
            this.lastName.AutoSize = true;
            this.lastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastName.Location = new System.Drawing.Point(23, 140);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(93, 20);
            this.lastName.TabIndex = 2;
            this.lastName.Text = "Last name";
            // 
            // phoneNr
            // 
            this.phoneNr.AutoSize = true;
            this.phoneNr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNr.Location = new System.Drawing.Point(23, 197);
            this.phoneNr.Name = "phoneNr";
            this.phoneNr.Size = new System.Drawing.Size(86, 20);
            this.phoneNr.TabIndex = 3;
            this.phoneNr.Text = "Phone nr.";
            // 
            // textFirstName
            // 
            this.textFirstName.Location = new System.Drawing.Point(172, 82);
            this.textFirstName.Name = "textFirstName";
            this.textFirstName.Size = new System.Drawing.Size(135, 26);
            this.textFirstName.TabIndex = 4;
            // 
            // textLastName
            // 
            this.textLastName.Location = new System.Drawing.Point(172, 140);
            this.textLastName.Name = "textLastName";
            this.textLastName.Size = new System.Drawing.Size(135, 26);
            this.textLastName.TabIndex = 5;
            // 
            // textPhoneNr
            // 
            this.textPhoneNr.Location = new System.Drawing.Point(172, 197);
            this.textPhoneNr.Name = "textPhoneNr";
            this.textPhoneNr.Size = new System.Drawing.Size(135, 26);
            this.textPhoneNr.TabIndex = 6;
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address.Location = new System.Drawing.Point(373, 88);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(75, 20);
            this.address.TabIndex = 7;
            this.address.Text = "Address";
            // 
            // zipCode
            // 
            this.zipCode.AutoSize = true;
            this.zipCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zipCode.Location = new System.Drawing.Point(373, 140);
            this.zipCode.Name = "zipCode";
            this.zipCode.Size = new System.Drawing.Size(76, 20);
            this.zipCode.TabIndex = 8;
            this.zipCode.Text = "ZipCode";
            // 
            // city
            // 
            this.city.AutoSize = true;
            this.city.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.city.Location = new System.Drawing.Point(373, 200);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(39, 20);
            this.city.TabIndex = 9;
            this.city.Text = "City";
            // 
            // textAddress
            // 
            this.textAddress.Location = new System.Drawing.Point(513, 85);
            this.textAddress.Name = "textAddress";
            this.textAddress.Size = new System.Drawing.Size(150, 26);
            this.textAddress.TabIndex = 10;
            // 
            // textZipCode
            // 
            this.textZipCode.Location = new System.Drawing.Point(513, 140);
            this.textZipCode.Name = "textZipCode";
            this.textZipCode.Size = new System.Drawing.Size(150, 26);
            this.textZipCode.TabIndex = 11;
            // 
            // textCity
            // 
            this.textCity.Location = new System.Drawing.Point(513, 194);
            this.textCity.Name = "textCity";
            this.textCity.Size = new System.Drawing.Size(150, 26);
            this.textCity.TabIndex = 12;
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(27, 246);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(53, 20);
            this.email.TabIndex = 13;
            this.email.Text = "Email";
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(172, 246);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(491, 26);
            this.textEmail.TabIndex = 14;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColFirstName,
            this.ColLastName,
            this.ColPhoneNr,
            this.ColAddress,
            this.ColZipCode,
            this.ColCity,
            this.ColEmail});
            this.dataGridView1.Location = new System.Drawing.Point(31, 317);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(829, 273);
            this.dataGridView1.TabIndex = 15;
            // 
            // ColFirstName
            // 
            this.ColFirstName.HeaderText = "First name";
            this.ColFirstName.MinimumWidth = 8;
            this.ColFirstName.Name = "ColFirstName";
            this.ColFirstName.Width = 150;
            // 
            // ColLastName
            // 
            this.ColLastName.HeaderText = "Last name";
            this.ColLastName.MinimumWidth = 8;
            this.ColLastName.Name = "ColLastName";
            this.ColLastName.Width = 150;
            // 
            // ColPhoneNr
            // 
            this.ColPhoneNr.FillWeight = 150F;
            this.ColPhoneNr.HeaderText = "Phone number";
            this.ColPhoneNr.MinimumWidth = 8;
            this.ColPhoneNr.Name = "ColPhoneNr";
            this.ColPhoneNr.Width = 150;
            // 
            // ColAddress
            // 
            this.ColAddress.FillWeight = 150F;
            this.ColAddress.HeaderText = "Address";
            this.ColAddress.MinimumWidth = 8;
            this.ColAddress.Name = "ColAddress";
            this.ColAddress.Width = 150;
            // 
            // ColZipCode
            // 
            this.ColZipCode.HeaderText = "Zip code";
            this.ColZipCode.MaxInputLength = 15;
            this.ColZipCode.MinimumWidth = 8;
            this.ColZipCode.Name = "ColZipCode";
            this.ColZipCode.Width = 80;
            // 
            // ColCity
            // 
            this.ColCity.FillWeight = 150F;
            this.ColCity.HeaderText = "City";
            this.ColCity.MaxInputLength = 124;
            this.ColCity.MinimumWidth = 8;
            this.ColCity.Name = "ColCity";
            this.ColCity.Width = 150;
            // 
            // ColEmail
            // 
            this.ColEmail.FillWeight = 150F;
            this.ColEmail.HeaderText = "Email";
            this.ColEmail.MinimumWidth = 8;
            this.ColEmail.Name = "ColEmail";
            this.ColEmail.Width = 150;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(785, 85);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 40);
            this.add.TabIndex = 16;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(785, 154);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(75, 40);
            this.edit.TabIndex = 17;
            this.edit.Text = "Edit";
            this.edit.UseVisualStyleBackColor = true;
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(785, 226);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 40);
            this.delete.TabIndex = 18;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            // 
            // ContactsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(892, 645);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.add);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.email);
            this.Controls.Add(this.textCity);
            this.Controls.Add(this.textZipCode);
            this.Controls.Add(this.textAddress);
            this.Controls.Add(this.city);
            this.Controls.Add(this.zipCode);
            this.Controls.Add(this.address);
            this.Controls.Add(this.textPhoneNr);
            this.Controls.Add(this.textLastName);
            this.Controls.Add(this.textFirstName);
            this.Controls.Add(this.phoneNr);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.addressLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ContactsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Address book";
            this.Load += new System.EventHandler(this.ContactsForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label addressLabel;
        private Label firstName;
        private Label lastName;
        private Label phoneNr;
        private TextBox textFirstName;
        private TextBox textLastName;
        private TextBox textPhoneNr;
        private Label address;
        private Label zipCode;
        private Label city;
        private TextBox textAddress;
        private TextBox textZipCode;
        private TextBox textCity;
        private Label email;
        private TextBox textEmail;
        private DataGridView dataGridView1;
        private Button add;
        private Button edit;
        private Button delete;
        private DataGridViewTextBoxColumn ColFirstName;
        private DataGridViewTextBoxColumn ColLastName;
        private DataGridViewTextBoxColumn ColPhoneNr;
        private DataGridViewTextBoxColumn ColAddress;
        private DataGridViewTextBoxColumn ColZipCode;
        private DataGridViewTextBoxColumn ColCity;
        private DataGridViewTextBoxColumn ColEmail;
        //private void InitializeComponent()
        //{
        //    this.SuspendLayout();
        //    // 
        //    // ContactsForm
        //    // 
        //    this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
        //    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        //    this.ClientSize = new System.Drawing.Size(800, 450);
        //    this.Name = "ContactsForm";
        //    this.Text = "Address book";
        //    this.ResumeLayout(false);

        //}

        //#endregion
    }
}

