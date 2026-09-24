using System;

namespace Gestionale
{
    public class CClienti
    {
        private string _nome;
        private string _cognome;
        private string _telefono;

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

        public string Telefono
        {
            get => _telefono;
            private set
            {
                _telefono = value;
            }
        }

        public CClienti(): this ("SCONOSCIUTO", "SCONOSCIUTO", "+39 0") {}

        public CClienti(string nome, string cognome, string telefono)
        {
            Nome = nome;
            Cognome = cognome;
            Telefono = telefono;
            _v = new CVeicolo[0];
        }

        public void AggiungiVeicolo(CVeicolo veicolo)
        {

            if (veicolo == null)
            {
                throw new ArgumentException("Il veicolo non può essere null");
            }

            for (int i = 0; i < _v.Length; i++)
            {
                if (_v[i] == veicolo)
                {
                    throw new ArgumentException("Questo veicolo è già connesso al cliente");
                }
            }
            Array.Resize(ref _v, _v.Length+1);
            _v[_v.Length-1] = veicolo;
            
        }

        public bool CercaVeicolo(string targa)
        {
            for (int i = 0; i < _v.Length; i++)
            {
                if (_v[i].Targa == targa)
                {
                    System.Console.WriteLine($"Targa trovata: {_v[i]}");
                    return true;
                }
            }
            return false;
        }

        public override string ToString()
        {
            return $"Cliente: (Nome: {Nome}, Cognome: {Cognome}, N. Telefono: {Telefono})";
        }
    }
}