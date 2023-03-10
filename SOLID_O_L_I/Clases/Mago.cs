using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_O
{
    // Clase de mago que hereda de la clase Personaje
    public class Mago : Personaje
    {
        public int Mana { get; set; }

        // Constructor de la clase
        public Mago(string nombre, int nivel, int vida, int danio, int mana) : base(nombre, nivel, vida, danio)
        {
            Mana = mana;
        }

        // Override del método Atacar de la clase base para incluir el uso de mana
        public override void Atacar(IEnemigo enemigo)
        {

            if (Mana >= 10)
            {
                Mana -= 10;
                base.Atacar(enemigo);
            }
            else
            {
                Console.WriteLine($"{Nombre} intenta lanzar una bola de fuego, pero no tiene suficiente mana.");
            }
        }
        public override void Descansar()
        {
            base.Descansar();
            Mana += 15;
        }
    }
}
