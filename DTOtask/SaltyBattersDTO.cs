using System;
using System.Collections.Generic;
using System.Text;

namespace DTOtask
{
    class SaltyBattersDTO : ItemDTO
    {
        public SaltyBattersDTO(int id, string type)
        {
            this.id = id;
            this.type = type;
        }

        public override bool Equals(object obj)
        {
            return obj is SaltyBattersDTO dTO &&
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
