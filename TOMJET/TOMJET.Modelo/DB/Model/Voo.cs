using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TOMJET.Modelo.DB.Model
{
    public class Voo
    {
        public virtual int IdVoo { get; set; }
        public virtual int NumVoo { get; set; }
        public virtual String AeronaveVoo { get; set; }
        public virtual DateTime DataVoo { get; set; }
        public virtual DateTime HoraVoo { get; set; }
        public virtual String OrigemVoo { get; set; }
        public virtual String DestinoVoo { get; set; }
        public virtual int QtdAssentosVoo { get; set; }
        public virtual double VrUnicoPassagemVoo { get; set; }
        [XmlIgnore]
        public virtual IList<Passagem> Passagens { get; set; }

        public Voo()
        {
            Passagens = new List<Passagem>();
        }
    }

    public class VooMap : ClassMapping<Voo>
    {
        public VooMap()
        {
            Id(x => x.IdVoo, m => m.Generator(Generators.Identity));

            Property(x => x.NumVoo);
            Property(x => x.AeronaveVoo);
            Property(x => x.DataVoo);
            Property(x => x.HoraVoo);
            Property(x => x.OrigemVoo);
            Property(x => x.DestinoVoo);
            Property(x => x.QtdAssentosVoo);
            Property(x => x.VrUnicoPassagemVoo);

            Bag(x => x.Passagens, m =>
            {
                m.Inverse(true);
                m.Cascade(Cascade.DeleteOrphans);
                m.Lazy(CollectionLazy.Lazy);
                m.Key(k => k.Column("idVoo"));
            }, r => r.OneToMany());
        }
    }
}
