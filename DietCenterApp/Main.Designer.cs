namespace DietCenterApp
{
    partial class Main
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
            this.ucLogin1 = new DietCenterApp.UCLogin();
            this.SuspendLayout();
            // 
            // ucLogin1
            // 
            this.ucLogin1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ucLogin1.Location = new System.Drawing.Point(-2, 0);
            this.ucLogin1.Margin = new System.Windows.Forms.Padding(5);
            this.ucLogin1.Name = "ucLogin1";
            this.ucLogin1.Size = new System.Drawing.Size(357, 537);
            this.ucLogin1.TabIndex = 0;
            this.ucLogin1.ValidLogin += new System.EventHandler(this.ucLogin1_ValidLogin);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(351, 537);
            this.Controls.Add(this.ucLogin1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Diet Center";
            this.ResumeLayout(false);

        }

        #endregion

        private UCLogin ucLogin1;
    }
}

