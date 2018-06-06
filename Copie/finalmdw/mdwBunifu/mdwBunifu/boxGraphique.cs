using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace mdwBunifu
{
    public partial class boxGraphique : UserControl
    {
        private ModelMeasure _model;

        public ModelMeasure Model
        {
            get { return _model; }
            set { _model = value; }
        }

        public boxGraphique(ModelMeasure mod)
        {
            InitializeComponent();
            this.Model = mod;
            dtpDebut.Value = DateTime.Now;
            dtpFin.Value = DateTime.Now.AddDays(1);
            fillTypes();


        }
        private void fillTypes()
        {
            foreach (string type in this.Model.GetAllTypes())
            {
                lbxLeft.Items.Add(type);
            }
        }
        private void CreateChart()
        {
            foreach (string type in lbxRight.Items)
            {
                chartmesure.Series.Clear();
                Series glycemie = new Series
                {
                    Name = type,
                    ChartType = SeriesChartType.Line,
                    XValueType = ChartValueType.DateTime,
                    YValueType = ChartValueType.Int32,
                    MarkerStyle = MarkerStyle.Circle,
                    MarkerSize = 5,
                    MarkerColor = Color.Red
                };
                DateTime dateMesure = dtpDebut.Value;
                string dateDeb = dateMesure.ToString("yyyy-MM-dd");
                dateMesure = dtpFin.Value;
                string dateFin = dateMesure.ToString("yyyy-MM-dd");
                List<Measure> mesures;
                mesures = this.Model.GetMesureByType(dateDeb, dateFin, type);

                foreach (var mes in mesures)
                {

                    mes.DateMesure = mes.DateMesure.Substring(0, 5).Replace('.', '-');
                    glycemie.Points.AddXY(mes.DateMesure, mes.Glucose);

                }



                chartmesure.Series.Add(glycemie);
            }

        }

        private void dtp_onValueChanged(object sender, EventArgs e)
        {
            CreateChart();
        }

        private void cbxTendance_OnChange(object sender, EventArgs e)
        {

        }

        private void btnToRight_Click(object sender, EventArgs e)
        {
            ListBox lsbtmp = new ListBox();
            foreach (var item in lbxLeft.SelectedItems)
            {
                lsbtmp.Items.Add(item);
            }
            foreach (var item in lsbtmp.Items)
            {
                lbxLeft.Items.Remove(item);
                lbxRight.Items.Add(item);
            }
            if(lbxLeft.Items.Count == 0)
            {
                btnToRight.Enabled = false;
            }
            else
            {
                btnToRight.Enabled = true;

            }
            if(lbxRight.Items.Count == 0)
            {
                btnToLeft.Enabled = false;
            }
            else
            {
                btnToLeft.Enabled = true;

            }
        }

        private void btnToLeft_Click(object sender, EventArgs e)
        {
            ListBox lsbtmp = new ListBox();
            foreach (var item in lbxRight.SelectedItems)
            {
                lsbtmp.Items.Add(item);
            }
            foreach (var item in lsbtmp.Items)
            {
                lbxRight.Items.Remove(item);
                lbxLeft.Items.Add(item);
            }
        }
    }
}
