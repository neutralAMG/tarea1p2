class Docente : Empleado
{


    public List<Estudiante>? Estudiantes { get; set; }
    public List<string>? MateriasImpartidas { get; set; }

    //constructor
    public Docente(string nombre, int edad, string email, string telefono, string id, int salario, string calificacion, bool enVacaciones, string cv) : base(nombre, edad, email, telefono, id, salario, calificacion, enVacaciones, cv)
    {
    }

    public virtual void Calificar(List<string> materiasImpartidas)
    {
        // Logica para poder califica
    }
    public virtual void PasarLista(List<string> materiasImpartidas)
    {
        // Logica para poder pasar lista
    }
    public virtual void Ensenar(List<string> materiasImpartidas)
    {
        // Logica para poder ensenar
    }



}

class Administrativo : Empleado
{


    public string? Departamento { get; set; }

    //constructor
    public Administrativo(string nombre, int edad, string email, string telefono, string id, int salario, string calificacion, bool enVacaciones, string cv, string departamento) : base(nombre, edad, email, telefono, id, salario, calificacion, enVacaciones, cv)
    {
        Departamento = departamento;
    }

    public void administrar()
    {
        // Logica para poder administrar
    }
}