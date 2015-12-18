using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Examen
{
    public interface Repository : IObservable<Produs>
    {
        void AddObject(Produs o);
        bool Remove(int id);
        Produs[] GetAll();
        void Close();

        bool Update(Produs p);
    }

    public class MemoryRepo : Repository
    {
        protected List<Produs> data;
        private List<IObserver<Produs>> observers = new List<IObserver<Produs>>();
        private class Unsubscriber : IDisposable
        {
            private List<IObserver<Produs>> _observers;
            private IObserver<Produs> _observer;

            public Unsubscriber(List<IObserver<Produs>> observers, IObserver<Produs> observer)
            {
                this._observers = observers;
                this._observer = observer;
            }

            public void Dispose()
            {
                if (_observer != null && _observers.Contains(_observer))
                {
                    _observers.Remove(_observer);
                }
            }
        }

        public MemoryRepo()
        {
            data = new List<Produs>();
        }

        public IDisposable Subscribe(IObserver<Produs> observer)
        {
            if (!observers.Contains(observer))
            {
                observers.Add(observer);
            }
            return new Unsubscriber(observers, observer);
        }

        public void Notify(Produs next)
        {
            foreach (IObserver<Produs> obs in this.observers)
            {
                obs.OnNext(next);
            }
        }

        public void AddObject(Produs o)
        {
            data.Add(o);
            this.Notify(o);
        }

        public bool Remove(int id)
        {
            foreach (Produs o in data)
            {
                if (o.ID == id)
                {
                    data.Remove(o);
                    this.Notify(o);
                    return true;
                }
            }
            return false;
        }

        public Produs[] GetAll()
        {
            return data.ToArray();
        }

        public bool Update(Produs o)
        {
            for (int i = 0; i < data.Count; i++)
            {
                if (data[i].categorie == o.categorie)
                {
                    data[i].procent = o.procent;
                    int pretNou = data[i].pret + (o.procent * data[i].pret)/100;
                    data[i].pret = pretNou;
                    this.Notify(data[i]);
                }
            }
            return true;
        }

        public virtual void Close()
        {

        }
    }

    public class XMLRepository : MemoryRepo
    {
        private String fileName;

        public XMLRepository(String fileName)
        {
            this.fileName = fileName;
            unmarshall();
        }
        public override void Close()
        {
            writeToFile();
            marshall();
        }

        private void writeToFile()
        {
            List<String> produse_modificate = new List<string>();
            foreach (Produs p in data)
            {
                if (p.procent != 0)
                {
                    string line = p.denumire + p.pret.ToString();
                    produse_modificate.Add(line);
                }
            }
            File.WriteAllLines(@"C:\Users\Lucian\SkyDrive\Documents\Visual Studio 2013\ANUL II\MAP\Examen\Produse_modificate.txt", produse_modificate.ToArray());
        }

        private void marshall()
        {
            XmlSerializer ser = new XmlSerializer(this.data.GetType());
            TextWriter writer = new StreamWriter(fileName);
            ser.Serialize(writer, this.data);
            writer.Close();
        }

        private void unmarshall()
        {
            XmlSerializer ser = new XmlSerializer(this.data.GetType());
            TextReader reader = new StreamReader(fileName);
            this.data = (List<Produs>)ser.Deserialize(reader);
            reader.Close();
        }


        
    }
}
