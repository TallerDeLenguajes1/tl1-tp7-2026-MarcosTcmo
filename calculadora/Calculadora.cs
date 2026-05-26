namespace EspacioCalculadora;

public class EspacioCalculadora
{
    private double dato;
    public double Dato { get => dato;}

    public double Sumar(double termino)
    {
        dato += termino;
    }
    public double Restar(double termino)
    {
        dato -= termino;
    }
    public double Multiplicar(double termino)
    {
        dato *= termino;
    }
    public double Dividir(double termino)
    {
        dato /= termino;
    }
    public double Limpiar()
    {
        dato = 0;
    }
    public double Resultado()
    {
        return dato;
    }
}