using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOMJET.Modelo.DB.Model
{
    public class Passagem
    {
        public virtual int IdPassagem { get; set; }
        public virtual DateTime DataPassagem { get; set; }
        public virtual DateTime HoraPassagem { get; set; }
        public virtual double ValorPassagem { get; set; }
        public virtual Voo Voo{ get; set; }
       

    }

    public class PassagemMap : ClassMapping<Passagem>
    {
        public PassagemMap()
        {
            Id(x => x.IdPassagem, m => m.Generator(Generators.Identity));

            Property(x => x.DataPassagem);
            Property(x => x.HoraPassagem);
            Property(x => x.ValorPassagem);

            ManyToOne(x => x.Voo, m =>
            {
                m.Lazy(LazyRelation.NoLazy);
                m.Column("idVoo");
            });

        }
        
    }
}
