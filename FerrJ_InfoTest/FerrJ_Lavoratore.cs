using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerrJ_InfoTest
{
    public abstract class FerrJ_Lavoratore: FerrJ_Candidato
    {
        private int _FerrJ_esperienze;
        public int FerrJ_esperienze
        {
            get
            {
                return FerrJ_esperienze;
            }
            set
            {
                if (value >= 0 && value <= 5)
                    FerrJ_esperienze = value;
                else
                    throw new Exception("n esperienze non valido");
            }
        }
        public FerrJ_Lavoratore()
        {
            FerrJ_esperienze = 0;
            
        }
        public FerrJ_Lavoratore(int esperienze, int matricola, string nome) : base(matricola, nome)
        {
            FerrJ_esperienze = esperienze;
            
        }
        public override int punteggio()
        {
            int punti = (FerrJ_esperienze * 20);

            return punti;
        }
        public override bool isIdoneo()
        {
            if (punteggio() >= 60)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override string ToString()
        {
            string s = Matricola + ", " + Nome + ", " + FerrJ_esperienze;
            return s;
        }
        public bool Equals(FerrJ_Lavoratore k)
        {
            if (k == null)
            {
                return false;
            }

            if (this == k)
            {
                return true;
            }

            if (this.Matricola == k.Matricola || this.Nome == k.Nome || this.FerrJ_esperienze == k.FerrJ_esperienze)
            {
                return true;
            }

            else 
            { 
                    return false;
            }
        }
        public override bool CompareTo(FerrJ_Candidato k)
        {
            if (this.punteggio() == k.punteggio())
                return true;
            else
                return false;
        }
    }
}
