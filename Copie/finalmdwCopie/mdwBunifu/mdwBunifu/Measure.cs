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
        private double _glucose;

        public double Glucose
        {
            get { return _glucose; }
            set { _glucose = value; }
        }
        private double _insulinRecommandation;

        public double InsulinRecommandation
        {
            get { return _insulinRecommandation; }
            set { _insulinRecommandation = value; }
        }
        private string _commentary;

        public string Commentary
        {
            get { return _commentary; }
            set { _commentary = value; }
        }
        private string _dateMesure;

        public string DateMesure
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
        public Measure(int idMesure, double glucose , double insulinRecommandation,string commentary, string type, string date)
        {
            this.IdMesure = idMesure;
            this.Glucose = glucose;
            this.InsulinRecommandation = insulinRecommandation;
            this.Commentary = commentary;
            this.Type = type;
            this.DateMesure = date;
        }
        //Ctor pour l'insertion dans le boxMesure
        public Measure(double glucose, string commentary, string type, string date)
        {
            this.Glucose = glucose;
            this.Commentary = commentary;
            this.Type = type;
            this.DateMesure = date;
        }
        public Measure(int idMesure)
        {
            this.IdMesure = idMesure;
           
        }
    }
}
