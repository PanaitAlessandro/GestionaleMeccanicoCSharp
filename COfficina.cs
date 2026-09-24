using System;
namespace Gestionale
{

    public interface IDescrizione
    {
        string Descrizione();
    }
    public class COfficina : IDescrizione
    {
        private CClienti[] _clienti;
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
            get => _m;
            private set
            {
                _m = value;
            }
        }

        public COfficina() : this("SCONOSCIUTO")
        {
            
        }

        public COfficina(string nomeofficina)
        {
            nomeOfficina = nomeofficina;
            _m = new CMeccanici[0];
            _clienti = new CClienti[0];

        }

        public string Descrizione()
        {
            return $"Il nome dell'officina è: {nomeOfficina}";
        }

        public void AggiungiMeccanico(CMeccanici meccanico)
        {
            Array.Resize(ref _m, _m.Length+1);
            _m[_m.Length-1] = meccanico;
        } 

        public void AggiungiCliente(CClienti cliente)
        {
            Array.Resize(ref _clienti, _clienti.Length+1);
            _clienti[_clienti.Length-1] = cliente;
        }

        public bool CercaVeicolo(string targa)
        {
           for (int i = 0; i < _clienti.Length; i++)
            {
                if(_clienti[i].CercaVeicolo(targa))
                {
                    return true;
                }
            }
            System.Console.WriteLine("Targa non trovata");
            return false;
        }

    }

    
}