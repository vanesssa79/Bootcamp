// See https://aka.ms/new-console-template for more information

Cliente cliente1 = new Cliente("Vicente", "656 74 76 84", "C/ Pers", "llomo@kof.com",
        "Sí");
Console.WriteLine("Nombre: " + cliente1.Nombre);
Console.WriteLine("Dirección: " + cliente1.Direccion );
Console.WriteLine("Teléfono: " + cliente1.Telefono);
Console.WriteLine("Email: " + cliente1.Email);
Console.WriteLine("Cliente nuevo: " + cliente1.NewCliente);
public struct Cliente
{
   public Cliente(string nombre, string telefono, string direccion, string email,
        string newCliente)
    {
        Nombre = nombre;
        Telefono = telefono;
        Direccion = direccion;
        Email = email;
        NewCliente = newCliente;

    }

    public string Nombre{get;}
    public string Telefono { get; }
    public string Direccion{ get; }
    public string Email { get; }
    public string NewCliente { get; }

}

