using NarucivanjeModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Narudzbe.Presenter
{
    class StavkaPresenter
    {
        public static List<StavkaPresenter> ToPresenter(List<NarudzbaStavka> stavke)
        {
            var stavkePresenter = new List<StavkaPresenter>();
            foreach(var s in stavke)
            {
                stavkePresenter.Add(new StavkaPresenter(s));
            }
            return stavkePresenter;
        }

        NarudzbaStavka model;

        public StavkaPresenter(NarudzbaStavka stavka)
        {
            this.model = stavka;
        }

        public string Naziv
        {
            get
            {
                return model.ArtiklStavke.Naziv;
            }
        }

        public string Kolicina
        {
            get
            {
                return model.Kolicina.ToString();
            }
        }

        public string Cijena
        {
            get
            {
                return model.ArtiklStavke.Cijena.ToString("#.## kn");
            }
        }
    }
}
