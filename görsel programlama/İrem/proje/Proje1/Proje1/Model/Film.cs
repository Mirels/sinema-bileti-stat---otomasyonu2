using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Proje1.Model
{
    public class Film
    {
        public virtual int Id { get; set; }
        public virtual string FilmAdi { get; set; }
        public virtual DateTime Tarih { get; set; } = DateTime.Now;
        public virtual DateTime Saat { get; set; } = DateTime.Now;
    }

    public class FilmMap : ClassMapping<Film>
    {
        public FilmMap()
        {
            Table("Film");
            Id(x => x.Id, m => m.Generator(Generators.Native));
            Property(x => x.FilmAdi, x => x.NotNullable(true));
            Property(x => x.Tarih, x => x.NotNullable(true));
            Property(x => x.Saat, x => x.NotNullable(true));
        }
    }
}
