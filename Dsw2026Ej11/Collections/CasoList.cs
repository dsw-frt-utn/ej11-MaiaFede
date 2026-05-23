namespace Dsw2026Ej11.Collections;

using Dsw2026Ej11.Domain;
using System.Collections.Generic;
using System.Linq;

public class CasoList
{
    // Crear un campo que represente una lista de alumnos (List<>)
    private List<Alumno> alumnos = new List<Alumno>();

    // Incluir un método para agregar alumnos a la lista
    public void AgregarAlumno(Alumno alumno)
    {
        alumnos.Add(alumno);
    }

    // Incluir un método para retornar la lista
    public List<Alumno> ObtenerLista()
    {
        return alumnos;
    }

    // Incluir un método para buscar un alumno por nombre
    public Alumno BuscarPorNombre(string nombre)
    {
        // Utilizamos LINQ para buscar el primer alumno que coincida con el nombre
        return alumnos.FirstOrDefault(a => a.Nombre.Equals(nombre, System.StringComparison.OrdinalIgnoreCase));
    }

    // Incluir un método para eliminar un alumno (debe recibir un alumno)
    public void EliminarAlumno(Alumno alumno)
    {
        alumnos.Remove(alumno);
    }

    // Incluir un método para eliminar un alumno en una determinada posición de la lista
    public void EliminarAlumnoEnPosicion(int posicion)
    {
        if (posicion >= 0 && posicion < alumnos.Count)
        {
            alumnos.RemoveAt(posicion);
        }
    }
}
