namespace BilgeAdam.Restaurant.Client
{
    partial class frmClients
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvClients = new System.Windows.Forms.DataGridView();
            this.btnNewClient = new System.Windows.Forms.Button();
            this.dgcName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcCreated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClients
            // 
            this.dgvClients.AllowUserToAddRows = false;
            this.dgvClients.AllowUserToDeleteRows = false;
            this.dgvClients.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvClients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgcName,
            this.dgcPhone,
            this.dgcCreated});
            this.dgvClients.Location = new System.Drawing.Point(12, 12);
            this.dgvClients.Name = "dgvClients";
            this.dgvClients.ReadOnly = true;
            this.dgvClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClients.Size = new System.Drawing.Size(610, 358);
            this.dgvClients.TabIndex = 0;
            // 
            // btnNewClient
            // 
            this.btnNewClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewClient.Location = new System.Drawing.Point(547, 376);
            this.btnNewClient.Name = "btnNewClient";
            this.btnNewClient.Size = new System.Drawing.Size(75, 23);
            this.btnNewClient.TabIndex = 1;
            this.btnNewClient.Text = "Yeni Ekle";
            this.btnNewClient.UseVisualStyleBackColor = true;
            this.btnNewClient.Click += new System.EventHandler(this.btnNewClient_Click);
            // 
            // dgcName
            // 
            this.dgcName.DataPropertyName = "FullName";
            this.dgcName.HeaderText = "Adı Soyadı";
            this.dgcName.Name = "dgcName";
            this.dgcName.ReadOnly = true;
            // 
            // dgcPhone
            // 
            this.dgcPhone.DataPropertyName = "Phone";
            this.dgcPhone.HeaderText = "Telefon Numarası";
            this.dgcPhone.Name = "dgcPhone";
            this.dgcPhone.ReadOnly = true;
            // 
            // dgcCreated
            // 
            this.dgcCreated.DataPropertyName = "CreatedDate";
            this.dgcCreated.HeaderText = "Kayıt Tarihi";
            this.dgcCreated.Name = "dgcCreated";
            this.dgcCreated.ReadOnly = true;
            // 
            // frmClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 411);
            this.Controls.Add(this.btnNewClient);
            this.Controls.Add(this.dgvClients);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(650, 450);
            this.Name = "frmClients";
            this.Text = "Müşteriler";
            this.Load += new System.EventHandler(this.frmClients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClients;
        private System.Windows.Forms.Button btnNewClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcCreated;
    }
}