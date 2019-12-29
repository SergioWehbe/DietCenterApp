namespace DietCenterApp.UserControls.Chef
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
            this.lblSearch = new System.Windows.Forms.Label();
            this.tbRecipeSearch = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ucEditRecipe1 = new DietCenterApp.UserControls.Chef.UCEditRecipe();
            this.ucAddRecipe1 = new DietCenterApp.UserControls.Chef.UCAddRecipe();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecipes)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvRecipes
            // 
            this.dgvRecipes.AllowUserToOrderColumns = true;
            this.dgvRecipes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRecipes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecipes.Location = new System.Drawing.Point(67, 167);
            this.dgvRecipes.Margin = new System.Windows.Forms.Padding(4);
            this.dgvRecipes.Name = "dgvRecipes";
            this.dgvRecipes.RowHeadersWidth = 51;
            this.dgvRecipes.Size = new System.Drawing.Size(526, 500);
            this.dgvRecipes.TabIndex = 2;
            this.dgvRecipes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRecipes_CellDoubleClick);
            this.dgvRecipes.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgvRecipes_UserDeletingRow);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(432, 131);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(117, 28);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(35, 111);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(53, 17);
            this.lblSearch.TabIndex = 1;
            this.lblSearch.Text = "Search";
            // 
            // tbRecipeSearch
            // 
            this.tbRecipeSearch.Location = new System.Drawing.Point(132, 107);
            this.tbRecipeSearch.Margin = new System.Windows.Forms.Padding(4);
            this.tbRecipeSearch.Name = "tbRecipeSearch";
            this.tbRecipeSearch.Size = new System.Drawing.Size(298, 22);
            this.tbRecipeSearch.TabIndex = 0;
            this.tbRecipeSearch.TextChanged += new System.EventHandler(this.tbRecipeSearch_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(347, 41);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(169, 37);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add Recipe";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.tbRecipeSearch);
            this.panel1.Controls.Add(this.lblSearch);
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Controls.Add(this.dgvRecipes);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1312, 846);
            this.panel1.TabIndex = 34;
            // 
            // ucEditRecipe1
            // 
            this.ucEditRecipe1.Location = new System.Drawing.Point(0, 0);
            this.ucEditRecipe1.Margin = new System.Windows.Forms.Padding(5);
            this.ucEditRecipe1.Name = "ucEditRecipe1";
            this.ucEditRecipe1.Size = new System.Drawing.Size(1312, 846);
            this.ucEditRecipe1.TabIndex = 4;
            this.ucEditRecipe1.CanceledRecipe += new System.EventHandler(this.UCEditRecipe1_CanceledRecipe);
            this.ucEditRecipe1.SavedRecipe += new System.EventHandler(this.UCEditRecipe1_SavedRecipe);
            this.ucEditRecipe1.BackToRecipesPressed += new System.EventHandler(this.OnBackToRecipes);
            // 
            // ucAddRecipe1
            // 
            this.ucAddRecipe1.Location = new System.Drawing.Point(0, 0);
            this.ucAddRecipe1.Margin = new System.Windows.Forms.Padding(5);
            this.ucAddRecipe1.Name = "ucAddRecipe1";
            this.ucAddRecipe1.Size = new System.Drawing.Size(1312, 846);
            this.ucAddRecipe1.TabIndex = 3;
            this.ucAddRecipe1.CanceledRecipe += new System.EventHandler(this.OnBackToRecipes);
            this.ucAddRecipe1.AddedRecipe += new System.EventHandler(this.UCAddRecipe1_AddedRecipe);
            // 
            // UCRecipes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ucEditRecipe1);
            this.Controls.Add(this.ucAddRecipe1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UCRecipes";
            this.Size = new System.Drawing.Size(1312, 846);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecipes)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvRecipes;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox tbRecipeSearch;
        private System.Windows.Forms.Button btnAdd;
        private UCAddRecipe ucAddRecipe1;
        private UCEditRecipe ucEditRecipe1;
        private System.Windows.Forms.Panel panel1;
    }
}
