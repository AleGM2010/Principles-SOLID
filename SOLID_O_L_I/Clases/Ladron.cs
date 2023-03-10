using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_O
{
    public class Ladron : Personaje
    {
        public int Estamina { get; set; }

        // Constructor de la clase
        public Ladron(string nombre, int nivel, int vida, int danio, int estamina) : base(nombre, nivel, vida, danio)
        {
            Estamina = estamina;
        }

        // Override del método Atacar de la clase base para incluir el uso de mana
        public override void Atacar(IEnemigo enemigo)
        {
            if (Estamina >= 10)
            {
                base.Atacar(enemigo);
                Estamina -= 10;
            }
            else
            {
                Console.WriteLine($"{Nombre} intenta atacar por la espalda, pero no tiene suficiente estamina.");
            }
        }
        public override void Descansar()
        {
            base.Descansar();
            Estamina += 10;
        }
    }
}
