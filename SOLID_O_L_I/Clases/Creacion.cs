using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_O
{ // Clase para crear los equipos de personajes y enemigos
    public class Creacion
    {

        public List<IEnemigo> GenerarEnemigos(List<IEnemigo> enemigos)
        {
            enemigos.Add(new EnemigoBasico("Goblin", 1, 50, 10));
            enemigos.Add(new EnemigoBasico("Esqueleto", 2, 70, 15));
            enemigos.Add(new EnemigoBasico("Grommash", 8, vida: 60, 4));
            return enemigos;
        }

        public List<IPersonaje> GenerarPersonajes(List<IPersonaje> equipo)
        {
            equipo.Add(new Guerrero("Conan", 10, 100, danio: 20, estamina: 30));
            equipo.Add(new Mago("Gandalf", 10, 80, danio: 50, mana: 40));
            equipo.Add(new Ladron("Arya", 10, 60, 30, 20));
            return equipo;
        }
    }
}
