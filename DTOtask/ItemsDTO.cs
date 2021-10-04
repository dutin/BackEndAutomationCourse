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

        public override bool Equals(object obj)
        {
            return obj is ItemsDTO dTO &&
                   id == dTO.id &&
                   type == dTO.type &&
                   name == dTO.name &&
                   ppu == dTO.ppu &&
                   EqualityComparer<BattersDTO>.Default.Equals(batters, dTO.batters) &&
                   EqualityComparer<List<ToppingsDTO>>.Default.Equals(toppings, dTO.toppings);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(id, type, name, ppu, batters, toppings);
        }
    }
}
