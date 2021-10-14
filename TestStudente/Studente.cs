using System;
using System.Collections.Generic;
using System.Text;

namespace TestStudente
{
    class Studente
    {
        private int eta;
        private List<LIbro> libri = new List<LIbro>();
        
        public Studente(string nome, string cognome, int eta)
        {
            this.Nome = nome;
            this.Cognome = cognome;
            this.Eta = eta;
        }
        public string Presentati()
        {
            return ($"{Nome} {Cognome} {Eta}");
        }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public int Eta
        {
            get
            {
                return eta;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("eta non valida");
                }
                this.eta = value;
            }
        }
        public void AddLibro(LIbro l)
        {
            libri.Add(l);
        }
        public void RemoveLibro(LIbro l)
        {
            libri.Remove(l);
        }
    }
}
