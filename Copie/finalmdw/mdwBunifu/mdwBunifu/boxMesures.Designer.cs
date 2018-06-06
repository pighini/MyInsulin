namespace mdwBunifu
{
    partial class boxMesures
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(boxMesures));
            this.lblMesure = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxGlycemie = new ns1.BunifuMetroTextbox();
            this.lblGlycemie = new ns1.BunifuCustomLabel();
            this.ddType = new ns1.BunifuDropdown();
            this.lblSend = new System.Windows.Forms.Label();
            this.dtpDateMesure = new ns1.BunifuDatepicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxCommentary = new ns1.BunifuMetroTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxInsuline = new ns1.BunifuMetroTextbox();
            this.btnSendMesure = new ns1.BunifuThinButton2();
            this.btnDelete = new ns1.BunifuThinButton2();
            this.SuspendLayout();
            // 
            // lblMesure
            // 
            this.lblMesure.AutoSize = true;
            this.lblMesure.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMesure.ForeColor = System.Drawing.Color.White;
            this.lblMesure.Location = new System.Drawing.Point(130, 10);
            this.lblMesure.Name = "lblMesure";
            this.lblMesure.Size = new System.Drawing.Size(319, 28);
            this.lblMesure.TabIndex = 0;
            this.lblMesure.Text = "Veuillez entrer une mesure";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(92, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Glycémie";
            // 
            // tbxGlycemie
            // 
            this.tbxGlycemie.BorderColorFocused = System.Drawing.Color.SteelBlue;
            this.tbxGlycemie.BorderColorIdle = System.Drawing.Color.White;
            this.tbxGlycemie.BorderColorMouseHover = System.Drawing.Color.SteelBlue;
            this.tbxGlycemie.BorderThickness = 1;
            this.tbxGlycemie.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxGlycemie.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbxGlycemie.ForeColor = System.Drawing.Color.White;
            this.tbxGlycemie.isPassword = false;
            this.tbxGlycemie.Location = new System.Drawing.Point(187, 60);
            this.tbxGlycemie.Margin = new System.Windows.Forms.Padding(4);
            this.tbxGlycemie.Name = "tbxGlycemie";
            this.tbxGlycemie.Size = new System.Drawing.Size(42, 31);
            this.tbxGlycemie.TabIndex = 2;
            this.tbxGlycemie.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbxGlycemie.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_KeyPress);
            // 
            // lblGlycemie
            // 
            this.lblGlycemie.AutoSize = true;
            this.lblGlycemie.BackColor = System.Drawing.Color.Transparent;
            this.lblGlycemie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGlycemie.ForeColor = System.Drawing.Color.Red;
            this.lblGlycemie.Location = new System.Drawing.Point(167, 55);
            this.lblGlycemie.Name = "lblGlycemie";
            this.lblGlycemie.Size = new System.Drawing.Size(13, 16);
            this.lblGlycemie.TabIndex = 3;
            this.lblGlycemie.Text = "*";
            this.lblGlycemie.Click += new System.EventHandler(this.lblGlycemie_Click);
            // 
            // ddType
            // 
            this.ddType.BackColor = System.Drawing.Color.Transparent;
            this.ddType.BorderRadius = 3;
            this.ddType.ForeColor = System.Drawing.Color.White;
            this.ddType.Items = new string[] {
        "matin",
        "midi",
        "soir"};
            this.ddType.Location = new System.Drawing.Point(187, 111);
            this.ddType.Name = "ddType";
            this.ddType.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.ddType.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.ddType.selectedIndex = -1;
            this.ddType.Size = new System.Drawing.Size(121, 35);
            this.ddType.TabIndex = 7;
            // 
            // lblSend
            // 
            this.lblSend.AutoSize = true;
            this.lblSend.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSend.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblSend.Location = new System.Drawing.Point(263, 352);
            this.lblSend.Name = "lblSend";
            this.lblSend.Size = new System.Drawing.Size(26, 16);
            this.lblSend.TabIndex = 8;
            this.lblSend.Text = "      ";
            // 
            // dtpDateMesure
            // 
            this.dtpDateMesure.BackColor = System.Drawing.Color.SeaGreen;
            this.dtpDateMesure.BorderRadius = 0;
            this.dtpDateMesure.ForeColor = System.Drawing.Color.White;
            this.dtpDateMesure.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpDateMesure.FormatCustom = null;
            this.dtpDateMesure.Location = new System.Drawing.Point(184, 160);
            this.dtpDateMesure.Name = "dtpDateMesure";
            this.dtpDateMesure.Size = new System.Drawing.Size(266, 36);
            this.dtpDateMesure.TabIndex = 9;
            this.dtpDateMesure.Value = new System.DateTime(2018, 5, 14, 11, 13, 32, 807);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(120, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(116, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 21);
            this.label3.TabIndex = 11;
            this.label3.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(92, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 21);
            this.label4.TabIndex = 12;
            this.label4.Text = "Commentaire";
            // 
            // tbxCommentary
            // 
            this.tbxCommentary.AutoSize = true;
            this.tbxCommentary.BorderColorFocused = System.Drawing.Color.SteelBlue;
            this.tbxCommentary.BorderColorIdle = System.Drawing.Color.White;
            this.tbxCommentary.BorderColorMouseHover = System.Drawing.Color.SteelBlue;
            this.tbxCommentary.BorderThickness = 1;
            this.tbxCommentary.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxCommentary.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCommentary.ForeColor = System.Drawing.Color.White;
            this.tbxCommentary.isPassword = false;
            this.tbxCommentary.Location = new System.Drawing.Point(103, 281);
            this.tbxCommentary.Margin = new System.Windows.Forms.Padding(4);
            this.tbxCommentary.Name = "tbxCommentary";
            this.tbxCommentary.Size = new System.Drawing.Size(346, 67);
            this.tbxCommentary.TabIndex = 13;
            this.tbxCommentary.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(99, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 21);
            this.label5.TabIndex = 14;
            this.label5.Text = "Insuline";
            // 
            // tbxInsuline
            // 
            this.tbxInsuline.BorderColorFocused = System.Drawing.Color.SeaGreen;
            this.tbxInsuline.BorderColorIdle = System.Drawing.Color.White;
            this.tbxInsuline.BorderColorMouseHover = System.Drawing.Color.SeaGreen;
            this.tbxInsuline.BorderThickness = 1;
            this.tbxInsuline.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxInsuline.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbxInsuline.ForeColor = System.Drawing.Color.White;
            this.tbxInsuline.isPassword = false;
            this.tbxInsuline.Location = new System.Drawing.Point(184, 213);
            this.tbxInsuline.Margin = new System.Windows.Forms.Padding(4);
            this.tbxInsuline.Name = "tbxInsuline";
            this.tbxInsuline.Size = new System.Drawing.Size(42, 31);
            this.tbxInsuline.TabIndex = 15;
            this.tbxInsuline.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnSendMesure
            // 
            this.btnSendMesure.ActiveBorderThickness = 1;
            this.btnSendMesure.ActiveCornerRadius = 1;
            this.btnSendMesure.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnSendMesure.ActiveForecolor = System.Drawing.Color.White;
            this.btnSendMesure.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnSendMesure.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(44)))));
            this.btnSendMesure.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSendMesure.BackgroundImage")));
            this.btnSendMesure.ButtonText = "Envoyer";
            this.btnSendMesure.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSendMesure.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendMesure.ForeColor = System.Drawing.Color.White;
            this.btnSendMesure.IdleBorderThickness = 1;
            this.btnSendMesure.IdleCornerRadius = 1;
            this.btnSendMesure.IdleFillColor = System.Drawing.Color.SeaGreen;
            this.btnSendMesure.IdleForecolor = System.Drawing.Color.White;
            this.btnSendMesure.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnSendMesure.Location = new System.Drawing.Point(120, 373);
            this.btnSendMesure.Margin = new System.Windows.Forms.Padding(5);
            this.btnSendMesure.Name = "btnSendMesure";
            this.btnSendMesure.Size = new System.Drawing.Size(326, 65);
            this.btnSendMesure.TabIndex = 6;
            this.btnSendMesure.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSendMesure.Click += new System.EventHandler(this.btnSendMesure_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.ActiveBorderThickness = 1;
            this.btnDelete.ActiveCornerRadius = 1;
            this.btnDelete.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDelete.ActiveForecolor = System.Drawing.Color.White;
            this.btnDelete.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(44)))));
            this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
            this.btnDelete.ButtonText = "Effacer";
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.IdleBorderThickness = 1;
            this.btnDelete.IdleCornerRadius = 1;
            this.btnDelete.IdleFillColor = System.Drawing.Color.Firebrick;
            this.btnDelete.IdleForecolor = System.Drawing.Color.White;
            this.btnDelete.IdleLineColor = System.Drawing.Color.Firebrick;
            this.btnDelete.Location = new System.Drawing.Point(226, 437);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(107, 33);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDelete.Visible = false;
            // 
            // boxMesures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(44)))));
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.tbxInsuline);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxCommentary);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpDateMesure);
            this.Controls.Add(this.lblSend);
            this.Controls.Add(this.ddType);
            this.Controls.Add(this.btnSendMesure);
            this.Controls.Add(this.lblGlycemie);
            this.Controls.Add(this.tbxGlycemie);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMesure);
            this.Name = "boxMesures";
            this.Size = new System.Drawing.Size(573, 488);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMesure;
        private System.Windows.Forms.Label label1;
        private ns1.BunifuMetroTextbox tbxGlycemie;
        private ns1.BunifuCustomLabel lblGlycemie;
        private ns1.BunifuThinButton2 btnSendMesure;
        private ns1.BunifuDropdown ddType;
        private System.Windows.Forms.Label lblSend;
        private ns1.BunifuDatepicker dtpDateMesure;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private ns1.BunifuMetroTextbox tbxCommentary;
        private System.Windows.Forms.Label label5;
        private ns1.BunifuMetroTextbox tbxInsuline;
        private ns1.BunifuThinButton2 btnDelete;
    }
}
