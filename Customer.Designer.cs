namespace DBMS_CrashCourse
{
    partial class Customer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.btnActAdd = new System.Windows.Forms.Button();
            this.btnActUpdate = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSaveAdd = new System.Windows.Forms.Button();
            this.txtCusEmail = new System.Windows.Forms.TextBox();
            this.txtCusNum = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCusAddress = new System.Windows.Forms.TextBox();
            this.txtCusName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSaveUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(300, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 23);
            this.label2.TabIndex = 14;
            this.label2.Text = "List of Customers";
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.AllowUserToAddRows = false;
            this.dgvCustomer.AllowUserToDeleteRows = false;
            this.dgvCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomer.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.Location = new System.Drawing.Point(304, 95);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.ReadOnly = true;
            this.dgvCustomer.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvCustomer.RowTemplate.Height = 24;
            this.dgvCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomer.Size = new System.Drawing.Size(854, 616);
            this.dgvCustomer.TabIndex = 15;
            this.dgvCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomer_CellClick);
            // 
            // btnActAdd
            // 
            this.btnActAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.btnActAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActAdd.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActAdd.ForeColor = System.Drawing.Color.White;
            this.btnActAdd.Location = new System.Drawing.Point(831, 18);
            this.btnActAdd.Name = "btnActAdd";
            this.btnActAdd.Size = new System.Drawing.Size(151, 54);
            this.btnActAdd.TabIndex = 2;
            this.btnActAdd.Text = "Add Customer";
            this.btnActAdd.UseVisualStyleBackColor = false;
            this.btnActAdd.Click += new System.EventHandler(this.btnActAdd_Click);
            // 
            // btnActUpdate
            // 
            this.btnActUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.btnActUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActUpdate.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActUpdate.ForeColor = System.Drawing.Color.White;
            this.btnActUpdate.Location = new System.Drawing.Point(998, 18);
            this.btnActUpdate.Name = "btnActUpdate";
            this.btnActUpdate.Size = new System.Drawing.Size(151, 54);
            this.btnActUpdate.TabIndex = 5;
            this.btnActUpdate.Text = "Update Customer";
            this.btnActUpdate.UseVisualStyleBackColor = false;
            this.btnActUpdate.Click += new System.EventHandler(this.btnActUpdate_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSaveUpdate);
            this.panel1.Controls.Add(this.txtCustomerID);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnSaveAdd);
            this.panel1.Controls.Add(this.txtCusEmail);
            this.panel1.Controls.Add(this.txtCusNum);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtCusAddress);
            this.panel1.Controls.Add(this.txtCusName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(289, 750);
            this.panel1.TabIndex = 16;
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Enabled = false;
            this.txtCustomerID.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtCustomerID.Location = new System.Drawing.Point(140, 182);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(62, 28);
            this.txtCustomerID.TabIndex = 57;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(21, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 21);
            this.label7.TabIndex = 56;
            this.label7.Text = "CustomerID:";
            // 
            // btnCancel
            // 
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCancel.FlatAppearance.BorderSize = 2;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCancel.Location = new System.Drawing.Point(148, 515);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 31);
            this.btnCancel.TabIndex = 55;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSaveAdd
            // 
            this.btnSaveAdd.FlatAppearance.BorderColor = System.Drawing.Color.YellowGreen;
            this.btnSaveAdd.FlatAppearance.BorderSize = 2;
            this.btnSaveAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveAdd.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnSaveAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSaveAdd.Location = new System.Drawing.Point(52, 515);
            this.btnSaveAdd.Name = "btnSaveAdd";
            this.btnSaveAdd.Size = new System.Drawing.Size(90, 31);
            this.btnSaveAdd.TabIndex = 54;
            this.btnSaveAdd.Text = "Save";
            this.btnSaveAdd.UseVisualStyleBackColor = true;
            this.btnSaveAdd.Click += new System.EventHandler(this.btnSaveAdd_Click);
            // 
            // txtCusEmail
            // 
            this.txtCusEmail.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtCusEmail.Location = new System.Drawing.Point(25, 448);
            this.txtCusEmail.Name = "txtCusEmail";
            this.txtCusEmail.Size = new System.Drawing.Size(250, 28);
            this.txtCusEmail.TabIndex = 53;
            // 
            // txtCusNum
            // 
            this.txtCusNum.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtCusNum.Location = new System.Drawing.Point(25, 381);
            this.txtCusNum.Name = "txtCusNum";
            this.txtCusNum.Size = new System.Drawing.Size(250, 28);
            this.txtCusNum.TabIndex = 52;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(21, 424);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 21);
            this.label6.TabIndex = 51;
            this.label6.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(21, 357);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 21);
            this.label5.TabIndex = 50;
            this.label5.Text = "Contact No.:";
            // 
            // txtCusAddress
            // 
            this.txtCusAddress.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtCusAddress.Location = new System.Drawing.Point(25, 317);
            this.txtCusAddress.Name = "txtCusAddress";
            this.txtCusAddress.Size = new System.Drawing.Size(250, 28);
            this.txtCusAddress.TabIndex = 49;
            // 
            // txtCusName
            // 
            this.txtCusName.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtCusName.Location = new System.Drawing.Point(25, 250);
            this.txtCusName.Name = "txtCusName";
            this.txtCusName.Size = new System.Drawing.Size(250, 28);
            this.txtCusName.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(21, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 21);
            this.label4.TabIndex = 47;
            this.label4.Text = "Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(21, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 21);
            this.label3.TabIndex = 46;
            this.label3.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(32, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 23);
            this.label1.TabIndex = 41;
            this.label1.Text = "Customers Information";
            // 
            // btnSaveUpdate
            // 
            this.btnSaveUpdate.FlatAppearance.BorderColor = System.Drawing.Color.YellowGreen;
            this.btnSaveUpdate.FlatAppearance.BorderSize = 2;
            this.btnSaveUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveUpdate.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnSaveUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSaveUpdate.Location = new System.Drawing.Point(52, 515);
            this.btnSaveUpdate.Name = "btnSaveUpdate";
            this.btnSaveUpdate.Size = new System.Drawing.Size(90, 31);
            this.btnSaveUpdate.TabIndex = 58;
            this.btnSaveUpdate.Text = "Save";
            this.btnSaveUpdate.UseVisualStyleBackColor = true;
            this.btnSaveUpdate.Click += new System.EventHandler(this.btnSaveUpdate_Click);
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnActUpdate);
            this.Controls.Add(this.dgvCustomer);
            this.Controls.Add(this.btnActAdd);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Customer";
            this.Size = new System.Drawing.Size(1184, 750);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.Button btnActAdd;
        private System.Windows.Forms.Button btnActUpdate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCusAddress;
        private System.Windows.Forms.TextBox txtCusName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCusEmail;
        private System.Windows.Forms.TextBox txtCusNum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSaveAdd;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSaveUpdate;
    }
}
