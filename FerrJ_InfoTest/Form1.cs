using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FerrJ_InfoTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<FerrJ_Candidato> Candidati = new List<FerrJ_Candidato>();
        public void Aggiungi(FerrJ_Candidato a)
        {
            Candidati.Add(a);
        }
        public string[] Visualizza(List<FerrJ_Candidato> c)
        {
            string[] s = new string[999];
            int count = 0;

            foreach (FerrJ_Candidato a in Candidati)
            {
                s[count] = a.ToString();
                count++;
            }
            return s;
        }
        public void Modifica(string nome, int numero)
        {
            for (int i = 0; i < Candidati.Count; i++)
            {
                if (Candidati[i].Matricola == numero)
                {
                    Candidati[i].Nome = nome;
                }
            }
        }
        public void Elimina(int numero)
        {
            for (int i = 0; i < Candidati.Count; i++)
            {
                if (Candidati[i].Matricola == numero)
                {
                    Candidati[i] = null;
                }
            }
        }
        public string[] VisualizzaIdonei()
        {
            string[] s = new string[999];
            int n = 0;
            foreach (FerrJ_Candidato d in Candidati)
            {
                bool b = d.isIdoneo();
                if (b == true)
                {
                    s[n] = d.ToString();
                    n++;
                }
            }
            return s;
        }
        public void Ordinamento()
        {
            //non ho avuto tempo :(
        }


    }
}
