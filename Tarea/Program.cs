using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el diametro del cilindro: ");
            double diametro = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la altura del cilindro: ");
            double altura = double.Parse(Console.ReadLine());

            Cilindro cilindro = new Cilindro(diametro, altura);

            Console.WriteLine("El volumen del cilindro es: " + cilindro.CalcularVolumen());


        }
    }

    public class Cilindro
    {
        private double diametro;
        private double altura;

        public Cilindro(double diametro, double altura)
        {
            this.diametro = diametro;
            this.altura = altura;
        }

        public double CalcularVolumen()
        {
            return Math.PI * Math.Pow(diametro / 2, 2) * altura;
        }


    }
}
