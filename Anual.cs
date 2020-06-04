namespace Polimorfismo
{
    public class Anual : Relatorio
    {
        public override void MostrarRelatorio(){
        System.Console.WriteLine("Mostrando relatório anual");
        base.MostrarRelatorio();
    }
}
}