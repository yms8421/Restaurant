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
    public partial class frmClients : Form
    {
        public frmClients()
        {
            InitializeComponent();
        }

        private void btnNewClient_Click(object sender, EventArgs e)
        {
            var f = new frmNewClient
            {
                MdiParent = this.MdiParent
            };
            f.Show();
        }

        private void frmClients_Load(object sender, EventArgs e)
        {
            dgvClients.AutoGenerateColumns = false;//kendisine binding verilirken gönderilen bütün property'lerin kolona dönüştürülmesi sağlanır. Bunu yapmasın. Çünkü biz manuel olarak kolonları oluşturduke
            dgvClients.DataSource = (this.MdiParent as frmMain).Corporate.Clients;
        }
    }
}
