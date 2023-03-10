using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_O
{
    class Program
    {
        static void Main()
        {
            NuevoJuego game = new NuevoJuego();
            Creacion crear = new Creacion();

            List<IPersonaje> equipo = crear.GenerarPersonajes(new List<IPersonaje>());
            List<IEnemigo> enemigos = crear.GenerarEnemigos(new List<IEnemigo>());

            game.MenuJuego(equipo, enemigos);
           
        } // Fin del main
    }
} // Fin 