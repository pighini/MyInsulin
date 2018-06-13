using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdwBunifu
{
    public class User
    {
        private int _idUser;

        public int IdUser
        {
            get { return _idUser; }
            set { _idUser = value; }
        }

        private string _firstName;

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        private string _lastName;

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        private string _email;

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }


        public User( string email )
        {
            this.Email = email;
            
        }

        public User(User connectedUser)
        {
            this.IdUser = connectedUser.IdUser;
        }

        private bool _isDoctor;

        public bool IsDoctor     
        {
            get { return _isDoctor; }
            set { _isDoctor = value; }
        }
    }
}
