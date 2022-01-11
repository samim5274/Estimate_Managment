namespace BuySallsProject
{
    partial class EmplyDepartment
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEDId = new System.Windows.Forms.TextBox();
            this.txtEDepartmentName = new System.Windows.Forms.TextBox();
            this.btnAddDepartment = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employ Department Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Employ Department Name";
            // 
            // txtEDId
            // 
            this.txtEDId.Location = new System.Drawing.Point(354, 117);
            this.txtEDId.Name = "txtEDId";
            this.txtEDId.Size = new System.Drawing.Size(269, 22);
            this.txtEDId.TabIndex = 2;
            // 
            // txtEDepartmentName
            // 
            this.txtEDepartmentName.Location = new System.Drawing.Point(354, 172);
            this.txtEDepartmentName.Name = "txtEDepartmentName";
            this.txtEDepartmentName.Size = new System.Drawing.Size(269, 22);
            this.txtEDepartmentName.TabIndex = 3;
            // 
            // btnAddDepartment
            // 
            this.btnAddDepartment.Location = new System.Drawing.Point(354, 220);
            this.btnAddDepartment.Name = "btnAddDepartment";
            this.btnAddDepartment.Size = new System.Drawing.Size(123, 63);
            this.btnAddDepartment.TabIndex = 4;
            this.btnAddDepartment.Text = "Save";
            this.btnAddDepartment.UseVisualStyleBackColor = true;
            this.btnAddDepartment.Click += new System.EventHandler(this.btnAddDepartment_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(500, 220);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(123, 63);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(214, 220);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(123, 63);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "New";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // EmployInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 380);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAddDepartment);
            this.Controls.Add(this.txtEDepartmentName);
            this.Controls.Add(this.txtEDId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EmployInformation";
            this.Text = "EmployInformation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEDId;
        private System.Windows.Forms.TextBox txtEDepartmentName;
        private System.Windows.Forms.Button btnAddDepartment;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReset;
    }
}