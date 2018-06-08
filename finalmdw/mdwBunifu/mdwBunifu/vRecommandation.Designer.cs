namespace mdwBunifu
{
    partial class vRecommandation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(vRecommandation));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tbxMin = new ns1.BunifuMaterialTextbox();
            this.tbxMax = new ns1.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxReco = new ns1.BunifuMetroTextbox();
            this.pbDel = new System.Windows.Forms.PictureBox();
            this.pbChange = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbDel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbChange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxMin
            // 
            this.tbxMin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxMin.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbxMin.ForeColor = System.Drawing.Color.White;
            this.tbxMin.HintForeColor = System.Drawing.Color.Empty;
            this.tbxMin.HintText = "";
            this.tbxMin.isPassword = false;
            this.tbxMin.LineFocusedColor = System.Drawing.Color.SeaGreen;
            this.tbxMin.LineIdleColor = System.Drawing.Color.White;
            this.tbxMin.LineMouseHoverColor = System.Drawing.Color.SeaGreen;
            this.tbxMin.LineThickness = 3;
            this.tbxMin.Location = new System.Drawing.Point(4, 4);
            this.tbxMin.Margin = new System.Windows.Forms.Padding(4);
            this.tbxMin.Name = "tbxMin";
            this.tbxMin.Size = new System.Drawing.Size(42, 44);
            this.tbxMin.TabIndex = 0;
            this.tbxMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbxMin.OnValueChanged += new System.EventHandler(this.tbx_OnValueChanged);
            // 
            // tbxMax
            // 
            this.tbxMax.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxMax.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbxMax.ForeColor = System.Drawing.Color.White;
            this.tbxMax.HintForeColor = System.Drawing.Color.Empty;
            this.tbxMax.HintText = "";
            this.tbxMax.isPassword = false;
            this.tbxMax.LineFocusedColor = System.Drawing.Color.SeaGreen;
            this.tbxMax.LineIdleColor = System.Drawing.Color.White;
            this.tbxMax.LineMouseHoverColor = System.Drawing.Color.SeaGreen;
            this.tbxMax.LineThickness = 3;
            this.tbxMax.Location = new System.Drawing.Point(64, 4);
            this.tbxMax.Margin = new System.Windows.Forms.Padding(4);
            this.tbxMax.Name = "tbxMax";
            this.tbxMax.Size = new System.Drawing.Size(42, 44);
            this.tbxMax.TabIndex = 1;
            this.tbxMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbxMax.OnValueChanged += new System.EventHandler(this.tbx_OnValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(46, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "-";
            // 
            // tbxReco
            // 
            this.tbxReco.BorderColorFocused = System.Drawing.Color.SeaGreen;
            this.tbxReco.BorderColorIdle = System.Drawing.Color.White;
            this.tbxReco.BorderColorMouseHover = System.Drawing.Color.SeaGreen;
            this.tbxReco.BorderThickness = 3;
            this.tbxReco.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxReco.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxReco.ForeColor = System.Drawing.Color.White;
            this.tbxReco.isPassword = false;
            this.tbxReco.Location = new System.Drawing.Point(170, 7);
            this.tbxReco.Margin = new System.Windows.Forms.Padding(4);
            this.tbxReco.Name = "tbxReco";
            this.tbxReco.Size = new System.Drawing.Size(49, 44);
            this.tbxReco.TabIndex = 4;
            this.tbxReco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxReco.OnValueChanged += new System.EventHandler(this.tbx_OnValueChanged);
            // 
            // pbDel
            // 
            this.pbDel.Image = global::mdwBunifu.Properties.Resources.icons8_multiplier_24__1_;
            this.pbDel.Location = new System.Drawing.Point(254, 20);
            this.pbDel.Name = "pbDel";
            this.pbDel.Size = new System.Drawing.Size(25, 28);
            this.pbDel.TabIndex = 6;
            this.pbDel.TabStop = false;
            this.pbDel.Click += new System.EventHandler(this.pbDel_Click);
            // 
            // pbChange
            // 
            this.pbChange.Image = global::mdwBunifu.Properties.Resources.icons8_edit_property_26_lightGrey;
            this.pbChange.Location = new System.Drawing.Point(224, 20);
            this.pbChange.Name = "pbChange";
            this.pbChange.Size = new System.Drawing.Size(24, 28);
            this.pbChange.TabIndex = 5;
            this.pbChange.TabStop = false;
            this.pbChange.Click += new System.EventHandler(this.pbChange_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(113, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 48);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // vRecommandation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(44)))));
            this.Controls.Add(this.pbDel);
            this.Controls.Add(this.pbChange);
            this.Controls.Add(this.tbxReco);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxMax);
            this.Controls.Add(this.tbxMin);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "vRecommandation";
            this.Size = new System.Drawing.Size(287, 55);
            ((System.ComponentModel.ISupportInitialize)(this.pbDel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbChange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ns1.BunifuMaterialTextbox tbxMin;
        private ns1.BunifuMaterialTextbox tbxMax;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ns1.BunifuMetroTextbox tbxReco;
        private System.Windows.Forms.PictureBox pbChange;
        private System.Windows.Forms.PictureBox pbDel;
    }
}
