using EspacioEmpleado;

Empleado[] empleados = new Empleado[3];
empleados[0] = new Empleado("Leonardo", "Caballero", new DateTime(2000,02,15),'S', new DateTime(2020,03,12), 700000.5, Cargos.Ingeniero);
empleados[1] = new Empleado("Lionel", "Messi", new DateTime(1987,06,24), 'C', new DateTime(2014,07,28), 1225000.25, Cargos.Especialista);
empleados[2] = new Empleado("Lionel", "Scaloni", new DateTime(1978,05,16), 'C', new DateTime(1999,12,01), 2050000.0, Cargos.Administrativo);

Console.WriteLine($"El salario de {empleados[0].Nombre} {empleados[0].Apellido} es {empleados[0].salario()}");
Console.WriteLine($"El salario de {empleados[1].Nombre} {empleados[1].Apellido} es {empleados[1].salario()}");
Console.WriteLine($"El salario de {empleados[2].Nombre} {empleados[2].Apellido} es {empleados[2].salario()}");

int anios = 100;
Empleado masViejo = empleados[0];
foreach (Empleado emp in empleados) {
    if (emp.aniosParaJubilarse()<anios) {
        anios = emp.aniosParaJubilarse();
        masViejo = emp;
    }
}
Console.WriteLine("Los datos del empleado más próximo a jubilarse son:");
Console.WriteLine("Nombre: " + masViejo.Nombre);
Console.WriteLine("Apellido: " + masViejo.Apellido);
Console.WriteLine("Fecha de nacimiento: " + masViejo.FechaNac.ToString("dd/MM/yyyy"));
Console.WriteLine("Estado civil: " + masViejo.EstadoCivil);
Console.WriteLine("Fecha de ingreso: " + masViejo.FechaIng.ToString("dd/MM/yyyy"));
Console.WriteLine("Sueldo básico: $" + masViejo.SueldoBasico);
Console.WriteLine("Cargo: " + masViejo.Cargo);
Console.WriteLine("Edad: " + masViejo.edad());
Console.WriteLine("Antigüedad: " + masViejo.antiguedad());
Console.WriteLine("Años para jubilarse: " + masViejo.aniosParaJubilarse());
Console.WriteLine("Salario: $" + masViejo.salario());