namespace BuySallsProject
{
    partial class Others
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.genaralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departmentInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salatryInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.genaralToolStripMenuItem,
            this.employToolStripMenuItem,
            this.salaryToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(818, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // genaralToolStripMenuItem
            // 
            this.genaralToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.departmentInfoToolStripMenuItem});
            this.genaralToolStripMenuItem.Name = "genaralToolStripMenuItem";
            this.genaralToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.genaralToolStripMenuItem.Text = "General";
            // 
            // departmentInfoToolStripMenuItem
            // 
            this.departmentInfoToolStripMenuItem.Name = "departmentInfoToolStripMenuItem";
            this.departmentInfoToolStripMenuItem.Size = new System.Drawing.Size(184, 24);
            this.departmentInfoToolStripMenuItem.Text = "DepartmentInfo";
            this.departmentInfoToolStripMenuItem.Click += new System.EventHandler(this.departmentInfoToolStripMenuItem_Click);
            // 
            // employToolStripMenuItem
            // 
            this.employToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employInfoToolStripMenuItem});
            this.employToolStripMenuItem.Name = "employToolStripMenuItem";
            this.employToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.employToolStripMenuItem.Text = "Employ";
            // 
            // employInfoToolStripMenuItem
            // 
            this.employInfoToolStripMenuItem.Name = "employInfoToolStripMenuItem";
            this.employInfoToolStripMenuItem.Size = new System.Drawing.Size(154, 24);
            this.employInfoToolStripMenuItem.Text = "EmployInfo";
            this.employInfoToolStripMenuItem.Click += new System.EventHandler(this.employInfoToolStripMenuItem_Click);
            // 
            // salaryToolStripMenuItem
            // 
            this.salaryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salatryInfoToolStripMenuItem});
            this.salaryToolStripMenuItem.Name = "salaryToolStripMenuItem";
            this.salaryToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.salaryToolStripMenuItem.Text = "Salary";
            // 
            // salatryInfoToolStripMenuItem
            // 
            this.salatryInfoToolStripMenuItem.Name = "salatryInfoToolStripMenuItem";
            this.salatryInfoToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.salatryInfoToolStripMenuItem.Text = "SalatryInfo";
            this.salatryInfoToolStripMenuItem.Click += new System.EventHandler(this.salatryInfoToolStripMenuItem_Click);
            // 
            // Others
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 480);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Others";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem genaralToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departmentInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salatryInfoToolStripMenuItem;
    }
}