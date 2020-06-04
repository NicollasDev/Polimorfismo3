using System;

namespace Polimorfismo
{
    public class Relatorio
    {
        public DateTime data { get; set; }
        public virtual void MostrarRelatorio(){
         System.Console.WriteLine("Mostrando relatório geral");
        }

    }
}