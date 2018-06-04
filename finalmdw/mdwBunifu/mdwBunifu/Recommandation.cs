using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdwBunifu
{
    public class Recommandation
    {
        private int _idReco;

        public int IdReco
        {
            get { return _idReco; }
            set { _idReco = value; }
        }
        private int _min;

        public int Min
        {
            get { return _min; }
            set { _min = value; }
        }
        private int _max;

        public int Max
        {
            get { return _max; }
            set { _max = value; }
        }
        private int _nbRecommandation;

        public int NbRecommandation 
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


        public Recommandation(int id, int min, int max, int reco)
        {
            this.IdReco = id;
            this.Min = min;
            this.Max = max;
            this.NbRecommandation = reco;

        }
    }
}
