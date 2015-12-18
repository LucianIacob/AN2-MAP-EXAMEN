using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen
{
    public partial class Administrator : Form, IObserver<Produs>
    {
        public Repository repository;

        public Administrator(Repository repo)
        {
            InitializeComponent();
            this.repository = repo;
            this.repository.Subscribe(this);
            reloadData();
        }

        private void reloadData()
        {
            lstProduse.Items.Clear();
            foreach (Produs p in repository.GetAll())
            {
                lstProduse.Items.Add(p.ToString());
            }
        }

        public void OnCompleted()
        {
            throw new NotImplementedException();
        }
        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }
        public void OnNext(Produs value)
        {
            this.reloadData();
        }
    }
}
