namespace DietCenterApp.UserControls.Manager
{
    partial class Employees
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
            this.tbEmployeeSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // tbEmployeeSearch
            // 
            this.tbEmployeeSearch.Location = new System.Drawing.Point(60, 74);
            this.tbEmployeeSearch.Name = "tbEmployeeSearch";
            this.tbEmployeeSearch.Size = new System.Drawing.Size(224, 20);
            this.tbEmployeeSearch.TabIndex = 8;
            this.tbEmployeeSearch.TextChanged += new System.EventHandler(this.tbEmployeeSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblSearch.Font = new System.Drawing.Font("Elephant", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.Color.White;
            this.lblSearch.Location = new System.Drawing.Point(12, 74);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(46, 14);
            this.lblSearch.TabIndex = 9;
            this.lblSearch.Text = "Search";
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.BackColor = System.Drawing.Color.LimeGreen;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(416, 417);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(88, 23);
            this.btnNext.TabIndex = 10;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.AllowUserToAddRows = false;
            this.dgvEmployees.AllowUserToOrderColumns = true;
            this.dgvEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployees.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Location = new System.Drawing.Point(10, 98);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.ReadOnly = true;
            this.dgvEmployees.RowHeadersWidth = 51;
            this.dgvEmployees.Size = new System.Drawing.Size(494, 312);
            this.dgvEmployees.TabIndex = 11;
            this.dgvEmployees.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgvEmployees_UserDeletingRow);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(8, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 24);
            this.label1.TabIndex = 99;
            this.label1.Text = "> Employees > CheckEmployees";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(513, 456);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbEmployeeSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.dgvEmployees);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Employees";
            this.Text = "Employees";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbEmployeeSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.Label label1;
    }
}