using Empleados;
Empleado[] empleados = new Empleado[3];
bool salida = true;
for (int i = 0; i < 3; i++)
{
    empleados[i] = new Empleado();
    Console.WriteLine("Ingrese el Nombre del empleado: ");
    empleados[i].Nombre = Console.ReadLine();
    Console.WriteLine("Ingrese el apellido del empleado: ");
    empleados[i].Apellido = Console.ReadLine();
    Console.WriteLine("Ingrese la fecha de nacimiento del empleado en formato yyyy/mm/dd: ");
    string fecha = Console.ReadLine();
    // DateTime fechaAParsear = new DateTime(2004 , 4 , 13);
    DateTime fechaAParsear;
    bool parseoFecha = DateTime.TryParse(fecha, out fechaAParsear);
    empleados[i].FechaNacimiento = fechaAParsear;
    do
    {
        Console.WriteLine("Ingrese el estado civil del empleado: " + empleados[i].Nombre);
        Console.WriteLine("c. Casado");
        Console.WriteLine("s. soltero");
        Console.WriteLine("v. viudo");
        empleados[i].EstadoCivil = Console.ReadLine().First();
        if (empleados[i].EstadoCivil == 'c' || empleados[i].EstadoCivil == 's' || empleados[i].EstadoCivil == 'v')
        {
            salida = false;
        }
        else
        {
            Console.WriteLine("No ingreso un dato valido");
        }
    } while (salida);
    double sueldo;
    double.TryParse(Console.ReadLine(), out sueldo);
    empleados[i].Sueldo = sueldo;
    int cargoQueTiene;
    do
    {
        Console.WriteLine("ingrese una opcion para almacenar el cargo que tiene: ");
        Console.WriteLine("1.Auxiliar");
        Console.WriteLine("2.Administrativo");
        Console.WriteLine("3.Ingeniero");
        Console.WriteLine("4.Especialista");
        Console.WriteLine("5.Investigador");
        int.TryParse(Console.ReadLine(), out cargoQueTiene);
    } while (cargoQueTiene < 1 && cargoQueTiene > 5);
    empleados[i].Cargo = (Cargos)cargoQueTiene;
}

