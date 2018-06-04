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

        public frmMain(ModelUser model)
        {
            InitializeComponent();
            CreateLeftButtons();           
            this.Model = model;
            this.ModeleMesure = new ModelMeasure(this.Model.ConnectedUser);
                    
        }
        private void CreateLeftButtons()
        {
            int cpt = 0;
            int locaY = 87;
            btns.Add("Accueil", Properties.Resources.icons8_home_32);
            btns.Add("Mesures", Properties.Resources.icons8_plus_32);
            btns.Add("Graphiques", Properties.Resources.icons8_statistics_32);
            btns.Add("Tableau", Properties.Resources.icons8_statistics_32);
            btns.Add("Recommandations",Properties.Resources.icons8_conseil_32);
            btns.Add("Profil", Properties.Resources.icons8_user_32);

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
        private void showReco()
        {
            boxProfil bxProf = new boxProfil(this.Model.ConnectedUser.IdUser)
            {
                Location = new Point(12, 13),
                Visible = true,
                Name = "Menu"
            };
            panelMenu.Controls.Add(bxProf);
        }
        private void toShow(object sender)
        {
            btnAccueil selectedButton;
            if (sender.GetType() == typeof(btnAccueil))
            {
                selectedButton = (btnAccueil)sender;
            }
            else
            {
                selectedButton = (btnAccueil)((Control)sender).Parent;
            }
            int valueButton = (int)selectedButton.Tag;
            selectedButton.BackColor = Color.MediumSeaGreen;
            switch (valueButton)
            {
                case 1:
                    closeMenu();
                    break;
                case 2:
                    
                    closeMenu();
                    showMesures();
                    break;
                case 3:
                    closeMenu();
                    showGraph();
                    break;
                case 4:
                    closeMenu();
                    showTable();

                    break;
                case 5:
                    closeMenu();
                    showReco();
                    break;

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
            boxTableau boxTable = new boxTableau(this.ModeleMesure)
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
            
                this.Close();
           
        }

        private void btnAccueil1_Click(object sender, EventArgs e)
        {
            CreateLeftButtons();
        }
    }
}
