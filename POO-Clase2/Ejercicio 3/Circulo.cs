using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Clase2.Ejercicio_3
{
    public class Circulo : FiguraGeometrica
    {
        public double radio;
        double area;
        double perimetro;

        public override void Area() =>
            Console.WriteLine(
                "El área del círculo es de: " + (area = radio * radio * Math.PI) + " cm."
            );

        public override void Perimetro() =>
            Console.WriteLine(
                "El perímetro del círculo es de: " + (perimetro = 2 * radio * Math.PI) + " cm."
            );
    }
}
