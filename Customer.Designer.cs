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
            this.addCustomer1 = new DBMS_CrashCourse.AddCustomer();
            this.updateCustomer1 = new DBMS_CrashCourse.UpdateCustomer();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(30, 96);
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
            this.dgvCustomer.Location = new System.Drawing.Point(34, 122);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.ReadOnly = true;
            this.dgvCustomer.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvCustomer.RowTemplate.Height = 24;
            this.dgvCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomer.Size = new System.Drawing.Size(1124, 589);
            this.dgvCustomer.TabIndex = 15;
            // 
            // btnActAdd
            // 
            this.btnActAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.btnActAdd.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.btnActAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActAdd.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActAdd.ForeColor = System.Drawing.Color.White;
            this.btnActAdd.Location = new System.Drawing.Point(1007, 85);
            this.btnActAdd.Name = "btnActAdd";
            this.btnActAdd.Size = new System.Drawing.Size(151, 34);
            this.btnActAdd.TabIndex = 2;
            this.btnActAdd.Text = "Add Customer";
            this.btnActAdd.UseVisualStyleBackColor = false;
            this.btnActAdd.Click += new System.EventHandler(this.btnActAdd_Click);
            // 
            // addCustomer1
            // 
            this.addCustomer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.addCustomer1.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.addCustomer1.ForeColor = System.Drawing.Color.White;
            this.addCustomer1.Location = new System.Drawing.Point(352, 122);
            this.addCustomer1.Margin = new System.Windows.Forms.Padding(4);
            this.addCustomer1.Name = "addCustomer1";
            this.addCustomer1.Size = new System.Drawing.Size(439, 502);
            this.addCustomer1.TabIndex = 17;
            // 
            // updateCustomer1
            // 
            this.updateCustomer1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.updateCustomer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.updateCustomer1.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.updateCustomer1.ForeColor = System.Drawing.Color.White;
            this.updateCustomer1.Location = new System.Drawing.Point(352, 122);
            this.updateCustomer1.Margin = new System.Windows.Forms.Padding(4);
            this.updateCustomer1.Name = "updateCustomer1";
            this.updateCustomer1.Size = new System.Drawing.Size(439, 502);
            this.updateCustomer1.TabIndex = 0;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(778, 37);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(380, 32);
            this.txtSearch.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(701, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 19);
            this.label1.TabIndex = 19;
            this.label1.Text = "Search:";
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.addCustomer1);
            this.Controls.Add(this.updateCustomer1);
            this.Controls.Add(this.dgvCustomer);
            this.Controls.Add(this.btnActAdd);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Customer";
            this.Size = new System.Drawing.Size(1184, 750);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.Button btnActAdd;
        private UpdateCustomer updateCustomer1;
        private AddCustomer addCustomer1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
    }
}
