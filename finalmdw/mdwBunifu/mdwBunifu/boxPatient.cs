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
    public partial class boxPatient : UserControl
    {
        private int _idConnected;

    

        private ModelUser _modelUser;

        public ModelUser ModelUser
        {
            get { return _modelUser; }
            set { _modelUser = value; }
        }


        public boxPatient(ModelUser mod)
        {
            InitializeComponent();
            this.ModelUser = mod;

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string nom = tbxNom.Text;
            string prenom = tbxPrenom.Text;
            string password = tbxPassword.Text;
            if(this.ModelUser.CheckPatient(prenom, nom,password))
            {
                this.ModelUser.AddPatient(this.ModelUser.ConnectedUser.IdUser, this.ModelUser.GetIdByName(prenom,nom,password));
            }
            else
            {
                MessageBox.Show("Utilisateurs introuvable");
            }
        }
    }
}
