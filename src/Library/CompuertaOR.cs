namespace Library;

public class CompuertaOR
{
    public List<bool> EntradaOR = new List<bool>();

    public void AgregarEntrada (bool entrada)
    {
        EntradaOR.Add(entrada);
    }

    public bool CalcularSalida ()
    {
        if (EntradaOR.Count < 2 )
        {
            throw new Exception ("Por lo menos se nececitan 2 entradas.");
        }

        bool Resultado = true;

        foreach (bool entrada in EntradaOR)
        {
            Resultado = Resultado || entrada;
        }

        return Resultado;
    }

}