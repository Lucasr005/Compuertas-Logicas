namespace Program;
using Library;
class Program 
{
    static void Main(string[] args)
    {
        ///AND
        CompuertaAND compuertaAND = new CompuertaAND();
        compuertaAND.AgregarEntrada(true);
        compuertaAND.AgregarEntrada(false);

        bool resultadoAND = compuertaAND.CalcularSalida();
        Console.WriteLine("El resultado es: " + resultadoAND);

        ///NOT
        CompuertaNOT compuertaNOT = new CompuertaNOT();
        compuertaNOT.AgregarEntrada(true);

        bool resultadoNOT = compuertaNOT.CalcularSalida();
        Console.WriteLine("El resultado es: " + resultadoNOT);

        ///OR
         CompuertaOR compuertaOR = new CompuertaOR();
        compuertaOR.AgregarEntrada(true);
        compuertaOR.AgregarEntrada(false);

        bool resultadoOR = compuertaOR.CalcularSalida();
        Console.WriteLine("El resultado es: " + resultadoOR);
        
    }
}