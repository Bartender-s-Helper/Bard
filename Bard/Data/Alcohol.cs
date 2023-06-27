using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bard.Data
{
    public class Alcohol
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal ABV { get; set; }
        public string? Description { get; set; }
        public string? Country { get; set; }
        public string? Categories { get; set; }
        public string? SugarContents { get; set; }
        public string? TastingNotes { get; set; }
        public string? Producer { get; set; }
    }
}
