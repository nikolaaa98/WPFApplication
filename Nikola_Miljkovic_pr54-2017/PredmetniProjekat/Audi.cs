using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PredmetniProjekat
{
    [Serializable]
    public class Audi
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string model;

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        private string opis;

        private string oznaka;

        public string Oznaka
        {
            get { return oznaka; }
            set { oznaka = value; }
        }

        public string Opis
        {
            get { return opis; }
            set { opis = value; }
        }

        private string karoserija;

        public string Karoserija
        {
            get { return karoserija; }
            set { karoserija = value; }
        }


        private DateTime vreme;

        public DateTime Vreme
        {
            get { return vreme; }
            set { vreme = value; }
        }

        private string image;

        public string Image
        {
            get { return image; }
            set { image = value; }
        }

        private int cena;

        public int Cena
        {
            get { return cena; }
            set { cena = value; }
        }



        public Audi(int id, int cena, string model, string oznaka, string opis, DateTime vreme,  string karoserija, string image)
        {
            Id = id;
            Model = model;
            Opis = opis;
            Vreme = vreme;
            Image = image;
            Oznaka = oznaka;
            Cena = cena;
            Karoserija = karoserija;
        }

        public Audi()
        {
            Id = 0;
            Model = "";
            Opis = "";
            Vreme = new DateTime(2019, 1, 1);
            Image = "";
            Oznaka = "";
            Cena = 0;
            Karoserija = "";
        }

        public override string ToString()
        {
            return Model + " " + Opis + " " + Oznaka + " " + Karoserija;
        }
    }
}
