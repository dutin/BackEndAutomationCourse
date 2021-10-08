using System;
using System.Collections.Generic;
using System.Text;

namespace DTOtask
{
    class Factory
    {
        public ItemDTO GetItem(int id, string name, string type, BatterDTO batter, ToppingsDTO topping)
        {
            return new ItemDTO(id, name, type, batter, topping);
        }

        public SweetBattersDTO GetSweetBatter(int id, string type)
        {
            return new SweetBattersDTO(id, type);
        }

        public SaltyBattersDTO GetSaltyBatter(int id, string type)
        {
            return new SaltyBattersDTO(id, type);
        }

        public ToppingsDTO GetToppings(int id, string type)
        {
            return new ToppingsDTO(id, type);
        }
    }
}
