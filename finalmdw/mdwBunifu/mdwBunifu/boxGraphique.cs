/* Project : MyInsulin 
 * Author : Lucas Pighini CFPT-I
 * Description : The window that create the chart for the users
 * Date : 12.06.2018
 */
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
        //Class var
        private ModelMeasure _model;
        Series TrendSerie;
        Series AverageSerie;

        //Property
        public ModelMeasure Model
        {
            get { return _model; }
            set { _model = value; }
        }
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="mod"></param>
        public boxGraphique(ModelMeasure mod)
        {
            InitializeComponent();
            this.Model = mod;
            dtpDebut.Value = DateTime.Now;
            dtpFin.Value = DateTime.Now.AddDays(1);
            fillTypes();
            if(this.Model.ConnectedUser.IsDoctor)
            {
                plType.Visible = false;
            }


        }
        /// <summary>
        /// Fill the listbox with the types of the user connected
        /// </summary>
        private void fillTypes()
        {
            foreach (string type in this.Model.GetAllTypesByUser())
            {
                lbxLeft.Items.Add(type);
            }
        }
        /// <summary>
        /// Add to the chart the average of each day
        /// </summary>
        private void AddAverage()
        {
            if (AverageSerie != null)
            {
                chartmesure.Series.Remove(TrendSerie);
            }
            Series glycemie = new Series
            {
                Name = "Moyenne",
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
            double Trend;
            foreach (DateTime date in datesMeasure)
            {
                
                dateTend = date.ToString("yyyy-MM-dd");
                Trend = this.Model.GetMesureDate(dateTend);
                if (Trend != 0)
                {
                    glycemie.Points.AddXY(dateTend.Substring(5,5), Trend);
                }
            }            

            chartmesure.Series.Add(glycemie);
            AverageSerie = glycemie; 
        }
        /// <summary>
        /// Add the trend to the chart
        /// </summary>
        private void AddTrend()
        {
            Dictionary<string,double> Averages = new Dictionary<string, double>();
            DateTime dateDebut = dtpDebut.Value;
            DateTime dateFin = dtpFin.Value;
            string dateTend;
            double Average;
            int cptTend = 0;
            double Trend = 0;


            List<DateTime> datesMeasure = new List<DateTime>();
            int cpt = 0;
            if (TrendSerie != null)
            {
                chartmesure.Series.Remove(TrendSerie);
            }
            Series glycemie = new Series
            {
                Name = "Tendance",
                ChartType = SeriesChartType.Line,
                XValueType = ChartValueType.DateTime,
                YValueType = ChartValueType.Int32,
                MarkerStyle = MarkerStyle.Circle,
                MarkerSize = 5,
                MarkerColor = Color.Green
            };
         
            for (DateTime i = dateDebut; i < dateFin; i = i.AddDays(1))
            {
                cpt++;
                datesMeasure.Add(i);
            }
       
            foreach (DateTime date in datesMeasure)
            {

                dateTend = date.ToString("yyyy-MM-dd");
                Average = this.Model.GetMesureDate(dateTend);
                if (Average != 0)
                {
                    Averages.Add(dateTend, Average);
                }
            }
        
            foreach (var moy in Averages)
            {
                cptTend++;
                Trend += moy.Value;
                if(cptTend>1)
                {
                    glycemie.Points.AddXY(moy.Key.Substring(5,5), Trend/cptTend);

                }

            }
            chartmesure.Series.Add(glycemie);
            TrendSerie = glycemie;
        }
        /// <summary>
        /// Add each curve that the the user has select
        /// </summary>
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

        /// <summary>
        /// Event when the dateTimepicker's date change
        /// Refresh the chart
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtp_onValueChanged(object sender, EventArgs e)
        {
            AddByType();
            refreshTend();
            refreshAvg();
        }
        /// <summary>
        /// Check if the user want to see the average
        /// </summary>
        private void refreshAvg()
        {
            if(cbxAvg.Checked)
            {
                AddAverage();
            }
        }
        /// <summary>
        /// Check if the user want to see the trend
        /// </summary>
        private void refreshTend()
        {
            if (cbxTend.Checked)
            {
                AddTrend();
            }
        }
        /// <summary>
        /// Event when the checkbox's value change, it refresh the average
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxTrend_OnChange(object sender, EventArgs e)
        {
            refreshAvg();
        }
        /// <summary>
        /// Event when the user click, move the selected value of the listbox into the right one 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Event when the user click, move the selected value of the listbox into the left one
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Event when the user click on the pictureBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbAdd_Click(object sender, EventArgs e)
        {
            string type = tbxType.Text;
            int id;
            id = this.Model.GetTypeByName(type);
            if(id != 0)
            {
                if (tbxType.Text != "")
                {
                    if (!lbxLeft.Items.Contains(type))
                    {
                        this.Model.AddHasType(id, this.Model.ConnectedUser.IdUser);
                        lbxLeft.Items.Add(type);
                    }
                    else
                    {
                        lblError.Visible = true;
                        System.Threading.Thread.Sleep(1000);
                        lblError.Visible = false;

                    }
                }
                else
                {
                    MessageBox.Show("Veuillez remplir le champ");
                }
            }
            else
            {
                this.Model.AddType(type);
                id = this.Model.GetTypeByName(type);
                this.Model.AddHasType(id, this.Model.ConnectedUser.IdUser);
                lbxLeft.Items.Add(type);
                


            }
            
        }

        private void pbDel_Click(object sender, EventArgs e)
        {
            List<string> lbxToR = new List<string>();
           foreach(var type in lbxLeft.SelectedItems)
            {
                this.Model.DeleteType(this.Model.GetTypeByName(type.ToString()));
                lbxToR.Add(type.ToString());
                
            }
            foreach (var todel in lbxToR)
            {
                lbxLeft.Items.Remove(todel);
            }
        }

        private void cbxTend_OnChange(object sender, EventArgs e)
        {
            refreshTend();
            
        }
        private void cbxAvg_OnChange(object sender, EventArgs e)
        {
            refreshAvg();

        }
    }
}
