using BilgeAdam.Restaurant.Common.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClientAlias = BilgeAdam.Restaurant.Common.Models.Client;

namespace BilgeAdam.Restaurant.Client
{
    public partial class frmMain : Form
    {
        public Corporate Corporate { get; set; }
        public frmMain()
        {
            Corporate = new Corporate("Bilge Adam");
            Corporate.Clients = new BindingList<ClientAlias>();
            //Binding List kullanma sebebi: Bu içerik değiştiğinde gridler otomatik olarak yenilensin
            InitializeComponent();
        }

        private void msbNewReservation_Click(object sender, EventArgs e)
        {
        }

        private void msbNewClient_Click(object sender, EventArgs e)
        {
            var a = Corporate.Clients;
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

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.Text += " - "  + Corporate.Title;
        }
    }
}
