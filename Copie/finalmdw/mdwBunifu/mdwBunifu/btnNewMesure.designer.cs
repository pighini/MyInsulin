namespace mayDaylyWeyght
{
    partial class btnNewMesure
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(btnNewMesure));
            this.lblText = new System.Windows.Forms.Label();
            this.pbImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText.ForeColor = System.Drawing.Color.White;
            this.lblText.Location = new System.Drawing.Point(82, 25);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(70, 19);
            this.lblText.TabIndex = 5;
            this.lblText.Text = "Mesures";
            this.lblText.MouseLeave += new System.EventHandler(this.btnNewMesure_MouseLeave);
            this.lblText.MouseHover += new System.EventHandler(this.btnNewMesure_MouseHover);
            // 
            // pbImage
            // 
            this.pbImage.Image = ((System.Drawing.Image)(resources.GetObject("pbImage.Image")));
            this.pbImage.Location = new System.Drawing.Point(18, 17);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(34, 39);
            this.pbImage.TabIndex = 4;
            this.pbImage.TabStop = false;
            this.pbImage.MouseLeave += new System.EventHandler(this.btnNewMesure_MouseLeave);
            this.pbImage.MouseHover += new System.EventHandler(this.btnNewMesure_MouseHover);
            // 
            // btnNewMesure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.pbImage);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "btnNewMesure";
            this.Size = new System.Drawing.Size(235, 67);
            this.MouseLeave += new System.EventHandler(this.btnNewMesure_MouseLeave);
            this.MouseHover += new System.EventHandler(this.btnNewMesure_MouseHover);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.PictureBox pbImage;
    }
}
