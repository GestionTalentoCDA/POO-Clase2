﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Clase2.Ejercicio_1
{
    public class Perro : Animal
    {
        public virtual void EmitirSonido() => Console.WriteLine(Nombre + " says: Guau!");
    }
}
