
class Administrador : Docente
{
    protected string MateriaAdministrada { get; set; }

    //constructor
    public Administrador(string nombre, int edad, string email, string telefono, string id, int salario, string calificacion, bool enVacaciones, string cv, string materiaAdministrada) : base(nombre, edad, email, telefono, id, salario, calificacion, enVacaciones, cv)
    {
        MateriaAdministrada = materiaAdministrada;
    }
    public void Gestionar()
    {

    }

    public override void Calificar(List<string> materiasImpartidas)
    {
        // Logica para poder calificar
    }

    public override void Ensenar(List<string> materiasImpartidas)
    {
        // Logica para poder ensenar
    }

    public override void PasarLista(List<string> materiasImpartidas)
    {
        // Logica para poder pasar lista
    }
}

class Maestro : Docente
{
    //constructor
    public Maestro(string nombre, int edad, string email, string telefono, string id, int salario, string calificacion, bool enVacaciones, string cv) : base(nombre, edad, email, telefono, id, salario, calificacion, enVacaciones, cv)
    {
    }

    public override void Calificar(List<string> materiasImpartidas)
    {
        // Logica para poder calificar
    }

    public override void Ensenar(List<string> materiasImpartidas)
    {

        // Logica para poder ensenar
    }

    public override void PasarLista(List<string> materiasImpartidas)
    {
        // Logica para poder pasar lista
    }


}