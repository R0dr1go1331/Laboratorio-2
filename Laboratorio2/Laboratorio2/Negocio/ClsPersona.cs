using Laboratorio2.Data;
using Laboratorio2.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio2.Negocio
{
    class ClsPersona : ClsRPersona 
    {
        public void Almacenar(persona Per)
        {
            if (Per.edadPersona >= 18)
            {
                Create(Per);
            }


        }

        public List<persona> ListaFinal()
        {
            List<persona> Lista = PersonaLista();
            return Lista;
        }
    }
}
