using System;

namespace Gestionale
{
    
    public class CAutoElettrica : CAuto
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
        
    }
}