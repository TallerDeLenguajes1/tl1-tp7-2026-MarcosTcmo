using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using EspacioCalculadora;

Calculadora Micalculadora = new Calculadora();

double leerNumero()
{
    double numeroIngresado = 0;
    string parseo = Console.ReadLine();
    bool cambioConfirmado = double.TryParse(parseo, out numeroIngresado);

    return numeroIngresado;
}


bool confirmar = true;
do
{

    Console.WriteLine("Ingrese un numero para elegir el calculo");
    Console.WriteLine("1. Sumar un numero");
    Console.WriteLine("2. Restar un numero");
    Console.WriteLine("3. Multiplicar un numero");
    Console.WriteLine("4. Dividir un numero");
    Console.WriteLine("5. Limpiar");
    Console.WriteLine("0. Salir");
    int numeroIngresado = 0;
    string parseo = Console.ReadLine();
    bool cambioConfirmado = int.TryParse(parseo, out numeroIngresado);

    switch (numeroIngresado)
    {
        case 1:
            Micalculadora.Sumar(leerNumero());
            break;
        case 2:
            Micalculadora.Restar(leerNumero());
            break;
        case 3:
            Micalculadora.Multiplicar(leerNumero());
            break;
        case 4:
            Micalculadora.Dividir(leerNumero());
            break;
        case 5:
            Micalculadora.Limpiar();
            break;
        case 0:
            confirmar = false;
            break;
        default:
            Console.WriteLine("No selecciono una opcion correcta");
            break;
    }
} while (confirmar);

