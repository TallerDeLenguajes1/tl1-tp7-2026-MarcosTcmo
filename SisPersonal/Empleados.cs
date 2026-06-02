public class Empleado
{
    private string nombre;
    private string apellido;
    private DateTime fechaNacimiento;
    private char estadoCivil;
    private DateTime fechaDeIngreso;
    private double sueldo;

    public string Nombre { get => nombre; set => nombre = value; }
    public string Apellido { get => apellido; set => apellido = value; }
    public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
    public char EstadoCivil { get => estadoCivil; set => estadoCivil = value; }
    public DateTime FechaDeIngreso1 { get => fechaDeIngreso; set => fechaDeIngreso = value; }
    public double Sueldo { get => sueldo; set => sueldo = value; }

    enum Cargos{
        Auxiliar = 1,
        Administrativo = 2,
        Ingeniero = 3,
        Especialista = 4,
        Investigador = 5,
    }   

    public int calcularAntiguedad()
    {
        return DateTime.Now.Year - fechaDeIngreso.Year; 
    }
}