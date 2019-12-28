namespace DietCenterApp.UserControls.Chef
{
    partial class UCEditRecipe
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
            this.btnRemoveImage = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnChangeImage = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.pbRecipe = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDecription = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPrice = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbRecipe)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRemoveImage
            // 
            this.btnRemoveImage.BackColor = System.Drawing.Color.Red;
            this.btnRemoveImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveImage.ForeColor = System.Drawing.Color.White;
            this.btnRemoveImage.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemoveImage.Location = new System.Drawing.Point(26, 17);
            this.btnRemoveImage.Name = "btnRemoveImage";
            this.btnRemoveImage.Size = new System.Drawing.Size(210, 46);
            this.btnRemoveImage.TabIndex = 30;
            this.btnRemoveImage.Text = "Remove Image";
            this.btnRemoveImage.UseVisualStyleBackColor = false;
            this.btnRemoveImage.Visible = false;
            this.btnRemoveImage.Click += new System.EventHandler(this.btnRemoveImage_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Brown;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.Location = new System.Drawing.Point(742, 17);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 30);
            this.btnCancel.TabIndex = 29;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Brown;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.Location = new System.Drawing.Point(579, 17);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 30);
            this.btnSave.TabIndex = 28;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnChangeImage
            // 
            this.btnChangeImage.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnChangeImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeImage.ForeColor = System.Drawing.Color.White;
            this.btnChangeImage.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChangeImage.Location = new System.Drawing.Point(350, 17);
            this.btnChangeImage.Name = "btnChangeImage";
            this.btnChangeImage.Size = new System.Drawing.Size(202, 46);
            this.btnChangeImage.TabIndex = 27;
            this.btnChangeImage.Text = "Change Image";
            this.btnChangeImage.UseVisualStyleBackColor = false;
            this.btnChangeImage.Visible = false;
            this.btnChangeImage.Click += new System.EventHandler(this.btnChangeImage_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.Location = new System.Drawing.Point(905, 17);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(58, 30);
            this.btnEdit.TabIndex = 26;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // tbName
            // 
            this.tbName.Enabled = false;
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(579, 183);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(384, 29);
            this.tbName.TabIndex = 25;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(575, 134);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(61, 24);
            this.lblName.TabIndex = 24;
            this.lblName.Text = "Name";
            // 
            // pbRecipe
            // 
            this.pbRecipe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbRecipe.Location = new System.Drawing.Point(0, 0);
            this.pbRecipe.Name = "pbRecipe";
            this.pbRecipe.Size = new System.Drawing.Size(550, 510);
            this.pbRecipe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRecipe.TabIndex = 23;
            this.pbRecipe.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(575, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 24);
            this.label1.TabIndex = 31;
            this.label1.Text = "Description";
            // 
            // tbDecription
            // 
            this.tbDecription.Enabled = false;
            this.tbDecription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDecription.Location = new System.Drawing.Point(579, 267);
            this.tbDecription.Multiline = true;
            this.tbDecription.Name = "tbDecription";
            this.tbDecription.Size = new System.Drawing.Size(384, 246);
            this.tbDecription.TabIndex = 32;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.tbPrice);
            this.panel1.Controls.Add(this.tbName);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 687);
            this.panel1.TabIndex = 33;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Brown;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBack.Location = new System.Drawing.Point(742, 17);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 30);
            this.btnBack.TabIndex = 34;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(575, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 24);
            this.label2.TabIndex = 45;
            this.label2.Text = "Price";
            // 
            // tbPrice
            // 
            this.tbPrice.Enabled = false;
            this.tbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrice.Location = new System.Drawing.Point(579, 90);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(384, 29);
            this.tbPrice.TabIndex = 44;
            // 
            // UCEditRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbDecription);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRemoveImage);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnChangeImage);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.pbRecipe);
            this.Controls.Add(this.panel1);
            this.Name = "UCEditRecipe";
            this.Size = new System.Drawing.Size(984, 687);
            ((System.ComponentModel.ISupportInitialize)(this.pbRecipe)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnRemoveImage;
        public System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.Button btnChangeImage;
        public System.Windows.Forms.Button btnEdit;
        public System.Windows.Forms.TextBox tbName;
        public System.Windows.Forms.Label lblName;
        public System.Windows.Forms.PictureBox pbRecipe;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox tbDecription;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button btnBack;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox tbPrice;
    }
}
