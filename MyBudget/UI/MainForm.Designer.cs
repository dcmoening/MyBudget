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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgv_BudgetReport = new System.Windows.Forms.DataGridView();
            this.col_BudgetName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_BudgetAmt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_BudgetSpent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_BudgetRemaining = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_TotalIncomeRemaining = new System.Windows.Forms.Label();
            this.lbl_TotalSpent = new System.Windows.Forms.Label();
            this.lbl_TotalIncome = new System.Windows.Forms.Label();
            this.lbl_ExpectedIncomeRemaining = new System.Windows.Forms.Label();
            this.lbl_TotalExpectedBudget = new System.Windows.Forms.Label();
            this.lbl_TotalExpectedIncome = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_moneyreceivedModify = new System.Windows.Forms.Button();
            this.btn_BudgetModify = new System.Windows.Forms.Button();
            this.btn_transModify = new System.Windows.Forms.Button();
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
            this.IncomeEntryAmt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_moneyreceivedMinus = new System.Windows.Forms.Button();
            this.btn_budgetMinus = new System.Windows.Forms.Button();
            this.btn_transMinus = new System.Windows.Forms.Button();
            this.btn_moneyreceivedAdd = new System.Windows.Forms.Button();
            this.btn_budgetAdd = new System.Windows.Forms.Button();
            this.btn_transAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label10 = new System.Windows.Forms.Label();
            this.tmr_UpdateMainScreen = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripMonthSelected = new System.Windows.Forms.ToolStripDropDownButton();
            this.decemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.octoberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.septemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.augustToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.julyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.juneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aprilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.februaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.januaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BudgetReport)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1027, 644);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgv_BudgetReport);
            this.tabPage1.Controls.Add(this.lbl_TotalIncomeRemaining);
            this.tabPage1.Controls.Add(this.lbl_TotalSpent);
            this.tabPage1.Controls.Add(this.lbl_TotalIncome);
            this.tabPage1.Controls.Add(this.lbl_ExpectedIncomeRemaining);
            this.tabPage1.Controls.Add(this.lbl_TotalExpectedBudget);
            this.tabPage1.Controls.Add(this.lbl_TotalExpectedIncome);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.btn_moneyreceivedModify);
            this.tabPage1.Controls.Add(this.btn_BudgetModify);
            this.tabPage1.Controls.Add(this.btn_transModify);
            this.tabPage1.Controls.Add(this.lstvw_TransactionEntry);
            this.tabPage1.Controls.Add(this.lstvw_Budget);
            this.tabPage1.Controls.Add(this.lstvw_MoneyReceived);
            this.tabPage1.Controls.Add(this.btn_moneyreceivedMinus);
            this.tabPage1.Controls.Add(this.btn_budgetMinus);
            this.tabPage1.Controls.Add(this.btn_transMinus);
            this.tabPage1.Controls.Add(this.btn_moneyreceivedAdd);
            this.tabPage1.Controls.Add(this.btn_budgetAdd);
            this.tabPage1.Controls.Add(this.btn_transAdd);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1019, 618);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Monthly Summary";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            this.dgv_BudgetReport.Location = new System.Drawing.Point(289, 256);
            this.dgv_BudgetReport.Name = "dgv_BudgetReport";
            this.dgv_BudgetReport.ReadOnly = true;
            this.dgv_BudgetReport.RowHeadersVisible = false;
            this.dgv_BudgetReport.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_BudgetReport.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_BudgetReport.ShowEditingIcon = false;
            this.dgv_BudgetReport.ShowRowErrors = false;
            this.dgv_BudgetReport.Size = new System.Drawing.Size(440, 300);
            this.dgv_BudgetReport.TabIndex = 55;
            // 
            // col_BudgetName
            // 
            this.col_BudgetName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_BudgetName.DataPropertyName = "BudgetName";
            this.col_BudgetName.HeaderText = "Budget Name";
            this.col_BudgetName.Name = "col_BudgetName";
            this.col_BudgetName.ReadOnly = true;
            this.col_BudgetName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_BudgetName.Width = 110;
            // 
            // col_BudgetAmt
            // 
            this.col_BudgetAmt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_BudgetAmt.DataPropertyName = "BudgetAmt";
            this.col_BudgetAmt.HeaderText = "Budget Amt";
            this.col_BudgetAmt.Name = "col_BudgetAmt";
            this.col_BudgetAmt.ReadOnly = true;
            this.col_BudgetAmt.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.col_BudgetAmt.Width = 110;
            // 
            // col_BudgetSpent
            // 
            this.col_BudgetSpent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_BudgetSpent.DataPropertyName = "BudgetSpent";
            this.col_BudgetSpent.HeaderText = "Budget Spent";
            this.col_BudgetSpent.Name = "col_BudgetSpent";
            this.col_BudgetSpent.ReadOnly = true;
            this.col_BudgetSpent.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.col_BudgetSpent.Width = 110;
            // 
            // col_BudgetRemaining
            // 
            this.col_BudgetRemaining.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_BudgetRemaining.DataPropertyName = "BudgetRemaining";
            this.col_BudgetRemaining.HeaderText = "Budget Remaining";
            this.col_BudgetRemaining.Name = "col_BudgetRemaining";
            this.col_BudgetRemaining.ReadOnly = true;
            this.col_BudgetRemaining.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.col_BudgetRemaining.Width = 110;
            // 
            // lbl_TotalIncomeRemaining
            // 
            this.lbl_TotalIncomeRemaining.AutoSize = true;
            this.lbl_TotalIncomeRemaining.Location = new System.Drawing.Point(523, 151);
            this.lbl_TotalIncomeRemaining.Name = "lbl_TotalIncomeRemaining";
            this.lbl_TotalIncomeRemaining.Size = new System.Drawing.Size(132, 13);
            this.lbl_TotalIncomeRemaining.TabIndex = 54;
            this.lbl_TotalIncomeRemaining.Text = "lbl_TotalIncomeRemaining";
            // 
            // lbl_TotalSpent
            // 
            this.lbl_TotalSpent.AutoSize = true;
            this.lbl_TotalSpent.Location = new System.Drawing.Point(523, 127);
            this.lbl_TotalSpent.Name = "lbl_TotalSpent";
            this.lbl_TotalSpent.Size = new System.Drawing.Size(75, 13);
            this.lbl_TotalSpent.TabIndex = 53;
            this.lbl_TotalSpent.Text = "lbl_TotalSpent";
            // 
            // lbl_TotalIncome
            // 
            this.lbl_TotalIncome.AutoSize = true;
            this.lbl_TotalIncome.Location = new System.Drawing.Point(523, 103);
            this.lbl_TotalIncome.Name = "lbl_TotalIncome";
            this.lbl_TotalIncome.Size = new System.Drawing.Size(82, 13);
            this.lbl_TotalIncome.TabIndex = 52;
            this.lbl_TotalIncome.Text = "lbl_TotalIncome";
            // 
            // lbl_ExpectedIncomeRemaining
            // 
            this.lbl_ExpectedIncomeRemaining.AutoSize = true;
            this.lbl_ExpectedIncomeRemaining.Location = new System.Drawing.Point(523, 70);
            this.lbl_ExpectedIncomeRemaining.Name = "lbl_ExpectedIncomeRemaining";
            this.lbl_ExpectedIncomeRemaining.Size = new System.Drawing.Size(153, 13);
            this.lbl_ExpectedIncomeRemaining.TabIndex = 51;
            this.lbl_ExpectedIncomeRemaining.Text = "lbl_ExpectedIncomeRemaining";
            // 
            // lbl_TotalExpectedBudget
            // 
            this.lbl_TotalExpectedBudget.AutoSize = true;
            this.lbl_TotalExpectedBudget.Location = new System.Drawing.Point(523, 46);
            this.lbl_TotalExpectedBudget.Name = "lbl_TotalExpectedBudget";
            this.lbl_TotalExpectedBudget.Size = new System.Drawing.Size(126, 13);
            this.lbl_TotalExpectedBudget.TabIndex = 50;
            this.lbl_TotalExpectedBudget.Text = "lbl_TotalExpectedBudget";
            // 
            // lbl_TotalExpectedIncome
            // 
            this.lbl_TotalExpectedIncome.AutoSize = true;
            this.lbl_TotalExpectedIncome.Location = new System.Drawing.Point(523, 19);
            this.lbl_TotalExpectedIncome.Name = "lbl_TotalExpectedIncome";
            this.lbl_TotalExpectedIncome.Size = new System.Drawing.Size(127, 13);
            this.lbl_TotalExpectedIncome.TabIndex = 49;
            this.lbl_TotalExpectedIncome.Text = "lbl_TotalExpectedIncome";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(365, 151);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 13);
            this.label9.TabIndex = 48;
            this.label9.Text = "Total Income Remaining:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(365, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 47;
            this.label8.Text = "Total Spent:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(365, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 46;
            this.label7.Text = "Total Income:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(365, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 13);
            this.label6.TabIndex = 45;
            this.label6.Text = "Expected Income Remaining:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(365, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 13);
            this.label5.TabIndex = 44;
            this.label5.Text = "Total Expected Budget:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(365, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "Total Expected Income:";
            // 
            // btn_moneyreceivedModify
            // 
            this.btn_moneyreceivedModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_moneyreceivedModify.Location = new System.Drawing.Point(932, 562);
            this.btn_moneyreceivedModify.Name = "btn_moneyreceivedModify";
            this.btn_moneyreceivedModify.Size = new System.Drawing.Size(77, 32);
            this.btn_moneyreceivedModify.TabIndex = 42;
            this.btn_moneyreceivedModify.Text = "Modify";
            this.btn_moneyreceivedModify.UseVisualStyleBackColor = true;
            this.btn_moneyreceivedModify.Click += new System.EventHandler(this.btn_moneyreceivedModify_Click);
            // 
            // btn_BudgetModify
            // 
            this.btn_BudgetModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BudgetModify.Location = new System.Drawing.Point(932, 253);
            this.btn_BudgetModify.Name = "btn_BudgetModify";
            this.btn_BudgetModify.Size = new System.Drawing.Size(77, 32);
            this.btn_BudgetModify.TabIndex = 41;
            this.btn_BudgetModify.Text = "Modify";
            this.btn_BudgetModify.UseVisualStyleBackColor = true;
            this.btn_BudgetModify.Click += new System.EventHandler(this.btn_BudgetModify_Click);
            // 
            // btn_transModify
            // 
            this.btn_transModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_transModify.Location = new System.Drawing.Point(157, 561);
            this.btn_transModify.Name = "btn_transModify";
            this.btn_transModify.Size = new System.Drawing.Size(77, 32);
            this.btn_transModify.TabIndex = 40;
            this.btn_transModify.Text = "Modify";
            this.btn_transModify.UseVisualStyleBackColor = true;
            this.btn_transModify.Click += new System.EventHandler(this.btn_transModify_Click);
            // 
            // lstvw_TransactionEntry
            // 
            this.lstvw_TransactionEntry.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TransactionEntryID,
            this.TransactionEntries,
            this.TransactionEntryAmt});
            this.lstvw_TransactionEntry.ForeColor = System.Drawing.Color.Red;
            this.lstvw_TransactionEntry.FullRowSelect = true;
            this.lstvw_TransactionEntry.Location = new System.Drawing.Point(10, 22);
            this.lstvw_TransactionEntry.MultiSelect = false;
            this.lstvw_TransactionEntry.Name = "lstvw_TransactionEntry";
            this.lstvw_TransactionEntry.Size = new System.Drawing.Size(224, 534);
            this.lstvw_TransactionEntry.TabIndex = 28;
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
            this.lstvw_Budget.ForeColor = System.Drawing.Color.Black;
            this.lstvw_Budget.FullRowSelect = true;
            this.lstvw_Budget.Location = new System.Drawing.Point(789, 19);
            this.lstvw_Budget.MultiSelect = false;
            this.lstvw_Budget.Name = "lstvw_Budget";
            this.lstvw_Budget.Size = new System.Drawing.Size(224, 225);
            this.lstvw_Budget.TabIndex = 29;
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
            this.budgetAmt.Text = "Amt";
            // 
            // lstvw_MoneyReceived
            // 
            this.lstvw_MoneyReceived.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IncomeEntryID,
            this.IncomeEntries,
            this.IncomeEntryAmt});
            this.lstvw_MoneyReceived.ForeColor = System.Drawing.Color.Green;
            this.lstvw_MoneyReceived.FullRowSelect = true;
            this.lstvw_MoneyReceived.Location = new System.Drawing.Point(784, 314);
            this.lstvw_MoneyReceived.MultiSelect = false;
            this.lstvw_MoneyReceived.Name = "lstvw_MoneyReceived";
            this.lstvw_MoneyReceived.Size = new System.Drawing.Size(224, 242);
            this.lstvw_MoneyReceived.TabIndex = 30;
            this.lstvw_MoneyReceived.UseCompatibleStateImageBehavior = false;
            this.lstvw_MoneyReceived.View = System.Windows.Forms.View.Details;
            // 
            // IncomeEntryID
            // 
            this.IncomeEntryID.DisplayIndex = 0;
            this.IncomeEntryID.Text = "ID";
            this.IncomeEntryID.Width = 0;
            // 
            // IncomeEntries
            // 
            this.IncomeEntries.Text = "Name";
            this.IncomeEntries.Width = 169;
            // 
            // IncomeEntryAmt
            // 
            this.IncomeEntryAmt.Text = "Amt";
            this.IncomeEntryAmt.Width = 51;
            // 
            // btn_moneyreceivedMinus
            // 
            this.btn_moneyreceivedMinus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_moneyreceivedMinus.BackgroundImage")));
            this.btn_moneyreceivedMinus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_moneyreceivedMinus.Location = new System.Drawing.Point(823, 561);
            this.btn_moneyreceivedMinus.Name = "btn_moneyreceivedMinus";
            this.btn_moneyreceivedMinus.Size = new System.Drawing.Size(32, 32);
            this.btn_moneyreceivedMinus.TabIndex = 39;
            this.btn_moneyreceivedMinus.UseVisualStyleBackColor = true;
            this.btn_moneyreceivedMinus.Click += new System.EventHandler(this.btn_moneyreceivedMinus_Click);
            // 
            // btn_budgetMinus
            // 
            this.btn_budgetMinus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_budgetMinus.BackgroundImage")));
            this.btn_budgetMinus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_budgetMinus.Location = new System.Drawing.Point(823, 253);
            this.btn_budgetMinus.Name = "btn_budgetMinus";
            this.btn_budgetMinus.Size = new System.Drawing.Size(32, 32);
            this.btn_budgetMinus.TabIndex = 38;
            this.btn_budgetMinus.UseVisualStyleBackColor = true;
            this.btn_budgetMinus.Click += new System.EventHandler(this.btn_budgetMinus_Click);
            // 
            // btn_transMinus
            // 
            this.btn_transMinus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_transMinus.BackgroundImage")));
            this.btn_transMinus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_transMinus.Location = new System.Drawing.Point(48, 562);
            this.btn_transMinus.Name = "btn_transMinus";
            this.btn_transMinus.Size = new System.Drawing.Size(32, 32);
            this.btn_transMinus.TabIndex = 37;
            this.btn_transMinus.UseVisualStyleBackColor = true;
            this.btn_transMinus.Click += new System.EventHandler(this.btn_transMinus_Click);
            // 
            // btn_moneyreceivedAdd
            // 
            this.btn_moneyreceivedAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_moneyreceivedAdd.BackgroundImage")));
            this.btn_moneyreceivedAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_moneyreceivedAdd.Location = new System.Drawing.Point(785, 562);
            this.btn_moneyreceivedAdd.Name = "btn_moneyreceivedAdd";
            this.btn_moneyreceivedAdd.Size = new System.Drawing.Size(32, 32);
            this.btn_moneyreceivedAdd.TabIndex = 36;
            this.btn_moneyreceivedAdd.UseVisualStyleBackColor = true;
            this.btn_moneyreceivedAdd.Click += new System.EventHandler(this.btn_moneyreceivedAdd_Click);
            // 
            // btn_budgetAdd
            // 
            this.btn_budgetAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_budgetAdd.BackgroundImage")));
            this.btn_budgetAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_budgetAdd.Location = new System.Drawing.Point(785, 253);
            this.btn_budgetAdd.Name = "btn_budgetAdd";
            this.btn_budgetAdd.Size = new System.Drawing.Size(32, 32);
            this.btn_budgetAdd.TabIndex = 35;
            this.btn_budgetAdd.UseVisualStyleBackColor = true;
            this.btn_budgetAdd.Click += new System.EventHandler(this.btn_budgetAdd_Click);
            // 
            // btn_transAdd
            // 
            this.btn_transAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_transAdd.BackgroundImage")));
            this.btn_transAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_transAdd.Location = new System.Drawing.Point(10, 562);
            this.btn_transAdd.Name = "btn_transAdd";
            this.btn_transAdd.Size = new System.Drawing.Size(32, 32);
            this.btn_transAdd.TabIndex = 34;
            this.btn_transAdd.UseVisualStyleBackColor = true;
            this.btn_transAdd.Click += new System.EventHandler(this.btn_transAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(782, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Money Received";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(782, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = " Budget";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Transaction Entries";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.listView1);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1019, 618);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Bank Accounts ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataGridView1.Location = new System.Drawing.Point(236, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.ShowRowErrors = false;
            this.dataGridView1.Size = new System.Drawing.Size(773, 536);
            this.dataGridView1.TabIndex = 56;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "DateEntered";
            this.dataGridViewTextBoxColumn1.HeaderText = "Date Entered";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TransactionEntry ";
            this.dataGridViewTextBoxColumn2.HeaderText = "Savings Amount";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "BudgetSpent";
            this.dataGridViewTextBoxColumn3.HeaderText = "Budget Spent";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "BudgetRemaining";
            this.dataGridViewTextBoxColumn4.HeaderText = "Budget Remaining";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.ForeColor = System.Drawing.Color.Red;
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(6, 23);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(224, 536);
            this.listView1.TabIndex = 32;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.DisplayIndex = 2;
            this.columnHeader1.Width = 0;
            // 
            // columnHeader2
            // 
            this.columnHeader2.DisplayIndex = 0;
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 169;
            // 
            // columnHeader3
            // 
            this.columnHeader3.DisplayIndex = 1;
            this.columnHeader3.Text = "Amt";
            this.columnHeader3.Width = 51;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 13);
            this.label10.TabIndex = 33;
            this.label10.Text = "Savings Accounts ";
            // 
            // tmr_UpdateMainScreen
            // 
            this.tmr_UpdateMainScreen.Interval = 30000;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMonthSelected});
            this.statusStrip1.Location = new System.Drawing.Point(0, 647);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1026, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripMonthSelected
            // 
            this.toolStripMonthSelected.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripMonthSelected.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.decemberToolStripMenuItem,
            this.novemberToolStripMenuItem,
            this.octoberToolStripMenuItem,
            this.septemberToolStripMenuItem,
            this.augustToolStripMenuItem,
            this.julyToolStripMenuItem,
            this.juneToolStripMenuItem,
            this.mayToolStripMenuItem,
            this.aprilToolStripMenuItem,
            this.marchToolStripMenuItem,
            this.februaryToolStripMenuItem,
            this.januaryToolStripMenuItem});
            this.toolStripMonthSelected.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMonthSelected.Image")));
            this.toolStripMonthSelected.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripMonthSelected.Name = "toolStripMonthSelected";
            this.toolStripMonthSelected.Size = new System.Drawing.Size(56, 20);
            this.toolStripMonthSelected.Text = "Month";
            // 
            // decemberToolStripMenuItem
            // 
            this.decemberToolStripMenuItem.Name = "decemberToolStripMenuItem";
            this.decemberToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.decemberToolStripMenuItem.Text = "December";
            this.decemberToolStripMenuItem.Click += new System.EventHandler(this.decemberToolStripMenuItem_Click);
            // 
            // novemberToolStripMenuItem
            // 
            this.novemberToolStripMenuItem.Name = "novemberToolStripMenuItem";
            this.novemberToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.novemberToolStripMenuItem.Text = "November";
            this.novemberToolStripMenuItem.Click += new System.EventHandler(this.novemberToolStripMenuItem_Click);
            // 
            // octoberToolStripMenuItem
            // 
            this.octoberToolStripMenuItem.Name = "octoberToolStripMenuItem";
            this.octoberToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.octoberToolStripMenuItem.Text = "October";
            this.octoberToolStripMenuItem.Click += new System.EventHandler(this.octoberToolStripMenuItem_Click);
            // 
            // septemberToolStripMenuItem
            // 
            this.septemberToolStripMenuItem.Name = "septemberToolStripMenuItem";
            this.septemberToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.septemberToolStripMenuItem.Text = "September";
            this.septemberToolStripMenuItem.Click += new System.EventHandler(this.septemberToolStripMenuItem_Click);
            // 
            // augustToolStripMenuItem
            // 
            this.augustToolStripMenuItem.Name = "augustToolStripMenuItem";
            this.augustToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.augustToolStripMenuItem.Text = "August";
            this.augustToolStripMenuItem.Click += new System.EventHandler(this.augustToolStripMenuItem_Click);
            // 
            // julyToolStripMenuItem
            // 
            this.julyToolStripMenuItem.Name = "julyToolStripMenuItem";
            this.julyToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.julyToolStripMenuItem.Text = "July";
            this.julyToolStripMenuItem.Click += new System.EventHandler(this.julyToolStripMenuItem_Click);
            // 
            // juneToolStripMenuItem
            // 
            this.juneToolStripMenuItem.Name = "juneToolStripMenuItem";
            this.juneToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.juneToolStripMenuItem.Text = "June";
            this.juneToolStripMenuItem.Click += new System.EventHandler(this.juneToolStripMenuItem_Click);
            // 
            // mayToolStripMenuItem
            // 
            this.mayToolStripMenuItem.Name = "mayToolStripMenuItem";
            this.mayToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.mayToolStripMenuItem.Text = "May";
            this.mayToolStripMenuItem.Click += new System.EventHandler(this.mayToolStripMenuItem_Click);
            // 
            // aprilToolStripMenuItem
            // 
            this.aprilToolStripMenuItem.Name = "aprilToolStripMenuItem";
            this.aprilToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.aprilToolStripMenuItem.Text = "April";
            this.aprilToolStripMenuItem.Click += new System.EventHandler(this.aprilToolStripMenuItem_Click);
            // 
            // marchToolStripMenuItem
            // 
            this.marchToolStripMenuItem.Name = "marchToolStripMenuItem";
            this.marchToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.marchToolStripMenuItem.Text = "March";
            this.marchToolStripMenuItem.Click += new System.EventHandler(this.marchToolStripMenuItem_Click);
            // 
            // februaryToolStripMenuItem
            // 
            this.februaryToolStripMenuItem.Name = "februaryToolStripMenuItem";
            this.februaryToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.februaryToolStripMenuItem.Text = "February";
            this.februaryToolStripMenuItem.Click += new System.EventHandler(this.februaryToolStripMenuItem_Click);
            // 
            // januaryToolStripMenuItem
            // 
            this.januaryToolStripMenuItem.Name = "januaryToolStripMenuItem";
            this.januaryToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.januaryToolStripMenuItem.Text = "January";
            this.januaryToolStripMenuItem.Click += new System.EventHandler(this.januaryToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 669);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "My Budget";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BudgetReport)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgv_BudgetReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_BudgetName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_BudgetAmt;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_BudgetSpent;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_BudgetRemaining;
        private System.Windows.Forms.Label lbl_TotalIncomeRemaining;
        private System.Windows.Forms.Label lbl_TotalSpent;
        private System.Windows.Forms.Label lbl_TotalIncome;
        private System.Windows.Forms.Label lbl_ExpectedIncomeRemaining;
        private System.Windows.Forms.Label lbl_TotalExpectedBudget;
        private System.Windows.Forms.Label lbl_TotalExpectedIncome;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_moneyreceivedModify;
        private System.Windows.Forms.Button btn_BudgetModify;
        private System.Windows.Forms.Button btn_transModify;
        private System.Windows.Forms.ListView lstvw_TransactionEntry;
        private System.Windows.Forms.ColumnHeader TransactionEntryID;
        private System.Windows.Forms.ColumnHeader TransactionEntries;
        private System.Windows.Forms.ColumnHeader TransactionEntryAmt;
        private System.Windows.Forms.ListView lstvw_Budget;
        private System.Windows.Forms.ColumnHeader BudgetName;
        private System.Windows.Forms.ColumnHeader budgetAmt;
        private System.Windows.Forms.ListView lstvw_MoneyReceived;
        private System.Windows.Forms.ColumnHeader IncomeEntryID;
        private System.Windows.Forms.ColumnHeader IncomeEntries;
        private System.Windows.Forms.ColumnHeader IncomeEntryAmt;
        private System.Windows.Forms.Button btn_moneyreceivedMinus;
        private System.Windows.Forms.Button btn_budgetMinus;
        private System.Windows.Forms.Button btn_transMinus;
        private System.Windows.Forms.Button btn_moneyreceivedAdd;
        private System.Windows.Forms.Button btn_budgetAdd;
        private System.Windows.Forms.Button btn_transAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Timer tmr_UpdateMainScreen;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.ToolStripDropDownButton toolStripMonthSelected;
        private System.Windows.Forms.ToolStripMenuItem decemberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novemberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem octoberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem septemberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem augustToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem julyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem juneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aprilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem februaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem januaryToolStripMenuItem;
    }
}

