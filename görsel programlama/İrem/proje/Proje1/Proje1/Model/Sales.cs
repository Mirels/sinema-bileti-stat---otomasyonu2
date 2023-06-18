using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;

namespace Proje1.Model
{
    public class Sales 
    {
        public Sales()
        {
            KesimTarih = DateTime.Now.ToString();
        }
        public virtual int Numara { get; set; }
        public virtual string KesimTarih { get; set; }
        public virtual decimal Ücret { get; set; }
        public virtual int Adet { get; set; }

        public virtual string Seans { get; set; }

        public virtual string MüsteriBilgi { get; set; }

        public virtual string Koltuk { get; set; }

        public override string ToString()
        {
            Movie movie = new Movie();
            return $"{movie.movieName} Adlı Filmin {Seans} Seansına {Adet} Adet Bilet Kesilmiştir. Toplam Tutar {Ücret} ₺ || Satın" +
                $"Alınma Tarihi = {KesimTarih}";
        }
    }

    public class SalesMapping : ClassMapping<Sales>
    {
        public SalesMapping()
        {
            Table("Sales");
            Id(x => x.Numara, m => m.Generator(Generators.Native));
            Property(x => x.KesimTarih, x => x.NotNullable(true));
            Property(x => x.Ücret, x => x.NotNullable(true));
            Property(x => x.Adet, x => x.NotNullable(true));
            Property(x => x.Seans, x => x.NotNullable(true));
            Property(x => x.MüsteriBilgi, x => x.NotNullable(false));
            Property(x => x.Koltuk, x => x.NotNullable(false));
        }
    }
}
