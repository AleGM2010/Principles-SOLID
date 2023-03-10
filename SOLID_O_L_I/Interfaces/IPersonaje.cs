using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_O
{
    // Interfaz IPersonaje para representar a los personajes del juego
    public interface IPersonaje
    {
        string Nombre { get; set; }
        int Nivel { get; set; }
        int Vida { get; set; }
        int Danio { get; set; }

    }
}
