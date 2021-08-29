using System;

namespace upn_T1_q_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Double capital, tasaInteres, periodo, montoDevolver, Interes;
            Console.WriteLine("Calculo de interés simple");
            
            Console.Write("Ingrese capital (soles): ");
            capital = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Ingrese tasaInteres simple anual (%): ");
            tasaInteres = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Ingrese período (meses): ");
            periodo = Convert.ToDouble(Console.ReadLine());
            
            Interes = capital * (tasaInteres/100) * (periodo/12);
            Console.Write("Interes es: " + Convert.ToString(Interes) + " soles");

            montoDevolver = capital + Interes;
            Console.WriteLine("El monto a devolver es: " + Convert.ToString(montoDevolver) + " soles");

        }
    }
}
