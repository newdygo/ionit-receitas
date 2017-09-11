using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ionit.receitas.core.interfaces;

namespace ionit_receitas.Controllers
{
    public class ReceitaController : Controller
    {
        private IUnitOfWork UnitOfWork;

        public ReceitaController(IUnitOfWork unitOfWork)
        {
            UnitOfWork = unitOfWork;
        }

        // GET: Receita
        public ActionResult Index()
        {
            var receitas = UnitOfWork.Receita;

            return View();
        }
    }
}