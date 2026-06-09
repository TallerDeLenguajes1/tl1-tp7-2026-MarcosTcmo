namespace Empleados
{


    public class Empleado
    {
        private string nombre;
        private string apellido;
        private DateTime fechaNacimiento;
        private char estadoCivil;
        private DateTime fechaDeIngreso;
        private double sueldo;
        private Cargos cargo;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public char EstadoCivil { get => estadoCivil; set => estadoCivil = value; }
        public DateTime FechaDeIngreso1 { get => fechaDeIngreso; set => fechaDeIngreso = value; }
        public double Sueldo { get => sueldo; set => sueldo = value; }
        public Cargos Cargo { get => cargo; set => cargo = value; }

        public int calcularAntiguedad()
        {
            return DateTime.Now.Year - fechaDeIngreso.Year;
        }
        public int calcularEdad()
        {
            return DateTime.Now.Year - fechaNacimiento.Year;
        }
        public int aniosParaJubilarse()
        {
            if (calcularEdad() < 65)
            {
                return 65 - calcularEdad();
            }
            else if (calcularEdad() == 65)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }
        public double calcularSalario()
        {
            double adicional, salario;
            if (calcularAntiguedad() <= 20)
            {
                adicional = sueldo * (calcularAntiguedad() * 0.01);
            }
            else
            {
                adicional = sueldo * 0.25;
            }
            if (cargo == Cargos.Ingeniero || cargo == Cargos.Especialista)
            {
                adicional *= 1.50; 
            }
            if (estadoCivil == 'C')
            {
                adicional += 150000; 
            }
            salario = sueldo + adicional;
            return salario;
        }
    }
    public enum Cargos
    {
        Auxiliar = 1,
        Administrativo = 2,
        Ingeniero = 3,
        Especialista = 4,
        Investigador = 5,
    }

}