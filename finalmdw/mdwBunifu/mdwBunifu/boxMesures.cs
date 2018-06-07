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

        private ModelMyInsulin _modelInsu;

        public ModelMyInsulin ModelInsu
        {
            get { return _modelInsu; }
            set { _modelInsu = value; }
        }
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
            
            this.ModelInsu = new ModelMyInsulin();
            tbxInsuline.Enabled = false;
            btnDelete.Visible = false;
            foreach (string type in this.Modele.GetAllTypesByUser())
            {
                ddType.AddItem(type);
            }
            if (this.Modification)
            {
                fillWithValue(this.Modele.Mes);
            }
            else
            {
                btnSendMesure.ButtonText = "Envoyer";
            }
        }
        private void fillWithValue(Measure mes)
        {
            
            int cpt = 0;
            int typePos = 0;
            
            foreach (var type in ddType.Items)
            {
                if (type.ToString() == mes.Type)
                {
                    typePos = cpt;
                }
                cpt++;
            }
            
            
            tbxGlycemie.Text = mes.Glucose.ToString();
            tbxInsuline.Text = mes.InsulinRecommandation.ToString();
            ddType.selectedIndex = typePos;
            btnSendMesure.ButtonText = "Modifier";
            tbxInsuline.Enabled = true;
            btnDelete.Visible = true;
            dtpDateMesure.Value = Convert.ToDateTime(mes.DateMesure);
        }
        private void lblGlycemie_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Champs obligatoire");
        }

        private void btnSendMesure_Click(object sender, EventArgs e)
        {

            //Verifie si l'user est en modif
            if (!this.Modification)
            {
                //Mode insertion
                if (this.Modele.isCoOpen())
                {
                    string type;
                    try
                    {
                        type = ddType.selectedValue;
                    }
                    catch
                    {
                        type = "0";
                    }
                    if (tbxGlycemie.Text != "" && type !="0")
                    {
                        double glucose = Convert.ToDouble(tbxGlycemie.Text);
                        string comment = tbxCommentary.Text;
                        
                        
                        tbxGlycemie.Text = "";
                        DateTime dateMesure = dtpDateMesure.Value;                      
                        string sqlDate = dateMesure.ToString("yyyy-MM-dd");


                        if (!this.Modele.verifMeasure(sqlDate, type))
                        {
                            double reco = this.ModelInsu.getRecommandationInsu(glucose, this.Modele.ConnectedUser.IdUser);
                            this.Modele.AddMesure(glucose,reco, comment, type, sqlDate);
                            lblSend.Visible = true;
                            lblSend.Text = "Mesure ajoutée";
                            lblSend.Refresh();
                            System.Threading.Thread.Sleep(1000);
                            lblSend.Visible = false;
                        }
                        else
                        {
                            DialogResult dialogResult = MessageBox.Show("Vous avez déjà une mesure de ce type", "Souhaitez-vous modifier la mesure existante ? ", MessageBoxButtons.YesNo);
                            if (dialogResult == DialogResult.Yes)
                            {
                                this.Modele.Mes = this.Modele.GetMesureByTypeAndDate(sqlDate, type);

                                this.Modele.ChangeMesure(glucose, this.ModelInsu.getRecommandationInsu(glucose,this.Modele.ConnectedUser.IdUser) , comment, type, sqlDate, this.Modele.Mes.IdMesure);



                            }
                            else if (dialogResult == DialogResult.No)
                            {
                                MessageBox.Show("La mesure n'a pas été changer");
                                tbxGlycemie.Text = glucose.ToString();
                                tbxCommentary.Text = comment; 
                                
                            }
                        }
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
                        
                        double glucose = Convert.ToDouble(tbxGlycemie.Text);
                        double insu = Convert.ToDouble(tbxInsuline.Text);
                        string comment = tbxCommentary.Text;
                        tbxInsuline.Enabled = true;
                        btnDelete.Visible = true ;
                        string type = ddType.selectedValue;
                        tbxGlycemie.Text = "";
                        DateTime dateMesure = dtpDateMesure.Value;
                        string sqlDate = dateMesure.ToString("yyyy-MM-dd");


                        if (!this.Modele.verifMeasure(sqlDate, type) && this.Modele.Mes.IdMesure != this.Modele.GetMesureByTypeAndDate(sqlDate, type).IdMesure)
                        {
                            this.Modele.ChangeMesure(glucose, insu, comment, type, sqlDate, Modele.Mes.IdMesure);
                            lblSend.Visible = true;
                            lblSend.Text = "Mesure modifiée";
                            lblSend.Refresh();
                            System.Threading.Thread.Sleep(1000);
                            lblSend.Visible = false;
                        }
                        else
                        {
                            this.Modele.Mes = this.Modele.GetMesureByTypeAndDate(sqlDate, type);
                            DialogResult dialogResult = MessageBox.Show("Vous avez déjà une mesure de ce type", "Souhaitez-vous modifier la mesure existante ? ", MessageBoxButtons.YesNo);
                            if (dialogResult == DialogResult.Yes)
                            {

                                this.Modele.ChangeMesure(glucose, this.ModelInsu.getRecommandationInsu(glucose,this.Modele.ConnectedUser.IdUser), comment, type, sqlDate, this.Modele.Mes.IdMesure);



                            }
                            else if (dialogResult == DialogResult.No)
                            {
                                MessageBox.Show("La mesure n'a pas été changer");
                                fillWithValue(this.Modele.Mes);
                            }
                        }
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

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
