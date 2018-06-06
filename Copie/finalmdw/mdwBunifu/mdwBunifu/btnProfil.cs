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
    public partial class btnProfil : UserControl
    {
        public btnProfil()
        {
            InitializeComponent();
        }

        private void btnProfil_MouseHover(object sender, EventArgs e)
        {
            BackColor = Color.MediumSeaGreen;
        }

        private void btnProfil_MouseLeave(object sender, EventArgs e)
        {
            BackColor = Color.SeaGreen;
        }
    }
}
