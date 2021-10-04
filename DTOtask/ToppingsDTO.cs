using System;
using System.Collections.Generic;
using System.Text;

namespace DTOtask
{
    class ToppingsDTO : ItemsDTO
    {
        public override bool Equals(object obj)
        {
            return obj is ToppingsDTO dTO &&
                   base.Equals(obj) &&
                   id == dTO.id &&
                   type == dTO.type;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(base.GetHashCode(), id, type);
        }
    }
}
