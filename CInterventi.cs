using System;

namespace Gestionale
{
    public class CInterventi
    {
        private CMeccanici _meccanico;

        private DateTime _data;
        private string _descrizione;
        private decimal _costoFinale;
        private bool _isInterventoChiuso;


        public DateTime Data
        {
            get => _data;
            private set
            {
                _data = value;
            }
        }

        public CMeccanici Meccanico
        {
            get => _meccanico;
            private set
            {
                if (value == null)
                {
                    throw new ArgumentException("Un meccanico non può essere 'null'");
                }
                _meccanico = value;
            }
        }

        public string Descrizione
        {
            get => _descrizione;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("La descrizione non può essere nulla");
                }
                _descrizione = value;
            }
        }

        public decimal costoFinale
        {
            get => _costoFinale;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Il costo finale non può essere negativo.");
                }
                _costoFinale = value;
            }
        }

        public bool isInterventoChiuso
        {
            get => _isInterventoChiuso;
            set
            {
                _isInterventoChiuso = value;
            }
        }

        public CInterventi() : this(DateTime.Now, "SCONOSCIUTA", new CMeccanici()) {}

        public CInterventi(DateTime data, string descrizione,  CMeccanici meccanico)
        {
            Data = data;
            Descrizione = descrizione;
            Meccanico = meccanico;

        }

        public override string ToString()
        {
            return $"Sezione Interventi\n Data: {Data},Descrizione Problema: {Descrizione}, CostoFinale: {costoFinale}, Stato Intervento: {isInterventoChiuso}, Meccanico: {_meccanico.ToString()}";
        }
    }
}