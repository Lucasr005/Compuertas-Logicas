namespace Library;

public class CompuertaGarage
{
    public bool A {get; set;}
    public bool B {get; set;}
    public bool C {get; set;}

   public CompuertaGarage (bool A, bool B, bool C)
   {
        this.A = A;
        this.B = B;
        this.C = C;
   }

   public bool CalcularSalida ()
   {
    CompuertaNOT recibeA = new CompuertaNOT();      ///creo compuerta not
    CompuertaNOT recibeB = new CompuertaNOT();
    
    recibeA.AgregarEntrada(this.A);                  ///Agrega entradas a la not
    recibeB.AgregarEntrada(this.B);

    CompuertaAND recibeAB = new CompuertaAND();    ///creo compuerta and
    CompuertaAND recibeNOT = new CompuertaAND();

    recibeAB.AgregarEntrada(this.A);
    recibeAB.AgregarEntrada(this.B);                   ////Agrega entrada a 1 de las and

    recibeNOT.AgregarEntrada(recibeA.CalcularSalida());      ///agrega entradas a la segunda cpmpuerta and
    recibeNOT.AgregarEntrada(recibeB.CalcularSalida()); 

    CompuertaOR recibeAND = new CompuertaOR();              ///crea OR
    
    recibeAND.AgregarEntrada(recibeAB.CalcularSalida());        ///Agrega entradas
    recibeAND.AgregarEntrada(recibeNOT.CalcularSalida());

    CompuertaAND compuertafinal = new CompuertaAND();
    compuertafinal.AgregarEntrada(recibeAND.CalcularSalida());
    compuertafinal.AgregarEntrada(this.C);

    return compuertafinal.CalcularSalida();
   }
}