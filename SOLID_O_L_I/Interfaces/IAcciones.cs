using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_O
{
    // Interfaz para Personaje para realizar acciones
    public interface IAcciones
    {
        void Atacar(IEnemigo enemigo);
        void Descansar();
    }
}
