using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Repository repository = new MemoryRepo();

            Repository repository = new XMLRepository(@"C:\Users\Lucian\SkyDrive\Documents\Visual Studio 2013\ANUL II\MAP\Examen\produse.xml");

            IDGenerator generator = IDGenerator.getGenerator();
            /*
            repository.AddObject(new Produs(generator.nextID(), "Sunca", 200, "Carne", 0));
            repository.AddObject(new Produs(generator.nextID(), "Carne tocata", 300, "Carne", 0));
            repository.AddObject(new Produs(generator.nextID(), "Lapte", 100, "Lactate", 0));
            repository.AddObject(new Produs(generator.nextID(), "Branza", 130, "Lactate", 0));
            repository.AddObject(new Produs(generator.nextID(), "Iaurt", 120, "Lactate", 0));
            repository.AddObject(new Produs(generator.nextID(), "Placinte", 80, "Fainoase", 0));
            repository.AddObject(new Produs(generator.nextID(), "Cornuri", 75, "Fainoase", 0));
            repository.AddObject(new Produs(generator.nextID(), "Paine", 110, "Fainoase", 0));
            */


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Angajat ang = new Angajat(repository);
            ang.Show();
            Angajat ang1 = new Angajat(repository);
            ang1.Show();
            Angajat ang2= new Angajat(repository);
            ang2.Show();
            Angajat ang3 = new Angajat(repository);
            ang3.Show();
            Application.Run(new Administrator(repository));

            repository.Close();
        }
    }
}
