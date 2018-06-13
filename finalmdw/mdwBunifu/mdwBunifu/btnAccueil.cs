using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mayDaylyWeyght
{
    public partial class btnAccueil : UserControl
    {
        private string _nom;

        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }
        private Image _imagebtn;

        public Image ImageBtn
        {
            get { return _imagebtn; }
            set { _imagebtn = value; }
        }
        private Point _loca;

        public Point Loca

        {
            get { return _loca; }
            set { _loca = value; }
        }


        public btnAccueil(string nom, Image img, Point loca)
        {
            InitializeComponent();
            this.Nom = nom;
            this.ImageBtn = img;
            this.lblText.Text = this.Nom;
            this.pbImage.Image = ImageBtn;
            this.Loca = loca;
            this.Location = this.Loca;
            this.Name = nom;
        }
        
        private void btnAccueil_MouseHover(object sender, EventArgs e)
        {
            BackColor = Color.MediumSeaGreen;
        }

        private void btnAccueil_MouseLeave(object sender, EventArgs e)
        {
            BackColor = Color.SeaGreen;
        }
    }
}
