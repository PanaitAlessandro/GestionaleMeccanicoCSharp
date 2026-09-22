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

        public COfficina() : this("SCONOSCIUTO") {}

        public COfficina(string nomeofficina)
        {
            nomeOfficina = nomeofficina;
        }

        public string Descrizione()
        {
            return $"Il nome dell'officina è: {nomeOfficina}";
        }
    }
}