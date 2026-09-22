using System;

namespace Gestionale
{
    public class CClienti
    {
        private string _nome;
        private string _cognome;
        private int _telefono;

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

        public CClienti(): this ("SCONOSCIUTO", "SCONOSCIUTO", "SCONOSCIUTO") {}

        public CClienti(string nome, string cognome, int telefono)
        {
            Nome = nome;
            Cognome = cognome;
            Telefono = telefono;
        }

        public override string ToString()
        {
            return $"Cliente: (Nome: {Nome}, Cognome: {Cognome}, N. Telefono: {Telefono})";
        }
    }
}