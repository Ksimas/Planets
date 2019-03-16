using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Planets.ViewModels
{
    public class StarVM
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
        public StarVM(string name, string type, double mass, double radius, string system, byte[] image)
        {
            Name = name;
            Type = type;
            Mass = mass;
            Radius = radius;
            PlanetarySystem = system;
            Image = image;
        }

        // nazwa gwiazdy
        public string Name { get; set; }
        // typ gwiazdy
        public string Type { get; set; }
        // masa gwiazdy
        public double Mass { get; set; }
        // promień gwiazdy
        public double Radius { get; set; }
        //system planetarny, do ktorego nalezy gwiazda
        public string PlanetarySystem { get; set; }
        // obraz gwiazdy
        public byte[] Image { get; set; }

    }
}