using System;
using System.Windows.Forms;

namespace MyBudget
{
    public partial class ErrorNotify : Form
    {
        public String errNbr { get; set; }
        public String errLocalDescription { get; set; }
        public String errDescription { get; set; }

        public ErrorNotify()
        {
            InitializeComponent();
        }

        
        private void ErrorNotify_Load(object sender, EventArgs e)
        {
            if (errNbr == "")
            {
                txt_ErrNbr.Visible = false;
                lbl_ErrorNbr.Visible = false;
            }
            else
            {
                txt_ErrNbr.Text = errNbr;
            }

            if (errLocalDescription == "")
            {
                txt_ErrLocalDesc.Visible = false;
                lbl_ErrLocalDesc.Visible = false;
            }
            else
            {
                txt_ErrLocalDesc.Text = errLocalDescription;
            }

            if (errDescription == "")
            {
                txt_ErrorDesc.Visible = false;
                lbl_ErrDesc.Visible = false;
            }
            else
            {
                txt_ErrorDesc.Text = errDescription;
            }
        }
    }
}
