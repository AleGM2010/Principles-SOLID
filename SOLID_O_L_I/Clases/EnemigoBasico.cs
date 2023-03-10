using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_O
{
    public class EnemigoBasico : IEnemigo
    {
        public string Nombre { get; set; }
        public int Nivel { get; set; }
        public int Vida { get; set; }
        public int Danio { get; set; }

        // Constructor de la clase
        public EnemigoBasico(string nombre, int nivel, int vida, int danio)
        {
            Nombre = nombre;
            Nivel = nivel;
            Vida = vida;
            Danio = danio;
        }

        // Implementación del método RecibirDanio de la interfaz IEnemigo
        public void RecibirDanio(int danio)
        {
            Vida -= danio;
        }

        // Implementación del método EstaVivo de la interfaz IEnemigo
        public bool EstaVivo()
        {
            return Vida > 0;
        }
    }
}
