using System;
using System.Collections.Generic;
using System.Text;

namespace DTOtask
{
    class Program
    {
        public static void Main(string[] args)
        {
            Factory creator = new Factory();

            //var cake = creator.GetItem();
            var pickle = creator.GetSweetBatter(1, "sdasdas");
            var sugarCoating = creator.GetToppings();
        }
    }
}
