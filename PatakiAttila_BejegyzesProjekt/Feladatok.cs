﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatakiAttila_BejegyzesProjekt
{
    internal class Feladatok
    {
        private List<Bejegyzes> beir;
        private List<Bejegyzes> bejegyzes;

        public Feladatok()
        {
            beir = new List<Bejegyzes>();
            ListaFeltolt();
        }

        private void ListaFeltolt()
        {
            int szam;
            Console.WriteLine("Kérem adjon meg egy természetes számot");
            szam = Convert.ToInt32(Console.ReadLine());
            if (szam < 0)
            {
                Console.WriteLine("Természetes számot adjon meg");
            }
            else
            {
                for (int i = 0; i < szam; i++)
                {
                    Console.WriteLine("Adjon megy egy szerzőt");
                    string szerzo = Console.ReadLine();
                    Console.WriteLine("Adja meg a tartalmat");
                    string tartalom = Console.ReadLine();
                    Bejegyzes b1 = new Bejegyzes(szerzo, tartalom);
                    beir.Add(b1);

                    

                    
                }

               
            }
            
        }


    }
}