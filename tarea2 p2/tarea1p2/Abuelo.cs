public abstract class MiembroDeLaComunidad
{
    protected string? Nombre { get; set; }
    protected int Edad { get; set; }
    protected string? Email { get; set; }
    protected string? Telefono { get; set; }
    protected string? Id { get; set; }

    //constructor
    public MiembroDeLaComunidad(string nombre, int edad, string email, string telefono, string id)
    {
        Nombre = nombre;
        Edad = edad;
        Email = email;
        Telefono = telefono;
        Id = id;
    }

    public void Presentarse()
    {
        Console.WriteLine($"Buenas me llamo, {Nombre} y tengo {Edad} años, mi id es {Id}");
    }

}