using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgeAdam.Restaurant.Client
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void msbNewReservation_Click(object sender, EventArgs e)
        {
        }

        private void msbNewClient_Click(object sender, EventArgs e)
        {
            var f = new frmNewClient
            {
                MdiParent = this
            };
            f.Show();
        }

        private void msbClients_Click(object sender, EventArgs e)
        {
            var f = new frmClients
            {
                MdiParent = this
            };
            f.Show();
        }
    }
}
