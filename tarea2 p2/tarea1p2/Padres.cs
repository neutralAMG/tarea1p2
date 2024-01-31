using System.Reflection.Metadata;

public class Empleado : MiembroDeLaComunidad
{
    protected int Salario { get; set; }
    protected string? Calificacion { get; set; }

    protected bool EnVacaciones { get; set; }
    protected string? CV { get; set; }

    //constructor
    public Empleado(string nombre, int edad, string email, string telefono, string id, int salario, string calificacion, bool enVacaciones, string cv) : base(nombre, edad, email, telefono, id)
    {
        Salario = salario;
        Calificacion = calificacion;
        EnVacaciones = enVacaciones;
        CV = cv;
    }
}

public class Estudiante : MiembroDeLaComunidad
{

    public string? Carrera { get; set; }

    public List<string>? Materias { get; set; }
    public double Indice { get; set; }

    //constructor
    public Estudiante(string nombre, int edad, string email, string telefono, string id, string carrera, double indice) : base(nombre, edad, email, telefono, id)
    {
        Carrera = carrera;
        Indice = indice;
    }

    public void Estudiar()
    {
        // Logica para poder estudiar
    }

}
public class ExAlumno : MiembroDeLaComunidad
{
    public DateOnly AñoDeGraduacion { get; set; }

    //constructor
    public void ReInscribirse()
    {
        // Logica para poder reinscribirse
    }
    public ExAlumno(string nombre, int edad, string email, string telefono, string id, DateOnly añoDeGraduacion) : base(nombre, edad, email, telefono, id)
    {
        AñoDeGraduacion = añoDeGraduacion;
    }
}