namespace DietCenterApp.UserControls.Chef
{
    partial class EditRecipe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditRecipe));
            this.btnRemoveImage = new System.Windows.Forms.Button();
            this.btnChangeImage = new System.Windows.Forms.Button();
            this.pbRecipe = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.tbDecription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbRecipe)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRemoveImage
            // 
            this.btnRemoveImage.BackColor = System.Drawing.Color.Transparent;
            this.btnRemoveImage.FlatAppearance.BorderSize = 0;
            this.btnRemoveImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveImage.ForeColor = System.Drawing.Color.Black;
            this.btnRemoveImage.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveImage.Image")));
            this.btnRemoveImage.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemoveImage.Location = new System.Drawing.Point(162, 256);
            this.btnRemoveImage.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemoveImage.Name = "btnRemoveImage";
            this.btnRemoveImage.Size = new System.Drawing.Size(38, 57);
            this.btnRemoveImage.TabIndex = 31;
            this.btnRemoveImage.UseVisualStyleBackColor = false;
            this.btnRemoveImage.Click += new System.EventHandler(this.btnRemoveImage_Click);
            // 
            // btnChangeImage
            // 
            this.btnChangeImage.BackColor = System.Drawing.Color.Transparent;
            this.btnChangeImage.FlatAppearance.BorderSize = 0;
            this.btnChangeImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeImage.ForeColor = System.Drawing.Color.White;
            this.btnChangeImage.Image = ((System.Drawing.Image)(resources.GetObject("btnChangeImage.Image")));
            this.btnChangeImage.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChangeImage.Location = new System.Drawing.Point(13, 256);
            this.btnChangeImage.Margin = new System.Windows.Forms.Padding(4);
            this.btnChangeImage.Name = "btnChangeImage";
            this.btnChangeImage.Size = new System.Drawing.Size(40, 57);
            this.btnChangeImage.TabIndex = 32;
            this.btnChangeImage.UseVisualStyleBackColor = false;
            this.btnChangeImage.Click += new System.EventHandler(this.btnChangeImage_Click);
            // 
            // pbRecipe
            // 
            this.pbRecipe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbRecipe.Location = new System.Drawing.Point(13, 39);
            this.pbRecipe.Margin = new System.Windows.Forms.Padding(4);
            this.pbRecipe.Name = "pbRecipe";
            this.pbRecipe.Size = new System.Drawing.Size(187, 209);
            this.pbRecipe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRecipe.TabIndex = 33;
            this.pbRecipe.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.Location = new System.Drawing.Point(518, 485);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(133, 37);
            this.btnSave.TabIndex = 34;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.Location = new System.Drawing.Point(377, 485);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(133, 37);
            this.btnCancel.TabIndex = 35;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(273, 152);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 29);
            this.label2.TabIndex = 51;
            this.label2.Text = "Price";
            // 
            // tbPrice
            // 
            this.tbPrice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.tbPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrice.Location = new System.Drawing.Point(277, 185);
            this.tbPrice.Margin = new System.Windows.Forms.Padding(4);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(94, 27);
            this.tbPrice.TabIndex = 50;
            // 
            // tbName
            // 
            this.tbName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(277, 85);
            this.tbName.Margin = new System.Windows.Forms.Padding(4);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(293, 27);
            this.tbName.TabIndex = 47;
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(273, 52);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(78, 29);
            this.lblName.TabIndex = 46;
            this.lblName.Text = "Name";
            // 
            // tbDecription
            // 
            this.tbDecription.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbDecription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.tbDecription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDecription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDecription.Location = new System.Drawing.Point(278, 281);
            this.tbDecription.Margin = new System.Windows.Forms.Padding(4);
            this.tbDecription.Multiline = true;
            this.tbDecription.Name = "tbDecription";
            this.tbDecription.Size = new System.Drawing.Size(374, 170);
            this.tbDecription.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(273, 248);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 29);
            this.label1.TabIndex = 48;
            this.label1.Text = "Description";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel1.Location = new System.Drawing.Point(277, 214);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(94, 2);
            this.panel1.TabIndex = 52;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel2.Location = new System.Drawing.Point(277, 119);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(293, 2);
            this.panel2.TabIndex = 53;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel3.Location = new System.Drawing.Point(269, 281);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(2, 170);
            this.panel3.TabIndex = 53;
            // 
            // EditRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.tbDecription);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnChangeImage);
            this.Controls.Add(this.btnRemoveImage);
            this.Controls.Add(this.pbRecipe);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EditRecipe";
            this.Text = "EditRecipe";
            ((System.ComponentModel.ISupportInitialize)(this.pbRecipe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnRemoveImage;
        public System.Windows.Forms.Button btnChangeImage;
        public System.Windows.Forms.PictureBox pbRecipe;
        public System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox tbPrice;
        public System.Windows.Forms.TextBox tbName;
        public System.Windows.Forms.Label lblName;
        public System.Windows.Forms.TextBox tbDecription;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}