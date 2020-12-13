using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public class Arm
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public Hero Hero{ get; set; }

        public int HeroId { get; set; }
    }
}
