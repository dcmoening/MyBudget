namespace MyBudget
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listView1 = new System.Windows.Forms.ListView();
            this.TransactionEntries = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TransactionEntryAmt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView2 = new System.Windows.Forms.ListView();
            this.BudgetName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.budgetAmt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView3 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_transAdd = new System.Windows.Forms.Button();
            this.btn_budgetAdd = new System.Windows.Forms.Button();
            this.btn_moneyreceivedAdd = new System.Windows.Forms.Button();
            this.btn_transMinus = new System.Windows.Forms.Button();
            this.btn_budgetMinus = new System.Windows.Forms.Button();
            this.btn_moneyreceivedMinus = new System.Windows.Forms.Button();
            this.btn_transModify = new System.Windows.Forms.Button();
            this.btn_BudgetModify = new System.Windows.Forms.Button();
            this.btn_moneyreceivedModify = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TransactionEntries,
            this.TransactionEntryAmt});
            this.listView1.Location = new System.Drawing.Point(12, 28);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(224, 534);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // TransactionEntries
            // 
            this.TransactionEntries.Text = "Name";
            this.TransactionEntries.Width = 169;
            // 
            // TransactionEntryAmt
            // 
            this.TransactionEntryAmt.Text = "Amt";
            this.TransactionEntryAmt.Width = 51;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.BudgetName,
            this.budgetAmt});
            this.listView2.Location = new System.Drawing.Point(787, 28);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(224, 225);
            this.listView2.TabIndex = 1;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // BudgetName
            // 
            this.BudgetName.Text = "Name";
            this.BudgetName.Width = 160;
            // 
            // budgetAmt
            // 
            this.budgetAmt.Text = "amt";
            // 
            // listView3
            // 
            this.listView3.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView3.Location = new System.Drawing.Point(787, 320);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(224, 242);
            this.listView3.TabIndex = 2;
            this.listView3.UseCompatibleStateImageBehavior = false;
            this.listView3.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 160;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "amt";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Transaction Entries";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(784, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = " Budget";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(784, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Money Received";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btn_transAdd
            // 
            this.btn_transAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_transAdd.BackgroundImage")));
            this.btn_transAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_transAdd.Location = new System.Drawing.Point(12, 568);
            this.btn_transAdd.Name = "btn_transAdd";
            this.btn_transAdd.Size = new System.Drawing.Size(32, 32);
            this.btn_transAdd.TabIndex = 6;
            this.btn_transAdd.UseVisualStyleBackColor = true;
            // 
            // btn_budgetAdd
            // 
            this.btn_budgetAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_budgetAdd.BackgroundImage")));
            this.btn_budgetAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_budgetAdd.Location = new System.Drawing.Point(787, 259);
            this.btn_budgetAdd.Name = "btn_budgetAdd";
            this.btn_budgetAdd.Size = new System.Drawing.Size(32, 32);
            this.btn_budgetAdd.TabIndex = 7;
            this.btn_budgetAdd.UseVisualStyleBackColor = true;
            // 
            // btn_moneyreceivedAdd
            // 
            this.btn_moneyreceivedAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_moneyreceivedAdd.BackgroundImage")));
            this.btn_moneyreceivedAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_moneyreceivedAdd.Location = new System.Drawing.Point(787, 568);
            this.btn_moneyreceivedAdd.Name = "btn_moneyreceivedAdd";
            this.btn_moneyreceivedAdd.Size = new System.Drawing.Size(32, 32);
            this.btn_moneyreceivedAdd.TabIndex = 8;
            this.btn_moneyreceivedAdd.UseVisualStyleBackColor = true;
            // 
            // btn_transMinus
            // 
            this.btn_transMinus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_transMinus.BackgroundImage")));
            this.btn_transMinus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_transMinus.Location = new System.Drawing.Point(50, 568);
            this.btn_transMinus.Name = "btn_transMinus";
            this.btn_transMinus.Size = new System.Drawing.Size(32, 32);
            this.btn_transMinus.TabIndex = 9;
            this.btn_transMinus.UseVisualStyleBackColor = true;
            // 
            // btn_budgetMinus
            // 
            this.btn_budgetMinus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_budgetMinus.BackgroundImage")));
            this.btn_budgetMinus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_budgetMinus.Location = new System.Drawing.Point(825, 259);
            this.btn_budgetMinus.Name = "btn_budgetMinus";
            this.btn_budgetMinus.Size = new System.Drawing.Size(32, 32);
            this.btn_budgetMinus.TabIndex = 10;
            this.btn_budgetMinus.UseVisualStyleBackColor = true;
            // 
            // btn_moneyreceivedMinus
            // 
            this.btn_moneyreceivedMinus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_moneyreceivedMinus.BackgroundImage")));
            this.btn_moneyreceivedMinus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_moneyreceivedMinus.Location = new System.Drawing.Point(825, 567);
            this.btn_moneyreceivedMinus.Name = "btn_moneyreceivedMinus";
            this.btn_moneyreceivedMinus.Size = new System.Drawing.Size(32, 32);
            this.btn_moneyreceivedMinus.TabIndex = 11;
            this.btn_moneyreceivedMinus.UseVisualStyleBackColor = true;
            // 
            // btn_transModify
            // 
            this.btn_transModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_transModify.Location = new System.Drawing.Point(159, 567);
            this.btn_transModify.Name = "btn_transModify";
            this.btn_transModify.Size = new System.Drawing.Size(77, 32);
            this.btn_transModify.TabIndex = 12;
            this.btn_transModify.Text = "Modify";
            this.btn_transModify.UseVisualStyleBackColor = true;
            // 
            // btn_BudgetModify
            // 
            this.btn_BudgetModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BudgetModify.Location = new System.Drawing.Point(934, 259);
            this.btn_BudgetModify.Name = "btn_BudgetModify";
            this.btn_BudgetModify.Size = new System.Drawing.Size(77, 32);
            this.btn_BudgetModify.TabIndex = 13;
            this.btn_BudgetModify.Text = "Modify";
            this.btn_BudgetModify.UseVisualStyleBackColor = true;
            // 
            // btn_moneyreceivedModify
            // 
            this.btn_moneyreceivedModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_moneyreceivedModify.Location = new System.Drawing.Point(934, 568);
            this.btn_moneyreceivedModify.Name = "btn_moneyreceivedModify";
            this.btn_moneyreceivedModify.Size = new System.Drawing.Size(77, 32);
            this.btn_moneyreceivedModify.TabIndex = 14;
            this.btn_moneyreceivedModify.Text = "Modify";
            this.btn_moneyreceivedModify.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 611);
            this.Controls.Add(this.btn_moneyreceivedModify);
            this.Controls.Add(this.btn_BudgetModify);
            this.Controls.Add(this.btn_transModify);
            this.Controls.Add(this.btn_moneyreceivedMinus);
            this.Controls.Add(this.btn_budgetMinus);
            this.Controls.Add(this.btn_transMinus);
            this.Controls.Add(this.btn_moneyreceivedAdd);
            this.Controls.Add(this.btn_budgetAdd);
            this.Controls.Add(this.btn_transAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView3);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader TransactionEntries;
        private System.Windows.Forms.ColumnHeader TransactionEntryAmt;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader BudgetName;
        private System.Windows.Forms.ColumnHeader budgetAmt;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_transAdd;
        private System.Windows.Forms.Button btn_budgetAdd;
        private System.Windows.Forms.Button btn_moneyreceivedAdd;
        private System.Windows.Forms.Button btn_transMinus;
        private System.Windows.Forms.Button btn_budgetMinus;
        private System.Windows.Forms.Button btn_moneyreceivedMinus;
        private System.Windows.Forms.Button btn_transModify;
        private System.Windows.Forms.Button btn_BudgetModify;
        private System.Windows.Forms.Button btn_moneyreceivedModify;
    }
}

