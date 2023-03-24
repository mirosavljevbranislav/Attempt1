using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.PartTwo.Data.Model
{
    public class EngineType
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public string Name { get; set; }
        public List<Engine> Engine { get; set ; }
        public int EngineId { get; set; }
    }
}
