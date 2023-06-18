using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje1.Model
{
    public class Musteri
    {
        public virtual int Id { get; set; }
        public virtual string AdSoyad { get; set; }
        public virtual string Bilet { get; set; }
    }

    public class MusteriMap : ClassMapping<Musteri>
    {
        public MusteriMap()
        {
            Table("Musteri");
            Id(x => x.Id, m => m.Generator(Generators.Native));
            Property(x => x.AdSoyad, x => x.NotNullable(true));
            Property(x => x.Bilet, x => x.NotNullable(true));
        }
    }
}
