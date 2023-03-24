using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.PartTwo.Data.Model
{
    public class Engine
    {
        public int Id { get; set; }
        public int Year { get; set; }
        public string Brand { get; set; }
        public int SerialNumber { get; set; }
        public string Type { get; set; }
        public EngineType EngineType { get; set; }
        public int EngineTypeId { get; set; }
    }
}
