


namespace Ejemplos;

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Lista de enteros
        List<int> numeros = new List<int>();
        
        // Agregar elementos a la lista de enteros
        numeros.Add(10);
        numeros.Add(20);
        numeros.Add(30);

        // Mostrar los elementos de la lista de enteros
        Console.WriteLine("Lista de enteros:");
        foreach (int numero in numeros)
        {
            Console.WriteLine(numero);
        }

        // Remover un elemento de la lista de enteros
        numeros.Remove(20);

        // Mostrar los elementos de la lista después de remover un elemento
        Console.WriteLine("\nLista de enteros después de remover un elemento:");
        foreach (int numero in numeros)
        {
            Console.WriteLine(numero);
        }

        // Obtener el índice de un elemento en la lista de enteros
        int indice = numeros.IndexOf(30);
        Console.WriteLine("\nEl índice de 30 en la lista de enteros es: " + indice);


        // Lista de cadenas de texto
        List<string> palabras = new List<string>();

        // Agregar elementos a la lista de cadenas de texto
        palabras.Add("Hola");
        palabras.Add("Mundo");
        palabras.Add("!");

        // Mostrar los elementos de la lista de cadenas de texto
        Console.WriteLine("\nLista de cadenas de texto:");
        foreach (string palabra in palabras)
        {
            Console.WriteLine(palabra);
        }

        // Remover un elemento de la lista de cadenas de texto
        palabras.Remove("Mundo");

        // Mostrar los elementos de la lista después de remover un elemento
        Console.WriteLine("\nLista de cadenas de texto después de remover un elemento:");
        foreach (string palabra in palabras)
        {
            Console.WriteLine(palabra);
        }


        // Lista de fechas
        List<DateTime> fechas = new List<DateTime>();

        // Agregar elementos a la lista de fechas
        fechas.Add(new DateTime(2024, 3, 19));
        fechas.Add(new DateTime(2024, 3, 20));
        fechas.Add(new DateTime(2024, 3, 21));

        // Mostrar los elementos de la lista de fechas
        Console.WriteLine("\nLista de fechas:");
        foreach (DateTime fecha in fechas)
        {
            Console.WriteLine(fecha.ToShortDateString());
        }

        // Remover un elemento de la lista de fechas
        fechas.RemoveAt(0);

        // Mostrar los elementos de la lista después de remover un elemento
        Console.WriteLine("\nLista de fechas después de remover un elemento:");
        foreach (DateTime fecha in fechas)
        {
            Console.WriteLine(fecha.ToShortDateString());
        }

        // Esperar que se presione una tecla antes de salir
        Console.ReadKey();
    }
}

