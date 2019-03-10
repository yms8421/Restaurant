using BilgeAdam.Restaurant.Common.Models;
using System;
using System.ComponentModel;
using System.Windows.Forms;
using ClientAlias = BilgeAdam.Restaurant.Common.Models.Client;

namespace BilgeAdam.Restaurant.Client
{
    public partial class frmNewClient : Form
    {
        public frmNewClient()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var cl = ClientAlias.CreateClient(txtFullName.Text, txtPhone.Text);
            ((this.MdiParent as frmMain).Corporate.Clients as BindingList<ClientAlias>).Add(cl); //Düzeltilecek
            // as keyword'ü sayesinde nesne esas nesnesine dönüştürülüp (gibi görülüp) direkt o nesneden erişerek çalışır
            //örnek olarak this.MdiParent içinde (Form oldupu için) Corporare diye bir şey yok; frmMain'de var
            txtFullName.Clear();
            txtPhone.Clear();
        }
    }
}
