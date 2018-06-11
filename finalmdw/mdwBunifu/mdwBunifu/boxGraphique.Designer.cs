namespace mdwBunifu
{
    partial class boxGraphique
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(boxGraphique));
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDebut = new ns1.BunifuDatepicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFin = new ns1.BunifuDatepicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxTendance = new ns1.BunifuCheckbox();
            this.chartmesure = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lbxLeft = new System.Windows.Forms.ListBox();
            this.lbxRight = new System.Windows.Forms.ListBox();
            this.lblDispo = new System.Windows.Forms.Label();
            this.lblAfficher = new System.Windows.Forms.Label();
            this.tbxType = new ns1.BunifuMetroTextbox();
            this.lblError = new System.Windows.Forms.Label();
            this.pbAdd = new System.Windows.Forms.PictureBox();
            this.pbDel = new System.Windows.Forms.PictureBox();
            this.btnToRight = new ns1.BunifuThinButton2();
            this.btnToLeft = new ns1.BunifuThinButton2();
            this.gbtype = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartmesure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDel)).BeginInit();
            this.gbtype.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(454, 30);
            this.label1.TabIndex = 12;
            this.label1.Text = "Graphique des mesures de glycémie";
            // 
            // dtpDebut
            // 
            this.dtpDebut.BackColor = System.Drawing.Color.SeaGreen;
            this.dtpDebut.BorderRadius = 0;
            this.dtpDebut.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDebut.ForeColor = System.Drawing.Color.White;
            this.dtpDebut.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpDebut.FormatCustom = null;
            this.dtpDebut.Location = new System.Drawing.Point(112, 367);
            this.dtpDebut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpDebut.Name = "dtpDebut";
            this.dtpDebut.Size = new System.Drawing.Size(217, 26);
            this.dtpDebut.TabIndex = 13;
            this.dtpDebut.Value = new System.DateTime(2018, 6, 4, 15, 31, 9, 819);
            this.dtpDebut.onValueChanged += new System.EventHandler(this.dtp_onValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 371);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Date de début ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 403);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Date de fin";
            // 
            // dtpFin
            // 
            this.dtpFin.BackColor = System.Drawing.Color.SeaGreen;
            this.dtpFin.BorderRadius = 0;
            this.dtpFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFin.ForeColor = System.Drawing.Color.White;
            this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpFin.FormatCustom = null;
            this.dtpFin.Location = new System.Drawing.Point(112, 399);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(217, 26);
            this.dtpFin.TabIndex = 15;
            this.dtpFin.Value = new System.DateTime(2018, 6, 4, 15, 31, 9, 819);
            this.dtpFin.onValueChanged += new System.EventHandler(this.dtp_onValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(54, 435);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Tendance";
            // 
            // cbxTendance
            // 
            this.cbxTendance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.cbxTendance.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.cbxTendance.Checked = false;
            this.cbxTendance.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.cbxTendance.ForeColor = System.Drawing.Color.White;
            this.cbxTendance.Location = new System.Drawing.Point(131, 432);
            this.cbxTendance.Name = "cbxTendance";
            this.cbxTendance.Size = new System.Drawing.Size(20, 20);
            this.cbxTendance.TabIndex = 18;
            this.cbxTendance.OnChange += new System.EventHandler(this.cbxTendance_OnChange);
            // 
            // chartmesure
            // 
            this.chartmesure.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chartmesure.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartmesure.Legends.Add(legend1);
            this.chartmesure.Location = new System.Drawing.Point(0, 52);
            this.chartmesure.Name = "chartmesure";
            this.chartmesure.Size = new System.Drawing.Size(565, 300);
            this.chartmesure.TabIndex = 0;
            this.chartmesure.Text = "chart1";
            // 
            // lbxLeft
            // 
            this.lbxLeft.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxLeft.FormattingEnabled = true;
            this.lbxLeft.ItemHeight = 16;
            this.lbxLeft.Location = new System.Drawing.Point(45, 29);
            this.lbxLeft.Name = "lbxLeft";
            this.lbxLeft.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbxLeft.Size = new System.Drawing.Size(96, 132);
            this.lbxLeft.TabIndex = 19;
            // 
            // lbxRight
            // 
            this.lbxRight.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxRight.FormattingEnabled = true;
            this.lbxRight.ItemHeight = 16;
            this.lbxRight.Location = new System.Drawing.Point(197, 29);
            this.lbxRight.Name = "lbxRight";
            this.lbxRight.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbxRight.Size = new System.Drawing.Size(94, 132);
            this.lbxRight.TabIndex = 20;
            // 
            // lblDispo
            // 
            this.lblDispo.AutoSize = true;
            this.lblDispo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDispo.Location = new System.Drawing.Point(42, 6);
            this.lblDispo.Name = "lblDispo";
            this.lblDispo.Size = new System.Drawing.Size(99, 17);
            this.lblDispo.TabIndex = 21;
            this.lblDispo.Text = "Type disponible";
            // 
            // lblAfficher
            // 
            this.lblAfficher.AutoSize = true;
            this.lblAfficher.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAfficher.Location = new System.Drawing.Point(194, 6);
            this.lblAfficher.Name = "lblAfficher";
            this.lblAfficher.Size = new System.Drawing.Size(95, 17);
            this.lblAfficher.TabIndex = 22;
            this.lblAfficher.Text = "Type à afficher";
            // 
            // tbxType
            // 
            this.tbxType.BorderColorFocused = System.Drawing.Color.Blue;
            this.tbxType.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbxType.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.tbxType.BorderThickness = 1;
            this.tbxType.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxType.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbxType.isPassword = false;
            this.tbxType.Location = new System.Drawing.Point(45, 168);
            this.tbxType.Margin = new System.Windows.Forms.Padding(4);
            this.tbxType.Name = "tbxType";
            this.tbxType.Size = new System.Drawing.Size(96, 23);
            this.tbxType.TabIndex = 25;
            this.tbxType.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(40, 195);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(127, 17);
            this.lblError.TabIndex = 28;
            this.lblError.Text = "Valeur déjà ajoutée";
            this.lblError.Visible = false;
            // 
            // pbAdd
            // 
            this.pbAdd.Image = global::mdwBunifu.Properties.Resources.icons8_coche_16;
            this.pbAdd.Location = new System.Drawing.Point(148, 173);
            this.pbAdd.Name = "pbAdd";
            this.pbAdd.Size = new System.Drawing.Size(19, 18);
            this.pbAdd.TabIndex = 27;
            this.pbAdd.TabStop = false;
            this.pbAdd.Click += new System.EventHandler(this.pbAdd_Click);
            // 
            // pbDel
            // 
            this.pbDel.Image = global::mdwBunifu.Properties.Resources.icons8_multiplier_16__1_;
            this.pbDel.Location = new System.Drawing.Point(173, 173);
            this.pbDel.Name = "pbDel";
            this.pbDel.Size = new System.Drawing.Size(19, 18);
            this.pbDel.TabIndex = 26;
            this.pbDel.TabStop = false;
            this.pbDel.Click += new System.EventHandler(this.pbDel_Click);
            // 
            // btnToRight
            // 
            this.btnToRight.ActiveBorderThickness = 1;
            this.btnToRight.ActiveCornerRadius = 20;
            this.btnToRight.ActiveFillColor = System.Drawing.Color.White;
            this.btnToRight.ActiveForecolor = System.Drawing.Color.Black;
            this.btnToRight.ActiveLineColor = System.Drawing.Color.White;
            this.btnToRight.BackColor = System.Drawing.Color.White;
            this.btnToRight.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnToRight.BackgroundImage")));
            this.btnToRight.ButtonText = "→";
            this.btnToRight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnToRight.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToRight.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnToRight.IdleBorderThickness = 1;
            this.btnToRight.IdleCornerRadius = 20;
            this.btnToRight.IdleFillColor = System.Drawing.Color.White;
            this.btnToRight.IdleForecolor = System.Drawing.Color.Black;
            this.btnToRight.IdleLineColor = System.Drawing.Color.White;
            this.btnToRight.Location = new System.Drawing.Point(157, 102);
            this.btnToRight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnToRight.Name = "btnToRight";
            this.btnToRight.Size = new System.Drawing.Size(21, 17);
            this.btnToRight.TabIndex = 24;
            this.btnToRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnToRight.Click += new System.EventHandler(this.btnToRight_Click);
            // 
            // btnToLeft
            // 
            this.btnToLeft.ActiveBorderThickness = 1;
            this.btnToLeft.ActiveCornerRadius = 20;
            this.btnToLeft.ActiveFillColor = System.Drawing.Color.White;
            this.btnToLeft.ActiveForecolor = System.Drawing.Color.Black;
            this.btnToLeft.ActiveLineColor = System.Drawing.Color.White;
            this.btnToLeft.BackColor = System.Drawing.Color.White;
            this.btnToLeft.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnToLeft.BackgroundImage")));
            this.btnToLeft.ButtonText = "←\t";
            this.btnToLeft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnToLeft.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToLeft.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnToLeft.IdleBorderThickness = 1;
            this.btnToLeft.IdleCornerRadius = 20;
            this.btnToLeft.IdleFillColor = System.Drawing.Color.White;
            this.btnToLeft.IdleForecolor = System.Drawing.Color.Black;
            this.btnToLeft.IdleLineColor = System.Drawing.Color.White;
            this.btnToLeft.Location = new System.Drawing.Point(157, 76);
            this.btnToLeft.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnToLeft.Name = "btnToLeft";
            this.btnToLeft.Size = new System.Drawing.Size(21, 17);
            this.btnToLeft.TabIndex = 23;
            this.btnToLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnToLeft.Click += new System.EventHandler(this.btnToLeft_Click);
            // 
            // gbtype
            // 
            this.gbtype.Controls.Add(this.lbxLeft);
            this.gbtype.Controls.Add(this.lblError);
            this.gbtype.Controls.Add(this.lbxRight);
            this.gbtype.Controls.Add(this.pbAdd);
            this.gbtype.Controls.Add(this.lblDispo);
            this.gbtype.Controls.Add(this.pbDel);
            this.gbtype.Controls.Add(this.lblAfficher);
            this.gbtype.Controls.Add(this.tbxType);
            this.gbtype.Controls.Add(this.btnToLeft);
            this.gbtype.Controls.Add(this.btnToRight);
            this.gbtype.Location = new System.Drawing.Point(335, 342);
            this.gbtype.Name = "gbtype";
            this.gbtype.Size = new System.Drawing.Size(317, 210);
            this.gbtype.TabIndex = 29;
            this.gbtype.TabStop = false;
            // 
            // boxGraphique
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gbtype);
            this.Controls.Add(this.cbxTendance);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpFin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpDebut);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chartmesure);
            this.Name = "boxGraphique";
            this.Size = new System.Drawing.Size(711, 566);
            ((System.ComponentModel.ISupportInitialize)(this.chartmesure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDel)).EndInit();
            this.gbtype.ResumeLayout(false);
            this.gbtype.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private ns1.BunifuDatepicker dtpDebut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private ns1.BunifuDatepicker dtpFin;
        private System.Windows.Forms.Label label4;
        private ns1.BunifuCheckbox cbxTendance;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartmesure;
        private System.Windows.Forms.ListBox lbxLeft;
        private System.Windows.Forms.ListBox lbxRight;
        private System.Windows.Forms.Label lblDispo;
        private System.Windows.Forms.Label lblAfficher;
        private ns1.BunifuThinButton2 btnToLeft;
        private ns1.BunifuThinButton2 btnToRight;
        private ns1.BunifuMetroTextbox tbxType;
        private System.Windows.Forms.PictureBox pbDel;
        private System.Windows.Forms.PictureBox pbAdd;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.GroupBox gbtype;
    }
}
