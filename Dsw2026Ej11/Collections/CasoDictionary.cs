namespace Dsw2026Ej11.Collections;

using Dsw2026Ej11.Domain;
using System.Collections.Generic;


public class CasoDictionary
{
    // Crear un diccionario donde la clave sea el legajo y el valor el alumno
    private Dictionary<int, Alumno> diccionarioAlumnos = new Dictionary<int, Alumno>();

    // Incluir un método para agregar un alumno al diccionario
    public void AgregarAlumno(Alumno alumno)
    {
        
        if (!diccionarioAlumnos.ContainsKey(alumno.Id))
        {
            diccionarioAlumnos.Add(alumno.Id, alumno);
        }
    }

    // Incluir un método para buscar un alumno utilizando la clave
    public Alumno BuscarAlumno(int legajo)
    {
        if (diccionarioAlumnos.TryGetValue(legajo, out Alumno alumno))
        {
            return alumno;
        }
        return null; 
    }

    // Incluir un método para retornar el diccionario
    public Dictionary<int, Alumno> ObtenerDiccionario()
    {
        return diccionarioAlumnos;
    }

    // Incluir un método para eliminar un alumno utilizando la clave
    public void EliminarAlumno(int legajo)
    {
        diccionarioAlumnos.Remove(legajo);
    }
}