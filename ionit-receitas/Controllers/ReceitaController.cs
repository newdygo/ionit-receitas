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
            return View(UnitOfWork.Receita.Entities.ToList());
        }

        // GET: fff/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: fff/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ionit.receitas.core.Entities.Receita entidade)
        {
            try
            {
                UnitOfWork.Receita.Create(entidade);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}