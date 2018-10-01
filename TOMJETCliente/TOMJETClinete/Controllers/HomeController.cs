using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TOMJETClinete.tomjetcliente;

namespace TOMJETClinete.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var server = new tomjetServer();
            var voos = server.BuscarTodos();

            return View(voos);
        }

        public ActionResult CadastrarVoo(Voo voo)
        {
            return View(new Voo());
        }

        public ActionResult GravarVoo(Voo voo)
        {
            var server = new tomjetServer();
            server.CadastrarVoo(voo);

            return RedirectToAction("Index");
        }

        public ActionResult BuscarVoo()
        {
            return View();
        }

        public ActionResult MostrarVoo(DateTime data,String origem, String destino)
        {
            var server = new tomjetServer();
            var voos = server.TodosVoosDataOrigemDestino(data, origem, destino);

            return View(voos);
        }

        public ActionResult ComprarPassagem(int id)
        {
            var server = new tomjetServer();
            var voo = server.BuscarVooPorId(id);

            return View(voo);
        }

        public ActionResult ConfirmarCompra(Voo voo,int qtdPassagens)
        {
            var server = new tomjetServer();
            server.ComprarBilhete(voo.NumVoo, qtdPassagens);

            return RedirectToAction("Index");
        }

        public ActionResult TodosBilhetes()
        {
            var server = new tomjetServer();
            var bilhetes = server.ConsultarBilhetes();

            return View(bilhetes);
        }

        public ActionResult DevolverBilhete(Passagem passagem)
        {
            var server = new tomjetServer();
            server.DevolverBilhete(passagem);

            return RedirectToAction("TodosBilhetes");
        }




    }
}