using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Planets.ViewModels
{
    public class PlanetVM
    {
        /// <summary>
        /// Konstruktor z parametrami
        /// </summary>
        /// <param name="name"></param>
        /// <param name="type"></param>
        /// <param name="mass"></param>
        /// <param name="radius"></param>
        /// <param name="life"></param>
        /// <param name="system"></param>
        /// <param name="image"></param>
        public PlanetVM(string name, string type, double mass, double radius, string life, string system, byte[] image)
        {
            Name = name;
            Type = type;
            Mass = mass;
            Radius = radius;
            Life = life;
            PlanetarySystem = system;
            Image = image;
        }

        // nazwa planety
        public string Name { get; set; }
        // typ planety
        public string Type { get; set; } 
        // masa planety
        public double Mass{ get; set; }
        // promień planety
        public double Radius { get; set; }
        // czy istnieje życie na planecie
        public string  Life { get; set; }
        //system planetarny, do ktorego nalezy planeta
        public string PlanetarySystem { get; set; }
        // obraz planety
        public byte[] Image{ get; set; }
    }
}