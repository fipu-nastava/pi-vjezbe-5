using NarucivanjeModel;
using Narudzbe.Presenter;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Narucivanje
{
    public partial class NarudzbaForm : Form
    {
        public List<Narudzba> narudzbePrikaz;

        public NarudzbaForm()
        {
            InitializeComponent();

            Artikl a1 = new Artikl("Mlijeko 2.5%mm", 2.32);
            Artikl a2 = new Artikl("Kruh Brionka bijeli", 5.44);
            Artikl a3 = new Artikl("Maslac 500g", 10.44);

            // instanciraj nekoliko narudžbi
            var n1 = new Narudzba(1, DateTime.Now.AddDays(-4), DateTime.Now.AddDays(1));
            n1.DodajStavku(a1, 13);
            var n2 = new Narudzba(2, DateTime.Now.AddDays(-3), DateTime.Now.AddDays(4));
            n2.DodajStavku(a1, 31);
            n2.DodajStavku(a2, 4);
            var n3 = new Narudzba(3, DateTime.Now.AddDays(-2), DateTime.Now.AddDays(5));
            n3.DodajStavku(a1, 3);
            n3.DodajStavku(a2, 4);
            n3.DodajStavku(a3, 3);
            var n4 = new Narudzba(4, DateTime.Now.AddDays(-1));
            n4.DodajStavku(a1, 2);
            n4.DodajStavku(a3, 12);

            // dodaj ih u kolekciju narudžbi
            narudzbePrikaz = new List<Narudzba> { n1, n2, n3, n4 };

            var narPresenter = new ObservableCollection<Narudzba>(narudzbePrikaz);
            dgNarudzba.DataSource = narPresenter;
        }

        private void dgNarudzba_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            var narudzba = this.narudzbePrikaz[e.RowIndex];

            // Bilo bi ljepše kroz NarudzbaPresenter, ali ajde...
            lblDatum.Text = narudzba.Datum.ToShortDateString();
            lblStavke.Text = narudzba.Stavke.Count.ToString();

            var stavkePresenter = new ObservableCollection<StavkaPresenter>(StavkaPresenter.ToPresenter(narudzba.Stavke));
            dgStavka.DataSource = stavkePresenter;
        }
    }
}
