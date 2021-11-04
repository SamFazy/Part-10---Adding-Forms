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
    public partial class frmChangeName : Form
    {

        int index; 

        public frmChangeName(int index)
        {
            InitializeComponent();
            this.index = index;
        }

        private void frmChangeName_Load(object sender, EventArgs e)
        {
            lblChosenName.Text = "The Name You Chose To Change Is: " + frmMain.names[index];
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (txtChangeName.Text == "")
            {

            }

            else
            {
                frmMain.names.RemoveAt(index);
                frmMain.names.Add(txtChangeName.Text);
                frmMain.names.Sort();

                this.Dispose();

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
