using Clase_8___Actividad_1;

namespace actividad1C8 
{
    class Program
    {
        public static void Main(string[] args)
        {
            Arquero arquero = new Arquero("Lucas", 1, 75, 80, 0, 0);

            Console.WriteLine("Nombre Arquero: "+ arquero.GetNombre());
            Console.WriteLine("Habilidad Arquero: " + arquero.GetHabilidad());
            Console.WriteLine("Velocidad Arquero: " + arquero.GetVelocidad());

            arquero.Mover(6, 3);
            Console.WriteLine("La posicion del arquero ahora es: (x,y) ("
                + arquero.x
                + ","
                + arquero.y
                + ")");

            arquero.Patear(8);

            arquero.TomarConLasManos();

            Console.ReadKey();

        }


//class
    }
}
