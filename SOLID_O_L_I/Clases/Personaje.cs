using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_O
{    // Clase de personaje básica que implementa la interfaz IPersonaje
    public class Personaje : IPersonaje, IAcciones
    {
        public string Nombre { get; set; }
        public int Nivel { get; set; }
        public int Vida { get; set; }
        public int Danio { get; set; }

        // Constructor de la clase
        public Personaje(string nombre, int nivel, int vida, int danio)
        {
            Nombre = nombre;
            Nivel = nivel;
            Vida = vida;
            Danio = danio;
        }

        // Implementación del método Atacar de la interfaz IPersonaje
        public virtual void Atacar(IEnemigo enemigo)
        {
            Console.WriteLine($"{Nombre} ataca a {enemigo.Nombre} y le hace {Danio} puntos de daño.");
            enemigo.RecibirDanio(Danio);
        }
        public virtual void Descansar()
        {
            Console.WriteLine($"{Nombre} decide descansar para recuperar aliento!\n");
        }
    }
}
