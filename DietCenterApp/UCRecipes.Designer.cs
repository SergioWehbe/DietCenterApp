namespace DietCenterApp
{
    partial class UCRecipes
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
            this.dgvRecipes = new System.Windows.Forms.DataGridView();
            this.btnNext = new System.Windows.Forms.Button();
            this.ucEditRecipe1 = new DietCenterApp.UCEditRecipe();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbRecipeSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecipes)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvRecipes
            // 
            this.dgvRecipes.AllowUserToOrderColumns = true;
            this.dgvRecipes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRecipes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecipes.Location = new System.Drawing.Point(29, 136);
            this.dgvRecipes.Name = "dgvRecipes";
            this.dgvRecipes.Size = new System.Drawing.Size(928, 406);
            this.dgvRecipes.TabIndex = 1;
            this.dgvRecipes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRecipes_CellDoubleClick);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(864, 107);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // ucEditRecipe1
            // 
            this.ucEditRecipe1.Location = new System.Drawing.Point(3, -3);
            this.ucEditRecipe1.Name = "ucEditRecipe1";
            this.ucEditRecipe1.Size = new System.Drawing.Size(984, 562);
            this.ucEditRecipe1.TabIndex = 0;
            this.ucEditRecipe1.CanceledRecipe += new System.EventHandler(this.ucEditRecipe11_CanceledRecipe);
            this.ucEditRecipe1.SavedRecipe += new System.EventHandler(this.ucEditRecipe1e1_SavedRecipe);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblSearch);
            this.panel1.Controls.Add(this.tbRecipeSearch);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 562);
            this.panel1.TabIndex = 34;
            // 
            // tbRecipeSearch
            // 
            this.tbRecipeSearch.Location = new System.Drawing.Point(99, 87);
            this.tbRecipeSearch.Name = "tbRecipeSearch";
            this.tbRecipeSearch.Size = new System.Drawing.Size(212, 20);
            this.tbRecipeSearch.TabIndex = 0;
            this.tbRecipeSearch.TextChanged += new System.EventHandler(this.tbRecipeSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(26, 90);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(41, 13);
            this.lblSearch.TabIndex = 1;
            this.lblSearch.Text = "Search";
            // 
            // UCRecipes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.dgvRecipes);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ucEditRecipe1);
            this.Name = "UCRecipes";
            this.Size = new System.Drawing.Size(984, 562);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecipes)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvRecipes;
        private System.Windows.Forms.Button btnNext;
        private UCEditRecipe ucEditRecipe1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbRecipeSearch;
        private System.Windows.Forms.Label lblSearch;
    }
}
