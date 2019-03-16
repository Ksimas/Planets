using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Planets.ViewModels
{
    public class MessageFromUserVM
    {

        public Int32 MessageID { get; set; }

        public string Author { get; set; }

        public string Content { get; set; }

        public DateTime Date { get; set; }
    }
}