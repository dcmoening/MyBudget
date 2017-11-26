namespace MyBudget
{
    partial class ErrorNotify
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
            this.txt_ErrorDesc = new System.Windows.Forms.TextBox();
            this.lbl_ErrDesc = new System.Windows.Forms.Label();
            this.txt_ErrLocalDesc = new System.Windows.Forms.TextBox();
            this.lbl_ErrLocalDesc = new System.Windows.Forms.Label();
            this.lbl_ErrorNbr = new System.Windows.Forms.Label();
            this.txt_ErrNbr = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_ErrorDesc
            // 
            this.txt_ErrorDesc.Location = new System.Drawing.Point(17, 151);
            this.txt_ErrorDesc.Multiline = true;
            this.txt_ErrorDesc.Name = "txt_ErrorDesc";
            this.txt_ErrorDesc.ReadOnly = true;
            this.txt_ErrorDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_ErrorDesc.Size = new System.Drawing.Size(424, 92);
            this.txt_ErrorDesc.TabIndex = 0;
            // 
            // lbl_ErrDesc
            // 
            this.lbl_ErrDesc.AutoSize = true;
            this.lbl_ErrDesc.Location = new System.Drawing.Point(17, 135);
            this.lbl_ErrDesc.Name = "lbl_ErrDesc";
            this.lbl_ErrDesc.Size = new System.Drawing.Size(85, 13);
            this.lbl_ErrDesc.TabIndex = 1;
            this.lbl_ErrDesc.Text = "Error Description";
            // 
            // txt_ErrLocalDesc
            // 
            this.txt_ErrLocalDesc.Location = new System.Drawing.Point(17, 89);
            this.txt_ErrLocalDesc.Name = "txt_ErrLocalDesc";
            this.txt_ErrLocalDesc.ReadOnly = true;
            this.txt_ErrLocalDesc.Size = new System.Drawing.Size(424, 20);
            this.txt_ErrLocalDesc.TabIndex = 2;
            // 
            // lbl_ErrLocalDesc
            // 
            this.lbl_ErrLocalDesc.AutoSize = true;
            this.lbl_ErrLocalDesc.Location = new System.Drawing.Point(17, 73);
            this.lbl_ErrLocalDesc.Name = "lbl_ErrLocalDesc";
            this.lbl_ErrLocalDesc.Size = new System.Drawing.Size(75, 13);
            this.lbl_ErrLocalDesc.TabIndex = 3;
            this.lbl_ErrLocalDesc.Text = "Error Summary";
            // 
            // lbl_ErrorNbr
            // 
            this.lbl_ErrorNbr.AutoSize = true;
            this.lbl_ErrorNbr.Location = new System.Drawing.Point(17, 28);
            this.lbl_ErrorNbr.Name = "lbl_ErrorNbr";
            this.lbl_ErrorNbr.Size = new System.Drawing.Size(69, 13);
            this.lbl_ErrorNbr.TabIndex = 4;
            this.lbl_ErrorNbr.Text = "Error Number";
            // 
            // txt_ErrNbr
            // 
            this.txt_ErrNbr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_ErrNbr.Location = new System.Drawing.Point(95, 25);
            this.txt_ErrNbr.Name = "txt_ErrNbr";
            this.txt_ErrNbr.ReadOnly = true;
            this.txt_ErrNbr.Size = new System.Drawing.Size(80, 13);
            this.txt_ErrNbr.TabIndex = 5;
            // 
            // ErrorNotify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 257);
            this.Controls.Add(this.txt_ErrNbr);
            this.Controls.Add(this.lbl_ErrorNbr);
            this.Controls.Add(this.lbl_ErrLocalDesc);
            this.Controls.Add(this.txt_ErrLocalDesc);
            this.Controls.Add(this.lbl_ErrDesc);
            this.Controls.Add(this.txt_ErrorDesc);
            this.Name = "ErrorNotify";
            this.Text = "Error";
            this.Load += new System.EventHandler(this.ErrorNotify_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_ErrorDesc;
        private System.Windows.Forms.Label lbl_ErrDesc;
        private System.Windows.Forms.TextBox txt_ErrLocalDesc;
        private System.Windows.Forms.Label lbl_ErrLocalDesc;
        private System.Windows.Forms.Label lbl_ErrorNbr;
        private System.Windows.Forms.TextBox txt_ErrNbr;
    }
}