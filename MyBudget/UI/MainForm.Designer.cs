namespace MyBudget
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lstvw_TransactionEntry = new System.Windows.Forms.ListView();
            this.TransactionEntryID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TransactionEntries = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TransactionEntryAmt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstvw_Budget = new System.Windows.Forms.ListView();
            this.BudgetName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.budgetAmt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstvw_MoneyReceived = new System.Windows.Forms.ListView();
            this.IncomeEntryID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IncomeEntries = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_TotalExpectedIncome = new System.Windows.Forms.Label();
            this.lbl_TotalExpectedBudget = new System.Windows.Forms.Label();
            this.lbl_ExpectedIncomeRemaing = new System.Windows.Forms.Label();
            this.lbl_TotalIncome = new System.Windows.Forms.Label();
            this.lbl_TotalSpent = new System.Windows.Forms.Label();
            this.lbl_TotalIncomeRemaining = new System.Windows.Forms.Label();
            this.dgv_BudgetReport = new System.Windows.Forms.DataGridView();
            this.col_BudgetName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_BudgetAmt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_BudgetSpent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_BudgetRemaining = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tmr_UpdateMainScreen = new System.Windows.Forms.Timer(this.components);
            this.IncomeEntryAmt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BudgetReport)).BeginInit();
            this.SuspendLayout();
            // 
            // lstvw_TransactionEntry
            // 
            this.lstvw_TransactionEntry.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TransactionEntryID,
            this.TransactionEntries,
            this.TransactionEntryAmt});
            this.lstvw_TransactionEntry.FullRowSelect = true;
            this.lstvw_TransactionEntry.Location = new System.Drawing.Point(12, 28);
            this.lstvw_TransactionEntry.MultiSelect = false;
            this.lstvw_TransactionEntry.Name = "lstvw_TransactionEntry";
            this.lstvw_TransactionEntry.Size = new System.Drawing.Size(224, 534);
            this.lstvw_TransactionEntry.TabIndex = 0;
            this.lstvw_TransactionEntry.UseCompatibleStateImageBehavior = false;
            this.lstvw_TransactionEntry.View = System.Windows.Forms.View.Details;
            // 
            // TransactionEntryID
            // 
            this.TransactionEntryID.DisplayIndex = 2;
            this.TransactionEntryID.Width = 0;
            // 
            // TransactionEntries
            // 
            this.TransactionEntries.DisplayIndex = 0;
            this.TransactionEntries.Text = "Name";
            this.TransactionEntries.Width = 169;
            // 
            // TransactionEntryAmt
            // 
            this.TransactionEntryAmt.DisplayIndex = 1;
            this.TransactionEntryAmt.Text = "Amt";
            this.TransactionEntryAmt.Width = 51;
            // 
            // lstvw_Budget
            // 
            this.lstvw_Budget.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.BudgetName,
            this.budgetAmt});
            this.lstvw_Budget.Location = new System.Drawing.Point(787, 28);
            this.lstvw_Budget.MultiSelect = false;
            this.lstvw_Budget.Name = "lstvw_Budget";
            this.lstvw_Budget.Size = new System.Drawing.Size(224, 225);
            this.lstvw_Budget.TabIndex = 1;
            this.lstvw_Budget.UseCompatibleStateImageBehavior = false;
            this.lstvw_Budget.View = System.Windows.Forms.View.Details;
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
            // lstvw_MoneyReceived
            // 
            this.lstvw_MoneyReceived.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IncomeEntryID,
            this.IncomeEntries,
            this.IncomeEntryAmt});
            this.lstvw_MoneyReceived.Location = new System.Drawing.Point(786, 320);
            this.lstvw_MoneyReceived.MultiSelect = false;
            this.lstvw_MoneyReceived.Name = "lstvw_MoneyReceived";
            this.lstvw_MoneyReceived.Size = new System.Drawing.Size(224, 242);
            this.lstvw_MoneyReceived.TabIndex = 2;
            this.lstvw_MoneyReceived.UseCompatibleStateImageBehavior = false;
            this.lstvw_MoneyReceived.View = System.Windows.Forms.View.Details;
            // 
            // IncomeEntryID
            // 
            this.IncomeEntryID.Text = "ID";
            this.IncomeEntryID.Width = 0;
            // 
            // IncomeEntries
            // 
            this.IncomeEntries.Text = "Name";
            this.IncomeEntries.Width = 169;
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
            this.btn_transAdd.Click += new System.EventHandler(this.btn_transAdd_Click);
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
            this.btn_budgetAdd.Click += new System.EventHandler(this.btn_budgetAdd_Click);
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
            this.btn_moneyreceivedAdd.Click += new System.EventHandler(this.btn_moneyreceivedAdd_Click);
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
            this.btn_transMinus.Click += new System.EventHandler(this.btn_transMinus_Click);
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
            this.btn_budgetMinus.Click += new System.EventHandler(this.btn_budgetMinus_Click);
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
            this.btn_moneyreceivedMinus.Click += new System.EventHandler(this.btn_moneyreceivedMinus_Click);
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
            this.btn_transModify.Click += new System.EventHandler(this.btn_transModify_Click);
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
            this.btn_BudgetModify.Click += new System.EventHandler(this.btn_BudgetModify_Click);
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
            this.btn_moneyreceivedModify.Click += new System.EventHandler(this.btn_moneyreceivedModify_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(386, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Total Expected Income:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(386, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Total Expected Budget:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(386, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Expected Income Remaining:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(386, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Total Income:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(386, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Total Spent:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(386, 157);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Total Income Remaining:";
            // 
            // lbl_TotalExpectedIncome
            // 
            this.lbl_TotalExpectedIncome.AutoSize = true;
            this.lbl_TotalExpectedIncome.Location = new System.Drawing.Point(544, 25);
            this.lbl_TotalExpectedIncome.Name = "lbl_TotalExpectedIncome";
            this.lbl_TotalExpectedIncome.Size = new System.Drawing.Size(127, 13);
            this.lbl_TotalExpectedIncome.TabIndex = 21;
            this.lbl_TotalExpectedIncome.Text = "lbl_TotalExpectedIncome";
            // 
            // lbl_TotalExpectedBudget
            // 
            this.lbl_TotalExpectedBudget.AutoSize = true;
            this.lbl_TotalExpectedBudget.Location = new System.Drawing.Point(544, 52);
            this.lbl_TotalExpectedBudget.Name = "lbl_TotalExpectedBudget";
            this.lbl_TotalExpectedBudget.Size = new System.Drawing.Size(126, 13);
            this.lbl_TotalExpectedBudget.TabIndex = 22;
            this.lbl_TotalExpectedBudget.Text = "lbl_TotalExpectedBudget";
            // 
            // lbl_ExpectedIncomeRemaing
            // 
            this.lbl_ExpectedIncomeRemaing.AutoSize = true;
            this.lbl_ExpectedIncomeRemaing.Location = new System.Drawing.Point(544, 76);
            this.lbl_ExpectedIncomeRemaing.Name = "lbl_ExpectedIncomeRemaing";
            this.lbl_ExpectedIncomeRemaing.Size = new System.Drawing.Size(145, 13);
            this.lbl_ExpectedIncomeRemaing.TabIndex = 23;
            this.lbl_ExpectedIncomeRemaing.Text = "lbl_ExpectedIncomeRemaing";
            // 
            // lbl_TotalIncome
            // 
            this.lbl_TotalIncome.AutoSize = true;
            this.lbl_TotalIncome.Location = new System.Drawing.Point(544, 109);
            this.lbl_TotalIncome.Name = "lbl_TotalIncome";
            this.lbl_TotalIncome.Size = new System.Drawing.Size(82, 13);
            this.lbl_TotalIncome.TabIndex = 24;
            this.lbl_TotalIncome.Text = "lbl_TotalIncome";
            // 
            // lbl_TotalSpent
            // 
            this.lbl_TotalSpent.AutoSize = true;
            this.lbl_TotalSpent.Location = new System.Drawing.Point(544, 133);
            this.lbl_TotalSpent.Name = "lbl_TotalSpent";
            this.lbl_TotalSpent.Size = new System.Drawing.Size(75, 13);
            this.lbl_TotalSpent.TabIndex = 25;
            this.lbl_TotalSpent.Text = "lbl_TotalSpent";
            // 
            // lbl_TotalIncomeRemaining
            // 
            this.lbl_TotalIncomeRemaining.AutoSize = true;
            this.lbl_TotalIncomeRemaining.Location = new System.Drawing.Point(544, 157);
            this.lbl_TotalIncomeRemaining.Name = "lbl_TotalIncomeRemaining";
            this.lbl_TotalIncomeRemaining.Size = new System.Drawing.Size(132, 13);
            this.lbl_TotalIncomeRemaining.TabIndex = 26;
            this.lbl_TotalIncomeRemaining.Text = "lbl_TotalIncomeRemaining";
            // 
            // dgv_BudgetReport
            // 
            this.dgv_BudgetReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgv_BudgetReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_BudgetReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_BudgetName,
            this.col_BudgetAmt,
            this.col_BudgetSpent,
            this.col_BudgetRemaining});
            this.dgv_BudgetReport.Location = new System.Drawing.Point(291, 262);
            this.dgv_BudgetReport.Name = "dgv_BudgetReport";
            this.dgv_BudgetReport.ReadOnly = true;
            this.dgv_BudgetReport.RowHeadersVisible = false;
            this.dgv_BudgetReport.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_BudgetReport.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_BudgetReport.ShowEditingIcon = false;
            this.dgv_BudgetReport.ShowRowErrors = false;
            this.dgv_BudgetReport.Size = new System.Drawing.Size(440, 300);
            this.dgv_BudgetReport.TabIndex = 27;
            // 
            // col_BudgetName
            // 
            this.col_BudgetName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_BudgetName.HeaderText = "Budget Name";
            this.col_BudgetName.Name = "col_BudgetName";
            this.col_BudgetName.ReadOnly = true;
            this.col_BudgetName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_BudgetName.Width = 110;
            // 
            // col_BudgetAmt
            // 
            this.col_BudgetAmt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_BudgetAmt.HeaderText = "Budget Amt";
            this.col_BudgetAmt.Name = "col_BudgetAmt";
            this.col_BudgetAmt.ReadOnly = true;
            this.col_BudgetAmt.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.col_BudgetAmt.Width = 110;
            // 
            // col_BudgetSpent
            // 
            this.col_BudgetSpent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_BudgetSpent.HeaderText = "Budget Spent";
            this.col_BudgetSpent.Name = "col_BudgetSpent";
            this.col_BudgetSpent.ReadOnly = true;
            this.col_BudgetSpent.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.col_BudgetSpent.Width = 110;
            // 
            // col_BudgetRemaining
            // 
            this.col_BudgetRemaining.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_BudgetRemaining.HeaderText = "Budget Remaining";
            this.col_BudgetRemaining.Name = "col_BudgetRemaining";
            this.col_BudgetRemaining.ReadOnly = true;
            this.col_BudgetRemaining.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.col_BudgetRemaining.Width = 110;
            // 
            // tmr_UpdateMainScreen
            // 
            this.tmr_UpdateMainScreen.Interval = 1000;
            this.tmr_UpdateMainScreen.Tick += new System.EventHandler(this.tmr_UpdateMainScreen_Tick);
            // 
            // IncomeEntryAmt
            // 
            this.IncomeEntryAmt.Text = "Amt";
            this.IncomeEntryAmt.Width = 51;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 611);
            this.Controls.Add(this.dgv_BudgetReport);
            this.Controls.Add(this.lbl_TotalIncomeRemaining);
            this.Controls.Add(this.lbl_TotalSpent);
            this.Controls.Add(this.lbl_TotalIncome);
            this.Controls.Add(this.lbl_ExpectedIncomeRemaing);
            this.Controls.Add(this.lbl_TotalExpectedBudget);
            this.Controls.Add(this.lbl_TotalExpectedIncome);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
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
            this.Controls.Add(this.lstvw_MoneyReceived);
            this.Controls.Add(this.lstvw_Budget);
            this.Controls.Add(this.lstvw_TransactionEntry);
            this.Name = "MainForm";
            this.Text = "My Budget";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BudgetReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstvw_TransactionEntry;
        private System.Windows.Forms.ColumnHeader TransactionEntries;
        private System.Windows.Forms.ColumnHeader TransactionEntryAmt;
        private System.Windows.Forms.ListView lstvw_Budget;
        private System.Windows.Forms.ColumnHeader BudgetName;
        private System.Windows.Forms.ColumnHeader budgetAmt;
        private System.Windows.Forms.ListView lstvw_MoneyReceived;
        private System.Windows.Forms.ColumnHeader IncomeEntryID;
        private System.Windows.Forms.ColumnHeader IncomeEntries;
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
        private System.Windows.Forms.ColumnHeader TransactionEntryID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_TotalExpectedIncome;
        private System.Windows.Forms.Label lbl_TotalExpectedBudget;
        private System.Windows.Forms.Label lbl_ExpectedIncomeRemaing;
        private System.Windows.Forms.Label lbl_TotalIncome;
        private System.Windows.Forms.Label lbl_TotalSpent;
        private System.Windows.Forms.Label lbl_TotalIncomeRemaining;
        private System.Windows.Forms.DataGridView dgv_BudgetReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_BudgetName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_BudgetAmt;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_BudgetSpent;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_BudgetRemaining;
        private System.Windows.Forms.Timer tmr_UpdateMainScreen;
        private System.Windows.Forms.ColumnHeader IncomeEntryAmt;
    }
}

