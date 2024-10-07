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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnActAdd = new System.Windows.Forms.Button();
            this.btnActUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(34, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 23);
            this.label2.TabIndex = 14;
            this.label2.Text = "List of Customers";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 95);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1122, 621);
            this.dataGridView1.TabIndex = 15;
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
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.btnActUpdate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnActAdd);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Customer";
            this.Size = new System.Drawing.Size(1184, 750);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnActAdd;
        private System.Windows.Forms.Button btnActUpdate;
    }
}
