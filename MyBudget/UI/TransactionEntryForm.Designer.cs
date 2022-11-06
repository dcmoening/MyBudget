namespace MyBudget
{
    partial class TransactionEntryForm
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
            this.transactionAmountTextBox = new System.Windows.Forms.TextBox();
            this.lbl_label2 = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.budgetNameComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbl_label1
            // 
            this.lbl_label1.AutoSize = true;
            this.lbl_label1.Location = new System.Drawing.Point(7, 21);
            this.lbl_label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_label1.Name = "lbl_label1";
            this.lbl_label1.Size = new System.Drawing.Size(94, 17);
            this.lbl_label1.TabIndex = 0;
            this.lbl_label1.Text = "Budget Name";
            // 
            // transactionAmountTextBox
            // 
            this.transactionAmountTextBox.Location = new System.Drawing.Point(111, 49);
            this.transactionAmountTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.transactionAmountTextBox.Name = "transactionAmountTextBox";
            this.transactionAmountTextBox.Size = new System.Drawing.Size(216, 22);
            this.transactionAmountTextBox.TabIndex = 3;
            this.transactionAmountTextBox.TextChanged += new System.EventHandler(this.txt_TransactionAmt_TextChanged);
            // 
            // lbl_label2
            // 
            this.lbl_label2.AutoSize = true;
            this.lbl_label2.Location = new System.Drawing.Point(69, 53);
            this.lbl_label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_label2.Name = "lbl_label2";
            this.lbl_label2.Size = new System.Drawing.Size(32, 17);
            this.lbl_label2.TabIndex = 2;
            this.lbl_label2.Text = "Amt";
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(111, 94);
            this.okButton.Margin = new System.Windows.Forms.Padding(4);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(100, 41);
            this.okButton.TabIndex = 4;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(231, 94);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(100, 41);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // budgetNameComboBox
            // 
            this.budgetNameComboBox.AllowDrop = true;
            this.budgetNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.budgetNameComboBox.FormattingEnabled = true;
            this.budgetNameComboBox.Location = new System.Drawing.Point(111, 17);
            this.budgetNameComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.budgetNameComboBox.Name = "budgetNameComboBox";
            this.budgetNameComboBox.Size = new System.Drawing.Size(216, 24);
            this.budgetNameComboBox.TabIndex = 6;
            // 
            // TransactionEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 149);
            this.Controls.Add(this.budgetNameComboBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.transactionAmountTextBox);
            this.Controls.Add(this.lbl_label2);
            this.Controls.Add(this.lbl_label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TransactionEntryForm";
            this.Text = "Transaction Entry";
            this.VisibleChanged += new System.EventHandler(this.TransactionEntryForm_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_label1;
        private System.Windows.Forms.TextBox transactionAmountTextBox;
        private System.Windows.Forms.Label lbl_label2;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ComboBox budgetNameComboBox;
    }
}