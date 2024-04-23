using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Clase2.Ejercicio_3
{
    public class Cuadrado : FiguraGeometrica
    {
        public double lado;
        double area;
        double perimetro;

        public override void Area() =>
            Console.WriteLine("El área del cuadrado es de: " + Math.Pow(lado, 2) + " cm.");

        public override void Perimetro() =>
            Console.WriteLine(
                "El perímetro del cuadrado es de: " + (perimetro = lado * 4) + " cm."
            );
    }
}
