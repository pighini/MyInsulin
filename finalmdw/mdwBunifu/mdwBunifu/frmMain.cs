 using mayDaylyWeyght;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mdwBunifu
{
    public partial class frmMain : Form
    {
        private ModelUser _model;

        public ModelUser Model
        {
            get { return _model; }
            set { _model = value; }
        }
        private ModelMeasure _modelMesure;

        public ModelMeasure ModeleMesure
        {
            get { return _modelMesure; }
            set { _modelMesure = value; }
        }

        Dictionary<string, Image> btns = new Dictionary<string, Image>();
        btnAccueil btnSelected;

        public frmMain(ModelUser model)
        {
            InitializeComponent();
            ddPatient.Visible = false;
            lblPatient.Visible = false;
            this.Model = model;
            User usr = new User(this.Model.ConnectedUser);
            this.ModeleMesure = new ModelMeasure(usr);
            string[] namesPatient;
            CreateLeftButtons();
            if(this.Model.ConnectedUser.IsDoctor)
            {
                List<string> names = new List<string>();
                foreach (var item in this.Model.GetAllUserForDoc())
                {
                    names.Add(item[0] + " " + item[1]);
                }
                ddPatient.Items = names.ToArray();
                ddPatient.selectedIndex = 0;
                ddPatient.Visible = true;
                lblPatient.Visible = true;
                namesPatient = ddPatient.selectedValue.Split(' ');
                this.Model.ConnectedUser.IdUser = this.Model.ConnectedUser.IdUser;
              this.ModeleMesure.ConnectedUser.IdUser = this.Model.GetIdByNames(namesPatient[1],namesPatient[0]);
               
            }

        }
        private void CreateLeftButtons()
        {
            int cpt = 0;
            int locaY = 140;
            if (this.Model.ConnectedUser.IsDoctor)
            {
                btns.Add("Graphiques", Properties.Resources.icons8_statistics_32);
                btns.Add("Tableau", Properties.Resources.icons8_tableau_26);
                btns.Add("Recommandations", Properties.Resources.icons8_conseil_32);
                btns.Add("Patients", Properties.Resources.icons8_user_32);

            }
            else
            {
                btns.Add("Mesures", Properties.Resources.icons8_plus_32);
                btns.Add("Graphiques", Properties.Resources.icons8_statistics_32);
                btns.Add("Tableau", Properties.Resources.icons8_tableau_26);
                btns.Add("Recommandations", Properties.Resources.icons8_conseil_32);
                
            }

            foreach (var btn in btns)
            {
                cpt++;
                
                btnAccueil btnLeft = new btnAccueil(btn.Key, btn.Value,new Point(0,locaY));
                locaY += 69;
                btnLeft.Name = "btnAccueil" + cpt.ToString();
                btnLeft.Tag = cpt;
                btnLeft.Parent = plButtonAccueil;
                btnLeft.Click += btnAccueil_Click;
                plButtonAccueil.Controls.Add(btnLeft);
                foreach (Control item in btnLeft.Controls)
                {
                    item.Click += btnAccueil_Click;
                }
            }
        

        }
        private void showMesures()
        {
            boxMesures bxMes = new boxMesures(this.ModeleMesure, false)
            {
                Location = new Point(12, 13),
                Visible = true,
                Name = "Menu"
            };
            panelMenu.Controls.Add(bxMes);
        }
        private void showPatient()
        {
            boxPatient bxMes = new boxPatient(this.Model)
            {
                Location = new Point(12, 13),
                Visible = true,
                Name = "Menu"
            };
            panelMenu.Controls.Add(bxMes);
        }
        private void showReco()
        {
            boxRecommandation bxProf = new boxRecommandation(this.ModeleMesure.ConnectedUser.IdUser)
            {
                Location = new Point(12, 13),
                Visible = true,
                Name = "Menu"
            };
            panelMenu.Controls.Add(bxProf);
        }
        private void toShow(object sender)
        {
            if(sender != null)
            { 
            if (sender.GetType() == typeof(btnAccueil))
            {
                btnSelected = (btnAccueil)sender;
            }
            else
            {
                btnSelected = (btnAccueil)((Control)sender).Parent;
            }
            int valueButton = (int)btnSelected.Tag;
            btnSelected.BackColor = Color.MediumSeaGreen;
                if (!this.Model.ConnectedUser.IsDoctor)
                {
                    switch (valueButton)
                    {
                        case 1:
                            closeMenu();
                            showMesures();
                            break;
                        case 2:

                            closeMenu();
                            showGraph();

                            break;
                        case 3:
                            closeMenu();
                            showTable();

                            break;
                        case 4:
                            closeMenu();
                            showReco();

                            break;


                    }
                }

                else
                {

                    switch (valueButton)
                    {
                        case 1:
                            closeMenu();
                            showGraph();
                            break;
                        case 2:

                            closeMenu();
                            showTable();

                            break;
                        case 3:
                            closeMenu();
                            showReco();

                            break;
                        case 4:
                            closeMenu();
                            showPatient();

                            break;


                    }
                }
            }
        }

        private void showGraph()
        {
            boxGraphique graph = new boxGraphique(this.ModeleMesure)
            {
                Location = new Point(12, 13),
                Visible = true,
                Name = "Menu"
            };
            panelMenu.Controls.Add(graph);
        }
        private void showTable()
        {
            boxTableau boxTable = new boxTableau(this.ModeleMesure, this.Model)
            {
                Location = new Point(12, 13),
                Visible = true,
                Name = "Menu"
            };
            panelMenu.Controls.Add(boxTable);
        }
        private void closeMenu()
        {
            foreach(Control item in panelMenu.Controls)
            {
                if (item.Visible == true)
                {
                    item.Visible = false;
                }
            }

        }
        
       
        private void btnAccueil_Click(object sender, EventArgs e)
        {

            toShow(sender);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
           

            Application.Exit();
           
        }
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult drs = new DialogResult();
            drs = MessageBox.Show("Voulez-vous quitter?", "Quitter", MessageBoxButtons.OKCancel);
            if (drs == DialogResult.Cancel)
            {
                e.Cancel = true;
            }

        }
        private void btnAccueil1_Click(object sender, EventArgs e)
        {
            CreateLeftButtons();
        }

        private void pbHide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ddPatient_onItemSelected(object sender, EventArgs e)
        {
            string[] namesPatient = ddPatient.selectedValue.Split(' ');
            this.ModeleMesure.ConnectedUser.IdUser = this.Model.GetIdByNames(namesPatient[1], namesPatient[0]);
            toShow(null);

        }
    }
}
