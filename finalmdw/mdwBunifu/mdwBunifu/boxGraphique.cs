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
        Series tendanceSerie;
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
            foreach (string type in this.Model.GetAllTypesByUser())
            {
                lbxLeft.Items.Add(type);
            }
        }
        private void AddTendance()
        {
            if (tendanceSerie != null)
            {
                chartmesure.Series.Remove(tendanceSerie);
            }
            Series glycemie = new Series
            {
                Name = "Tendance",
                ChartType = SeriesChartType.Line,
                XValueType = ChartValueType.DateTime,
                YValueType = ChartValueType.Int32,
                MarkerStyle = MarkerStyle.Circle,
                MarkerSize = 5,
                MarkerColor = Color.Pink
            };
            DateTime dateDebut = dtpDebut.Value;
            DateTime dateFin = dtpFin.Value;
            List<DateTime> datesMeasure = new List<DateTime>();
            int cpt = 0;
            for (DateTime i = dateDebut; i < dateFin; i= i.AddDays(1))
            {
                cpt++;
                datesMeasure.Add(i);
            }
            string dateTend;
            double tendance;
            foreach (DateTime date in datesMeasure)
            {
                
                dateTend = date.ToString("yyyy-MM-dd");
                tendance = this.Model.GetMesureDate(dateTend);
                if (tendance != 0)
                {
                    glycemie.Points.AddXY(dateTend, tendance);
                }
            }            

            chartmesure.Series.Add(glycemie);
            tendanceSerie = glycemie; 
        }
        private void AddByType()
        {
            Random rnd = new Random();
            chartmesure.Series.Clear();
            foreach (string type in lbxRight.Items)
            {
                
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
                string formattedDate;
                mesures = this.Model.GetMesureByType(dateDeb, dateFin, this.Model.GetTypeByName(type));

                foreach (var mes in mesures)
                {

                    formattedDate = mes.DateMesure.Substring(0, 5).Replace('.', '-');
                    glycemie.Points.AddXY(formattedDate, mes.Glucose);

                }

                chartmesure.Series.Add(glycemie);
            }

        }

        private void dtp_onValueChanged(object sender, EventArgs e)
        {
            AddByType();
            refreshTend();
        }
        private void refreshTend()
        {
            if(cbxTendance.Checked)
            {
                AddTendance();
            }
        }
        private void cbxTendance_OnChange(object sender, EventArgs e)
        {
            refreshTend();
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
            AddByType();
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
            AddByType();

        }
    }
}
