using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_8___Actividad_1
{
    internal class Arquero : Jugador
    {
        public Arquero(string nombre, int numero, int habilidad, int velocidad, int x, int y)
        : base(nombre, numero, habilidad, velocidad, x, y)
        {
        }

        public void TomarConLasManos()
        {
            Console.WriteLine("El arquero agarro la pelota");
        }

    }
}
