using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mdwBunifu
{
    public partial class vRecommandation : UserControl
    {
        private ModelMyInsulin _modele;

        public ModelMyInsulin Modele
        {
            get { return _modele; }
            set { _modele = value; }
        }
        private bool _alreadyAdded;

        public bool AlreadyAdded
        {
            get { return _alreadyAdded; }
            set { _alreadyAdded = value; }
        }

        private int _idReco;

        public int IdReco
        {
            get { return _idReco; }
            set { _idReco = value; }
        }
        private double _min;

        public double Min
        {
            get { return _min; }
            set { _min = value; }
        }
        private double _max;

        public double Max
        {
            get { return _max; }
            set { _max = value; }
        }
        private double _nbRecommandation;

        public double NbRecommandation
        {
            get { return _nbRecommandation; }
            set { _nbRecommandation = value; }
        }
        private int _idUser;

        public int IdUser
        {
            get { return _idUser; }
            set { _idUser = value; }
        }
        private int oldMin;
        private int oldMax;
        private int oldReco;
        private bool toAdd;
        public vRecommandation(ModelMyInsulin mod, int id, double min, double max, double reco, int idUser, bool added)
        {
            InitializeComponent();
            this.Modele = mod;
            this.IdReco = id;
            this.Min = min;
            this.Max = max;
            this.NbRecommandation = reco;
            this.IdUser = idUser;
            this.AlreadyAdded = added;
            FillWithValue();
            pbChange.Image = Properties.Resources.icons8_edit_property_26_lightGrey;
       

        }
        private void FillWithValue()
        {
            tbxMin.Text = this.Min.ToString();
            tbxMax.Text = this.Max.ToString();
            tbxReco.Text = this.NbRecommandation.ToString();
        }

        private void tbx_OnValueChanged(object sender, EventArgs e)
        {
            pbChange.Image = Properties.Resources.icons8_edit_orange;
            toAdd = true;
            double min;
            double max;
            double reco;
            try
            {
                 min = Convert.ToDouble(tbxMin.Text);
                 max = Convert.ToDouble(tbxMax.Text);
                 reco = Convert.ToDouble(tbxReco.Text);
            }
            catch
            {
                min = 0;
                max = 0;
                reco = 0;
            }

            if ( min < this.Modele.GetMaxGluc(this.IdUser) || max < min || reco < this.Modele.getMaxReco(this.IdUser) )
            {
                pbChange.Image = Properties.Resources.icons8_edit_property_26_red;
                toAdd = false;
            }
           
        }

        private void pbChange_Click(object sender, EventArgs e)
        {
            Image img = Properties.Resources.icons8_edit_property_26_red;
            if (toAdd )
            {
                if (this.AlreadyAdded)
                {
                    this.Min = Convert.ToDouble(tbxMin.Text);
                    this.Max = Convert.ToDouble(tbxMax.Text);
                    this.NbRecommandation = Convert.ToInt32(tbxReco.Text);
                    pbChange.Image = Properties.Resources.icons8_edit_green;
                    this.Modele.ChangeReco(this.IdReco, this.Min, this.Max, this.NbRecommandation);
                    pbChange.Refresh();
                    System.Threading.Thread.Sleep(1000);
                    pbChange.Image = Properties.Resources.icons8_edit_property_26_lightGrey;
                }
                else
                {
                    this.Min = Convert.ToInt32(tbxMin.Text);
                    this.Max = Convert.ToInt32(tbxMax.Text);
                    this.NbRecommandation = Convert.ToInt32(tbxReco.Text);
                    pbChange.Image = Properties.Resources.icons8_edit_green;
                    DateTime dateMesure = DateTime.Now;
                    string sqlDate = dateMesure.ToString("yyyy-MM-dd");
                    this.Modele.AddReco(this.IdReco, this.Min, this.Max, this.NbRecommandation, sqlDate, this.IdUser);
                    pbChange.Refresh();
                    System.Threading.Thread.Sleep(1000);
                    pbChange.Image = Properties.Resources.icons8_edit_property_26_lightGrey;
                }
            }
            else
            {
                MessageBox.Show("Les données ne sont pas cohérentes");
            }
        }

        private void pbDel_Click(object sender, EventArgs e)
        {
            this.Modele.Delete(this.IdReco);
            this.Parent = null;
        }
    }
}
