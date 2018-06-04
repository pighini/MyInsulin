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
    public partial class boxMesures : UserControl
    {
        
        private ModelMeasure _model;
        private bool _mod;

        public bool Modification
        {
            get { return _mod; }
            set { _mod = value; }
        }


        public ModelMeasure Modele
        {
            get { return _model; }
            set { _model = value; }
        }

        public boxMesures(ModelMeasure modele, bool mod)
        {
            InitializeComponent();
            Modele = modele;
            this.Modification = mod;
            if(this.Modification)
            {
                fillWithValue();
            }
        }
        private void fillWithValue()
        {
            
            int cpt = 0;
            int typePos = 0;
            foreach (var type in ddType.Items)
            {
                if (type.ToString() == this.Modele.Mes.Type)
                {
                    typePos = cpt;
                }
                cpt++;
            }
            
            tbxGlycemie.Text = this.Modele.Mes.Glucose.ToString();
            tbxInsuline.Text = this.Modele.Mes.InsulinRecommandation.ToString();
            ddType.selectedIndex = typePos;
            dtpDateMesure.Value = this.Modele.Mes.DateMesure;
        }
        private void lblGlycemie_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Glycémie obligatoire");
        }

        private void btnSendMesure_Click(object sender, EventArgs e)
        {
            if (!this.Modification)
            {
                if (this.Modele.isCoOpen())
                {
                    if (tbxGlycemie.Text != "")
                    {
                        int glucose = Convert.ToInt32(tbxGlycemie.Text);
                        int insu = Convert.ToInt32(tbxInsuline.Text);
                        string comment = tbxCommentary.Text;

                        string type = ddType.selectedValue;
                        tbxGlycemie.Text = "";
                        DateTime dateMesure = dtpDateMesure.Value;
                        this.Modele.AddMesure(glucose, insu, comment, type, dateMesure);
                        lblSend.Visible = true;
                        lblSend.Text = "Mesure envoyé";
                        lblSend.Refresh();
                        System.Threading.Thread.Sleep(1000);
                        lblSend.Visible = false;
                    }
                    else
                    {

                        lblGlycemie_Click(sender, e);
                    }
                }
                else
                {
                    lblSend.Visible = true;
                    lblSend.Text = "Problème de connexion";
                    lblSend.Refresh();
                    System.Threading.Thread.Sleep(1000);
                    lblSend.Visible = false;
                }
            }
            else
            {
                if (this.Modele.isCoOpen())
                {
                    if (tbxGlycemie.Text != "")
                    {
                        int glucose = Convert.ToInt32(tbxGlycemie.Text);
                        int insu = Convert.ToInt32(tbxInsuline.Text);
                        string comment = tbxCommentary.Text;

                        string type = ddType.selectedValue;
                        tbxGlycemie.Text = "";
                        DateTime dateMesure = dtpDateMesure.Value;
                        this.Modele.ChangeMesure(glucose, insu, comment, type, dateMesure,Modele.Mes.IdMesure);
                        lblSend.Visible = true;
                        lblSend.Text = "Mesure modifiée";
                        lblSend.Refresh();
                        System.Threading.Thread.Sleep(1000);
                        lblSend.Visible = false;
                    }
                    else
                    {

                        lblGlycemie_Click(sender, e);
                    }
                }
            }
        }
        

        private void tbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            filtrage(sender, e);
        }
        private void filtrage(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            
        }


    }
}
