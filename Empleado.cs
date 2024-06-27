namespace EspacioEmpleado;

class Empleado {
    private string nombre;
    private string apellido;
    private DateTime fechaNac;
    private char estadoCivil;
    private DateTime fechaIng;
    private double sueldoBasico;
    private Cargos cargo;

    public string Nombre { get => nombre; set => nombre = value; }
    public string Apellido { get => apellido; set => apellido = value; }
    public DateTime FechaNac { get => fechaNac; set => fechaNac = value; }
    public char EstadoCivil { get => estadoCivil; set => estadoCivil = value; }
    public DateTime FechaIng { get => fechaIng; set => fechaIng = value; }
    public double SueldoBasico { get => sueldoBasico; set => sueldoBasico = value; }
    internal Cargos Cargo { get => cargo; set => cargo = value; }
    public int antiguedad() {
        TimeSpan diferencia = DateTime.Today - fechaIng;
        return (diferencia.Days)/365;
    }
    public int edad() {
        TimeSpan edad = DateTime.Today - fechaNac;
        return (edad.Days)/365;
    }
    public int aniosParaJubilarse() {
        return 65-edad();
    }
    public double salario() {
        double adicional;
        if (antiguedad()<21) {
            adicional = sueldoBasico * 0.01 * antiguedad();
        } else {
            adicional = sueldoBasico * 1.25;
        }
        if (cargo == Cargos.Ingeniero || cargo == Cargos.Especialista) {
            adicional = 1.5 * adicional;
        }
        if (estadoCivil.Equals("C")) {
            adicional += 150000;
        }
        return sueldoBasico + adicional;
    }

}

enum Cargos {
    Auxiliar,
    Administrativo,
    Ingeniero,
    Especialista,
    Investigador,
}