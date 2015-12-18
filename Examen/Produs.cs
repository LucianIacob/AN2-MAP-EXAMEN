using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    public class Produs : IDObject
    {
        public Produs()
            : base(IDGenerator.getGenerator().nextID())
        {
        }

        public String denumire { get; set; }
        public int pret { get; set; }
        public String categorie { get; set; }
        public int procent { get; set; }

        public Produs(int id, String d, int p, String c, int pr)
            : base(id)
        {
            denumire = d;
            pret = p;
            categorie = c;
            procent = pr;
        }

        public override string ToString()
        {
            return denumire + " - " + pret.ToString() + " - " + categorie + " - " + procent.ToString();
        }
    }
}
