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

    public partial class frmMain : System.Windows.Forms.Form
    {
        public static List<string> names = new List<string>();

        public frmMain()
        {
            InitializeComponent();

        }

        private void btnAddName_Click(object sender, EventArgs e)
        {
            FormAddName frmAddName = new FormAddName();
            frmAddName.ShowDialog();


        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            names.Add("Sam");
            names.Add("Erik");
            names.Add("Kenny");

            names.Sort();
            lstNames.DataSource = null;
            lstNames.DataSource = names;
        }

        private void btnRemoveNames_Click(object sender, EventArgs e)
        {
            if (lstNames.SelectedIndex >= 0)
            {
                names.RemoveAt(lstNames.SelectedIndex);
                lstNames.DataSource = null;
                lstNames.DataSource = names;
            }
            else
            {

            }
            
        }

        private void btnEditNames_Click(object sender, EventArgs e)
        {

            frmChangeName frmChangeName = new frmChangeName(lstNames.SelectedIndex);
            frmChangeName.ShowDialog();
            lstNames.DataSource = null;
            lstNames.DataSource = names;
        }

        private void lstNames_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
