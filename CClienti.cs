using System;

namespace Gestionale
{
    public class CClienti
    {
        private string _nome;
        private string _cognome;
        private int _telefono;

        private CVeicolo[] _v;


        public string Nome
        {
            get => _nome;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Il nome non può essere nullo!");
                }
                _nome = value;
            }
        }

        public string Cognome
        {
            get => _cognome;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Il cognome non può essere nullo!");
                }
                _cognome = value;
            }
        }

        public int Telefono
        {
            get => _telefono;
            private set
            {
                _telefono = value;
            }
        }

        public CClienti(): this ("SCONOSCIUTO", "SCONOSCIUTO", 0) {}

        public CClienti(string nome, string cognome, int telefono)
        {
            Nome = nome;
            Cognome = cognome;
            Telefono = telefono;
            _v = new CVeicolo[0];
        }

        public void AggiungiVeicolo(CVeicolo veicolo)
        {
            Array.Resize(ref _v, _v.Length+1);
            _v[_v.Length-1] = veicolo;
            
        }

        public override string ToString()
        {
            return $"Cliente: (Nome: {Nome}, Cognome: {Cognome}, N. Telefono: {Telefono})";
        }
    }
}