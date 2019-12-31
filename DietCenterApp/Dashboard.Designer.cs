namespace DietCenterApp
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panelClientsSubMenu = new System.Windows.Forms.Panel();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.btnCheckClients = new System.Windows.Forms.Button();
            this.btnClients = new System.Windows.Forms.Button();
            this.panelEmpSubMenu = new System.Windows.Forms.Panel();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.btnCheckEmployees = new System.Windows.Forms.Button();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.panelRecipeSubMenu = new System.Windows.Forms.Panel();
            this.btnAddRecipe = new System.Windows.Forms.Button();
            this.btnCheckRecipes = new System.Windows.Forms.Button();
            this.btnRecipes = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panelSideMenu.SuspendLayout();
            this.panelClientsSubMenu.SuspendLayout();
            this.panelEmpSubMenu.SuspendLayout();
            this.panelRecipeSubMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panelSideMenu.Controls.Add(this.btnLogout);
            this.panelSideMenu.Controls.Add(this.panelClientsSubMenu);
            this.panelSideMenu.Controls.Add(this.btnClients);
            this.panelSideMenu.Controls.Add(this.panelEmpSubMenu);
            this.panelSideMenu.Controls.Add(this.btnEmployees);
            this.panelSideMenu.Controls.Add(this.panelRecipeSubMenu);
            this.panelSideMenu.Controls.Add(this.btnRecipes);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(250, 561);
            this.panelSideMenu.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.Silver;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 516);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(250, 45);
            this.btnLogout.TabIndex = 9;
            this.btnLogout.Text = "  Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panelClientsSubMenu
            // 
            this.panelClientsSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.panelClientsSubMenu.Controls.Add(this.btnAddClient);
            this.panelClientsSubMenu.Controls.Add(this.btnCheckClients);
            this.panelClientsSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelClientsSubMenu.Location = new System.Drawing.Point(0, 382);
            this.panelClientsSubMenu.Name = "panelClientsSubMenu";
            this.panelClientsSubMenu.Size = new System.Drawing.Size(250, 87);
            this.panelClientsSubMenu.TabIndex = 7;
            // 
            // btnAddClient
            // 
            this.btnAddClient.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddClient.FlatAppearance.BorderSize = 0;
            this.btnAddClient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnAddClient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.btnAddClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddClient.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddClient.ForeColor = System.Drawing.Color.Silver;
            this.btnAddClient.Location = new System.Drawing.Point(0, 40);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnAddClient.Size = new System.Drawing.Size(250, 40);
            this.btnAddClient.TabIndex = 1;
            this.btnAddClient.Text = "Add Client";
            this.btnAddClient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddClient.UseVisualStyleBackColor = true;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // btnCheckClients
            // 
            this.btnCheckClients.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCheckClients.FlatAppearance.BorderSize = 0;
            this.btnCheckClients.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnCheckClients.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.btnCheckClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckClients.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckClients.ForeColor = System.Drawing.Color.Silver;
            this.btnCheckClients.Location = new System.Drawing.Point(0, 0);
            this.btnCheckClients.Name = "btnCheckClients";
            this.btnCheckClients.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnCheckClients.Size = new System.Drawing.Size(250, 40);
            this.btnCheckClients.TabIndex = 0;
            this.btnCheckClients.Text = "Check Clients";
            this.btnCheckClients.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCheckClients.UseVisualStyleBackColor = true;
            this.btnCheckClients.Click += new System.EventHandler(this.btnCheckClients_Click);
            // 
            // btnClients
            // 
            this.btnClients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnClients.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClients.FlatAppearance.BorderSize = 0;
            this.btnClients.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnClients.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.btnClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClients.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClients.ForeColor = System.Drawing.Color.Silver;
            this.btnClients.Image = ((System.Drawing.Image)(resources.GetObject("btnClients.Image")));
            this.btnClients.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClients.Location = new System.Drawing.Point(0, 337);
            this.btnClients.Name = "btnClients";
            this.btnClients.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnClients.Size = new System.Drawing.Size(250, 45);
            this.btnClients.TabIndex = 6;
            this.btnClients.Text = "Clients";
            this.btnClients.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClients.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClients.UseVisualStyleBackColor = false;
            this.btnClients.Click += new System.EventHandler(this.btnClients_Click);
            // 
            // panelEmpSubMenu
            // 
            this.panelEmpSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.panelEmpSubMenu.Controls.Add(this.btnAddEmployee);
            this.panelEmpSubMenu.Controls.Add(this.btnCheckEmployees);
            this.panelEmpSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEmpSubMenu.Location = new System.Drawing.Point(0, 247);
            this.panelEmpSubMenu.Name = "panelEmpSubMenu";
            this.panelEmpSubMenu.Size = new System.Drawing.Size(250, 90);
            this.panelEmpSubMenu.TabIndex = 4;
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddEmployee.FlatAppearance.BorderSize = 0;
            this.btnAddEmployee.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnAddEmployee.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.btnAddEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEmployee.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEmployee.ForeColor = System.Drawing.Color.Silver;
            this.btnAddEmployee.Location = new System.Drawing.Point(0, 40);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnAddEmployee.Size = new System.Drawing.Size(250, 40);
            this.btnAddEmployee.TabIndex = 1;
            this.btnAddEmployee.Text = "Add Employee";
            this.btnAddEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // btnCheckEmployees
            // 
            this.btnCheckEmployees.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCheckEmployees.FlatAppearance.BorderSize = 0;
            this.btnCheckEmployees.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnCheckEmployees.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.btnCheckEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckEmployees.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckEmployees.ForeColor = System.Drawing.Color.Silver;
            this.btnCheckEmployees.Location = new System.Drawing.Point(0, 0);
            this.btnCheckEmployees.Name = "btnCheckEmployees";
            this.btnCheckEmployees.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnCheckEmployees.Size = new System.Drawing.Size(250, 40);
            this.btnCheckEmployees.TabIndex = 0;
            this.btnCheckEmployees.Text = "Check Employees";
            this.btnCheckEmployees.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCheckEmployees.UseVisualStyleBackColor = true;
            this.btnCheckEmployees.Click += new System.EventHandler(this.btnCheckEmployees_Click);
            // 
            // btnEmployees
            // 
            this.btnEmployees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnEmployees.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmployees.FlatAppearance.BorderSize = 0;
            this.btnEmployees.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnEmployees.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.btnEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployees.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployees.ForeColor = System.Drawing.Color.Silver;
            this.btnEmployees.Image = ((System.Drawing.Image)(resources.GetObject("btnEmployees.Image")));
            this.btnEmployees.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployees.Location = new System.Drawing.Point(0, 202);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnEmployees.Size = new System.Drawing.Size(250, 45);
            this.btnEmployees.TabIndex = 3;
            this.btnEmployees.Text = "Employees";
            this.btnEmployees.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployees.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEmployees.UseVisualStyleBackColor = false;
            this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click);
            // 
            // panelRecipeSubMenu
            // 
            this.panelRecipeSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.panelRecipeSubMenu.Controls.Add(this.btnAddRecipe);
            this.panelRecipeSubMenu.Controls.Add(this.btnCheckRecipes);
            this.panelRecipeSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRecipeSubMenu.Location = new System.Drawing.Point(0, 112);
            this.panelRecipeSubMenu.Name = "panelRecipeSubMenu";
            this.panelRecipeSubMenu.Size = new System.Drawing.Size(250, 90);
            this.panelRecipeSubMenu.TabIndex = 2;
            // 
            // btnAddRecipe
            // 
            this.btnAddRecipe.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddRecipe.FlatAppearance.BorderSize = 0;
            this.btnAddRecipe.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnAddRecipe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.btnAddRecipe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRecipe.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRecipe.ForeColor = System.Drawing.Color.Silver;
            this.btnAddRecipe.Location = new System.Drawing.Point(0, 40);
            this.btnAddRecipe.Name = "btnAddRecipe";
            this.btnAddRecipe.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnAddRecipe.Size = new System.Drawing.Size(250, 40);
            this.btnAddRecipe.TabIndex = 1;
            this.btnAddRecipe.Text = "Add Recipe";
            this.btnAddRecipe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddRecipe.UseVisualStyleBackColor = true;
            this.btnAddRecipe.Click += new System.EventHandler(this.btnAddRecipe_Click);
            // 
            // btnCheckRecipes
            // 
            this.btnCheckRecipes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCheckRecipes.FlatAppearance.BorderSize = 0;
            this.btnCheckRecipes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnCheckRecipes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.btnCheckRecipes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckRecipes.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckRecipes.ForeColor = System.Drawing.Color.Silver;
            this.btnCheckRecipes.Location = new System.Drawing.Point(0, 0);
            this.btnCheckRecipes.Name = "btnCheckRecipes";
            this.btnCheckRecipes.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnCheckRecipes.Size = new System.Drawing.Size(250, 40);
            this.btnCheckRecipes.TabIndex = 0;
            this.btnCheckRecipes.Text = "Check Recipes";
            this.btnCheckRecipes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCheckRecipes.UseVisualStyleBackColor = true;
            this.btnCheckRecipes.Click += new System.EventHandler(this.btnCheckRecipes_Click);
            // 
            // btnRecipes
            // 
            this.btnRecipes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnRecipes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRecipes.FlatAppearance.BorderSize = 0;
            this.btnRecipes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnRecipes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnRecipes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecipes.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecipes.ForeColor = System.Drawing.Color.Silver;
            this.btnRecipes.Image = ((System.Drawing.Image)(resources.GetObject("btnRecipes.Image")));
            this.btnRecipes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecipes.Location = new System.Drawing.Point(0, 67);
            this.btnRecipes.Name = "btnRecipes";
            this.btnRecipes.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnRecipes.Size = new System.Drawing.Size(250, 45);
            this.btnRecipes.TabIndex = 1;
            this.btnRecipes.Text = " Recipes";
            this.btnRecipes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecipes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRecipes.UseVisualStyleBackColor = false;
            this.btnRecipes.Click += new System.EventHandler(this.btnRecipes_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panelLogo.Controls.Add(this.label3);
            this.panelLogo.Controls.Add(this.label2);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(250, 67);
            this.panelLogo.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Montserrat Subrayada", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(96, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 30);
            this.label3.TabIndex = 40;
            this.label3.Text = "Center";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Montserrat Subrayada", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LimeGreen;
            this.label2.Location = new System.Drawing.Point(48, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 29);
            this.label2.TabIndex = 39;
            this.label2.Text = "Diet";
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(250, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(684, 561);
            this.panelChildForm.TabIndex = 2;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelSideMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panelSideMenu.ResumeLayout(false);
            this.panelClientsSubMenu.ResumeLayout(false);
            this.panelEmpSubMenu.ResumeLayout(false);
            this.panelRecipeSubMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelRecipeSubMenu;
        private System.Windows.Forms.Button btnAddRecipe;
        private System.Windows.Forms.Button btnCheckRecipes;
        private System.Windows.Forms.Button btnRecipes;
        private System.Windows.Forms.Panel panelClientsSubMenu;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.Button btnCheckClients;
        private System.Windows.Forms.Button btnClients;
        private System.Windows.Forms.Panel panelEmpSubMenu;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Button btnCheckEmployees;
        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

