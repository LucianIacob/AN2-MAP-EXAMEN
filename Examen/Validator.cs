using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen
{
    class Validator
    {
        public bool Validate(string a, string b)
        {
            int pret;
            try
            {
                pret = Int32.Parse(b);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Procentul de ajustare trebuie sa fie un numar natural!", "Atentie!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MessageBox.Show(ex.Message);
                return false;
            }
            if (string.IsNullOrWhiteSpace(a))
            {
                MessageBox.Show("Numele categoriei este null sau contine numai spatii", "Atentie!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (pret > 40)
            {
                MessageBox.Show("Procentul de ajustare nu poate fi mai mare decat 40%!", "Atentie!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (pret < 1)
            {
                MessageBox.Show("Procentul de ajustare nu poate fi mai mic decat 1%!", "Atentie!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            

            return true;
        }
    }
}
