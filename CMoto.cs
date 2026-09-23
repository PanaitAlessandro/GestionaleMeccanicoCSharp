using System;

namespace Gestionale
{
    
    public class CMoto : CVeicolo
    {
        private int _cilindrata;

        public int Cilindrata
        {
            get => _cilindrata;
            private set
            {
                if (value < 50)
                {
                    throw new ArgumentException("La cilindrata non può scendere sotto i 50cc");
                }

                _cilindrata = value;
            }
        }

        public CMoto() : this(50, "SCONOSCIUTA", "N/A", "SCONOSCIUTO", 0) {}

        public CMoto(int cilindrata,string targa, string marca, string modello, int chilometraggio) : base(targa,marca,modello,chilometraggio)
        {
            Cilindrata = cilindrata;

        }

        public override string ToString()
        {
            return $"Cilindrata: {Cilindrata}, [Veicolo: {base.ToString()}]";
        }
    }
}