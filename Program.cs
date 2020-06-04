using System;

namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Anual anual = new Anual();
            anual.MostrarRelatorio();
            System.Console.WriteLine("Digite a data do relatório anual: ");
            anual.data = DateTime.Parse(Console.ReadLine());

            Mensal mensal = new Mensal();
            mensal.MostrarRelatorio();
            System.Console.WriteLine("Digite a data do relatório mensal: ");
            mensal.data = DateTime.Parse(Console.ReadLine());
       

             
        }
    }
}
