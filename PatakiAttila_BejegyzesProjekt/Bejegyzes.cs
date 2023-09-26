using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatakiAttila_BejegyzesProjekt
{
    internal class Bejegyzes
    {

        private string szerzo;
        private string tartalom;
        private int like;
        private DateTime letrejott;
        private DateTime szerkesztve;


        public Bejegyzes(string szerzo, string tartalom)
        {
            this.szerzo = szerzo;
            this.tartalom = tartalom;
            this.like = 0;
            this.letrejott = DateTime.Today;
            this.szerkesztve = DateTime.Today;
        }

        public string Szerzo { get => szerzo; }
        public string Tartalom
        {
            get => tartalom;
            set
            {
                tartalom = value;
                szerkesztve = DateTime.Now;
                
            }
        }

        public int Like { get => like; }
        public DateTime Letrejott { get => letrejott; }
        public DateTime Szerkesztve { get => szerkesztve; }

        public void Likenovelese()
        {
            this.like++;
        }

        public override string ToString()
        {
            string tostring =$"{this.szerzo} - {this.like} - {this.letrejott} \n";
            if (this.letrejott!=this.szerkesztve)
            {
                tostring += $"Szerkesztve {this.szerkesztve} \n";
            }
            tostring += $" {this.tartalom}";


            return tostring;
        }


        





        
    }
}
