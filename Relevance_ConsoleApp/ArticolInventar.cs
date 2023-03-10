using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relevance_ConsoleApp
{
    public class ArticolInventar
    {
        public float Greutate { get; private set; }
        public float Volum { get; private set; }

        public ArticolInventar(float greutate, float volum)
        {
            Greutate = greutate;
            Volum = volum;
        }
    }
}
