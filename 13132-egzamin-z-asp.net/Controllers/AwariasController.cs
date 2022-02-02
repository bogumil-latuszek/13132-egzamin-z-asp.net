using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using _13132_egzamin_z_asp.net.Data;
using _13132_egzamin_z_asp.net.Models;

namespace _13132_egzamin_z_asp.net.Controllers
{
    public class repozytoriumAwarii
    {
        private List<Awaria> lista = new List<Awaria>();

        public List<Awaria> GetList()
        {
            return lista;
        }
        public void AddAwaria(Awaria a)
        {
            lista.Add(a);
        }
    }
    public class AwariasController : Controller
    {
        /*
        private readonly _13132_egzamin_z_aspnetContext _context;

        public AwariasController(_13132_egzamin_z_aspnetContext context)
        {
            _context = context;
        }
        */
        private int idCounter = 0;
        private repozytoriumAwarii repo = new repozytoriumAwarii();
        // GET: Awarias
        public async Task<IActionResult> Index()
        {
            return View(repo.GetList());
        }

        

        // GET: Awarias/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Awarias/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("miejsce,opis,nrUrzadzenia")] Awaria awaria)
        {
            if (ModelState.IsValid)
            {
                idCounter++;
                awaria.AwariaID = idCounter;
                DateTime aktualnaData = DateTime.Now;
                awaria.dataZgloszenia = aktualnaData;
                repo.AddAwaria(awaria);
                return RedirectToAction(nameof(Index));
            }
            return View(awaria);
        }
    }
}
