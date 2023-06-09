﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerrJ_InfoTest
{
    public abstract class FerrJ_Disoccupato:FerrJ_Candidato
    {
        private int _FerrJ_voto;
        private bool _FerrJ_lode;

        public int FerrJ_voto
        {
            get
            {
                return FerrJ_voto;
            }
            set
            {
                if (value >= 0 && value <= 110)
                    FerrJ_voto = value;
                else
                    throw new Exception("Voto non valido");
            }
        }
        public bool FerrJ_lode
        {
            get
            {
                return _FerrJ_lode;
            }
            set
            {
                if (_FerrJ_voto == 110)
                {
                    try
                    {
                        _FerrJ_lode = value;
                    }
                    catch
                    {
                        throw new Exception("non valida");
                    }
                }
                else
                    throw new Exception("non disponibile");
            }
        }
        public FerrJ_Disoccupato()
        {
            FerrJ_voto = 0;
            FerrJ_lode = false;
        }
        public FerrJ_Disoccupato(int voto,bool lode, int matricola, string nome) :base (matricola, nome)
        {
            FerrJ_voto = voto;
            FerrJ_lode = lode;
        }
        public override int punteggio()
        {
            int a = (FerrJ_voto * 100) / 110;
            if (FerrJ_lode == true)
                a += 5;

            return a;
        }
        public override bool isIdoneo()
        {
            if (punteggio() >= 72)
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
            string s = Matricola + ", " + Nome + ", " + FerrJ_voto + ", " + FerrJ_lode;
            return s;
        }
        public bool Equals(FerrJ_Disoccupato k)
        {
            if (k == null)
                return false;

            if (this == k)
                return true;

            if (this.Matricola == k.Matricola || this.Nome == k.Nome || this.FerrJ_voto == k.FerrJ_voto || this.FerrJ_lode == k.FerrJ_lode)
                return true;

            else
                return false;
        }
        public int CompareTo(FerrJ_Disoccupato k)
        {
            if (k == null)
            {
                return 1;
            }

            if (this.punteggio() == k.punteggio())
            {
                return 0;
            }

            else if (this.punteggio() < k.punteggio())
            {
                return -1;
            }

            else
                return 1;
        }

    }
}
