using System.Runtime.CompilerServices;
using EspacioCalculadora;

Calculadora Micalculadora = new Calculadora();

Console.WriteLine("1. Sumar un numero");
Console.WriteLine("2. Restar un numero");
Console.WriteLine("3. Multiplicar un numero");
Console.WriteLine("4. Dividir un numero");
Console.WriteLine("5. Limpiar");

int numeroIngresado = 0;
string parseo = Console.ReadLine();
bool cambioConfirmado = int.TryParse(parseo,out numeroIngresado);

double leerNumero(string datoParaParsear)
{
    int numeroIngresado = 0;
string parseo = Console.ReadLine();
bool cambioConfirmado = int.TryParse(parseo,out numeroIngresado);
    
    return numeroParseado;
}

if(cambioConfirmado && numeroIngresado >= 0)
{
    bool confirmar = true;
    do
    {
        switch (numeroIngresado)
        {
            case 1:

                break;  
            default:
        }
    } while (confirmar);
}