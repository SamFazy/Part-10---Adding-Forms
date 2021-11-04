using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part_10___Adding_Forms
{
    public partial class FormAddName : Form
    {
        public FormAddName()
        {
            InitializeComponent();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void FormAddName_Load(object sender, EventArgs e)
        {
            lstNames.DataSource = frmMain.names;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtAddName.Text == "")
            {

            }

            else
            {
                frmMain.names.Add(txtAddName.Text);
                lstNames.DataSource = null;
                lstNames.DataSource = frmMain.names;
            }

            txtAddName.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
