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
    public partial class btnTableau : UserControl
    {
        public btnTableau()
        {
            InitializeComponent();
        }

        private void btnTableau_MouseHover(object sender, EventArgs e)
        {
            BackColor = Color.MediumSeaGreen;
        }

        private void btnTableau_MouseLeave(object sender, EventArgs e)
        {
            BackColor = Color.SeaGreen;
        }
    }
}
