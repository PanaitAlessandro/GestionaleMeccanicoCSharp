using System;
namespace Gestionale
{
    public class CAuto : CVeicolo
    {
        private int _numeroPorte;

        public int numeroPorte
        {
            get => _numeroPorte;
            private set
            {
                if (value < 2)
                {
                    throw new ArgumentException("Il numero delle porte non può essere inferiore a 2");
                } 
                _numeroPorte = value;
            }
        }

        public CAuto() : this(4,"SCONOSCIUTA", "N/A", "SCONOSCIUTI", 0) {}

/*
        private string _targa;
        private string _marca;
        private string _modello;
        private int _chilometraggio;
*/
        public CAuto(int numeroporte, string targa, string marca, string modello, int chilometraggio) : base(targa, marca,modello,chilometraggio) 
        {

            numeroPorte = numeroporte;
        }

        public override string ToString()
        {
            return $"numeroPorte: {numeroPorte}, [Veicolo: {base.ToString()}]";
        }
    }
}