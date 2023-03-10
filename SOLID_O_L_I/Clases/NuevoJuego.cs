using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_O
{
    public class NuevoJuego
    {
        public void MenuJuego(List<IPersonaje> equipo, List<IEnemigo> enemigos)
        {
            JugarTurno(equipo, enemigos);

            Console.WriteLine("¿Desea seguir jugando? (s/n)");
            var seguirJugando = Console.ReadLine();
            if (!string.IsNullOrEmpty(seguirJugando) && seguirJugando.ToLower() == "s")
            {
                MenuJuego(equipo, enemigos);
            }
        }



        public void JugarTurno(List<IPersonaje> equipo, List<IEnemigo> enemigos)
        {
            foreach (Personaje p in equipo)
            {
                foreach (IEnemigo e in enemigos.ToList())
                {
                    int accion;
                    Console.WriteLine($"Que desea que {p.Nombre} haga Vs {e.Nombre}? \n 1. Atacar \n 2. Descansar\n");
                    accion = int.Parse(Console.ReadLine());
                    switch (accion)
                    {
                        case 1:
                            p.Atacar(e);
                            Console.WriteLine($"{e.Nombre} Le queda {e.Vida} Hp");
                            if (!e.EstaVivo())
                            {
                                enemigos.Remove(e);
                                Console.WriteLine($"{e.Nombre} ha sido derrotado!");
                            }
                            break;
                        case 2:
                            p.Descansar();
                            goto siguienteTurno;
                        default:
                            Console.WriteLine($"{p.Nombre} No hace nada"); break;
                    }
                }
            siguienteTurno:;

            }

        }

    }
}
