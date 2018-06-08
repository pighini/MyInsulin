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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.pbHide = new ns1.BunifuImageButton();
            this.btnClose = new ns1.BunifuImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.plButtonAccueil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // plButtonAccueil
            // 
            this.plButtonAccueil.Controls.Add(this.pictureBox1);
            this.plButtonAccueil.Location = new System.Drawing.Point(3, 2);
            this.plButtonAccueil.Name = "plButtonAccueil";
            this.plButtonAccueil.Size = new System.Drawing.Size(231, 572);
            this.plButtonAccueil.TabIndex = 0;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Transparent;
            this.panelMenu.Location = new System.Drawing.Point(258, 2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(622, 560);
            this.panelMenu.TabIndex = 19;
            // 
            // pbHide
            // 
            this.pbHide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(44)))));
            this.pbHide.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbHide.Image = global::mdwBunifu.Properties.Resources.icons8_réduire_la_fenêtre_32;
            this.pbHide.ImageActive = null;
            this.pbHide.Location = new System.Drawing.Point(885, 2);
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
            this.btnClose.Location = new System.Drawing.Point(911, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(20, 19);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 18;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::mdwBunifu.Properties.Resources._6d065362_b0c1_4b37_8f3e_c556d57101321;
            this.pictureBox1.Location = new System.Drawing.Point(-95, -99);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 186);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(932, 576);
            this.Controls.Add(this.pbHide);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.plButtonAccueil);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.plButtonAccueil.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbHide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel plButtonAccueil;
        private ns1.BunifuImageButton btnClose;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ns1.BunifuImageButton pbHide;
    }
}

