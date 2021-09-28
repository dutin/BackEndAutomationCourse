using System;
using System.Collections.Generic;
using System.Text;

namespace DTOtask
{
    class BattersDTO
    {
        public List<SweetBattersDTO> sweetBatters { get; set; }
        public List<SaltyBattersDTO> saltyBatters { get; set; }
    }
}
