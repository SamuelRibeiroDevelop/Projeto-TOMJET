using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TOMJET.Modelo.DB.Model;

namespace TOMJET.Modelo.DB.Repository
{
    public class VooRepository : RepositoryBase<Voo>
    {
        public VooRepository(ISessionFactory sessionFactory) : base(sessionFactory) { }

        public Voo BuscarPeloNumero(int numeroVoo)
        {
            try
            {
                return Session.Query<Voo>().FirstOrDefault(f => f.NumVoo == numeroVoo);
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
