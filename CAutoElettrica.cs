using System;

namespace Gestionale
{
    
    public class CAutoElettrica : CAuto
    {

        private int _autonomia;

        public int Autonomia
        {
            get => _autonomia;
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("L'autonomia non può essere negativa");
                }
                _autonomia = value;
            }
        }

        public CAutoElettrica() : this() {
        }
        
    }
}