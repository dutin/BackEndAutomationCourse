using System;
using System.Collections.Generic;
using System.Text;

namespace DTOtask
{
    class BakeryDTO
    {

        public List<ItemsDTO> items;

        public override bool Equals(object obj)
        {
            return obj is BakeryDTO dTO &&
                   EqualityComparer<List<ItemsDTO>>.Default.Equals(items, dTO.items);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(items);
        }
    }
}
