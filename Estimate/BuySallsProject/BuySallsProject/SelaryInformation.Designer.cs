namespace BuySallsProject
{
    partial class SelaryInformation
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSelaryId = new System.Windows.Forms.TextBox();
            this.cbxEmployName = new System.Windows.Forms.ComboBox();
            this.dtpSelaryDate = new System.Windows.Forms.DateTimePicker();
            this.cbxDepartment = new System.Windows.Forms.ComboBox();
            this.txtAmmount = new System.Windows.Forms.TextBox();
            this.btnSelarySave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selary Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Employ Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(146, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Selary Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(146, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Department";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(146, 344);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ammount";
            // 
            // txtSelaryId
            // 
            this.txtSelaryId.Location = new System.Drawing.Point(258, 98);
            this.txtSelaryId.Name = "txtSelaryId";
            this.txtSelaryId.Size = new System.Drawing.Size(251, 22);
            this.txtSelaryId.TabIndex = 5;
            // 
            // cbxEmployName
            // 
            this.cbxEmployName.FormattingEnabled = true;
            this.cbxEmployName.Location = new System.Drawing.Point(258, 161);
            this.cbxEmployName.Name = "cbxEmployName";
            this.cbxEmployName.Size = new System.Drawing.Size(251, 24);
            this.cbxEmployName.TabIndex = 6;
            // 
            // dtpSelaryDate
            // 
            this.dtpSelaryDate.Location = new System.Drawing.Point(258, 222);
            this.dtpSelaryDate.Name = "dtpSelaryDate";
            this.dtpSelaryDate.Size = new System.Drawing.Size(251, 22);
            this.dtpSelaryDate.TabIndex = 7;
            // 
            // cbxDepartment
            // 
            this.cbxDepartment.FormattingEnabled = true;
            this.cbxDepartment.Location = new System.Drawing.Point(258, 285);
            this.cbxDepartment.Name = "cbxDepartment";
            this.cbxDepartment.Size = new System.Drawing.Size(251, 24);
            this.cbxDepartment.TabIndex = 8;
            // 
            // txtAmmount
            // 
            this.txtAmmount.Location = new System.Drawing.Point(258, 341);
            this.txtAmmount.Name = "txtAmmount";
            this.txtAmmount.Size = new System.Drawing.Size(251, 22);
            this.txtAmmount.TabIndex = 9;
            // 
            // btnSelarySave
            // 
            this.btnSelarySave.Location = new System.Drawing.Point(283, 410);
            this.btnSelarySave.Name = "btnSelarySave";
            this.btnSelarySave.Size = new System.Drawing.Size(126, 55);
            this.btnSelarySave.TabIndex = 10;
            this.btnSelarySave.Text = "Save";
            this.btnSelarySave.UseVisualStyleBackColor = true;
            this.btnSelarySave.Click += new System.EventHandler(this.btnSelarySave_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(451, 410);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(89, 55);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(149, 410);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(89, 55);
            this.btnReload.TabIndex = 12;
            this.btnReload.Text = "New";
            this.btnReload.UseVisualStyleBackColor = true;
            // 
            // SelaryInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 506);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSelarySave);
            this.Controls.Add(this.txtAmmount);
            this.Controls.Add(this.cbxDepartment);
            this.Controls.Add(this.dtpSelaryDate);
            this.Controls.Add(this.cbxEmployName);
            this.Controls.Add(this.txtSelaryId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SelaryInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SelaryInformation";
            this.Load += new System.EventHandler(this.SelaryInformation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSelaryId;
        private System.Windows.Forms.ComboBox cbxEmployName;
        private System.Windows.Forms.DateTimePicker dtpSelaryDate;
        private System.Windows.Forms.ComboBox cbxDepartment;
        private System.Windows.Forms.TextBox txtAmmount;
        private System.Windows.Forms.Button btnSelarySave;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReload;
    }
}