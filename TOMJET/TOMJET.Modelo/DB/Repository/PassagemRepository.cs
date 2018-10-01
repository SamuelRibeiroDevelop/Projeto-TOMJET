using NHibernate;
using NHibernate.Criterion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TOMJET.Modelo.DB.Model;

namespace TOMJET.Modelo.DB.Repository
{
    public class PassagemRepository : RepositoryBase<Passagem>
    {
        public PassagemRepository(ISessionFactory sessionFactory) : base(sessionFactory) { }

        public int ContarPassagens(int id)
        {
            try
            {
                return Session.Query<Passagem>().Where(x => x.Voo.IdVoo == id).Count() ;
            }
            finally
            {
                if (Session.IsOpen)
                {
                    Session.Close();
                }
            }
        }
    }
}
