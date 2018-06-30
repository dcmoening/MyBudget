namespace MyBudget
{
    partial class MoneyReceivedEntry
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
            this.lbl_label1 = new System.Windows.Forms.Label();
            this.txt_TransactionAmt = new System.Windows.Forms.TextBox();
            this.lbl_label2 = new System.Windows.Forms.Label();
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.cmbo_BudgetName = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbl_label1
            // 
            this.lbl_label1.AutoSize = true;
            this.lbl_label1.Location = new System.Drawing.Point(5, 17);
            this.lbl_label1.Name = "lbl_label1";
            this.lbl_label1.Size = new System.Drawing.Size(72, 13);
            this.lbl_label1.TabIndex = 0;
            this.lbl_label1.Text = "Budget Name";
            // 
            // txt_TransactionAmt
            // 
            this.txt_TransactionAmt.Location = new System.Drawing.Point(83, 40);
            this.txt_TransactionAmt.Name = "txt_TransactionAmt";
            this.txt_TransactionAmt.Size = new System.Drawing.Size(163, 20);
            this.txt_TransactionAmt.TabIndex = 3;
            // 
            // lbl_label2
            // 
            this.lbl_label2.AutoSize = true;
            this.lbl_label2.Location = new System.Drawing.Point(52, 43);
            this.lbl_label2.Name = "lbl_label2";
            this.lbl_label2.Size = new System.Drawing.Size(25, 13);
            this.lbl_label2.TabIndex = 2;
            this.lbl_label2.Text = "Amt";
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(83, 76);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 33);
            this.btn_OK.TabIndex = 4;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(173, 76);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 33);
            this.btn_Cancel.TabIndex = 5;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // cmbo_BudgetName
            // 
            this.cmbo_BudgetName.AllowDrop = true;
            this.cmbo_BudgetName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbo_BudgetName.FormattingEnabled = true;
            this.cmbo_BudgetName.Location = new System.Drawing.Point(83, 14);
            this.cmbo_BudgetName.Name = "cmbo_BudgetName";
            this.cmbo_BudgetName.Size = new System.Drawing.Size(163, 21);
            this.cmbo_BudgetName.TabIndex = 6;
            // 
            // MoneyReceivedEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 121);
            this.Controls.Add(this.cmbo_BudgetName);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.txt_TransactionAmt);
            this.Controls.Add(this.lbl_label2);
            this.Controls.Add(this.lbl_label1);
            this.Name = "MoneyReceivedEntry";
            this.Text = "Money Received Entry";
            this.Load += new System.EventHandler(this.MoneyReceivedEntry_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_label1;
        private System.Windows.Forms.TextBox txt_TransactionAmt;
        private System.Windows.Forms.Label lbl_label2;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.ComboBox cmbo_BudgetName;
    }
}