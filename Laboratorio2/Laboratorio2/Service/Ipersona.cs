using Laboratorio2.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio2.Service
{
    interface Ipersona
    {
        void Create(persona Per);
         List<persona> PersonaLista();



    }
}
