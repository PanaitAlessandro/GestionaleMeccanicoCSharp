using System;

namespace Gestionale
{
    
    public abstract class CAutoElettrica : CAuto
    {

        private int _autonomia;

        public int Autonomia
        {
            get => _autonomia;
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("L'autonomia non può essere negativa");
                }
                _autonomia = value;
            }
        }

        public CAutoElettrica() : this(100,4,"SCONOSCIUTA", "N/A", "SCONOSCIUTI", 0) {
        }

        public CAutoElettrica(int autonomia,int numeroporte, string targa, string marca, string modello, int chilometraggio ) : base(numeroporte,targa,marca,modello,chilometraggio)
        {
            Autonomia = autonomia;
        }

        public override decimal CalcolaCostoTagliando()
        {
            // facciamo cosi:
            // autonomia *1
            // chilometraggio / 500
            // + il prezzo di base di 100
            int prezzoBase = 100;
            prezzoBase += Autonomia;
            prezzoBase += Chilometraggio / 500;

            return prezzoBase;
        }

        public override string ToString()
        {
            return $"Autonomia: {Autonomia}, [Auto: {base.ToString()}]";
        }
    }
}