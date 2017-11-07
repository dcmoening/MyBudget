using System;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBudget
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public static String ReturnConnectionString()
        {
            string connString = "server=" + ConfigurationManager.AppSettings["server"].ToString() +
                                     "user=" + ConfigurationManager.AppSettings["user"].ToString() +
                                     "database=" + ConfigurationManager.AppSettings["database"].ToString() +
                                     "port=" + ConfigurationManager.AppSettings["port"].ToString() +
                                     "password=" + ConfigurationManager.AppSettings["password"] + ";";
            return connString;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_transAdd_Click(object sender, EventArgs e)
        {
            TransactionEntry form_TransactionEntry = new TransactionEntry();
            form_TransactionEntry.isAddTransactionEntry = true;
            form_TransactionEntry.Show();
        }
    }
}
