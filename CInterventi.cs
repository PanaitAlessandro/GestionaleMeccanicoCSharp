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
            private set
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
            private set
            {
                _isInterventoChiuso = value;
            }
        }

        public CInterventi() : this(DateTime.Now, "SCONOSCIUTA", 0, false,"SCONOSCIUTO", "SCONOSCIUTA") {}

        public CInterventi(DateTime data, string descrizione, decimal costofinale, bool interventochiuso, string nome, string specializzazione)
        {
            Data = data;
            Descrizione = descrizione;
            costoFinale = costofinale;
            isInterventoChiuso = interventochiuso;
            _meccanico = new CMeccanici(nome,specializzazione);

        }

        public override string ToString()
        {
            return $"Sezione Interventi\n Data: {Data},Descrizione Problema: {Descrizione}, CostoFinale: {costoFinale}, Stato Intervento: {isInterventoChiuso}, Meccanico: {_meccanico.ToString()}";
        }
    }
}