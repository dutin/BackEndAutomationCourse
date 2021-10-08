using System;
using System.Collections.Generic;
using System.Text;

namespace DTOtask
{
    class ItemDTO
    {       

        public int id { get; set; }
        public string type { get; set; }
        public string name { get; set; }
        public double ppu { get; set; }
        public BatterDTO batter { get; set; }
        public ToppingsDTO topping { get; set; }

        public ItemDTO() { }
        public ItemDTO(int id, string name, string type, BatterDTO batter, ToppingsDTO topping)
        {
            this.id = id;
            this.name = name;
            this.type = type;
            this.batter = batter;
            this.topping = topping;
        }

        public override bool Equals(object obj)
        {
            return obj is ItemDTO dTO &&
                   id == dTO.id &&
                   type == dTO.type &&
                   name == dTO.name &&
                   ppu == dTO.ppu &&
                   EqualityComparer<BatterDTO>.Default.Equals(batter, dTO.batter) &&
                   EqualityComparer<ToppingsDTO>.Default.Equals(topping, dTO.topping);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(id, type, name, ppu, batter, topping);
        }
    }
}
