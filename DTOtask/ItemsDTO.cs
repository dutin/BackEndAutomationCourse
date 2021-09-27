using System;
using System.Collections.Generic;
using System.Text;

namespace DTOtask
{
    class ItemsDTO
    {

        public int id { get; set; }
        public string type { get; set; }
        public string name { get; set; }
        public double ppu { get; set; }
        public BattersDTO batters { get; set; }
        public List<ToppingsDTO> toppings { get; set; }

    }
}
