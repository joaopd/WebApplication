using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public class Hero
    {
        public int Id{ get; set; }

        public string Name { get; set; }

        public Batle Batle{ get; set; }

        public int BatleId{ get; set; }


    }
}
