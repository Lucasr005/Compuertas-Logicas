namespace Library;

public class CompuertaNOT
{
    public List<bool> EntradaNOT = new List<bool>();

    public void AgregarEntrada (bool entrada)
    {
        if (EntradaNOT.Count == 1)
        {
            throw new Exception ("Solamente se necesita 1 entrada.");
        }
        EntradaNOT.Add(entrada);
    }
    
    public bool CalcularSalida ()
    {
        bool Resultado = true;

        foreach (bool entrada in EntradaNOT)
        {
            Resultado = !entrada;
        }

        return Resultado;
    }
}