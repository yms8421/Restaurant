﻿using System;
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
    }
}
