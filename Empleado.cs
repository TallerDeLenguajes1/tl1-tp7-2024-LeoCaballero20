namespace EspacioEmpleado;

class Empleado {
    private string nombre;
    private string apellido;
    private DateTime fechaNac;
    private char estadoCivil;
    private DateTime fechaIng;
    private double sueldoBasico;
    private Cargos cargo;

    public Empleado(string nomb, string ape, DateTime fecN, char est, DateTime fecI, double sueldo, Cargos car) {
        nombre = nomb;
        apellido = ape;
        fechaNac = fecN;
        estadoCivil = est;
        fechaIng = fecI;
        sueldoBasico = sueldo;
        cargo = car;
    }

    public string Nombre { get => nombre; set => nombre = value; }
    public string Apellido { get => apellido; set => apellido = value; }
    public DateTime FechaNac { get => fechaNac; set => fechaNac = value; }
    public char EstadoCivil { get => estadoCivil; set => estadoCivil = value; }
    public DateTime FechaIng { get => fechaIng; set => fechaIng = value; }
    public double SueldoBasico { get => sueldoBasico; set => sueldoBasico = value; }
    internal Cargos Cargo { get => cargo; set => cargo = value; }
    public int antiguedad() {
        int ant = DateTime.Today.Year - fechaIng.Year;
        if (DateTime.Today.Month < fechaIng.Month || ((DateTime.Today.Month == fechaIng.Month) && (DateTime.Today.Day < fechaIng.Day))) {
            ant--;
        }
        return ant;
    }
    public int edad() {
        int edad = DateTime.Today.Year - fechaNac.Year;
        if (DateTime.Today.Month < fechaNac.Month || ((DateTime.Today.Month == fechaNac.Month) && (DateTime.Today.Day < fechaNac.Day))) {
            edad--;
        }
        return edad;
    }
    public int aniosParaJubilarse() {
        return 65-edad();
    }
    public double salario() {
        double adicional;
        if (antiguedad()<21) {
            adicional = sueldoBasico * 0.01 * antiguedad();
        } else {
            adicional = sueldoBasico * 0.25;
        }
        if (cargo == Cargos.Ingeniero || cargo == Cargos.Especialista) {
            adicional *= 1.5;
        }
        if (estadoCivil.Equals('C')) {
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