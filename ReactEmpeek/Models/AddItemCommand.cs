using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReactEmpeek.Models
{
    public class AddItemCommand
    {
        public string Name { get; set; }
        public string Type { get; set; }
    }
}
