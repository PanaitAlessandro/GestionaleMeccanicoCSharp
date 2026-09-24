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

            CAuto auto = new CAuto(4,"ABDCDDE", "TOYOTA", "MODEL S", 4000);
            CMoto moto = new CMoto(200,"SJCIOES", "TOYOTA", "MODEL Z", 40000);
            CAutoElettrica autoel = new CAutoElettrica(200,4,"EOPSPANE", "TOYOTA", "MODEL Y", 40);

            CVeicolo[] veicoli = {auto, moto, autoel};

            foreach (CVeicolo v in veicoli)
            {
                System.Console.WriteLine(v);
            }

            CMeccanici meccanico = new CMeccanici("Carlo", "Moto");

            cliente.AggiungiVeicolo(moto);
            cliente2.AggiungiCliente(auto);
            cliente3.AggiungiCliente(autoel);
            
            officina.AggiungiCliente(cliente);
            officina.AggiungiCliente(cliente2);
            officina.AggiungiCliente(cliente3);
            officina.AggiungiMeccanico(meccanico);




            CInterventi intervento = new CInterventi(DateTime.Now, "Rottura del parabrezza", meccanico);

            moto.AggiungiIntervento(intervento);

            intervento.ChiudiIntervento(500);
        }
    }
}