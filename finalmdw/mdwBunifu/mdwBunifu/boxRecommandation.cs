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
    public partial class boxRecommandation : UserControl
    {
        private ModelMyInsulin _model;

        public ModelMyInsulin Model
        {
            get { return _model; }
            set { _model = value; }
        }
        private int _idUser;

        public int IdUser
        {
            get { return _idUser; }
            set { _idUser = value; }
        }

        int cpt = 0;
        int locaY = 0;
        vRecommandation oldReco;
        public boxRecommandation(int id)
        {
            InitializeComponent();
            this.Model = new ModelMyInsulin();
            this.IdUser = id;
            GenerateRecommandation();
        }
        private void GenerateRecommandation()
        {
            cpt = 0;
            locaY = 0;
            
            
            foreach (InsulineTable reco in this.Model.GetRecommandation(this.IdUser))
            {


                vRecommandation vReco = new vRecommandation(this.Model, reco.IdReco, reco.Min, reco.Max, reco.NbRecommandation, this.IdUser, true)
                {
                    Name = "btnReco",
                    Tag = reco.IdReco,
                    Parent = plReco,
                    Location = new Point(55, locaY + (50 * cpt))
                };
                plReco.Controls.Add(vReco);
                cpt++;
                oldReco = vReco;
            }
            GenerateAddRecoBtn();

        }
        private void add_Click(object sender, EventArgs e)
        {
            if (plReco.Controls.Find("btnReco", true).Length <= 6)
            {
                int id = this.Model.GetLastId() + 1;
                vRecommandation vReco = new vRecommandation(this.Model, id, 0, 0, 0, this.IdUser, false)
                {
                    Name = "btnReco",
                    Tag = id,
                    Parent = plReco,
                    Location = new Point(55, locaY + (50 * cpt))
                };
                if (plReco.Controls.Count >= 1)
                {
                    vReco.Top = oldReco.Bottom;
                }
                else
                    vReco.Top = 0;


                plReco.Controls.Add(vReco);
                cpt++;
                RemovePb();
                oldReco = vReco;
            }
            else
            {
                MessageBox.Show("Nombre maximum de recommandation atteint");
            }
        }
        private void RemovePb()
        {
            plReco.Controls.RemoveByKey("add");
            
        }
        
        private void GenerateAddRecoBtn()
        {
            PictureBox pbAdd = new PictureBox();
            pbAdd.Name = "add";
            pbAdd.Location = new Point(200, 40 + locaY + (50 * plReco.Controls.Count));
            pbAdd.Image = Properties.Resources.icons8_plus_50__1_;
            pbAdd.Click += add_Click;
            plReco.Controls.Add(pbAdd);
            
        }

        private void plReco_ControlRemoved(object sender, ControlEventArgs e)
        {
            RemovePb();
            if (plReco.Controls.Find("add", true).Length == 0)
            {
                GenerateAddRecoBtn();
                Control[] recos = plReco.Controls.Find("btnReco", true);
                oldReco =(vRecommandation)recos[recos.Length-1];
                cpt--;
            }
            
        }
    }
    
}
