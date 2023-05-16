using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_8___Actividad_1
{
    internal class Jugador
    {
        protected string nombre;
        protected int numero;
        protected int habilidad;
        protected int velocidad;
        public int x, y;

        public Jugador(string nombre, int numero, int habilidad, int velocidad, int x, int y)
        {
            this.nombre = nombre;
            this.numero = numero;
            this.habilidad = habilidad;
            this.velocidad = velocidad;
            this.x = x;
            this.y = y;
        }

        public void SetHabilidad(int habilidad)
        {
            this.habilidad = habilidad;
        }
            
        public int GetHabilidad()
        {
            return habilidad;
        }

        public void SetVelocidad(int velocidad)
        {
            this.velocidad = velocidad;
        }

        public int GetVelocidad()
        {
            return velocidad;
        }

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public String GetNombre()
        {
            return nombre;
        }

        public void Mover(int desplazamientoX, int desplazamientoY)
        {
            x += desplazamientoX;
            y += desplazamientoY;
        }

        public void Patear(int potencia)
        {
            if(potencia >= 1 && potencia <= 3)
            {
                Console.WriteLine("Disparo Debil");
            }
            else if(potencia >= 4 && potencia <= 8)
            {
                Console.WriteLine("Disparo Medio");
            }
            else if (potencia >= 9 && potencia <= 10)
            {
                Console.WriteLine("Disparo Medio");
            }
            else
            {
                Console.WriteLine("Potencia indicada invalida");
            }
        }

    }
}
