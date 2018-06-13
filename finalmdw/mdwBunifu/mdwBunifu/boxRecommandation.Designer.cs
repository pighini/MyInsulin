namespace mdwBunifu
{
    partial class boxRecommandation
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblRecommandation = new System.Windows.Forms.Label();
            this.plReco = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRecommandation
            // 
            this.lblRecommandation.AutoSize = true;
            this.lblRecommandation.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecommandation.ForeColor = System.Drawing.Color.White;
            this.lblRecommandation.Location = new System.Drawing.Point(167, 8);
            this.lblRecommandation.Name = "lblRecommandation";
            this.lblRecommandation.Size = new System.Drawing.Size(232, 28);
            this.lblRecommandation.TabIndex = 0;
            this.lblRecommandation.Text = "Recommandations";
            // 
            // plReco
            // 
            this.plReco.AutoScroll = true;
            this.plReco.Location = new System.Drawing.Point(40, 84);
            this.plReco.Name = "plReco";
            this.plReco.Size = new System.Drawing.Size(495, 446);
            this.plReco.TabIndex = 1;
            this.plReco.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.plReco_ControlRemoved);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::mdwBunifu.Properties.Resources.recommandation1;
            this.pictureBox1.Location = new System.Drawing.Point(102, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(325, 51);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // boxRecommandation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(44)))));
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.plReco);
            this.Controls.Add(this.lblRecommandation);
            this.Name = "boxRecommandation";
            this.Size = new System.Drawing.Size(578, 537);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRecommandation;
        private System.Windows.Forms.Panel plReco;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
