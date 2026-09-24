using System;
using System.Runtime.InteropServices;

namespace Gestionale
{
    class Program
    {
        static void Main(string[] args)
        {
            COfficina officina = new COfficina("Officina Vicentina");
            System.Console.WriteLine(officina.Descrizione());

            CClienti cliente = new CClienti("Alessandro", "Panait", "+39 3245299900");
            CClienti cliente2 = new CClienti("Gianni", "Rossi", "+39 324522930");
            CClienti cliente3 = new CClienti("Luca", "Niello", "+39 3012939239");

            CClienti[] clienti = { cliente, cliente2, cliente3 };

            foreach (CClienti c in clienti)
            {
                System.Console.WriteLine(c);
            }

            
        }
    }
}