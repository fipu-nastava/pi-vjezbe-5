using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Artikli
{
    public partial class ArtikliForm : Form
    {
        public BindingSource datasource;
        public List<Artikl> artikli;

        public ArtikliForm()
        {
            InitializeComponent();
            artikli = new List<Artikl>()
            {
                new Artikl("Mlijeko 2.5% mm", 4.49),
                new Artikl("Kruh bijeli 500g", 5.49),
                new Artikl("Čipi čips 200g", 15.23),
                new Artikl("Mlijeko 3.2% mm", 5.23)
            };
            var collection = new ObservableCollection<Artikl>(artikli);
            collection.CollectionChanged += Collection_CollectionChanged;

            datasource = new BindingSource(collection, null);
            // Omogući dodavanje novih redaka
            datasource.AllowNew = true;
            datasource.AddingNew += Datasource_AddingNew;
            dataGridView1.DataSource = datasource;
        }

        // Primjer hendlanja promjena
        private void Collection_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            if (e.Action == NotifyCollectionChangedAction.Add)
            {
                foreach (Artikl n in e.NewItems)
                {
                    n.Naziv = "Novi artikl";
                }
            }
        }

        // Primjer hendlanja novog artikla
        private void Datasource_AddingNew(object sender, AddingNewEventArgs e)
        {
            Console.WriteLine("Adding new" + e.NewObject);
            e.NewObject = new Artikl("", 0);
        }

        // klik na ćeliju
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                labArtikl.Text = "-";
                return;
            }
            else if (e.RowIndex < artikli.Count)
            {
                Artikl a = (Artikl)this.artikli[e.RowIndex];
                labArtikl.Text = a.Naziv + " " + a.Cijena;
                dataGridView1.Refresh();
            }
        }
    }
}
