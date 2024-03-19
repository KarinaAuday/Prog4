


namespace Ejemplos;

class Program
{
    static Dictionary<string, string> diccionario = new Dictionary<string, string>();
    static void Main(string[] args)
    {
        Console.WriteLine("Bienvenidos al sistema de Biblioteca");
        int cantLibros = IngresarEntero("Ingrese la cantidad de libros a cargar: ");
        for (int i = 0; i < cantLibros; i++)
        {
            llenarDiccionario();
        }
        
        mostrarLibros();

    }

    private static void mostrarLibros()
    {
       if (diccionario.Count == 0)
        {
            Console.WriteLine("No hay libros cargados");
        }
        else
        {
            foreach (var item in diccionario)
            {
                Console.WriteLine("Libro: " + item.Key + " Autor: " + item.Value);
            }
        }
        Console.ReadLine();
    }

    private static void llenarDiccionario()
    {
        string libro = IngresarTexto("Ingrese el nombre del libro: ");
        do
        {
            if (diccionario.ContainsKey(libro))
            {
                Console.WriteLine("Este libro ya esta cargado, ingrese otro libro");
                libro = IngresarTexto("Ingrese el nombre del libro: ");
            }
        } while (diccionario.ContainsKey(libro));

        string autor = IngresarTexto("Ingrese el nombre del autor: ");
        diccionario.Add(libro, autor);


    }

    private static int IngresarEntero(string msj)
    {
        int entero = 0;
        do
        {
            Console.Write(msj);
            int.TryParse(Console.ReadLine(), out entero);
        } while (entero <= 0);
        return entero;

    }

    static string IngresarTexto(string msj)
    {
        string texto;
        do
        {
            Console.Write(msj);
            texto = Console.ReadLine();
        } while (texto == "");
        return texto;
    }

}
