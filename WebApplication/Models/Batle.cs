using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public class Batle
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public String Description   { get; set; }

        public DateTime DTBegin{ get; set; }

        public DateTime DtFinish{ get; set; }
    }
}
