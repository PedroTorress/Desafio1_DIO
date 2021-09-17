using System;

namespace DIO.Series
{
    class Program
    {
        static SerieRepositorio repositorio = new SerieRepositorio();
        
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com uma opção");
            int opc = Convert.ToInt32(Console.ReadLine());
        }
    }
}
