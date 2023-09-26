using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PatakiAttila_BejegyzesProjekt
{
    internal class Feladatok
    {
        private List<Bejegyzes> beir;
        private List<Bejegyzes> bejegyzes;

        public Feladatok()
        {
            beir = new List<Bejegyzes>();
            bejegyzes = new List<Bejegyzes>();
            ListaFeltolt();
            Beolv();
            Likeosztas();
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

        private void Beolv()
        {
            StreamReader sr = new StreamReader("bejegyzesek.csv");
            
            while (!sr.EndOfStream)
            {
                string[] adatok = sr.ReadLine().Split(';');
                string szerzo = adatok[0];
                string tartalom = adatok[1];
                Bejegyzes b = new Bejegyzes(szerzo,tartalom);
                bejegyzes.Add(b);
            }
        }

        private void Likeosztas()
        {
            Random r = new Random();
            int szam;
            for (int i = 0; i < beir.Count*20; i++)
            {
                szam= r.Next(0,beir.Count);
                beir[szam].Likenovelese();

            }
            for (int i = 0; i < beir.Count; i++)
            {
                Console.WriteLine(beir[i].ToString()); 
            }
        }

    }
}
