namespace mdwBunifu
{
    partial class boxTypes
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
            this.lblMesure = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMesure
            // 
            this.lblMesure.AutoSize = true;
            this.lblMesure.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMesure.ForeColor = System.Drawing.Color.White;
            this.lblMesure.Location = new System.Drawing.Point(193, 20);
            this.lblMesure.Name = "lblMesure";
            this.lblMesure.Size = new System.Drawing.Size(219, 28);
            this.lblMesure.TabIndex = 1;
            this.lblMesure.Text = "Gestion des types";
            // 
            // boxTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(44)))));
            this.Controls.Add(this.lblMesure);
            this.Name = "boxTypes";
            this.Size = new System.Drawing.Size(609, 502);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMesure;
    }
}
