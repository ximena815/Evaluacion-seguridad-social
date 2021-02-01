using System;

namespace Evaluación_seguridad_Social
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Salario mensual: ");
            double salario = double.Parse(Console.ReadLine());

            Console.WriteLine("tipo de contrato(dependiente = 1 o independiente = 2): ");
            int contrato = int.Parse(Console.ReadLine());


            double cotizacion = 0;
            double SMMLV = 908526;

            if (salario >= SMMLV)
            {
                cotizacion = salario * 0.4;
            }
            if (salario < SMMLV)
            {
                cotizacion = SMMLV;
            }


            if (contrato == 2)
            {
                Console.WriteLine("Clase de riesgo: ");
                double riesgo = double.Parse(Console.ReadLine());

                double EPS = cotizacion * 12.5 / 100;
                Console.WriteLine("EPS: " + EPS);

                double Pension = cotizacion * 16 / 100;
                Console.WriteLine("Pension: " + Pension);


                if (riesgo == 1)
                {
                    double ARL = cotizacion * 0.522 / 100;
                    Console.WriteLine("ARL: " + ARL);
                    double deducciones = EPS + Pension + ARL;
                    Console.WriteLine("deducciones: " + deducciones);
                    double salarioR = salario - deducciones;
                    Console.WriteLine("salario Real: " + salarioR);
                    double salaAU = salarioR * 12;
                    Console.WriteLine("salario Anual: " + salaAU);
                }
                if (riesgo == 2)
                {
                    double ARL = cotizacion * 1.044 / 100;
                    Console.WriteLine("ARL: " + ARL);
                    double deducciones = EPS + Pension + ARL;
                    Console.WriteLine("deducciones: " + deducciones);
                    double salarioR = salario - deducciones;
                    Console.WriteLine("salario Real: " + salarioR);
                    double salaAU = salarioR * 12;
                    Console.WriteLine("salario Anual: " + salaAU);
                }
                if (riesgo == 3)
                {
                    double ARL = cotizacion * 2.436 / 100;
                    Console.WriteLine("ARL: " + ARL);
                    double deducciones = EPS + Pension + ARL;
                    Console.WriteLine("deducciones: " + deducciones);
                    double salarioR = salario - deducciones;
                    Console.WriteLine("salario Real: " + salarioR);
                    double salaAU = salarioR * 12;
                    Console.WriteLine("salario Anual: " + salaAU);
                }
                if (riesgo == 4)
                {
                    double ARL = cotizacion * 4.350 / 100;
                    Console.WriteLine("ARL: " + ARL);
                    double deducciones = EPS + Pension + ARL;
                    Console.WriteLine("deducciones: " + deducciones);
                    double salarioR = salario - deducciones;
                    Console.WriteLine("salario Real: " + salarioR);
                    double salaAU = salarioR * 12;
                    Console.WriteLine("salario Anual: " + salaAU);
                }
                if (riesgo == 5)
                {
                    double ARL = cotizacion * 6.960 / 100;
                    Console.WriteLine("ARL: " + ARL);
                    double deducciones = EPS + Pension + ARL;
                    Console.WriteLine("deducciones: " + deducciones);
                    double salarioR = salario - deducciones;
                    Console.WriteLine("salario Real: " + salarioR);
                    double salaAU = salarioR * 12;
                    Console.WriteLine("salario Anual: " + salaAU);
                }



            }
            else if (contrato == 1)
            {

                int ARL = 0;
                Console.WriteLine("ARL: "+ ARL);

                    double EPS = cotizacion * 0.04;
                Console.WriteLine("EPS: " + EPS);

                double Pension = cotizacion * 0.04;
                Console.WriteLine("Pension: " + Pension);

                double deducciones = EPS + Pension;
                Console.WriteLine("deducciones: " + deducciones);

                double salarioR = salario - deducciones;
                Console.WriteLine("salario Real: " + salarioR);

                double salaAU = salario + salarioR * 12;
                Console.WriteLine("salario Anual: " + salaAU);

                
            }


        }
    }
}
