using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Planets.ViewModels;

namespace Planets.Controllers
{
    public class HomeController : Controller
    {
        // Połączenie z bazą danych
        PlanetsDbEntities database = new PlanetsDbEntities();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        // Strona służy do przesyłania wiadomości od użytkowników do twórców
        public ActionResult Contact(MessageFromUserVM model)
        {

            //ViewBag.Message = "Your contact page.";
            try
            {
                MessageFromUser message = new MessageFromUser();

                message.Author = model.Author;
                message.Content = model.Content;
                DateTime time = DateTime.Today;
                message.Date = time;

                database.MessageFromUser.Add(message);
                database.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Trace.TraceInformation("Property: {0} Error: {1}",
                                                validationError.PropertyName,
                                                validationError.ErrorMessage);
                    }
                }
            }

            return View();
        }
        [HttpGet]
        public ActionResult PlanetsOfSolarSystem()
        {
            // pobranie wszystkich planet do listy
            //List<Planet> AllPlanets = database.Planet.ToList();

            // JOIN tabeli zależnej Planet z tabelami głównymi
            var queryable = from planet in database.Planet
                            join type in database.TypeOfPlanet on planet.Type equals type.IDType
                            join life in database.IsThereLife on planet.Life equals life.IDLife
                            join system in database.PlanetarySystem on planet.PlanetarySystem equals system.IDPlanetarySystem
                            select new { Name = planet.Name, Type = type.Type, Mass = planet.Mass, Radius = planet.Radius, Life = life.Life, PlanetarySystem = system.System, Image = planet.Image };

            // stworzenie listy obietków klasy PlanetVM
            List<PlanetVM> ViewPlanets = new List<PlanetVM>();

            // dodanie do utworzonej listy planety stworzone na podstawie konstruktora w klasie PlanetVM
            foreach (var Planet in queryable)
            {
                PlanetVM viewPlanet = new PlanetVM(Planet.Name, Planet.Type, Planet.Mass, Planet.Radius, Planet.Life, Planet.PlanetarySystem, Planet.Image);
                ViewPlanets.Add(viewPlanet);
            }

            return View(ViewPlanets);
        }
        /// <summary>
        /// Wyświetlanie strony o układzie słonecznym
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult SolarSystem()
        {
            return View();
        }

        /// <summary>
        /// Wyświetlanie strony o zaćmieniach słońca
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Eclipse()
        {
            // pobranie wszystkich danych o zaćmieniach
            List<Eclipse> AllEclpise = database.Eclipse.ToList();

            // stworzenie listy obiektów klasy EclipseVM
            List<EclipseVM> ViewEclpise = new List<EclipseVM>();

            // dodanie do utworzonej listy zaćmienia stworzone na podstawie konstruktora w klasie EclipseVM
            foreach (var Eclipse in AllEclpise)
            {
                EclipseVM viewEclipse = new EclipseVM(Eclipse.IDEclipse, Eclipse.DataOfEclipse, Eclipse.StartEclipse, Eclipse.MaxPhase, Eclipse.EndEclipse, Eclipse.Discription);
                ViewEclpise.Add(viewEclipse);
            }
            return View(ViewEclpise);
        }


        /// <summary>
        /// Wyświetlanie strony o Słońcu
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Sun()
        {
            // z tabeli Stars będzie wybierany wiersz z nazwą gwiazdy rowną 'Słońce'
            var name = "Słońce";

            // JOIN jako, że tabela Star jest tabelą zależną
            var join = from sun in database.Star
                       join system in database.PlanetarySystem on sun.PlanetarySystem equals system.IDPlanetarySystem
                       where sun.NameStar == name
                       select new { Name = sun.NameStar, Type = sun.TypeStar, Mass = sun.Mass, Radius = sun.Radius, PlanetarySystem = system.System, Image = sun.Image };

            List<StarVM> ViewSun = new List<StarVM>();

            foreach (var Sun in join)
            {
                StarVM viewSun = new StarVM(Sun.Name, Sun.Type, Sun.Mass, Sun.Radius, Sun.PlanetarySystem, Sun.Image);
                ViewSun.Add(viewSun);
            }

            return View(ViewSun);
        }

    }
}

