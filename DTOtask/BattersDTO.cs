using System;
using System.Collections.Generic;
using System.Text;

namespace DTOtask
{
    class BattersDTO
    {
        public List<SweetBattersDTO> sweetBatters { get; set; }
        public List<SaltyBattersDTO> saltyBatters { get; set; }

        public override bool Equals(object obj)
        {
            return obj is BattersDTO dTO &&
                   EqualityComparer<List<SweetBattersDTO>>.Default.Equals(sweetBatters, dTO.sweetBatters) &&
                   EqualityComparer<List<SaltyBattersDTO>>.Default.Equals(saltyBatters, dTO.saltyBatters);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(sweetBatters, saltyBatters);
        }
    }
}
