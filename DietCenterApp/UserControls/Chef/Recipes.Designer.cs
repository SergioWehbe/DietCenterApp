namespace DietCenterApp.UserControls.Chef
{
    partial class Recipes
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
            this.tbRecipeSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.dgvRecipes = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecipes)).BeginInit();
            this.SuspendLayout();
            // 
            // tbRecipeSearch
            // 
            this.tbRecipeSearch.Location = new System.Drawing.Point(77, 65);
            this.tbRecipeSearch.Margin = new System.Windows.Forms.Padding(4);
            this.tbRecipeSearch.Name = "tbRecipeSearch";
            this.tbRecipeSearch.Size = new System.Drawing.Size(298, 22);
            this.tbRecipeSearch.TabIndex = 3;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Elephant", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.Color.White;
            this.lblSearch.Location = new System.Drawing.Point(13, 65);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(56, 18);
            this.lblSearch.TabIndex = 4;
            this.lblSearch.Text = "Search";
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.BackColor = System.Drawing.Color.White;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Location = new System.Drawing.Point(554, 513);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(117, 28);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // dgvRecipes
            // 
            this.dgvRecipes.AllowUserToOrderColumns = true;
            this.dgvRecipes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRecipes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRecipes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dgvRecipes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecipes.Location = new System.Drawing.Point(13, 95);
            this.dgvRecipes.Margin = new System.Windows.Forms.Padding(4);
            this.dgvRecipes.Name = "dgvRecipes";
            this.dgvRecipes.RowHeadersWidth = 51;
            this.dgvRecipes.Size = new System.Drawing.Size(658, 410);
            this.dgvRecipes.TabIndex = 7;
            this.dgvRecipes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRecipes_CellDoubleClick);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(684, 561);
            this.panel1.TabIndex = 8;
            // 
            // Recipes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.tbRecipeSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.dgvRecipes);
            this.Controls.Add(this.panel1);
            this.Name = "Recipes";
            this.Text = "Recipes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecipes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbRecipeSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.DataGridView dgvRecipes;
        public System.Windows.Forms.Panel panel1;
    }
}