using System;

namespace upn_T1_q_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Double capital, tasaInteres, periodo, montoDevolver;
            Console.WriteLine("Calculo de interés simple");
            Console.Write("Ingrese capital (soles): ");
            capital = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese tasaInteres (%): ");
            tasaInteres = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese período (meses): ");
            periodo = Convert.ToDouble(Console.ReadLine());
            tasaInteres = capital*tasaInteres*periodo/1200;
            montoDevolver = capital + tasaInteres;
            Console.WriteLine("El monto a devolver es: " + Convert.ToString(montoDevolver) + " soles");

        }
    }
}
