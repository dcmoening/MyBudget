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
            this.transactionDataGridView = new System.Windows.Forms.DataGridView();
            this.incomeDataGridView = new System.Windows.Forms.DataGridView();
            this.budgetDataGridView = new System.Windows.Forms.DataGridView();
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
            this.modifyIncomeButton = new System.Windows.Forms.Button();
            this.modifyBudgetButton = new System.Windows.Forms.Button();
            this.modifyTransactionButton = new System.Windows.Forms.Button();
            this.removeIncomeButton = new System.Windows.Forms.Button();
            this.removeBudgetButton = new System.Windows.Forms.Button();
            this.removeTransactionButton = new System.Windows.Forms.Button();
            this.addIncomeButton = new System.Windows.Forms.Button();
            this.addBudgetButton = new System.Windows.Forms.Button();
            this.addTransactionButton = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.transactionDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incomeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetDataGridView)).BeginInit();
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
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1369, 793);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.transactionDataGridView);
            this.tabPage1.Controls.Add(this.incomeDataGridView);
            this.tabPage1.Controls.Add(this.budgetDataGridView);
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
            this.tabPage1.Controls.Add(this.modifyIncomeButton);
            this.tabPage1.Controls.Add(this.modifyBudgetButton);
            this.tabPage1.Controls.Add(this.modifyTransactionButton);
            this.tabPage1.Controls.Add(this.removeIncomeButton);
            this.tabPage1.Controls.Add(this.removeBudgetButton);
            this.tabPage1.Controls.Add(this.removeTransactionButton);
            this.tabPage1.Controls.Add(this.addIncomeButton);
            this.tabPage1.Controls.Add(this.addBudgetButton);
            this.tabPage1.Controls.Add(this.addTransactionButton);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1361, 764);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Monthly Summary";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // transactionDataGridView
            // 
            this.transactionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transactionDataGridView.Location = new System.Drawing.Point(8, 28);
            this.transactionDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.transactionDataGridView.Name = "transactionDataGridView";
            this.transactionDataGridView.RowHeadersWidth = 51;
            this.transactionDataGridView.Size = new System.Drawing.Size(300, 656);
            this.transactionDataGridView.TabIndex = 58;
            // 
            // incomeDataGridView
            // 
            this.incomeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.incomeDataGridView.Location = new System.Drawing.Point(1045, 407);
            this.incomeDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.incomeDataGridView.Name = "incomeDataGridView";
            this.incomeDataGridView.RowHeadersWidth = 51;
            this.incomeDataGridView.Size = new System.Drawing.Size(300, 277);
            this.incomeDataGridView.TabIndex = 57;
            // 
            // budgetDataGridView
            // 
            this.budgetDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.budgetDataGridView.Location = new System.Drawing.Point(1045, 27);
            this.budgetDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.budgetDataGridView.Name = "budgetDataGridView";
            this.budgetDataGridView.RowHeadersWidth = 51;
            this.budgetDataGridView.RowTemplate.Height = 24;
            this.budgetDataGridView.Size = new System.Drawing.Size(300, 277);
            this.budgetDataGridView.TabIndex = 56;
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
            this.dgv_BudgetReport.Location = new System.Drawing.Point(385, 315);
            this.dgv_BudgetReport.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_BudgetReport.Name = "dgv_BudgetReport";
            this.dgv_BudgetReport.ReadOnly = true;
            this.dgv_BudgetReport.RowHeadersVisible = false;
            this.dgv_BudgetReport.RowHeadersWidth = 51;
            this.dgv_BudgetReport.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_BudgetReport.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_BudgetReport.ShowEditingIcon = false;
            this.dgv_BudgetReport.ShowRowErrors = false;
            this.dgv_BudgetReport.Size = new System.Drawing.Size(587, 369);
            this.dgv_BudgetReport.TabIndex = 55;
            // 
            // col_BudgetName
            // 
            this.col_BudgetName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_BudgetName.DataPropertyName = "BudgetName";
            this.col_BudgetName.HeaderText = "Budget Name";
            this.col_BudgetName.MinimumWidth = 6;
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
            this.col_BudgetAmt.MinimumWidth = 6;
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
            this.col_BudgetSpent.MinimumWidth = 6;
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
            this.col_BudgetRemaining.MinimumWidth = 6;
            this.col_BudgetRemaining.Name = "col_BudgetRemaining";
            this.col_BudgetRemaining.ReadOnly = true;
            this.col_BudgetRemaining.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.col_BudgetRemaining.Width = 110;
            // 
            // lbl_TotalIncomeRemaining
            // 
            this.lbl_TotalIncomeRemaining.AutoSize = true;
            this.lbl_TotalIncomeRemaining.Location = new System.Drawing.Point(697, 186);
            this.lbl_TotalIncomeRemaining.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_TotalIncomeRemaining.Name = "lbl_TotalIncomeRemaining";
            this.lbl_TotalIncomeRemaining.Size = new System.Drawing.Size(174, 17);
            this.lbl_TotalIncomeRemaining.TabIndex = 54;
            this.lbl_TotalIncomeRemaining.Text = "lbl_TotalIncomeRemaining";
            // 
            // lbl_TotalSpent
            // 
            this.lbl_TotalSpent.AutoSize = true;
            this.lbl_TotalSpent.Location = new System.Drawing.Point(697, 156);
            this.lbl_TotalSpent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_TotalSpent.Name = "lbl_TotalSpent";
            this.lbl_TotalSpent.Size = new System.Drawing.Size(99, 17);
            this.lbl_TotalSpent.TabIndex = 53;
            this.lbl_TotalSpent.Text = "lbl_TotalSpent";
            // 
            // lbl_TotalIncome
            // 
            this.lbl_TotalIncome.AutoSize = true;
            this.lbl_TotalIncome.Location = new System.Drawing.Point(697, 127);
            this.lbl_TotalIncome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_TotalIncome.Name = "lbl_TotalIncome";
            this.lbl_TotalIncome.Size = new System.Drawing.Size(107, 17);
            this.lbl_TotalIncome.TabIndex = 52;
            this.lbl_TotalIncome.Text = "lbl_TotalIncome";
            // 
            // lbl_ExpectedIncomeRemaining
            // 
            this.lbl_ExpectedIncomeRemaining.AutoSize = true;
            this.lbl_ExpectedIncomeRemaining.Location = new System.Drawing.Point(697, 86);
            this.lbl_ExpectedIncomeRemaining.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ExpectedIncomeRemaining.Name = "lbl_ExpectedIncomeRemaining";
            this.lbl_ExpectedIncomeRemaining.Size = new System.Drawing.Size(200, 17);
            this.lbl_ExpectedIncomeRemaining.TabIndex = 51;
            this.lbl_ExpectedIncomeRemaining.Text = "lbl_ExpectedIncomeRemaining";
            // 
            // lbl_TotalExpectedBudget
            // 
            this.lbl_TotalExpectedBudget.AutoSize = true;
            this.lbl_TotalExpectedBudget.Location = new System.Drawing.Point(697, 57);
            this.lbl_TotalExpectedBudget.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_TotalExpectedBudget.Name = "lbl_TotalExpectedBudget";
            this.lbl_TotalExpectedBudget.Size = new System.Drawing.Size(165, 17);
            this.lbl_TotalExpectedBudget.TabIndex = 50;
            this.lbl_TotalExpectedBudget.Text = "lbl_TotalExpectedBudget";
            // 
            // lbl_TotalExpectedIncome
            // 
            this.lbl_TotalExpectedIncome.AutoSize = true;
            this.lbl_TotalExpectedIncome.Location = new System.Drawing.Point(697, 23);
            this.lbl_TotalExpectedIncome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_TotalExpectedIncome.Name = "lbl_TotalExpectedIncome";
            this.lbl_TotalExpectedIncome.Size = new System.Drawing.Size(165, 17);
            this.lbl_TotalExpectedIncome.TabIndex = 49;
            this.lbl_TotalExpectedIncome.Text = "lbl_TotalExpectedIncome";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(487, 186);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(164, 17);
            this.label9.TabIndex = 48;
            this.label9.Text = "Total Income Remaining:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(487, 156);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 17);
            this.label8.TabIndex = 47;
            this.label8.Text = "Total Spent:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(487, 127);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 17);
            this.label7.TabIndex = 46;
            this.label7.Text = "Total Income:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(487, 86);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(190, 17);
            this.label6.TabIndex = 45;
            this.label6.Text = "Expected Income Remaining:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(487, 57);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 17);
            this.label5.TabIndex = 44;
            this.label5.Text = "Total Expected Budget:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(487, 27);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 17);
            this.label4.TabIndex = 43;
            this.label4.Text = "Total Expected Income:";
            // 
            // modifyIncomeButton
            // 
            this.modifyIncomeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyIncomeButton.Location = new System.Drawing.Point(1243, 692);
            this.modifyIncomeButton.Margin = new System.Windows.Forms.Padding(4);
            this.modifyIncomeButton.Name = "modifyIncomeButton";
            this.modifyIncomeButton.Size = new System.Drawing.Size(103, 39);
            this.modifyIncomeButton.TabIndex = 42;
            this.modifyIncomeButton.Text = "Modify";
            this.modifyIncomeButton.UseVisualStyleBackColor = true;
            this.modifyIncomeButton.Click += new System.EventHandler(this.modifyIncomeButton_Click);
            // 
            // modifyBudgetButton
            // 
            this.modifyBudgetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyBudgetButton.Location = new System.Drawing.Point(1243, 311);
            this.modifyBudgetButton.Margin = new System.Windows.Forms.Padding(4);
            this.modifyBudgetButton.Name = "modifyBudgetButton";
            this.modifyBudgetButton.Size = new System.Drawing.Size(103, 39);
            this.modifyBudgetButton.TabIndex = 41;
            this.modifyBudgetButton.Text = "Modify";
            this.modifyBudgetButton.UseVisualStyleBackColor = true;
            this.modifyBudgetButton.Click += new System.EventHandler(this.ModifyBudgetButton_Click);
            // 
            // modifyTransactionButton
            // 
            this.modifyTransactionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyTransactionButton.Location = new System.Drawing.Point(209, 690);
            this.modifyTransactionButton.Margin = new System.Windows.Forms.Padding(4);
            this.modifyTransactionButton.Name = "modifyTransactionButton";
            this.modifyTransactionButton.Size = new System.Drawing.Size(103, 39);
            this.modifyTransactionButton.TabIndex = 40;
            this.modifyTransactionButton.Text = "Modify";
            this.modifyTransactionButton.UseVisualStyleBackColor = true;
            // 
            // removeIncomeButton
            // 
            this.removeIncomeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("removeIncomeButton.BackgroundImage")));
            this.removeIncomeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.removeIncomeButton.Location = new System.Drawing.Point(1097, 690);
            this.removeIncomeButton.Margin = new System.Windows.Forms.Padding(4);
            this.removeIncomeButton.Name = "removeIncomeButton";
            this.removeIncomeButton.Size = new System.Drawing.Size(43, 39);
            this.removeIncomeButton.TabIndex = 39;
            this.removeIncomeButton.UseVisualStyleBackColor = true;
            this.removeIncomeButton.Click += new System.EventHandler(this.removeIncomeButton_Click);
            // 
            // removeBudgetButton
            // 
            this.removeBudgetButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("removeBudgetButton.BackgroundImage")));
            this.removeBudgetButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.removeBudgetButton.Location = new System.Drawing.Point(1097, 311);
            this.removeBudgetButton.Margin = new System.Windows.Forms.Padding(4);
            this.removeBudgetButton.Name = "removeBudgetButton";
            this.removeBudgetButton.Size = new System.Drawing.Size(43, 39);
            this.removeBudgetButton.TabIndex = 38;
            this.removeBudgetButton.UseVisualStyleBackColor = true;
            this.removeBudgetButton.Click += new System.EventHandler(this.RemoveBudgetButton_Click);
            // 
            // removeTransactionButton
            // 
            this.removeTransactionButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("removeTransactionButton.BackgroundImage")));
            this.removeTransactionButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.removeTransactionButton.Location = new System.Drawing.Point(64, 692);
            this.removeTransactionButton.Margin = new System.Windows.Forms.Padding(4);
            this.removeTransactionButton.Name = "removeTransactionButton";
            this.removeTransactionButton.Size = new System.Drawing.Size(43, 39);
            this.removeTransactionButton.TabIndex = 37;
            this.removeTransactionButton.UseVisualStyleBackColor = true;
            // 
            // addIncomeButton
            // 
            this.addIncomeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addIncomeButton.BackgroundImage")));
            this.addIncomeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addIncomeButton.Location = new System.Drawing.Point(1047, 692);
            this.addIncomeButton.Margin = new System.Windows.Forms.Padding(4);
            this.addIncomeButton.Name = "addIncomeButton";
            this.addIncomeButton.Size = new System.Drawing.Size(43, 39);
            this.addIncomeButton.TabIndex = 36;
            this.addIncomeButton.UseVisualStyleBackColor = true;
            this.addIncomeButton.Click += new System.EventHandler(this.addIncomeButton_Click);
            // 
            // addBudgetButton
            // 
            this.addBudgetButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addBudgetButton.BackgroundImage")));
            this.addBudgetButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addBudgetButton.Location = new System.Drawing.Point(1047, 311);
            this.addBudgetButton.Margin = new System.Windows.Forms.Padding(4);
            this.addBudgetButton.Name = "addBudgetButton";
            this.addBudgetButton.Size = new System.Drawing.Size(43, 39);
            this.addBudgetButton.TabIndex = 35;
            this.addBudgetButton.UseVisualStyleBackColor = true;
            this.addBudgetButton.Click += new System.EventHandler(this.AddBudgetButton_Click);
            // 
            // addTransactionButton
            // 
            this.addTransactionButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addTransactionButton.BackgroundImage")));
            this.addTransactionButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addTransactionButton.Location = new System.Drawing.Point(13, 692);
            this.addTransactionButton.Margin = new System.Windows.Forms.Padding(4);
            this.addTransactionButton.Name = "addTransactionButton";
            this.addTransactionButton.Size = new System.Drawing.Size(43, 39);
            this.addTransactionButton.TabIndex = 34;
            this.addTransactionButton.UseVisualStyleBackColor = true;
            this.addTransactionButton.Click += new System.EventHandler(this.addTransactionButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1043, 386);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 17);
            this.label3.TabIndex = 33;
            this.label3.Text = "Money Received";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1043, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 32;
            this.label2.Text = " Budget";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 17);
            this.label1.TabIndex = 31;
            this.label1.Text = "Transaction Entries";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.listView1);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1361, 764);
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
            this.dataGridView1.Location = new System.Drawing.Point(315, 28);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.ShowRowErrors = false;
            this.dataGridView1.Size = new System.Drawing.Size(1031, 660);
            this.dataGridView1.TabIndex = 56;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "DateEntered";
            this.dataGridViewTextBoxColumn1.HeaderText = "Date Entered";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TransactionEntry ";
            this.dataGridViewTextBoxColumn2.HeaderText = "Savings Amount";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "BudgetSpent";
            this.dataGridViewTextBoxColumn3.HeaderText = "Budget Spent";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "BudgetRemaining";
            this.dataGridViewTextBoxColumn4.HeaderText = "Budget Remaining";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
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
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(8, 28);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(297, 659);
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
            this.label10.Location = new System.Drawing.Point(4, 9);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 17);
            this.label10.TabIndex = 33;
            this.label10.Text = "Savings Accounts ";
            // 
            // tmr_UpdateMainScreen
            // 
            this.tmr_UpdateMainScreen.Interval = 30000;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMonthSelected});
            this.statusStrip1.Location = new System.Drawing.Point(0, 797);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1368, 26);
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
            this.toolStripMonthSelected.Size = new System.Drawing.Size(66, 24);
            this.toolStripMonthSelected.Text = "Month";
            // 
            // decemberToolStripMenuItem
            // 
            this.decemberToolStripMenuItem.Name = "decemberToolStripMenuItem";
            this.decemberToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.decemberToolStripMenuItem.Text = "December";
            // 
            // novemberToolStripMenuItem
            // 
            this.novemberToolStripMenuItem.Name = "novemberToolStripMenuItem";
            this.novemberToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.novemberToolStripMenuItem.Text = "November";
            // 
            // octoberToolStripMenuItem
            // 
            this.octoberToolStripMenuItem.Name = "octoberToolStripMenuItem";
            this.octoberToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.octoberToolStripMenuItem.Text = "October";
            // 
            // septemberToolStripMenuItem
            // 
            this.septemberToolStripMenuItem.Name = "septemberToolStripMenuItem";
            this.septemberToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.septemberToolStripMenuItem.Text = "September";
            // 
            // augustToolStripMenuItem
            // 
            this.augustToolStripMenuItem.Name = "augustToolStripMenuItem";
            this.augustToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.augustToolStripMenuItem.Text = "August";
            // 
            // julyToolStripMenuItem
            // 
            this.julyToolStripMenuItem.Name = "julyToolStripMenuItem";
            this.julyToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.julyToolStripMenuItem.Text = "July";
            // 
            // juneToolStripMenuItem
            // 
            this.juneToolStripMenuItem.Name = "juneToolStripMenuItem";
            this.juneToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.juneToolStripMenuItem.Text = "June";
            // 
            // mayToolStripMenuItem
            // 
            this.mayToolStripMenuItem.Name = "mayToolStripMenuItem";
            this.mayToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.mayToolStripMenuItem.Text = "May";
            // 
            // aprilToolStripMenuItem
            // 
            this.aprilToolStripMenuItem.Name = "aprilToolStripMenuItem";
            this.aprilToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.aprilToolStripMenuItem.Text = "April";
            // 
            // marchToolStripMenuItem
            // 
            this.marchToolStripMenuItem.Name = "marchToolStripMenuItem";
            this.marchToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.marchToolStripMenuItem.Text = "March";
            // 
            // februaryToolStripMenuItem
            // 
            this.februaryToolStripMenuItem.Name = "februaryToolStripMenuItem";
            this.februaryToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.februaryToolStripMenuItem.Text = "February";
            // 
            // januaryToolStripMenuItem
            // 
            this.januaryToolStripMenuItem.Name = "januaryToolStripMenuItem";
            this.januaryToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.januaryToolStripMenuItem.Text = "January";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1368, 823);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "My Budget";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transactionDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incomeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetDataGridView)).EndInit();
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
        private System.Windows.Forms.Button modifyIncomeButton;
        private System.Windows.Forms.Button modifyBudgetButton;
        private System.Windows.Forms.Button modifyTransactionButton;
        private System.Windows.Forms.Button removeIncomeButton;
        private System.Windows.Forms.Button removeBudgetButton;
        private System.Windows.Forms.Button removeTransactionButton;
        private System.Windows.Forms.Button addIncomeButton;
        private System.Windows.Forms.Button addBudgetButton;
        private System.Windows.Forms.Button addTransactionButton;
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
        private System.Windows.Forms.DataGridView budgetDataGridView;
        private System.Windows.Forms.DataGridView incomeDataGridView;
        private System.Windows.Forms.DataGridView transactionDataGridView;
    }
}

