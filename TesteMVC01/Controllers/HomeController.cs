using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteMVC01.Models;

namespace TesteMVC01.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var pessoa = new Pessoa
            {
                idPessoa = 1,
                Nome = "Joeslei",
                Tipo = "Heroi"
            };

            //ViewData["idPessoa"] = pessoa.idPessoa;
            //ViewData["Nome"] = pessoa.Nome;
            //ViewData["Tipo"] = pessoa.Tipo;

            //ViewBag.id = pessoa.idPessoa;
            //ViewBag.nome = pessoa.Nome;
            //ViewBag.tipo = pessoa.Tipo;

            //return View();

            return View(pessoa);
        }

        [HttpPost] // esse método so pode ser usado em requisições HTTP
        public IActionResult Lista(int pessoaId, string nome, string tipo)
        {
            ViewData["idPessoa"] = pessoaId;
            ViewData["Nome"] = nome;
            ViewData["Tipo"] = tipo;

            return View();
        }

        public IActionResult Contatos()
        {
            return View();
        }
    }
}
