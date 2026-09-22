using System;
namespace Gestionale
{

    public interface IDescrizione
    {
        string Descrizione();
    }
    public class COfficina : IDescrizione
    {
        private string _nomeofficina;
        private CMeccanici[] _m;

        public string nomeOfficina
        {
            get => _nomeofficina;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Il nome dell'officina non può essere vuoto");
                }

                _nomeofficina = value;
            }
        }

        public CMeccanici[] m
        {
            get => m;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Il nome del meccanico non può essere vuoto");
                }

                m = value;
            }
        }

        public COfficina() : this("SCONOSCIUTO", "SCONOSCIUTO", "SCONOSCIUTA") {}

        public COfficina(string nomeofficina, string nome, string specializzazione)
        {
            nomeOfficina = nomeofficina;
            m = new CMeccanici(nome, specializzazione);
        }

        public string Descrizione()
        {
            return $"Il nome dell'officina è: {nomeOfficina}";
        }
    }
}