using System;


namespace Practica2
{
    class Letras
    {
        int x;
        int y;
        int i;
        char[] letra;
        char[] palabra;
        public Letras()
        {

            Console.WriteLine("ingresa la dimencion del arreglo");
            x = int.Parse(Console.ReadLine());
            letra = new char[x];
            Llenararreglo();

        }


        private void Llenararreglo()
        {
            for (i = 0; i < x; i++)
            {
                Console.WriteLine("introduce la " + (i + 1) + " letra del arreglo");
                letra[i] = char.Parse(Console.ReadLine().ToUpper());// ToUpper convierte todo a mayusculas 
            }
            Console.Clear();
            Ingresarpalabra();
        }


        private void Ingresarpalabra()
        {

            Console.WriteLine("a continuacion ingresa un palabra letra por letra");
            Console.WriteLine("cuantas letras tiene tu palabra: ");
            y = int.Parse(Console.ReadLine());
            palabra = new char[y];

            for (i = 0; i < y; i++)
            {
                Console.WriteLine("introduce la " + (i + 1) + " letra de la palabra");
                palabra[i] = char.Parse(Console.ReadLine().ToUpper());
            }
            Console.Clear();
            Buscarpalabra();
        }

        private void Buscarpalabra()
        {
            char z;
            char w;

            int con = 0;
            for (i = 0; i < palabra.Length; i++)
            {
                z = palabra[i];

                for (int j = 0; j < letra.Length; j++)
                {

                    w = letra[j];
                    if (z == w)
                    {
                        con++;
                    }
                }

            }

            if (con >= y)
            {
                Console.WriteLine("la palabra si existe en el arreglo inicial");
            }
            else
            {
                Console.WriteLine("la palabra no existe dentro del arreglo inicial");
            }

            Console.Write ("arreglo inicial:  ");
            for(i=0; i<letra.Length; i++)
            {
                Console.Write(letra[i]);
            }
        
            Console.WriteLine("   ");
            Console.Write("palabra introducida: ");
            for (i = 0; i < palabra.Length; i++)
            {
                Console.Write(palabra[i]);
            }

            Console.ReadKey();

        }



    }
}
