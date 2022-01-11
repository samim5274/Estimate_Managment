namespace BuySallsProject
{
    partial class SellsInfo
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
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtWuantity = new System.Windows.Forms.TextBox();
            this.dtpSalesDate = new System.Windows.Forms.DateTimePicker();
            this.cbxCustomarId = new System.Windows.Forms.ComboBox();
            this.cbxCatagory = new System.Windows.Forms.ComboBox();
            this.cbxItemName = new System.Windows.Forms.ComboBox();
            this.btnSell = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(153, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 17);
            this.label7.TabIndex = 20;
            this.label7.Text = "ItemName";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(163, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "Quantity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(159, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Category";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(149, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "CusomerId";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(158, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "SaleDate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "UnitPrice";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(205, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Id";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(280, 76);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(246, 22);
            this.txtId.TabIndex = 21;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(280, 255);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(246, 22);
            this.txtPrice.TabIndex = 22;
            // 
            // txtWuantity
            // 
            this.txtWuantity.Location = new System.Drawing.Point(280, 288);
            this.txtWuantity.Name = "txtWuantity";
            this.txtWuantity.Size = new System.Drawing.Size(246, 22);
            this.txtWuantity.TabIndex = 23;
            // 
            // dtpSalesDate
            // 
            this.dtpSalesDate.Location = new System.Drawing.Point(280, 108);
            this.dtpSalesDate.Name = "dtpSalesDate";
            this.dtpSalesDate.Size = new System.Drawing.Size(246, 22);
            this.dtpSalesDate.TabIndex = 24;
            // 
            // cbxCustomarId
            // 
            this.cbxCustomarId.FormattingEnabled = true;
            this.cbxCustomarId.Location = new System.Drawing.Point(280, 143);
            this.cbxCustomarId.Name = "cbxCustomarId";
            this.cbxCustomarId.Size = new System.Drawing.Size(246, 24);
            this.cbxCustomarId.TabIndex = 25;
            // 
            // cbxCatagory
            // 
            this.cbxCatagory.FormattingEnabled = true;
            this.cbxCatagory.Location = new System.Drawing.Point(280, 180);
            this.cbxCatagory.Name = "cbxCatagory";
            this.cbxCatagory.Size = new System.Drawing.Size(246, 24);
            this.cbxCatagory.TabIndex = 26;
            this.cbxCatagory.SelectedIndexChanged += new System.EventHandler(this.cbxCatagory_SelectedIndexChanged);
            // 
            // cbxItemName
            // 
            this.cbxItemName.FormattingEnabled = true;
            this.cbxItemName.Location = new System.Drawing.Point(280, 219);
            this.cbxItemName.Name = "cbxItemName";
            this.cbxItemName.Size = new System.Drawing.Size(246, 24);
            this.cbxItemName.TabIndex = 27;
            // 
            // btnSell
            // 
            this.btnSell.Location = new System.Drawing.Point(296, 333);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(90, 47);
            this.btnSell.TabIndex = 28;
            this.btnSell.Text = "Sells";
            this.btnSell.UseVisualStyleBackColor = true;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(392, 333);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(90, 47);
            this.btnExit.TabIndex = 29;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // SellsInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 495);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSell);
            this.Controls.Add(this.cbxItemName);
            this.Controls.Add(this.cbxCatagory);
            this.Controls.Add(this.cbxCustomarId);
            this.Controls.Add(this.dtpSalesDate);
            this.Controls.Add(this.txtWuantity);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SellsInfo";
            this.Text = "SellsInfo";
            this.Load += new System.EventHandler(this.SellsInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtWuantity;
        private System.Windows.Forms.DateTimePicker dtpSalesDate;
        private System.Windows.Forms.ComboBox cbxCustomarId;
        private System.Windows.Forms.ComboBox cbxCatagory;
        private System.Windows.Forms.ComboBox cbxItemName;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.Button btnExit;
    }
}