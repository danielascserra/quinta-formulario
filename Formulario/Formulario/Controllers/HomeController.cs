using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Formulario.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            // viewBag para guardar a resposta
            ViewBag.resposta = "";

            return View();
        }

        [HttpPost]
        public ActionResult Index(string nome, int? idade){
            /// (comentário longo) precisamos de validar os dados introduzidos pelo utilizador
            /// 1ª questao: o "nome" é um nome?
            /// 2ª questao: a idade está dentro dos parâmetros pretendidos[0;120]?


            string mensagem = "";

            // validar a idade
            if (idade >= 0 && idade <= 120)
            {
                // criar a mensagem de resposta.
                mensagem = "Você chama-se " + nome + "e tem " + idade + " anos.";
            }
            else {
                //mensagem alternativa
                mensagem = "Deve especificar uma idade válda!\n" + 
                    " A idade deve ser maior que ero e menor que  120 anos...";
            }
 
            // criar o "contentor" que levará a mensagem para o View
            ViewBag.resposta = mensagem;
            // invoca a View
            return View();
        }






    }
}