namespace Library;
using System;

public class CompuertaAND
{
    public List<bool> EntradaAND = new List<bool>();

    public void AgregarEntrada (bool entrada)
    {
        EntradaAND.Add(entrada);
    }

    public bool CalcularSalida ()
    {
        if (EntradaAND.Count < 2 )
        {
            throw new Exception ("Por lo menos se nececitan 2 entradas.");
        }

        bool Resultado = true;

        foreach (bool entrada in EntradaAND)
        {
            Resultado = Resultado && entrada;
        }

        return Resultado;
    }

}
