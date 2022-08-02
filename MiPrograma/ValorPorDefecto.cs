namespace MiPrograma
{
    class ValorPorDefecto
    {
        static void Main(string[] args)
        {
            //Tipo de Datos
            TiposDatos d= new TiposDatos();
            d.datos();
                            
            //Valores por defecto
            int numero1 = 0;
            double numero2= 0.0;
            bool isSabado = false;           
            char letra = ' ';
            string cadena = null;

            int numero3 = default;
            double numero4 = default;
            bool isLunes = default;            
            char letra1 = default;
            string cadena1 = default;

            Console.WriteLine(numero1);
            Console.WriteLine(numero2);
            Console.WriteLine(isSabado);
            Console.WriteLine(cadena);
            Console.WriteLine(letra );

            Console.WriteLine(numero3);
            Console.WriteLine(numero4);
            Console.WriteLine(isLunes);
            Console.WriteLine(cadena1);
            Console.WriteLine(letra1);
        }
    }
}
