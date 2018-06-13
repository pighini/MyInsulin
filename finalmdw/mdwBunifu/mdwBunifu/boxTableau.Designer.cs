namespace mdwBunifu
{
    partial class boxTableau
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbxMoyenne = new ns1.BunifuCheckbox();
            this.label4 = new System.Windows.Forms.Label();
            this.pbPreviousWeek = new System.Windows.Forms.PictureBox();
            this.pbNextWeek = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPreviousWeek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNextWeek)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(578, 5);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(93, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 459);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(0, 111);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(500, 1);
            this.panel3.TabIndex = 1;
            // 
            // cbxMoyenne
            // 
            this.cbxMoyenne.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.cbxMoyenne.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.cbxMoyenne.Checked = false;
            this.cbxMoyenne.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.cbxMoyenne.ForeColor = System.Drawing.Color.White;
            this.cbxMoyenne.Location = new System.Drawing.Point(88, 478);
            this.cbxMoyenne.Name = "cbxMoyenne";
            this.cbxMoyenne.Size = new System.Drawing.Size(20, 20);
            this.cbxMoyenne.TabIndex = 20;
            this.cbxMoyenne.OnChange += new System.EventHandler(this.cbxTendance_OnChange);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(11, 481);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Moyenne";
            // 
            // pbPreviousWeek
            // 
            this.pbPreviousWeek.Image = global::mdwBunifu.Properties.Resources.icons8_gauche_26;
            this.pbPreviousWeek.Location = new System.Drawing.Point(14, 20);
            this.pbPreviousWeek.Name = "pbPreviousWeek";
            this.pbPreviousWeek.Size = new System.Drawing.Size(27, 27);
            this.pbPreviousWeek.TabIndex = 3;
            this.pbPreviousWeek.TabStop = false;
            this.pbPreviousWeek.Click += new System.EventHandler(this.pbPreviousWeek_Click);
            // 
            // pbNextWeek
            // 
            this.pbNextWeek.Image = global::mdwBunifu.Properties.Resources.icons8_droite_26;
            this.pbNextWeek.Location = new System.Drawing.Point(53, 20);
            this.pbNextWeek.Name = "pbNextWeek";
            this.pbNextWeek.Size = new System.Drawing.Size(27, 26);
            this.pbNextWeek.TabIndex = 2;
            this.pbNextWeek.TabStop = false;
            this.pbNextWeek.Click += new System.EventHandler(this.pbNextWeek_Click);
            // 
            // boxTableau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(44)))));
            this.Controls.Add(this.cbxMoyenne);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pbPreviousWeek);
            this.Controls.Add(this.pbNextWeek);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "boxTableau";
            this.Size = new System.Drawing.Size(580, 524);
            ((System.ComponentModel.ISupportInitialize)(this.pbPreviousWeek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNextWeek)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pbNextWeek;
        private System.Windows.Forms.PictureBox pbPreviousWeek;
        private ns1.BunifuCheckbox cbxMoyenne;
        private System.Windows.Forms.Label label4;
    }
}
