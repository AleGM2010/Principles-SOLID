using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_O
{
    // Interfaz IEnemigo para representar a los enemigos del juego
    public interface IEnemigo
    {
        string Nombre { get; set; }
        int Nivel { get; set; }
        int Vida { get; set; }
        int Danio { get; set; }

        void RecibirDanio(int danio);
        bool EstaVivo();
    }
}
