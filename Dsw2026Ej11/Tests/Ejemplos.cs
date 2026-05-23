using System;
using System.Collections.Generic;
using Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Tests;

internal class Ejemplos
{
    public static void EjemploList()
    {
        CasoList lista = new CasoList();
        Alumno a1 = new Alumno(1, "Juan Perez", 8.5);
        Alumno a2 = new Alumno(2, "Maria Gomez", 9.2);
        Alumno a3 = new Alumno(3, "Carlos Diaz", 7.8);

        // Agregar 3 alumnos a la lista
        lista.AgregarAlumno(a1);
        lista.AgregarAlumno(a2);
        lista.AgregarAlumno(a3);

        // Listar por consola los alumnos
        Console.WriteLine("--- Lista de Alumnos ---");
        foreach (var alu in lista.ObtenerLista()) Console.WriteLine(alu);

        // Buscar por nombre un alumno que exista y mostrar
        Console.WriteLine("\nBuscar 'Maria Gomez':");
        var encontrado = lista.BuscarPorNombre("Maria Gomez");
        Console.WriteLine(encontrado != null ? encontrado.ToString() : "No existe");

        // Buscar por nombre un alumno que no exista
        Console.WriteLine("\nBuscar 'Roberto':");
        var noEncontrado = lista.BuscarPorNombre("Roberto");
        Console.WriteLine(noEncontrado != null ? noEncontrado.ToString() : "No existe");

        // Eliminar un alumno y listar
        Console.WriteLine("\nEliminando a Carlos Diaz...");
        lista.EliminarAlumno(a3);
        foreach (var alu in lista.ObtenerLista()) Console.WriteLine(alu);

        // Eliminar el primer elemento de la lista y listar
        Console.WriteLine("\nEliminando el primer elemento (Posición 0)...");
        lista.EliminarAlumnoEnPosicion(0);
        foreach (var alu in lista.ObtenerLista()) Console.WriteLine(alu);
    }

    public static void EjemploDictionary()
    {
        CasoDictionary diccionario = new CasoDictionary();
        Alumno a1 = new Alumno(101, "Ana Martinez", 8.0);
        Alumno a2 = new Alumno(102, "Luis Suarez", 6.5);
        Alumno a3 = new Alumno(103, "Sofia Lopez", 9.8);

        // Agregar 3 alumnos al diccionario
        diccionario.AgregarAlumno(a1);
        diccionario.AgregarAlumno(a2);
        diccionario.AgregarAlumno(a3);

        // Listar por consola los alumnos
        Console.WriteLine("\n--- Diccionario de Alumnos ---");
        foreach (var kvp in diccionario.ObtenerDiccionario())
        {
            Console.WriteLine($"Legajo: {kvp.Key} -> {kvp.Value}");
        }

        // Buscar un alumno por clave y mostrar
        Console.WriteLine("\nBuscar Legajo 102:");
        var encontrado = diccionario.BuscarAlumno(102);
        Console.WriteLine(encontrado != null ? encontrado.ToString() : "No existe");

        // Buscar un alumno por clave que no exista
        Console.WriteLine("\nBuscar Legajo 999:");
        var noEncontrado = diccionario.BuscarAlumno(999);
        Console.WriteLine(noEncontrado != null ? noEncontrado.ToString() : "No existe");

        // Eliminar un alumno por clave y listar
        Console.WriteLine("\nEliminando Legajo 101...");
        diccionario.EliminarAlumno(101);
        foreach (var kvp in diccionario.ObtenerDiccionario())
        {
            Console.WriteLine($"Legajo: {kvp.Key} -> {kvp.Value}");
        }
    }

    public static void EjemploLinq()
    {
        CasoLinq linq = new CasoLinq();
        Console.WriteLine("\n--- Pruebas LINQ ---");

        Console.WriteLine($"Primer Libro: {linq.GetPrimero().Titulo}");
        Console.WriteLine($"Último Libro: {linq.GetUltimo().Titulo}");
        Console.WriteLine($"Suma Total de Precios: {linq.GetTotalPrecios():C}");
        Console.WriteLine($"Promedio de Precios: {linq.GetPromedioPrecios():C}");

        Console.WriteLine("\nLibros con ID > 15:");
        foreach (var l in linq.GetListById()) Console.WriteLine($"- {l.Titulo}");

        Console.WriteLine("\nLibros formateados:");
        foreach (var l in linq.GetLibros()) Console.WriteLine(l);

        Console.WriteLine($"\nLibro más caro: {linq.GetMayorPrecio().Titulo}");
        Console.WriteLine($"Libro más barato: {linq.GetMenorPrecio().Titulo}");

        Console.WriteLine("\nLibros por encima del promedio:");
        foreach (var l in linq.GetMayorPromedio()) Console.WriteLine($"- {l.Titulo} ({l.Precio:C})");

        Console.WriteLine("\nLibros ordenados por Título Descendente:");
        foreach (var l in linq.GetLibrosOrdenados()) Console.WriteLine($"- {l.Titulo}");
    }
}