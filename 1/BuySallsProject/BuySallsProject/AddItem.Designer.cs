namespace BuySallsProject
{
    partial class AddItem
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
            this.label6 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.dtpExpDate = new System.Windows.Forms.DateTimePicker();
            this.dtpMgfDate = new System.Windows.Forms.DateTimePicker();
            this.cbxCatagory = new System.Windows.Forms.ComboBox();
            this.txtBuyPrice = new System.Windows.Forms.TextBox();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCatagoryAdd = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Item Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Catagory";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(107, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Exp.Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(107, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mgf.Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(104, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Buy Price";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(244, 53);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(243, 22);
            this.txtId.TabIndex = 6;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(244, 98);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(243, 22);
            this.txtName.TabIndex = 7;
            // 
            // dtpExpDate
            // 
            this.dtpExpDate.Location = new System.Drawing.Point(244, 197);
            this.dtpExpDate.Name = "dtpExpDate";
            this.dtpExpDate.Size = new System.Drawing.Size(243, 22);
            this.dtpExpDate.TabIndex = 8;
            // 
            // dtpMgfDate
            // 
            this.dtpMgfDate.Location = new System.Drawing.Point(244, 248);
            this.dtpMgfDate.Name = "dtpMgfDate";
            this.dtpMgfDate.Size = new System.Drawing.Size(243, 22);
            this.dtpMgfDate.TabIndex = 9;
            // 
            // cbxCatagory
            // 
            this.cbxCatagory.FormattingEnabled = true;
            this.cbxCatagory.Location = new System.Drawing.Point(244, 150);
            this.cbxCatagory.Name = "cbxCatagory";
            this.cbxCatagory.Size = new System.Drawing.Size(201, 24);
            this.cbxCatagory.TabIndex = 10;
            // 
            // txtBuyPrice
            // 
            this.txtBuyPrice.Location = new System.Drawing.Point(244, 302);
            this.txtBuyPrice.Name = "txtBuyPrice";
            this.txtBuyPrice.Size = new System.Drawing.Size(243, 22);
            this.txtBuyPrice.TabIndex = 11;
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(253, 356);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(124, 46);
            this.btnAddItem.TabIndex = 12;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(383, 356);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(104, 46);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCatagoryAdd
            // 
            this.btnCatagoryAdd.Location = new System.Drawing.Point(451, 150);
            this.btnCatagoryAdd.Name = "btnCatagoryAdd";
            this.btnCatagoryAdd.Size = new System.Drawing.Size(36, 24);
            this.btnCatagoryAdd.TabIndex = 14;
            this.btnCatagoryAdd.Text = "+";
            this.btnCatagoryAdd.UseVisualStyleBackColor = true;
            this.btnCatagoryAdd.Click += new System.EventHandler(this.btnCatagoryAdd_Click);
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(143, 356);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(104, 46);
            this.btnReload.TabIndex = 15;
            this.btnReload.Text = "Reseat Page";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // AddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 450);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnCatagoryAdd);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.txtBuyPrice);
            this.Controls.Add(this.cbxCatagory);
            this.Controls.Add(this.dtpMgfDate);
            this.Controls.Add(this.dtpExpDate);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AddItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddItem";
            this.Load += new System.EventHandler(this.AddItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DateTimePicker dtpExpDate;
        private System.Windows.Forms.DateTimePicker dtpMgfDate;
        private System.Windows.Forms.ComboBox cbxCatagory;
        private System.Windows.Forms.TextBox txtBuyPrice;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCatagoryAdd;
        private System.Windows.Forms.Button btnReload;
    }
}