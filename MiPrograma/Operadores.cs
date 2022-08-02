using System;

namespace MiPrograma
{
    class Operadores
    {
        public void operadores()
        {
            int a = 10;
            int b = 20;
            int suma = a + b;
            int resta = a - b;
            int multiplicacion = a * b;
            int division = a / b;
            int modulo = a % b;

            bool isMayor = 90 > 80;
            bool isMenor = 80 < 90;
            bool isIgual = 90 == 80;
            bool isDiferente = 90 != 80;
            bool esMayoroIgual = 90 >= 90;

            Console.WriteLine(suma);
            Console.WriteLine(resta);
            Console.WriteLine(multiplicacion);
            Console.WriteLine(division);
            Console.WriteLine(modulo);
            Console.WriteLine(isMayor);
            Console.WriteLine(isMenor);
            Console.WriteLine(isIgual);
            Console.WriteLine(isDiferente);
            Console.WriteLine(esMayoroIgual);


        }
    }
}
