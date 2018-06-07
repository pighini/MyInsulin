using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdwBunifu
{
    public class InsulineTable
    {
        private int _idReco;

        public int IdReco
        {
            get { return _idReco; }
            set { _idReco = value; }
        }
        private double _min;

        public double Min
        {
            get { return _min; }
            set { _min = value; }
        }
        private double _max;

        public double Max
        {
            get { return _max; }
            set { _max = value; }
        }
        private double _nbRecommandation;

        public double NbRecommandation 
        {
            get { return _nbRecommandation; }
            set { _nbRecommandation = value; }
        }
        private int _idUser;

        public int IdUser
        {
            get { return _idUser; }
            set { _idUser = value; }
        }


        public InsulineTable(int id, double min, double max, double reco)
        {
            this.IdReco = id;
            this.Min = min;
            this.Max = max;
            this.NbRecommandation = reco;

        }
    }
}
