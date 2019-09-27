using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaComposicion
{
    public class Pizza
    {
        public Pizza()
        {
            this.Queso = new Queso();
            this.Refresco = new Refresco();
        }

        public Queso Queso { get; set; }

        public Refresco Refresco { get; set; }

    }
    public class Queso
    {

    }

    public class Refresco
    {

    }
}
