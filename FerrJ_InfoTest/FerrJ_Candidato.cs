using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerrJ_InfoTest
{
    public abstract class FerrJ_Candidato
    {
        private int FerrJ_Matricola;
        private string FerrJ_Nome;


        public int Matricola
        {
            get { return FerrJ_Matricola; }
            set { FerrJ_Matricola = value; }
        }

        public string Nome
        {
            get { return FerrJ_Nome; }
            set { FerrJ_Nome = value; }
        }
        public FerrJ_Candidato()
        {
            FerrJ_Matricola = 0;
            FerrJ_Nome = null;
        }
        public FerrJ_Candidato(int n)
        {
            FerrJ_Matricola = n;
            FerrJ_Nome = null;
        }
        public FerrJ_Candidato(string s)
        {
            FerrJ_Matricola = 0;
            FerrJ_Nome = s;
        }
        public FerrJ_Candidato(int n, string s)
        {
            FerrJ_Matricola = n;
            FerrJ_Nome = s;
        }


        public abstract bool isIdoneo();

        public abstract int punteggio();
        
    }
}


