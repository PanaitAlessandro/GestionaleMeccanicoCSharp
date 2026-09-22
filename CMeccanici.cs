using System;

namespace Gestionale
{
    public class CMeccanici
    {
        private string _nomeMeccanico;
        private string _specializzazione;

        public string nomeMeccanico
        {
            get => _nomeMeccanico;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Il nome del meccanico non può essere nullo");
                }

                _nomeMeccanico = value;
            }
        }

        public string Specializzazione
        {
            get => _specializzazione;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("La specializzazione non può essere nulla");
                }

                _specializzazione = value;
            }
        }

        public CMeccanici() : this("SCONOSCIUTO", "SCONOSCIUTA") {}

        public CMeccanici(string nome, string specializzazione)
        {
            nomeMeccanico = nome;
            Specializzazione = specializzazione;
        }

        public override string ToString()
        {
            return $"Meccanico: (Nome: {nomeMeccanico}, Specializzazione: {Specializzazione})";
        }
    }
}