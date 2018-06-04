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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.chartmesure = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblEnd = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDebut = new ns1.BunifuDatepicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFin = new ns1.BunifuDatepicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxTendance = new ns1.BunifuCheckbox();
            this.label5 = new System.Windows.Forms.Label();
            this.ddType1 = new ns1.BunifuDropdown();
            this.ddType2 = new ns1.BunifuDropdown();
            this.label6 = new System.Windows.Forms.Label();
            this.ddType3 = new ns1.BunifuDropdown();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartmesure)).BeginInit();
            this.SuspendLayout();
            // 
            // chartmesure
            // 
            this.chartmesure.BackColor = System.Drawing.Color.Transparent;
            chartArea3.Name = "ChartArea1";
            this.chartmesure.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartmesure.Legends.Add(legend3);
            this.chartmesure.Location = new System.Drawing.Point(0, 52);
            this.chartmesure.Name = "chartmesure";
            this.chartmesure.Size = new System.Drawing.Size(565, 300);
            this.chartmesure.TabIndex = 0;
            this.chartmesure.Text = "chart1";
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStart.Location = new System.Drawing.Point(23, 326);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(34, 13);
            this.lblStart.TabIndex = 10;
            this.lblStart.Text = "Start";
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnd.Location = new System.Drawing.Point(444, 324);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(29, 13);
            this.lblEnd.TabIndex = 11;
            this.lblEnd.Text = "End";
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
            this.dtpDebut.ForeColor = System.Drawing.Color.White;
            this.dtpDebut.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpDebut.FormatCustom = null;
            this.dtpDebut.Location = new System.Drawing.Point(131, 366);
            this.dtpDebut.Name = "dtpDebut";
            this.dtpDebut.Size = new System.Drawing.Size(108, 27);
            this.dtpDebut.TabIndex = 13;
            this.dtpDebut.Value = new System.DateTime(2018, 6, 4, 15, 31, 9, 819);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 371);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Date de début ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 403);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Date de fin";
            // 
            // dtpFin
            // 
            this.dtpFin.BackColor = System.Drawing.Color.SeaGreen;
            this.dtpFin.BorderRadius = 0;
            this.dtpFin.ForeColor = System.Drawing.Color.White;
            this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpFin.FormatCustom = null;
            this.dtpFin.Location = new System.Drawing.Point(131, 399);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(108, 27);
            this.dtpFin.TabIndex = 15;
            this.dtpFin.Value = new System.DateTime(2018, 6, 4, 15, 31, 9, 819);
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
            this.cbxTendance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.cbxTendance.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.cbxTendance.Checked = false;
            this.cbxTendance.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.cbxTendance.ForeColor = System.Drawing.Color.White;
            this.cbxTendance.Location = new System.Drawing.Point(131, 432);
            this.cbxTendance.Name = "cbxTendance";
            this.cbxTendance.Size = new System.Drawing.Size(20, 20);
            this.cbxTendance.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(310, 371);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Type 1";
            // 
            // ddType1
            // 
            this.ddType1.BackColor = System.Drawing.Color.Transparent;
            this.ddType1.BorderRadius = 3;
            this.ddType1.ForeColor = System.Drawing.Color.White;
            this.ddType1.Items = new string[0];
            this.ddType1.Location = new System.Drawing.Point(363, 369);
            this.ddType1.Name = "ddType1";
            this.ddType1.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.ddType1.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.ddType1.selectedIndex = -1;
            this.ddType1.Size = new System.Drawing.Size(65, 22);
            this.ddType1.TabIndex = 20;
            // 
            // ddType2
            // 
            this.ddType2.BackColor = System.Drawing.Color.Transparent;
            this.ddType2.BorderRadius = 3;
            this.ddType2.ForeColor = System.Drawing.Color.White;
            this.ddType2.Items = new string[0];
            this.ddType2.Location = new System.Drawing.Point(363, 398);
            this.ddType2.Name = "ddType2";
            this.ddType2.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.ddType2.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.ddType2.selectedIndex = -1;
            this.ddType2.Size = new System.Drawing.Size(65, 22);
            this.ddType2.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(310, 400);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "Type 2";
            // 
            // ddType3
            // 
            this.ddType3.BackColor = System.Drawing.Color.Transparent;
            this.ddType3.BorderRadius = 3;
            this.ddType3.ForeColor = System.Drawing.Color.White;
            this.ddType3.Items = new string[0];
            this.ddType3.Location = new System.Drawing.Point(363, 426);
            this.ddType3.Name = "ddType3";
            this.ddType3.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.ddType3.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.ddType3.selectedIndex = -1;
            this.ddType3.Size = new System.Drawing.Size(65, 22);
            this.ddType3.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(310, 428);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 17);
            this.label7.TabIndex = 23;
            this.label7.Text = "Type 3";
            // 
            // boxGraphique
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ddType3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ddType2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ddType1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbxTendance);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpFin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpDebut);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.chartmesure);
            this.Name = "boxGraphique";
            this.Size = new System.Drawing.Size(578, 464);
            ((System.ComponentModel.ISupportInitialize)(this.chartmesure)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartmesure;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.Label label1;
        private ns1.BunifuDatepicker dtpDebut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private ns1.BunifuDatepicker dtpFin;
        private System.Windows.Forms.Label label4;
        private ns1.BunifuCheckbox cbxTendance;
        private System.Windows.Forms.Label label5;
        private ns1.BunifuDropdown ddType1;
        private ns1.BunifuDropdown ddType2;
        private System.Windows.Forms.Label label6;
        private ns1.BunifuDropdown ddType3;
        private System.Windows.Forms.Label label7;
    }
}
