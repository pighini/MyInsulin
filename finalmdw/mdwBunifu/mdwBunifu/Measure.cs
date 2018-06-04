using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdwBunifu
{
    public class Measure
    {
        private int _idMesure;

        public int IdMesure
        {
            get { return _idMesure; }
            set { _idMesure = value; }
        }
        private int _glucose;

        public int Glucose
        {
            get { return _glucose; }
            set { _glucose = value; }
        }
        private int _insulinRecommandation;

        public int InsulinRecommandation
        {
            get { return _insulinRecommandation; }
            set { _insulinRecommandation = value; }
        }
        private string _commentary;

        public string Commentary
        {
            get { return _type; }
            set { _type = value; }
        }
        private DateTime _dateMesure;

        public DateTime DateMesure
        {
            get { return _dateMesure; }
            set { _dateMesure = value; }
        }
        private string _type;

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }
        public Measure(int idMesure, int glucose , int insulinRecommandation,string commentary, string type, DateTime date)
        {
            this.IdMesure = idMesure;
            this.Glucose = glucose;
            this.InsulinRecommandation = insulinRecommandation;
            this.Commentary = commentary;
            this.Type = type;
            this.DateMesure = date;
        }

    }
}
