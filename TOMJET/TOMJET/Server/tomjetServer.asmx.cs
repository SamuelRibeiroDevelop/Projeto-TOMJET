using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using TOMJET.Modelo.DB;
using TOMJET.Modelo.DB.Model;

namespace TOMJET.Server
{
    /// <summary>
    /// Descrição resumida de tomjetServer
    /// </summary>
    [WebService(Namespace = "http://grupodomeio.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que esse serviço da web seja chamado a partir do script, usando ASP.NET AJAX, remova os comentários da linha a seguir. 
    // [System.Web.Script.Services.ScriptService]
    public class tomjetServer : System.Web.Services.WebService
    {

        [WebMethod]
        public Voo CadastrarVoo(Voo voo)
        {
            return DbFactory.Instance.VooRepository.SaveOrUpdate(voo);
        }

        [WebMethod]
        public List<Voo> BuscarTodos()
        {
            List <Voo> voo = new List<Voo>();
            voo = DbFactory.Instance.VooRepository.FindAll().ToList();

            return voo;
        }

        [WebMethod]
        public Voo BuscarVooPorId(int id)
        {
            var voo = DbFactory.Instance.VooRepository.FirstById(id);

            return voo;
        }


        [WebMethod]
        public List<Voo> TodosVoosDataOrigemDestino(DateTime data, String origem, String destino)
        {
            var voos = DbFactory.Instance.VooRepository.FindAll().ToList();
            voos = voos.Where(w => w.DataVoo.Date == data.Date && w.OrigemVoo.ToString() == origem.ToString() && w.DestinoVoo.ToString() == destino.ToString()).ToList();

            return voos;
        }

        [WebMethod]
        public Voo ComprarBilhete(int numeroVoo, int quantPassagens)
        {
            //var NumeroPassagens = DbFactory.Instance.PassagemRepository.ContarPassagens(voo.IdVoo);

             var voo = DbFactory.Instance.VooRepository.BuscarPeloNumero(numeroVoo);

                if (voo.QtdAssentosVoo >= quantPassagens)
                {
                    for (var i = 0; i < quantPassagens; i++)
                    {
                        voo.QtdAssentosVoo = voo.QtdAssentosVoo - 1;
                        Passagem p = new Passagem();
                        p.Voo = voo;
                        p.DataPassagem = voo.DataVoo;
                        p.HoraPassagem = voo.HoraVoo;
                        p.ValorPassagem = voo.VrUnicoPassagemVoo;
                        DbFactory.Instance.PassagemRepository.SaveOrUpdate(p);
                    }

                    DbFactory.Instance.VooRepository.SaveOrUpdate(voo);
                    return voo;
                }

                throw new Exception("Não ha mais bilhetes disponíveis");
        }

        [WebMethod]
        public List<Passagem> ConsultarBilhetes()
        {
            var bilhetes = DbFactory.Instance.PassagemRepository.FindAll().ToList();

            return bilhetes;
        }

        [WebMethod]
        public void DevolverBilhete(Passagem passagem)
        {
            var pas = DbFactory.Instance.PassagemRepository.FirstById(passagem.IdPassagem);
            var voo = DbFactory.Instance.VooRepository.BuscarPeloNumero(pas.Voo.NumVoo);

                if(voo != null)
                {
                    voo.QtdAssentosVoo = voo.QtdAssentosVoo + 1;
                    DbFactory.Instance.PassagemRepository.Delete(pas);
                    DbFactory.Instance.VooRepository.SaveOrUpdate(voo);
                }
            	else{
                    throw new Exception("Não foi possível encontrar este bilhete",ex);
	}        
        }

    }
}
