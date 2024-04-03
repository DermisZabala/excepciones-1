using System;

namespace excepciones1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int numAleatorio = new Random().Next(0, 101);
            int contador = 0;
            sbyte miNumero;

            Console.WriteLine("Ingrese un numero del 0 al 100 para adivinar");

            do
            {

                contador++;

                try
                {
                    miNumero = sbyte.Parse(Console.ReadLine());
                }
                catch(Exception ex)
                {
                    Console.WriteLine($"Has cometido un error tipo: {ex.Message} \nInténtalo otra vez!!\n");
                    miNumero = -1;
                }

                
                if (miNumero < numAleatorio)
                {
                    Console.WriteLine("El numero ha adivinar es mas alto");
                }
                else if (miNumero > numAleatorio)
                {
                    Console.WriteLine("El numero ha adivinar es mas bajo");
                }



            }while(miNumero != numAleatorio);

            Console.WriteLine($"Felicidades lo has logrado en {contador} intentos");

        }
    }
}
