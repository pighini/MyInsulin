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
            CreateChart("DAY");

        }
        
        private void CreateChart(string unit)
        {
            chartmesure.Series.Clear();
            const string uDay = "DAY";
            const  string uMonth = "MONTH";
            const string uYear = "YEAR";
            Series poids = new Series
            {
                Name = "Poids",
                ChartType = SeriesChartType.Line,
                XValueType = ChartValueType.DateTime,
                YValueType = ChartValueType.Int32,
                MarkerStyle = MarkerStyle.Circle,
                MarkerSize = 5,
                MarkerColor = Color.Red
            };
            DateTime dateDeb;
            DateTime dateFin;
            List<Measure> mesures;


            switch (unit)
            {
                case uDay:
                    mesures = Model.GetMesure(8, uDay);
                    dateDeb = mesures.ElementAt(0).DateMesure;
                    dateFin = mesures.ElementAt(mesures.Count - 1).DateMesure;
                    lblEnd.Text = this.Model.DateForDays(dateFin);
                    lblStart.Text = this.Model.DateForDays(dateDeb);
                    break;
                case uMonth:
                    mesures = Model.GetMesure(1,uMonth);
                     dateDeb = mesures.ElementAt(0).DateMesure;
                     dateFin = mesures.ElementAt(mesures.Count - 1).DateMesure;
                    lblEnd.Text = this.Model.DateForDays(dateFin);
                    lblStart.Text = this.Model.DateForDays(dateDeb);
                    break;
                case uYear:
                    mesures = Model.GetMesure(1, uYear);
                    dateDeb = mesures.ElementAt(0).DateMesure;
                    dateFin = mesures.ElementAt(mesures.Count - 1).DateMesure;
                    lblEnd.Text = this.Model.DateForDays(dateFin);
                    lblStart.Text = this.Model.DateForDays(dateDeb);
                    break;
                default:
                    mesures = Model.GetMesure(8, uDay);
                    break;
            }
            foreach (var mes in mesures)
            {

                poids.Points.AddXY(this.Model.DateForDays(mes.DateMesure), mes.Glucose);

            }

            
            
            chartmesure.Series.Add(poids);


        }
        

        //private void bunifuCheckbox_Click(object sender, EventArgs e)
        //{
        //    ns1.BunifuCheckbox radioBtn = (ns1.BunifuCheckbox)sender;
        //    if(radioBtn.Tag == cbxTendance.Tag)
        //    {
        //        bunifuCheckbox2.Checked = false;
        //        bunifuCheckbox3.Checked = false;
        //    }
        //    if (radioBtn.Tag == bunifuCheckbox2.Tag)
        //    {
        //        cbxTendance.Checked = false;
        //        bunifuCheckbox3.Checked = false;
        //    }
        //    if(radioBtn.Tag == bunifuCheckbox3.Tag)
        //    {
        //        cbxTendance.Checked = false;
        //        bunifuCheckbox2.Checked = false;
        //    }
        //    CreateChart(radioBtn.Tag.ToString());
        //}
    }
}
