using System;

namespace Gestionale
{
    public class CVeicolo
    {
        //  targa, marca, modello, chilometraggio
        private string _targa;
        private string _marca;
        private string _modello;
        private int _chilometraggio;
        private CInterventi[] _interventi;

        public string Targa
        {
            get => _targa;
            private set
            {
                if (string.IsNullOrWhiteSpace(value)) {
                    throw new ArgumentException("La targa non può essere null");
                }
                _targa = value;
            }
        }

        public string Marca
        {
            get => _marca;
            private set
            {
                if (string.IsNullOrWhiteSpace(value)) {
                    throw new ArgumentException("La marca non può essere null");
                }
                _marca = value;
            }
        }

        public string Modello
        {
            get => _modello;
            private set
            {
                if (string.IsNullOrWhiteSpace(value)) {
                    throw new ArgumentException("Il modello non può essere null");
                }
                _modello = value;
            }
        }

        public int Chilometraggio
        {
            get => _chilometraggio;
            private set
            {
                if (value < 0) {
                    throw new ArgumentException("Il chilometraggio non può essere negativo");
                }
                _chilometraggio = value;
            }
        }

        public CVeicolo() : this("SCONOSCIUTA", "N/A", "SCONOSCIUTO", 0) {}

        public CVeicolo(string targa, string marca, string modello, int chilometraggio)
        {
            Targa = targa;
            Marca = marca;
            Modello = modello;
            Chilometraggio = chilometraggio;
        }

        public override string ToString()
        {
            return $"Targa: {Targa}, Marca: {Marca}, Modello: {Modello}, Chilometraggio: {Chilometraggio}";
        }
    }
}