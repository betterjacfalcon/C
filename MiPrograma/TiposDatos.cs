using System;

namespace MiPrograma
{
	class Tipos
	{
        static void Main(string[] args) {
            
                /*Tipo de datos
                     * byte: 8 byte    -> 0-155
                     * short: 16 byte  -> 0 -32667
                     * int: 32 byte    -> 0 - 2000 millones
                     * long: 64 byte    -> 0 - mayores 2000 millones
                     * 
                     * Numero Real .decimal
                     * float: 32 byte
                     * double: 64 byte
                     * decimal: 128 byte
                     * 
                     * char: 1, b, B, e
                     * string: hola, saludo, que bello dia tenemos
                     * 
                     * bool: true, false
                     * 
                     * 
                     * --*/
                int numero1 = 23; //23 es un literal- valor por defecto es 0 si no se le asigna un valor no se puedo utilizar
                bool isFalse = false;
                float numero5 = 2.34f;
                decimal numero7 = 4.44444444444m;
                int numero8=9, numero9=0;

                var numero2 = 2;
                var numero3 = 2.34;
                var numero4 = 2.34f;
                var numero6 = 2.3232323232m;

                Console.WriteLine(numero1);
                Console.WriteLine(isFalse);
                Console.WriteLine(numero2);
                Console.WriteLine(numero3);
                Console.WriteLine(numero4);
                Console.WriteLine(numero5);
                Console.WriteLine(numero6);
                Console.WriteLine(numero7);
                Console.WriteLine(numero8);
                Console.WriteLine(numero9);
        }
    }
}
