using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Planets.ViewModels
{
    public class EclipseVM
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
        public EclipseVM(int id, DateTime data, TimeSpan start, TimeSpan max, TimeSpan end, string  discription)
        {
            IDEclipse = id;
            DataOfEclipse = data;
            StartEclipse = start;
            MaxPhase = max;
            EndPhase = end;
            Discription = discription;
        }


        public int IDEclipse { get; set; }
        public DateTime DataOfEclipse { get; set; }
        public TimeSpan StartEclipse { get; set; }
        public TimeSpan MaxPhase { get; set; }
        public TimeSpan EndPhase { get; set; }
        public string Discription { get; set; }
    }
}