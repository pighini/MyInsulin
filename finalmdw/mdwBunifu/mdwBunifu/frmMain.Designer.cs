namespace mdwBunifu
{
    partial class frmMain
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.plButtonAccueil = new System.Windows.Forms.Panel();
            this.lblPatient = new System.Windows.Forms.Label();
            this.ddPatient = new ns1.BunifuDropdown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.pbHide = new ns1.BunifuImageButton();
            this.btnClose = new ns1.BunifuImageButton();
            this.plButtonAccueil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // plButtonAccueil
            // 
            this.plButtonAccueil.Controls.Add(this.lblPatient);
            this.plButtonAccueil.Controls.Add(this.ddPatient);
            this.plButtonAccueil.Controls.Add(this.pictureBox1);
            this.plButtonAccueil.Location = new System.Drawing.Point(3, 2);
            this.plButtonAccueil.Name = "plButtonAccueil";
            this.plButtonAccueil.Size = new System.Drawing.Size(231, 572);
            this.plButtonAccueil.TabIndex = 0;
            // 
            // lblPatient
            // 
            this.lblPatient.AutoSize = true;
            this.lblPatient.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblPatient.ForeColor = System.Drawing.Color.White;
            this.lblPatient.Location = new System.Drawing.Point(23, 512);
            this.lblPatient.Name = "lblPatient";
            this.lblPatient.Size = new System.Drawing.Size(73, 21);
            this.lblPatient.TabIndex = 11;
            this.lblPatient.Text = "Patients";
            this.lblPatient.Visible = false;
            // 
            // ddPatient
            // 
            this.ddPatient.BackColor = System.Drawing.Color.Transparent;
            this.ddPatient.BorderRadius = 3;
            this.ddPatient.ForeColor = System.Drawing.Color.White;
            this.ddPatient.Items = new string[0];
            this.ddPatient.Location = new System.Drawing.Point(102, 512);
            this.ddPatient.Name = "ddPatient";
            this.ddPatient.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.ddPatient.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.ddPatient.selectedIndex = -1;
            this.ddPatient.Size = new System.Drawing.Size(102, 23);
            this.ddPatient.TabIndex = 1;
            this.ddPatient.Visible = false;
            this.ddPatient.onItemSelected += new System.EventHandler(this.ddPatient_onItemSelected);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::mdwBunifu.Properties.Resources._6d065362_b0c1_4b37_8f3e_c556d5710132;
            this.pictureBox1.Location = new System.Drawing.Point(-25, -34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 164);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Transparent;
            this.panelMenu.Location = new System.Drawing.Point(258, 2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(657, 572);
            this.panelMenu.TabIndex = 19;
            // 
            // pbHide
            // 
            this.pbHide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(44)))));
            this.pbHide.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbHide.Image = global::mdwBunifu.Properties.Resources.icons8_réduire_la_fenêtre_32;
            this.pbHide.ImageActive = null;
            this.pbHide.Location = new System.Drawing.Point(921, 2);
            this.pbHide.Name = "pbHide";
            this.pbHide.Size = new System.Drawing.Size(20, 19);
            this.pbHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHide.TabIndex = 20;
            this.pbHide.TabStop = false;
            this.pbHide.Zoom = 10;
            this.pbHide.Click += new System.EventHandler(this.pbHide_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(44)))));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = ((System.Drawing.Image)(resources.GetObject("btnClose.ImageActive")));
            this.btnClose.Location = new System.Drawing.Point(947, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(20, 19);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 18;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(970, 594);
            this.Controls.Add(this.pbHide);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.plButtonAccueil);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.plButtonAccueil.ResumeLayout(false);
            this.plButtonAccueil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel plButtonAccueil;
        private ns1.BunifuImageButton btnClose;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ns1.BunifuImageButton pbHide;
        private ns1.BunifuDropdown ddPatient;
        private System.Windows.Forms.Label lblPatient;
    }
}

