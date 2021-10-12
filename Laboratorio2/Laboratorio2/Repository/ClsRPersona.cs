using Laboratorio2.Data;
using Laboratorio2.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio2.Repository
{
    class ClsRPersona : Ipersona
    {
        public void Create(persona Per)
        {
            using (almacendepersonasEntities almacendepersonas = new almacendepersonasEntities())
            {
                persona persona = new persona();
                persona.nombrePersona = Per.nombrePersona;

                persona.edadPersona = Per.edadPersona;
                persona.descripcionPersona = Per.descripcionPersona;
                almacendepersonas.persona.Add(persona);
                almacendepersonas.SaveChanges();
            }
        }

        public List<persona> PersonaLista()
        {
            using (almacendepersonasEntities almacendepersonas = new almacendepersonasEntities())
            {
                List<persona> Lpersonas = almacendepersonas.persona.ToList();
                return Lpersonas;
            }
        }
    }
}
