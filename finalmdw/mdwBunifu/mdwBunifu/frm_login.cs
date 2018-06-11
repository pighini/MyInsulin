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

    public partial class frm_login : Form
    {
        string firstName;
        string lastName;
        string email;
        string password;
        frmMain frm;
        private ModelUser _modelUser;

        public ModelUser Modele
        {
            get { return _modelUser; }
            set { _modelUser = value; }
        }

        public frm_login(ModelUser modele)
        {
            InitializeComponent();
            Modele = modele;
            ShowSignIn();

        }
        public void ShowSignIn()
        {

            this.ActiveControl = tbxEmailCo;
            tbxUsername.TabIndex = 0;
            tbxUsername.Text = "";
            tbxPassword.TabIndex = 1;
            tbxPassword.Text = "";
            btnLogin.TabIndex = 2;
            slideA.Visible = false;
            slideB.Left = 49;
            slideB.Visible = true;
            slideB.Refresh();

        }
        public void ShowSignUp()
        {

            this.ActiveControl = tbxPrenom;     
            tbxPrenom.TabIndex = 0;
            tbxPrenom.Text = "";
            tbxNom.TabIndex = 1;
            tbxNom.Text = "";
            tbxEmail.TabIndex = 2;
            tbxEmail.Text = "";
            tbxNewPassword.TabIndex = 1;
            tbxNewPassword.Text = "";
            tbxRepeatPassword.TabIndex = 3;
            tbxRepeatPassword.Text = "";
            btnSignUp.TabIndex = 4;
            slideB.Visible = false;
            slideA.Visible = true;
            slideA.Refresh();

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            ShowSignUp();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            ShowSignIn();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            email = tbxEmail.Text;
            firstName = tbxPrenom.Text;
            lastName = tbxNom.Text;
            password = tbxNom.Text;
            password = Modele.CalculateSHA1(password, Encoding.UTF8);
            bool isDoc = cbxDoctor.Checked;



            if (Modele.isCoOpen())
            {
                lblErrorConnection.Text = "";

                if (!Modele.UserExist(email))
                {
                    lblErrorUsername.Text = "";
                    if (tbxNewPassword.Text == "")
                    {
                        lblErrorPassword.Text = "Le mot de passe ne peut être vide";
                    }
                    else
                    {
                        lblErrorPassword.Text = "";
                        if (tbxNewPassword.Text != tbxRepeatPassword.Text)
                        {
                            lblRepeatPassword.Text = "Les mots de passe ne concordent pas ";
                        }
                        else
                        {
                            lblRepeatPassword.Text = "";
                            Modele.AddUser(firstName, lastName, email, password, isDoc);
                            ShowSignIn();
                        }
                    }
                }
                else
                {
                    lblErrorUsername.Text = "Email déjà pris";
                }


            }
            else
            {
                lblErrorConnection.Text = "Vérifier votre connexion internet";
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            email = tbxEmailCo.Text;
            password = Modele.CalculateSHA1(tbxPasswordInsc.Text, Encoding.UTF8);
            if (Modele.isCoOpen())
            {
                lblErrorConnection.Text = "";
                if (Modele.loginUser(email, password))
                {
                    lblErrorLogin.Text = "";
                    this.Hide();
                    frm = new frmMain(Modele);
                    frm.ShowDialog();
                    
                }
                else
                {
                    lblErrorLogin.Text = "L'email ou le mot de passe est invalide";
                }
            }
            else
            {
                lblErrorConnection.Text = "Vérifier votre connexion";
            }
        }
        private void filtrageEntree(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbxUsernameLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)//e.KeyChar = touche que l'utilisateur tape
            {
                btnLogin_Click(sender, e);
            }
            filtrageEntree(sender, e);
        }

        private void tbxPasswordLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)//e.KeyChar = touche que l'utilisateur tape
            {
                btnSubmit_Click(sender, e);
            }
            filtrageEntree(sender, e);
        }

        private void tbxNewUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            filtrageEntree(sender, e);
        }

        private void tbxNewPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            filtrageEntree(sender, e);
        }

        private void tbxRepeatPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            filtrageEntree(sender, e);
        }

        private void btnCloseLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        public string GetUsername()
        {
            return tbxUsername.Text;
        }
    }
}

 
